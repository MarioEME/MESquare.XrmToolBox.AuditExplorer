using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XrmToolBox.Extensibility;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;
using Microsoft.Xrm.Sdk.Metadata.Query;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Tooling.Connector;
using MESquare.MsCrm.Sdk.Extentions;
using MESquare.MsCrm.Sdk;
using System.Threading;
using MESquare.XrmToolBox.AuditExplorer.Entities;
using OfficeOpenXml;
using McTools.Xrm.Connection;
using XrmToolBox.Extensibility.Interfaces;
using XrmToolBox.Extensibility.Args;

namespace MESquare.XrmToolBox.AuditExplorer
{
    public partial class PluginControl : PluginControlBase, IStatusBarMessenger
    {
        #region IStatusBarMessenger

        public event EventHandler<StatusBarMessageEventArgs> SendMessageToStatusBar;

        #endregion

        private Settings settings = new Settings();
        private bool showingSettings = false;
        private bool updatingChekedAuditableEntities = false;
        private Dictionary<String,EntityMetadata> auditableEntities = null;
        private Dictionary<Guid, Entity> users = null;
 
        public PluginControl()
        {
            InitializeComponent();
        }

        private void MyPluginControl_Load(object sender, EventArgs e)
        {
            HideOptions();
            ProcessSettings();
            
            UpdateGridView();

            dtpFilterCreatedBeforeDate.CustomFormat = "yyyy-MM-dd HH:mm";
            dtpFilterCreatedAfterDate.CustomFormat = "yyyy-MM-dd HH:mm";
            dtpFilterCreatedBeforeDate.Value = DateTime.Today.AddDays(1);
            dtpFilterCreatedAfterDate.Value = DateTime.Today.AddDays(-7);

            gvAuditRecords.AutoGenerateColumns = false;
        }

        private void UpdateGridView()
        {
            for (var i = 0; i < this.settings.Columns.Count; i++)
            {
                gvAuditRecords.Columns[i].Visible = this.settings.Columns[i];
            }
        }

        private void ProcessSettings()
        {
            try
            {

                SettingsManager.Instance.TryLoad(settings.GetType(), out settings);
                if (settings == null)
                    settings = new Settings();
                InitializeColumnsSettings();
                ShowSettings();
            }
            catch (Exception ex)
            {
                settings = new Settings();
                InitializeColumnsSettings();
                ShowSettings();
            }

        }

        private void ShowSettings()
        {
            this.showingSettings = true;

            nudMaxParallelRequests.Value = this.settings.MaxNumberOfParallelRequests;
            nudRecordsPerRequest.Value = this.settings.NumberOfRecordsPerRequest;
            nudRequestsPerBulkRequest.Value = this.settings.NumberOfRequestsPerBulkRequest;
            nudNumberOfRowsPerExcelFile.Value = this.settings.NumberOfRowsPerExcelFile;

            for (var i = 0; i < this.settings.Columns.Count; i++)
            {
                cblVisibleColumns.SetItemChecked(i, this.settings.Columns[i]);
            }

            this.showingSettings = false;
        }
        
        private void tsbClose_Click(object sender, EventArgs e)
        {
            CloseTool();
        }

        public override void ClosingPlugin(PluginCloseInfo info)
        {
            SettingsManager.Instance.Save(settings.GetType(), settings);
        }

        private void InitializeColumnsSettings()
        {
            if (this.settings.Columns != null && this.settings.Columns.Count == 0)
            {
                this.settings.Columns = new List<bool>
                    {
                        true,
                        true,
                        false,
                        true,
                        false,
                        true,
                        false,
                        true,
                        false,
                        true,
                        true,
                        false,
                        true,
                        false,
                        true
                    };
            }
        }

        private void MyPluginControl_OnCloseTool(object sender, EventArgs e)
        {
            SettingsManager.Instance.Save(settings.GetType(), settings);
        }

        protected override void OnConnectionUpdated(ConnectionUpdatedEventArgs e)
        {
            base.OnConnectionUpdated(e);
            ResetLayout();
        }

