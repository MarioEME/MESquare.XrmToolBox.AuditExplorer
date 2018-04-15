﻿using System.ComponentModel.Composition;
using XrmToolBox.Extensibility;
using XrmToolBox.Extensibility.Interfaces;

namespace MESquare.XrmToolBox.AuditExplorer
{
    [Export(typeof(IXrmToolBoxPlugin)),
        ExportMetadata("Name", "Attribute Audit Explorer"),
        ExportMetadata("Description", "Helps in the attribute and entity audit analysis"),
        // Please specify the base64 content of a 32x32 pixels image
        ExportMetadata("SmallImageBase64", "iVBORw0KGgoAAAANSUhEUgAAACAAAAAgCAIAAAD8GO2jAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAADsMAAA7DAcdvqGQAAAAYdEVYdFNvZnR3YXJlAHBhaW50Lm5ldCA0LjAuOWwzfk4AAASLSURBVEhL7ZRrTFNnHMb33SVzDFptQagtUFoKwrgMUFjUTZx+MFmQOZDLKFcVJwuwqSByGShQKEIooEykFpC7ILQM5GYLUpkgRWspl6KlIAXZkAIF2v2701kyzPiyLVnCk9+H5zzvP+9zzsk573vqf1lbBZtqq2BT/YcFtfXtN4rq2ByeWPwCLlc0WlWpVMjqekE+OTUDY2BASuXK2tqadm2DtAVy+dx2as7O6yPo9Id6vhk0OhPllYIKyjYJou85k330bOalDFZgws0vovMtQ+noALpeeJFeZGl0HMPcI+ajoFwsNdP+dJZfTEF+Yc2r6VlkT0Tagh7+ICqebVarBrB5gt2WXxoxJeBNa1WEaiWmSGhcOokrn8VXzsMlMmZSJnf3T9CnZiFj+CqFyR05htGP8qMl0Zirq9pn0haUlTcZFgyQ2WoAVz65zSEAXyVHLgFs8fO3/i2E6tf7A5PRvmmkRtX6nFi/hL7SEhHLQN6btiAlqwRfKd3TqgaI9+a2h+aS2QuUn5eRxJAptGpZBYOvkGKvdaNiaz4MZezwTfUOSSIfj0XH1e280mKU34evnCBzFmGM0qzU900XDUl0BSGJN0mNcnue2vr+gk37MiqHa8dVkTlzkABGLKFN25LGXOOaWXnYu58+6nXxfit/SDw+Pi5jshpOhafYOnq9T/bUT6y346lgUj+88AG3T1dwOCrPpmPeuVdt0SBz6lUZsZ46PVKBhwTYVSK07XgDxrJp2qxWQmZPYdKb8woq4Ru7xWq09EtBx5QT7ohIjTLbTs2YQ7fSwDeN19WvKzANpLk8VroNqgk1Iy59K5TmyU/4i2TOBCSAccngxw/mEI9AKBHExuVmMip2JN614/3qJtAtOfYoDOltR74+LxL9+YoWFhb1g7MPDKkPDqmNS586//LGbVBpx5ulNE9AogkL+badcjBWLTJitWj3jYeoKOaFmBzsyZR9TxYh39u/SKofM2FwUd+zMCcSPfxi2zt74S/RFgifj2HiKg6Nqz6XrKGSGxx6ZsBTWl5at0rBALuyW206ZGBQ0UwDs2Moe1/0Z9/i/a5i0jkQHhxZ0Y8sJlgfP3Ao5KuT50+dS72UdF0mm4adQZqCRjYXV9S1X6pwHZ3/wDuV0vkCPO5Wt2W7BAxgePUuqWUUDKVTAtg+kjkK5K4jv5lzhiF0Ec3hbvPxrB7T6ifm955ZNA2ZlPWdjabrnoBZysZV9juIpmwHpNv2hRHqBS7SWYMfmBYdw3tlrwFMShWh+jHi10PqHPlLgkBsFVPDkpaXldqCsbEJ98Bkok+yoX+a65EzRp7xWGqGnhPVuKqP2CUGDC7exuY1UwRjJP6wWZsQV8U3zGGjLhRjf+Ja9AxvxKiYFxFJ0z0BSKFYfCmdeiYchb9DKn01IBBzeX1h59J8ghOAb4ITPvW57Oz/42G/y94BcRFRtDRaMauUHfodzTMoaSMnqPG1dW1ra5qDUlvwTsEtLC0t/4Fyfn5BNimfmZmDTw45PuGchQGFYumdKFdWkE3+ruAf0VbBptoq2FT/9wK1+ncQ3A8fgSyM7QAAAABJRU5ErkJggg=="),
        // Please specify the base64 content of a 80x80 pixels image
        ExportMetadata("BigImageBase64", "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"),
        ExportMetadata("BackgroundColor", "White"),
        ExportMetadata("PrimaryFontColor", "Black"),
        ExportMetadata("SecondaryFontColor", "Gray")]

    public class Plugin : PluginBase
    {
        public override IXrmToolBoxPluginControl GetControl()
        {
            return new PluginControl();
        }
    }
}