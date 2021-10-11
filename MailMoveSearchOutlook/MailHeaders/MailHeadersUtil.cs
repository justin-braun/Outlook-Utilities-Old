using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Outlook = Microsoft.Office.Interop.Outlook;
using Office = Microsoft.Office.Core;
using System.Runtime.InteropServices;

namespace WCOutlookUtilities.MailHeaders
{
    public static class MailHeadersUtil
    {
        public static void LoadSmtpAddresses()
        {
            if (Globals.ThisAddIn.Application.ActiveExplorer().CurrentFolder.Items.Count > 0)
            {
                var folderItems = Globals.ThisAddIn.Application.ActiveExplorer().CurrentFolder.Items;

                foreach(var item in folderItems)
                {
                    if(item is Outlook.MailItem)
                    {
                        // Cast the MailItem
                        Outlook.MailItem mailItem = (item as Outlook.MailItem);

                        // Get message header properties and split
                        string header = mailItem.PropertyAccessor.GetProperty("http://schemas.microsoft.com/mapi/proptag/0x007D001F");
                        string[] headerFields = header.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

                        string smtpTo = "";
                        foreach (var line in headerFields)
                        {
                            if (line.StartsWith("To:"))
                            {
                                // Source = "To: Name <smtp address>"
                                string smtp = line.Split(':')[1];

                                // Header may contain name and SMTP and could have the SMTP address enclosed in <smtp address>"
                                smtpTo = smtp.Contains("<") ? smtp.Split('<', '>')[1] : smtp;


                                // User Property
                                Outlook.UserProperties props = mailItem.UserProperties;
                                props.Add("SMTPToAddress", Outlook.OlUserPropertyType.olText);

                                Outlook.UserProperty smtpAddressProperty = props.Find("SMTPToAddress");
                                smtpAddressProperty.Value = smtpTo;
                                mailItem.Save();

                                // Release
                                Marshal.ReleaseComObject(smtpAddressProperty);
                                Marshal.ReleaseComObject(props);

                                break;
                            }
                        }

                        // Release
                        Marshal.ReleaseComObject(mailItem);
                        
                        
                    }
                }
            }
        }
    }
}