        private void MyPluginControl_ConnectionUpdated(object sender, ConnectionUpdatedEventArgs e)
        {
            ResetLayout();
        }

        private void ResetLayout()
        {
            tvAuditableEntities.Nodes.Clear();
            cbFilterUsers.DataSource = null;
            btnPreviewData.Enabled = false;
            btnExportToExcel.Enabled = false;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ExecuteMethod(LoadInitialData);
        }


        private void LoadInitialData()
        {
            WorkAsync(new WorkAsyncInfo
            {
                Message = "Loading Auditable Entities",
                Work = (w, e) =>
                {
                    e.Result = new
                    {
                        AuditableEntities = Service.RetrieveAuditableEntities().ToList(),
                        Users = Service.RetriveAllUsers().ToList(),
                    };
                },
                PostWorkCallBack = e =>
                {
                    var result = e.Result as dynamic;
                    var auditableEntitiesAsList = result.AuditableEntities as List<EntityMetadata>;
                    var usersAsList = result.Users as List<Entity>;

                    this.auditableEntities = auditableEntitiesAsList.ToDictionary(em => em.LogicalName);
                    this.users = usersAsList.ToDictionary(u => u.Id);

                    ShowAuditableEntities(auditableEntitiesAsList);
                    ShowUsers(usersAsList);

                    EnableLayout();
                }
            });
        }

        private void EnableLayout()
        {
            btnExportToExcel.Enabled = true;
            btnPreviewData.Enabled = true;
        }

        private void ShowUsers(List<Entity> users)
        {
            var dataSource = users.Select(u => new {
                FullName = u.GetAttributeValue<String>("fullname"),
                Id = u.Id
            }).OrderBy(u => u.FullName)
              .ToList();
            dataSource.Insert(0, new { FullName = "All", Id = Guid.Empty });

            cbFilterUsers.DataSource = dataSource;
            cbFilterUsers.Refresh();
            cbFilterUsers.DisplayMember = "FullName";
            cbFilterUsers.ValueMember = "Id";
        }

        private void ShowAuditableEntities(List<EntityMetadata> metadataList)
        {
            tvAuditableEntities.Nodes.Clear();
            tvAuditableEntities.BeginUpdate();
            metadataList
                .OrderBy(md => md.DisplayName?.UserLocalizedLabel?.Label)
                .ToList()
                .ForEach(metadata => AddEntityNode(tvAuditableEntities.Nodes, metadata));
            tvAuditableEntities.EndUpdate();
        }

        private void AddEntityNode(TreeNodeCollection nodes, EntityMetadata metadata)
        {
            if (metadata.DisplayName != null && metadata.DisplayName.UserLocalizedLabel != null)
            {
                var key = metadata.LogicalName;
                var text = $"{metadata.DisplayName.UserLocalizedLabel.Label} ({key})";

                var entityNode = nodes.Add(key, text);
                entityNode.Tag = "entity";

                metadata.Attributes
                    .OrderBy(attr => attr.DisplayLabel())
                    .ToList()
                    .ForEach(attr => AddAttributeNode(entityNode, attr));
            }
        }

