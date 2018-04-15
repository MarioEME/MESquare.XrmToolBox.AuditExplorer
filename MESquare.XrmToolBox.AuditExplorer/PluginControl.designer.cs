using MESquare.XrmToolBox.AuditExplorer.Controls;
using MESquare.XrmToolBox.AuditExplorer.Entities;

namespace MESquare.XrmToolBox.AuditExplorer
{
    partial class PluginControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PluginControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.tssSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbLoadAuditableObjects = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPreviewData = new System.Windows.Forms.ToolStripButton();
            this.btnExportToExcel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbToggleOptions = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nudNumberOfRecords = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFilterCreatedAfterDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFilterCreatedBeforeDate = new System.Windows.Forms.DateTimePicker();
            this.cbFilterUsers = new System.Windows.Forms.ComboBox();
            this.gbAuditableEntities = new System.Windows.Forms.GroupBox();
            this.btnUncheckAll = new System.Windows.Forms.LinkLabel();
            this.btnCheckAll = new System.Windows.Forms.LinkLabel();
            this.tvAuditableEntities = new MESquare.XrmToolBox.AuditExplorer.Controls.TriStateTreeView();
            this.gbAuditRecords = new System.Windows.Forms.GroupBox();
            this.gvAuditRecords = new MESquare.XrmToolBox.AuditExplorer.Controls.MyGridView();
            this.createdOnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operationValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operationFormatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionFormatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entityLogicalNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entityDisplayNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objectLogicalNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objectDisplayNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recordNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oldValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oldValueFormatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newValueFormatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.auditRecordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbOptions = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.nudNumberOfRowsPerExcelFile = new System.Windows.Forms.NumericUpDown();
            this.nudMaxParallelRequests = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.nudRequestsPerBulkRequest = new System.Windows.Forms.NumericUpDown();
            this.nudRecordsPerRequest = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cblVisibleColumns = new System.Windows.Forms.CheckedListBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.toolStripMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfRecords)).BeginInit();
            this.gbAuditableEntities.SuspendLayout();
            this.gbAuditRecords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvAuditRecords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditRecordBindingSource)).BeginInit();
            this.gbOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfRowsPerExcelFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxParallelRequests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRequestsPerBulkRequest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRecordsPerRequest)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.AutoSize = false;
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbClose,
            this.tssSeparator1,
            this.tsbLoadAuditableObjects,
            this.toolStripSeparator1,
            this.btnPreviewData,
            this.btnExportToExcel,
            this.toolStripSeparator2,
            this.tsbToggleOptions});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(747, 25);
            this.toolStripMenu.TabIndex = 4;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // tsbClose
            // 
            this.tsbClose.AutoSize = false;
            this.tsbClose.Image = ((System.Drawing.Image)(resources.GetObject("tsbClose.Image")));
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(56, 22);
            this.tsbClose.Text = "Close";
            this.tsbClose.Click += new System.EventHandler(this.tsbClose_Click);
            // 
            // tssSeparator1
            // 
            this.tssSeparator1.Name = "tssSeparator1";
            this.tssSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbLoadAuditableObjects
            // 
            this.tsbLoadAuditableObjects.Image = ((System.Drawing.Image)(resources.GetObject("tsbLoadAuditableObjects.Image")));
            this.tsbLoadAuditableObjects.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLoadAuditableObjects.Name = "tsbLoadAuditableObjects";
            this.tsbLoadAuditableObjects.Size = new System.Drawing.Size(98, 22);
            this.tsbLoadAuditableObjects.Text = "Load Entities";
            this.tsbLoadAuditableObjects.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnPreviewData
            // 
            this.btnPreviewData.Enabled = false;
            this.btnPreviewData.Image = ((System.Drawing.Image)(resources.GetObject("btnPreviewData.Image")));
            this.btnPreviewData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPreviewData.Name = "btnPreviewData";
            this.btnPreviewData.Size = new System.Drawing.Size(99, 22);
            this.btnPreviewData.Text = "Preview Data";
            this.btnPreviewData.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.Enabled = false;
            this.btnExportToExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExportToExcel.Image")));
            this.btnExportToExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.Size = new System.Drawing.Size(107, 22);
            this.btnExportToExcel.Text = "Export to Excel";
            this.btnExportToExcel.Click += new System.EventHandler(this.tsbExport_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbToggleOptions
            // 
            this.tsbToggleOptions.Image = ((System.Drawing.Image)(resources.GetObject("tsbToggleOptions.Image")));
            this.tsbToggleOptions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbToggleOptions.Name = "tsbToggleOptions";
            this.tsbToggleOptions.Size = new System.Drawing.Size(105, 22);
            this.tsbToggleOptions.Text = "Show Options";
            this.tsbToggleOptions.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nudNumberOfRecords);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpFilterCreatedAfterDate);
            this.groupBox1.Controls.Add(this.dtpFilterCreatedBeforeDate);
            this.groupBox1.Controls.Add(this.cbFilterUsers);
            this.groupBox1.Location = new System.Drawing.Point(7, 255);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 182);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Preview records count";
            // 
            // nudNumberOfRecords
            // 
            this.nudNumberOfRecords.Location = new System.Drawing.Point(7, 156);
            this.nudNumberOfRecords.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudNumberOfRecords.Name = "nudNumberOfRecords";
            this.nudNumberOfRecords.Size = new System.Drawing.Size(120, 20);
            this.nudNumberOfRecords.TabIndex = 8;
            this.nudNumberOfRecords.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "After";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Before";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Author";
            // 
            // dtpFilterCreatedAfterDate
            // 
            this.dtpFilterCreatedAfterDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFilterCreatedAfterDate.Location = new System.Drawing.Point(7, 115);
            this.dtpFilterCreatedAfterDate.Name = "dtpFilterCreatedAfterDate";
            this.dtpFilterCreatedAfterDate.Size = new System.Drawing.Size(212, 20);
            this.dtpFilterCreatedAfterDate.TabIndex = 3;
            // 
            // dtpFilterCreatedBeforeDate
            // 
            this.dtpFilterCreatedBeforeDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFilterCreatedBeforeDate.Location = new System.Drawing.Point(7, 74);
            this.dtpFilterCreatedBeforeDate.Name = "dtpFilterCreatedBeforeDate";
            this.dtpFilterCreatedBeforeDate.Size = new System.Drawing.Size(212, 20);
            this.dtpFilterCreatedBeforeDate.TabIndex = 1;
            // 
            // cbFilterUsers
            // 
            this.cbFilterUsers.FormattingEnabled = true;
            this.cbFilterUsers.Location = new System.Drawing.Point(6, 34);
            this.cbFilterUsers.Name = "cbFilterUsers";
            this.cbFilterUsers.Size = new System.Drawing.Size(213, 21);
            this.cbFilterUsers.TabIndex = 0;
            // 
            // gbAuditableEntities
            // 
            this.gbAuditableEntities.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbAuditableEntities.Controls.Add(this.btnUncheckAll);
            this.gbAuditableEntities.Controls.Add(this.btnCheckAll);
            this.gbAuditableEntities.Controls.Add(this.tvAuditableEntities);
            this.gbAuditableEntities.Location = new System.Drawing.Point(4, 149);
            this.gbAuditableEntities.Name = "gbAuditableEntities";
            this.gbAuditableEntities.Size = new System.Drawing.Size(231, 100);
            this.gbAuditableEntities.TabIndex = 6;
            this.gbAuditableEntities.TabStop = false;
            this.gbAuditableEntities.Text = "Auditable Entities";
            // 
            // btnUncheckAll
            // 
            this.btnUncheckAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUncheckAll.AutoSize = true;
            this.btnUncheckAll.Location = new System.Drawing.Point(163, 84);
            this.btnUncheckAll.Name = "btnUncheckAll";
            this.btnUncheckAll.Size = new System.Drawing.Size(65, 13);
            this.btnUncheckAll.TabIndex = 2;
            this.btnUncheckAll.TabStop = true;
            this.btnUncheckAll.Text = "Uncheck All";
            this.btnUncheckAll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnUncheckAll_LinkClicked);
            // 
            // btnCheckAll
            // 
            this.btnCheckAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCheckAll.AutoSize = true;
            this.btnCheckAll.Location = new System.Drawing.Point(0, 84);
            this.btnCheckAll.Name = "btnCheckAll";
            this.btnCheckAll.Size = new System.Drawing.Size(52, 13);
            this.btnCheckAll.TabIndex = 1;
            this.btnCheckAll.TabStop = true;
            this.btnCheckAll.Text = "Check All";
            this.btnCheckAll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnCheckAll_LinkClicked);
            // 
            // tvAuditableEntities
            // 
            this.tvAuditableEntities.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tvAuditableEntities.CheckBoxes = true;
            this.tvAuditableEntities.Location = new System.Drawing.Point(3, 16);
            this.tvAuditableEntities.Name = "tvAuditableEntities";
            this.tvAuditableEntities.Size = new System.Drawing.Size(225, 65);
            this.tvAuditableEntities.TabIndex = 0;
            // 
            // gbAuditRecords
            // 
            this.gbAuditRecords.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAuditRecords.Controls.Add(this.gvAuditRecords);
            this.gbAuditRecords.Location = new System.Drawing.Point(241, 149);
            this.gbAuditRecords.Name = "gbAuditRecords";
            this.gbAuditRecords.Size = new System.Drawing.Size(498, 288);
            this.gbAuditRecords.TabIndex = 7;
            this.gbAuditRecords.TabStop = false;
            this.gbAuditRecords.Text = "Audit Records";
            // 
            // gvAuditRecords
            // 
            this.gvAuditRecords.AllowUserToAddRows = false;
            this.gvAuditRecords.AllowUserToDeleteRows = false;
            this.gvAuditRecords.AllowUserToOrderColumns = true;
            this.gvAuditRecords.AllowUserToResizeRows = false;
            this.gvAuditRecords.AutoGenerateColumns = false;
            this.gvAuditRecords.CausesValidation = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvAuditRecords.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvAuditRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvAuditRecords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.createdOnDataGridViewTextBoxColumn,
            this.authorNameDataGridViewTextBoxColumn,
            this.operationValueDataGridViewTextBoxColumn,
            this.operationFormatedDataGridViewTextBoxColumn,
            this.actionValueDataGridViewTextBoxColumn,
            this.actionFormatedDataGridViewTextBoxColumn,
            this.entityLogicalNameDataGridViewTextBoxColumn,
            this.entityDisplayNameDataGridViewTextBoxColumn,
            this.objectLogicalNameDataGridViewTextBoxColumn,
            this.objectDisplayNameDataGridViewTextBoxColumn,
            this.recordNameDataGridViewTextBoxColumn,
            this.oldValueDataGridViewTextBoxColumn,
            this.oldValueFormatedDataGridViewTextBoxColumn,
            this.newValueDataGridViewTextBoxColumn,
            this.newValueFormatedDataGridViewTextBoxColumn});
            this.gvAuditRecords.DataSource = this.auditRecordBindingSource;
            this.gvAuditRecords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvAuditRecords.Location = new System.Drawing.Point(3, 16);
            this.gvAuditRecords.MultiSelect = false;
            this.gvAuditRecords.Name = "gvAuditRecords";
            this.gvAuditRecords.ReadOnly = true;
            this.gvAuditRecords.RowHeadersVisible = false;
            this.gvAuditRecords.Size = new System.Drawing.Size(492, 269);
            this.gvAuditRecords.TabIndex = 0;
            // 
            // createdOnDataGridViewTextBoxColumn
            // 
            this.createdOnDataGridViewTextBoxColumn.DataPropertyName = "CreatedOn";
            this.createdOnDataGridViewTextBoxColumn.HeaderText = "Created On";
            this.createdOnDataGridViewTextBoxColumn.Name = "createdOnDataGridViewTextBoxColumn";
            this.createdOnDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // authorNameDataGridViewTextBoxColumn
            // 
            this.authorNameDataGridViewTextBoxColumn.DataPropertyName = "AuthorName";
            this.authorNameDataGridViewTextBoxColumn.HeaderText = "Author";
            this.authorNameDataGridViewTextBoxColumn.Name = "authorNameDataGridViewTextBoxColumn";
            this.authorNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // operationValueDataGridViewTextBoxColumn
            // 
            this.operationValueDataGridViewTextBoxColumn.DataPropertyName = "OperationValue";
            this.operationValueDataGridViewTextBoxColumn.HeaderText = "Operation Value";
            this.operationValueDataGridViewTextBoxColumn.Name = "operationValueDataGridViewTextBoxColumn";
            this.operationValueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // operationFormatedDataGridViewTextBoxColumn
            // 
            this.operationFormatedDataGridViewTextBoxColumn.DataPropertyName = "OperationFormated";
            this.operationFormatedDataGridViewTextBoxColumn.HeaderText = "Operation";
            this.operationFormatedDataGridViewTextBoxColumn.Name = "operationFormatedDataGridViewTextBoxColumn";
            this.operationFormatedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // actionValueDataGridViewTextBoxColumn
            // 
            this.actionValueDataGridViewTextBoxColumn.DataPropertyName = "ActionValue";
            this.actionValueDataGridViewTextBoxColumn.HeaderText = "Action Value";
            this.actionValueDataGridViewTextBoxColumn.Name = "actionValueDataGridViewTextBoxColumn";
            this.actionValueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // actionFormatedDataGridViewTextBoxColumn
            // 
            this.actionFormatedDataGridViewTextBoxColumn.DataPropertyName = "ActionFormated";
            this.actionFormatedDataGridViewTextBoxColumn.HeaderText = "Action";
            this.actionFormatedDataGridViewTextBoxColumn.Name = "actionFormatedDataGridViewTextBoxColumn";
            this.actionFormatedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // entityLogicalNameDataGridViewTextBoxColumn
            // 
            this.entityLogicalNameDataGridViewTextBoxColumn.DataPropertyName = "EntityLogicalName";
            this.entityLogicalNameDataGridViewTextBoxColumn.HeaderText = "Entity Logical Name";
            this.entityLogicalNameDataGridViewTextBoxColumn.Name = "entityLogicalNameDataGridViewTextBoxColumn";
            this.entityLogicalNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // entityDisplayNameDataGridViewTextBoxColumn
            // 
            this.entityDisplayNameDataGridViewTextBoxColumn.DataPropertyName = "EntityDisplayName";
            this.entityDisplayNameDataGridViewTextBoxColumn.HeaderText = "Entity";
            this.entityDisplayNameDataGridViewTextBoxColumn.Name = "entityDisplayNameDataGridViewTextBoxColumn";
            this.entityDisplayNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // objectLogicalNameDataGridViewTextBoxColumn
            // 
            this.objectLogicalNameDataGridViewTextBoxColumn.DataPropertyName = "ObjectLogicalName";
            this.objectLogicalNameDataGridViewTextBoxColumn.HeaderText = "Object Logical Name";
            this.objectLogicalNameDataGridViewTextBoxColumn.Name = "objectLogicalNameDataGridViewTextBoxColumn";
            this.objectLogicalNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // objectDisplayNameDataGridViewTextBoxColumn
            // 
            this.objectDisplayNameDataGridViewTextBoxColumn.DataPropertyName = "ObjectDisplayName";
            this.objectDisplayNameDataGridViewTextBoxColumn.HeaderText = "Object";
            this.objectDisplayNameDataGridViewTextBoxColumn.Name = "objectDisplayNameDataGridViewTextBoxColumn";
            this.objectDisplayNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // recordNameDataGridViewTextBoxColumn
            // 
            this.recordNameDataGridViewTextBoxColumn.DataPropertyName = "RecordName";
            this.recordNameDataGridViewTextBoxColumn.HeaderText = "Record";
            this.recordNameDataGridViewTextBoxColumn.Name = "recordNameDataGridViewTextBoxColumn";
            this.recordNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oldValueDataGridViewTextBoxColumn
            // 
            this.oldValueDataGridViewTextBoxColumn.DataPropertyName = "OldValue";
            this.oldValueDataGridViewTextBoxColumn.HeaderText = "Old Value Value";
            this.oldValueDataGridViewTextBoxColumn.Name = "oldValueDataGridViewTextBoxColumn";
            this.oldValueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oldValueFormatedDataGridViewTextBoxColumn
            // 
            this.oldValueFormatedDataGridViewTextBoxColumn.DataPropertyName = "OldValueFormated";
            this.oldValueFormatedDataGridViewTextBoxColumn.HeaderText = "Old Value";
            this.oldValueFormatedDataGridViewTextBoxColumn.Name = "oldValueFormatedDataGridViewTextBoxColumn";
            this.oldValueFormatedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // newValueDataGridViewTextBoxColumn
            // 
            this.newValueDataGridViewTextBoxColumn.DataPropertyName = "NewValue";
            this.newValueDataGridViewTextBoxColumn.HeaderText = "New Value Value";
            this.newValueDataGridViewTextBoxColumn.Name = "newValueDataGridViewTextBoxColumn";
            this.newValueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // newValueFormatedDataGridViewTextBoxColumn
            // 
            this.newValueFormatedDataGridViewTextBoxColumn.DataPropertyName = "NewValueFormated";
            this.newValueFormatedDataGridViewTextBoxColumn.HeaderText = "New Value";
            this.newValueFormatedDataGridViewTextBoxColumn.Name = "newValueFormatedDataGridViewTextBoxColumn";
            this.newValueFormatedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // auditRecordBindingSource
            // 
            this.auditRecordBindingSource.DataSource = typeof(MESquare.XrmToolBox.AuditExplorer.Entities.AuditRecord);
            // 
            // gbOptions
            // 
            this.gbOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbOptions.Controls.Add(this.label8);
            this.gbOptions.Controls.Add(this.nudNumberOfRowsPerExcelFile);
            this.gbOptions.Controls.Add(this.nudMaxParallelRequests);
            this.gbOptions.Controls.Add(this.label7);
            this.gbOptions.Controls.Add(this.nudRequestsPerBulkRequest);
            this.gbOptions.Controls.Add(this.nudRecordsPerRequest);
            this.gbOptions.Controls.Add(this.label6);
            this.gbOptions.Controls.Add(this.label5);
            this.gbOptions.Controls.Add(this.cblVisibleColumns);
            this.gbOptions.Location = new System.Drawing.Point(4, 28);
            this.gbOptions.Name = "gbOptions";
            this.gbOptions.Size = new System.Drawing.Size(732, 115);
            this.gbOptions.TabIndex = 8;
            this.gbOptions.TabStop = false;
            this.gbOptions.Text = "Options";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(252, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Rows per Excel file";
            // 
            // nudNumberOfRowsPerExcelFile
            // 
            this.nudNumberOfRowsPerExcelFile.Location = new System.Drawing.Point(369, 89);
            this.nudNumberOfRowsPerExcelFile.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudNumberOfRowsPerExcelFile.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudNumberOfRowsPerExcelFile.Name = "nudNumberOfRowsPerExcelFile";
            this.nudNumberOfRowsPerExcelFile.Size = new System.Drawing.Size(76, 20);
            this.nudNumberOfRowsPerExcelFile.TabIndex = 7;
            this.nudNumberOfRowsPerExcelFile.Value = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudNumberOfRowsPerExcelFile.ValueChanged += new System.EventHandler(this.nudNumberOfRowsPerExcelFile_ValueChanged);
            // 
            // nudMaxParallelRequests
            // 
            this.nudMaxParallelRequests.Location = new System.Drawing.Point(369, 64);
            this.nudMaxParallelRequests.Name = "nudMaxParallelRequests";
            this.nudMaxParallelRequests.Size = new System.Drawing.Size(76, 20);
            this.nudMaxParallelRequests.TabIndex = 6;
            this.nudMaxParallelRequests.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudMaxParallelRequests.ValueChanged += new System.EventHandler(this.nudParallelRequests_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(252, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Max Parallel requests";
            // 
            // nudRequestsPerBulkRequest
            // 
            this.nudRequestsPerBulkRequest.Location = new System.Drawing.Point(369, 40);
            this.nudRequestsPerBulkRequest.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudRequestsPerBulkRequest.Name = "nudRequestsPerBulkRequest";
            this.nudRequestsPerBulkRequest.Size = new System.Drawing.Size(76, 20);
            this.nudRequestsPerBulkRequest.TabIndex = 4;
            this.nudRequestsPerBulkRequest.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudRequestsPerBulkRequest.ValueChanged += new System.EventHandler(this.nudRequestsPerBulkRequest_ValueChanged);
            // 
            // nudRecordsPerRequest
            // 
            this.nudRecordsPerRequest.Location = new System.Drawing.Point(369, 15);
            this.nudRecordsPerRequest.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudRecordsPerRequest.Name = "nudRecordsPerRequest";
            this.nudRecordsPerRequest.Size = new System.Drawing.Size(76, 20);
            this.nudRecordsPerRequest.TabIndex = 3;
            this.nudRecordsPerRequest.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudRecordsPerRequest.ValueChanged += new System.EventHandler(this.nudRecordsPerRequest_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(252, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Bulk request records";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(252, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Records per request";
            // 
            // cblVisibleColumns
            // 
            this.cblVisibleColumns.FormattingEnabled = true;
            this.cblVisibleColumns.Items.AddRange(new object[] {
            "Created On",
            "Author",
            "Operation Value",
            "Operation",
            "Action Value",
            "Action",
            "Entity Logical Name",
            "Entity",
            "Object Logical Name",
            "Object",
            "Record",
            "Old Value Value",
            "Old Value",
            "New Value Value",
            "New Value"});
            this.cblVisibleColumns.Location = new System.Drawing.Point(3, 15);
            this.cblVisibleColumns.Name = "cblVisibleColumns";
            this.cblVisibleColumns.Size = new System.Drawing.Size(228, 94);
            this.cblVisibleColumns.TabIndex = 0;
            this.cblVisibleColumns.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.cblVisibleColumns_ItemCheck);
            this.cblVisibleColumns.SelectedIndexChanged += new System.EventHandler(this.cblVisibleColumns_SelectedIndexChanged);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "xlsx";
            this.saveFileDialog.FileName = "audit.xlsx";
            this.saveFileDialog.Filter = "Excel |*.xlsx";
            // 
            // PluginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbOptions);
            this.Controls.Add(this.gbAuditRecords);
            this.Controls.Add(this.gbAuditableEntities);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStripMenu);
            this.Name = "PluginControl";
            this.Size = new System.Drawing.Size(747, 443);
            this.Load += new System.EventHandler(this.MyPluginControl_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfRecords)).EndInit();
            this.gbAuditableEntities.ResumeLayout(false);
            this.gbAuditableEntities.PerformLayout();
            this.gbAuditRecords.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvAuditRecords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditRecordBindingSource)).EndInit();
            this.gbOptions.ResumeLayout(false);
            this.gbOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfRowsPerExcelFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxParallelRequests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRequestsPerBulkRequest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRecordsPerRequest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.ToolStripSeparator tssSeparator1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbAuditableEntities;
        private System.Windows.Forms.GroupBox gbAuditRecords;
        private MyGridView gvAuditRecords;
        private System.Windows.Forms.ToolStripButton tsbLoadAuditableObjects;
        private System.Windows.Forms.ToolStripButton btnPreviewData;
        private System.Windows.Forms.ComboBox cbFilterUsers;
        private System.Windows.Forms.DateTimePicker dtpFilterCreatedBeforeDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFilterCreatedAfterDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudNumberOfRecords;
        private System.Windows.Forms.ToolStripButton tsbToggleOptions;
        private System.Windows.Forms.GroupBox gbOptions;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnExportToExcel;
        private System.Windows.Forms.NumericUpDown nudMaxParallelRequests;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudRequestsPerBulkRequest;
        private System.Windows.Forms.NumericUpDown nudRecordsPerRequest;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckedListBox cblVisibleColumns;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.DataGridViewTextBoxColumn actionTextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operationTextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oldValueTextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn newValueTextDataGridViewTextBoxColumn;
        private TriStateTreeView tvAuditableEntities;
        private System.Windows.Forms.BindingSource auditRecordBindingSource;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudNumberOfRowsPerExcelFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdOnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operationValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operationFormatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actionValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actionFormatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entityLogicalNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entityDisplayNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn objectLogicalNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn objectDisplayNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recordNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oldValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oldValueFormatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn newValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn newValueFormatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.LinkLabel btnUncheckAll;
        private System.Windows.Forms.LinkLabel btnCheckAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}