        private void AddAttributeNode(TreeNode entityNode, AttributeMetadata metadata)
        {
            if (metadata.DisplayName != null && metadata.DisplayName.UserLocalizedLabel != null)
            {
                if (metadata.IsAuditEnabled.Value)
                {
                    var key = metadata.LogicalName;
                    var text = $"{metadata.DisplayLabel()} ({key})";

                    var node = entityNode.Nodes.Add(key, text);
                    node.Tag = "field";
                }
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ExecuteMethod(ShowAuditData);
        }

        private void GetFilterEntitiesAttributes(TreeNodeCollection entitiesNodes, List<AuditDataFilterEntity> entitiesFilter)
        {
            foreach (TreeNode selectedNode in entitiesNodes)
            {
                if (!selectedNode.Checked) continue;
                var entityFilter = new AuditDataFilterEntity
                {
                    EntityLogicalName = selectedNode.Name.ToString(),
                    Attributes = new List<string>(),
                };
                entitiesFilter.Add(entityFilter);
                foreach( TreeNode attributeNode in selectedNode.Nodes)
                {
                    if (attributeNode.Checked)
                        entityFilter.Attributes.Add(attributeNode.Name.ToString());
                }

                entityFilter.AllAttributes = selectedNode.Nodes.Count == entityFilter.Attributes.Count;
            }
        }

        private AuditDataFilter GetFilter()
        {
            var entities = new List<AuditDataFilterEntity>();
            var author = default(Guid?);
            var createdAfter = DateTime.Now;
            var createdBefore = DateTime.Now;
            var objectId = default(Guid?);
            var actions = new List<int>();
            var excludeActions = new List<int>();
            var numberOfRecords = 0;


            if (cbFilterUsers.SelectedIndex > 0)
                author = new Guid(cbFilterUsers.SelectedValue.ToString());

            createdBefore = dtpFilterCreatedBeforeDate.Value;
            createdAfter = dtpFilterCreatedAfterDate.Value;

            GetFilterEntitiesAttributes(tvAuditableEntities.Nodes, entities);

            numberOfRecords = Convert.ToInt32(nudNumberOfRecords.Value);

            return new AuditDataFilter
            {
                Author = author,
                CreatedAfter = createdAfter,
                CreatedBefore = createdBefore,
                Entities = entities,
                ObjectId = objectId,
                Actions = actions,
                ExcludeActions = excludeActions,
                Take = Math.Min(numberOfRecords, 5000),
                Skip = 0,
                NumberOfRecords = numberOfRecords,
                MaxNumberOfParallelRequests = this.settings.MaxNumberOfParallelRequests,
                NumberOfRequestsPerBulkRequest = this.settings.NumberOfRequestsPerBulkRequest
            };
        }


        private void ShowAuditData()
        {
            var filter = GetFilter();

            WorkAsync(new WorkAsyncInfo
            {
                Message = "Loading Preview Data",
                Work = (w, e) =>
                {
                    var data = LoadAuditData(filter);
                    e.Result = data;

                },
                PostWorkCallBack = e =>
                {
                    gvAuditRecords.SuspendLayout();

                    gvAuditRecords.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
                    gvAuditRecords.DataSource = e.Result as List<AuditRecord>;

                    gvAuditRecords.ResumeLayout();
                }
            });
        }

        private void ExportAllAuditData()
        {
            saveFileDialog.FileName = $"Entity Audit {DateTime.Now.ToString("yyyyMMdd")}.xlsx";
            var result = saveFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                var filePath = saveFileDialog.FileName;
                var filter = GetFilter();

                filter.NumberOfRecords = int.MaxValue;
                filter.Take = this.settings.NumberOfRecordsPerRequest;

                WorkAsync(new WorkAsyncInfo
                {
                    Message = "Exporting to Excel. Please wait.",
                    Work = (w, e) =>
                    {
                        ExportToExcelAuditData(filter, filePath);
                    },
                    PostWorkCallBack = e =>
                    {
                    }
                });
            }
        }


        private ExcelPackage GetExcelFile(String filePath, int fileIndex = 0)
        {
            if (!filePath.EndsWith(".xlsx"))
                filePath = filePath + ".xlsx";

            if (fileIndex != 0)
                filePath = filePath.Replace(".xlsx", $"_{fileIndex}.xlsx");

            if (System.IO.File.Exists(filePath))
                System.IO.File.Delete(filePath);

            var package = new ExcelPackage(new System.IO.FileInfo(filePath));
            package.Workbook.Properties.Title = "CRM Audit Records";

            var workSheet = package.Workbook.Worksheets.Add("Audit");

            var columnIdx = 1;
            for (var i = 1; i <= gvAuditRecords.Columns.Count; i++)
            {
                var column = gvAuditRecords.Columns[i - 1];
                if (column.Visible)
                {
                    workSheet.Cells[1, columnIdx++].Value = column.HeaderText;
                }
            }

            if (this.settings.Columns[0])
                workSheet.Column(1).Style.Numberformat.Format = "yyyy-MM-dd HH:mm";

            return package;
        }

        private void SaveExcelFile(ExcelPackage package)
        {
            this.SendMessageToStatusBar(this, new StatusBarMessageEventArgs($"Saving Excel File"));
            LogInfo("Saving excel file...");

            package.Workbook.Worksheets[1].Cells[package.Workbook.Worksheets[1].Dimension.Address].AutoFitColumns();
            package.Save();
        }

        private void ExportToExcelAuditData(AuditDataFilter filter, String filePath)
        {
            LogInfo("Excel Export Started");

            var package = GetExcelFile(filePath);
            this.SendMessageToStatusBar(this, new StatusBarMessageEventArgs($"Loading data..."));

            var columnIdx = 1;
            var row = 2;
            var fileCount = 0;
            var recordType = typeof(AuditRecord);

            Service.ExpandAuditDetails(filter, (auditDetails) =>
            {
                this.SendMessageToStatusBar(this, new StatusBarMessageEventArgs($"Adding {auditDetails.Count} rows to Excel File..."));
                foreach (var detail in auditDetails)
                {
                    var records = ConvertToAttributeAuditRecord(detail).Where(a => a != null).OrderByDescending( a => a.CreatedOn);

                    foreach (var record in records)
                    {
                        columnIdx = 1;
                        for (var i = 1; i <= gvAuditRecords.Columns.Count; i++)
                        {
                            var column = gvAuditRecords.Columns[i - 1];
                            if (column.Visible)
                            {
                                package.Workbook.Worksheets[1].Cells[row, columnIdx++].Value = recordType.GetProperty(column.DataPropertyName).GetValue(record);
                            }
                        }

                        if ((row-1) % this.settings.NumberOfRowsPerExcelFile == 0)
                        {
                            row = 2;
                            SaveExcelFile(package);
                            package.Dispose();
                            package = GetExcelFile(filePath, fileCount);
                            fileCount++;
                        }
                        else
                        {
                            row++;
                        }
                    }
                }

                this.SendMessageToStatusBar(this, new StatusBarMessageEventArgs($"{row} rows processed. Loading more data..."));

            }, () =>
            {
                return this.Service;
            });

            SaveExcelFile(package);
            package.Dispose();

            this.SendMessageToStatusBar(this, new StatusBarMessageEventArgs($""));
            LogInfo("Export to Excel finished");
        }

        private List<AuditRecord> LoadAuditData(AuditDataFilter filter)
        {
            var result = Service.RetrieveAuditDetails(filter)
                            .SelectMany(ad => ConvertToAttributeAuditRecord(ad))
                            .ToList();

            return result;
        }

        private List<AuditRecord> ConvertToAttributeAuditRecord(AuditDetail auditDetails)
        {
            var auditRecords = new List<AuditRecord>();
            if (auditDetails is AttributeAuditDetail attr)
            {
                auditRecords.AddRange(ConvertToAttributeAuditRecord(attr));
            }
            else if (auditDetails is UserAccessAuditDetail user)
            {
                auditRecords.Add(ConvertToAttributeAuditRecord(user));
            }
            else if (auditDetails is ShareAuditDetail share)
            {
                auditRecords.Add(ConvertToAttributeAuditRecord(share));
            }
            else if (auditDetails is RelationshipAuditDetail rel)
            {
                auditRecords.Add(ConvertToAttributeAuditRecord(rel));
            }

            return auditRecords;
        }

        private List<AuditRecord> ConvertToAttributeAuditRecord(AttributeAuditDetail auditDetails)
        {
            var auditRecords = new List<AuditRecord>();

            if (auditDetails != null && auditDetails.OldValue != null)
            {
                Entity audit = auditDetails.AuditRecord;
                foreach (var attribute in auditDetails.OldValue.Attributes)
                {
                    var entityLogicalName = audit.GetAttributeValue<EntityReference>("objectid")?.LogicalName;

                    auditRecords.Add(new AuditRecord
                    {
                        EntityLogicalName = entityLogicalName,
                        EntityDisplayName = this.auditableEntities[entityLogicalName].DisplayName?.UserLocalizedLabel?.Label,
                        RecordName = audit.GetAttributeValue<EntityReference>("objectid")?.Name,
                        AuthorName = audit.GetAttributeValue<EntityReference>("userid")?.Name,
                        CreatedOn = audit.GetAttributeValue<DateTime>("createdon"),
                        ObjectLogicalName = attribute.Key,
                        ObjectDisplayName = this.auditableEntities[entityLogicalName].Attributes.First( a => a.LogicalName == attribute.Key).DisplayName?.UserLocalizedLabel?.Label,
                        NewValue = auditDetails.NewValue?.GetAttributeValueAsString(attribute.Key),
                        NewValueFormated = auditDetails.NewValue?.GetAttributeText(attribute.Key),
                        OldValue = auditDetails.OldValue?.GetAttributeValueAsString(attribute.Key),
                        OldValueFormated = auditDetails.OldValue?.GetAttributeText(attribute.Key),
                        OperationFormated = audit.GetAttributeText("operation"),
                        OperationValue = audit.GetAttributeValueAsString("operation"),
                        ActionValue = audit.GetAttributeValueAsString("action"),
                        ActionFormated = audit.GetAttributeText("action"),
                    });
                }
            }

            return auditRecords;
        }

        private void ToggleOptions()
        {
            if (gbOptions.Visible)
                HideOptions();
            else
                ShowOptions();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            ToggleOptions();
        }

        private void HideOptions()
        {
            gbOptions.Visible = false;
            gbAuditableEntities.Height += gbOptions.Height;
            gbAuditableEntities.Location = new Point(4, 33);
            gbAuditRecords.Location = new Point(241, 33);
            gbAuditRecords.Height += gbOptions.Height;
            tsbToggleOptions.Text = "Show Options";
        }

        private void ShowOptions()
        {
            gbOptions.Visible = true;
            gbAuditableEntities.Height -= gbOptions.Height;
            gbAuditableEntities.Location = new Point(4, 149);
            gbAuditRecords.Location = new Point(241, 149);
            gbAuditRecords.Height -= gbOptions.Height;
            tsbToggleOptions.Text = "Hide Options";
        }

        private void allToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExecuteMethod(ExportAllAuditData);
        }

        private void tsbExport_Click(object sender, EventArgs e)
        {
            ExecuteMethod(ExportAllAuditData);
        }

        private void FillSettings()
        {
            this.settings.MaxNumberOfParallelRequests = Convert.ToInt32(nudMaxParallelRequests.Value);
            this.settings.NumberOfRecordsPerRequest = Convert.ToInt32(nudRecordsPerRequest.Value);
            this.settings.NumberOfRequestsPerBulkRequest = Convert.ToInt32(nudRequestsPerBulkRequest.Value);
            this.settings.NumberOfRowsPerExcelFile = Convert.ToInt32(nudNumberOfRowsPerExcelFile.Value);

            for (var i = 0; i < cblVisibleColumns.Items.Count; i++)
            {
                this.settings.Columns[i] = cblVisibleColumns.GetItemChecked(i);
            }
        }

        private void cblVisibleColumns_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (!this.showingSettings)
            {
                FillSettings();
                this.settings.Columns[e.Index] = e.NewValue == CheckState.Checked;
                UpdateGridView();
            }
        }

        private AuditRecord ConvertToAttributeAuditRecord(UserAccessAuditDetail auditDetails)
        {
            AuditRecord auditRecord = null;

            if (auditDetails != null)
            {
                Entity audit = auditDetails.AuditRecord;
                auditRecord = new AuditRecord
                {
                    EntityLogicalName = audit.GetAttributeValue<EntityReference>("objectid")?.LogicalName,
                    RecordName = audit.GetAttributeValue<EntityReference>("objectid")?.Name,
                    AuthorName = audit.GetAttributeValue<EntityReference>("userid")?.Name,
                    CreatedOn = audit.GetAttributeValue<DateTime>("createdon"),
                    ObjectLogicalName = "",

                    NewValue = "",
                    NewValueFormated = "",
                    OldValue = "",
                    OldValueFormated = "",

                    OperationFormated = audit.GetAttributeText("operation"),
                    OperationValue = audit.GetAttributeValueAsString("operation"),
                    ActionValue = audit.GetAttributeValueAsString("action"),
                    ActionFormated = audit.GetAttributeText("action"),
                };
            }

            return auditRecord;
        }

        private AuditRecord ConvertToAttributeAuditRecord(RelationshipAuditDetail auditDetails)
        {
            AuditRecord auditRecord = null;

            if (auditDetails != null)
            {
                Entity audit = auditDetails.AuditRecord;
                auditRecord = new AuditRecord
                {
                    EntityLogicalName = audit.GetAttributeValue<EntityReference>("objectid")?.LogicalName,
                    RecordName = audit.GetAttributeValue<EntityReference>("objectid")?.Name,
                    AuthorName = audit.GetAttributeValue<EntityReference>("userid")?.Name,
                    CreatedOn = audit.GetAttributeValue<DateTime>("createdon"),
                    ObjectLogicalName = "",

                    NewValue = "",
                    NewValueFormated = "",
                    OldValue = "",
                    OldValueFormated = "",

                    OperationFormated = audit.GetAttributeText("operation"),
                    OperationValue = audit.GetAttributeValueAsString("operation"),
                    ActionValue = audit.GetAttributeValueAsString("action"),
                    ActionFormated = audit.GetAttributeText("action"),
                };
            }

            return auditRecord;
        }

        private AuditRecord ConvertToAttributeAuditRecord(ShareAuditDetail auditDetails)
        {
            AuditRecord auditRecord = null;

            if (auditDetails != null)
            {
                Entity audit = auditDetails.AuditRecord;
                auditRecord = new AuditRecord
                {
                    EntityLogicalName = audit.GetAttributeValue<EntityReference>("objectid")?.LogicalName,
                    RecordName = audit.GetAttributeValue<EntityReference>("objectid")?.Name,
                    AuthorName = audit.GetAttributeValue<EntityReference>("userid")?.Name,
                    CreatedOn = audit.GetAttributeValue<DateTime>("createdon"),
                    ObjectLogicalName = "",

                    NewValue = "",
                    NewValueFormated = "",
                    OldValue = "",
                    OldValueFormated = "",

                    OperationFormated = audit.GetAttributeText("operation"),
                    OperationValue = audit.GetAttributeValueAsString("operation"),
                    ActionValue = audit.GetAttributeValueAsString("action"),
                    ActionFormated = audit.GetAttributeText("action"),
                };
            }

            return auditRecord;
        }

        private void cblVisibleColumns_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nudNumberOfRowsPerExcelFile_ValueChanged(object sender, EventArgs e)
        {
            if (!this.showingSettings)
                FillSettings();
        }

        private void nudParallelRequests_ValueChanged(object sender, EventArgs e)
        {
            if (!this.showingSettings)
            FillSettings();
        }

        private void nudRequestsPerBulkRequest_ValueChanged(object sender, EventArgs e)
        {
            if (!this.showingSettings)
            FillSettings();
        }

        private void nudRecordsPerRequest_ValueChanged(object sender, EventArgs e)
        {
            if (!this.showingSettings)
            FillSettings();
        }
        
        private void SetAuditableEntitiesCheck(bool check)
        {
            this.updatingChekedAuditableEntities = true;

            foreach ( TreeNode entityNode in tvAuditableEntities.Nodes)
            {
                entityNode.Checked = check;
                foreach(TreeNode attributeNode in entityNode.Nodes)
                {
                    attributeNode.Checked = check;
                }
            }

            this.updatingChekedAuditableEntities = false;
        }

        private void btnCheckAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SetAuditableEntitiesCheck(true);
        }

        private void btnUncheckAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SetAuditableEntitiesCheck(false);
        }
    }
}