using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Outlook = Microsoft.Office.Interop.Outlook;
using Office = Microsoft.Office.Core;
using System.Windows.Forms;

namespace WCOutlookUtilities
{
    public partial class ThisAddIn
    {
        Outlook.Explorer currentExplorer = null;
        string lastEntryId = "";

        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            currentExplorer = this.Application.ActiveExplorer();
            currentExplorer.FolderSwitch += CurrentExplorer_FolderSwitch;
            currentExplorer.CurrentFolder.Items.ItemAdd
            //MessageBox.Show($"{currentExplorer.CurrentFolder.Items.Count + 1} items found"); 

        }

        private void CurrentExplorer_FolderSwitch()
        {
            MailHeaders.MailHeadersUtil.LoadSmtpAddresses();

        }

        private void CurrentExplorer_SelectionChange()
        {
            if(this.Application.ActiveExplorer().Selection.Count > 0)
            {
                object selObject = this.Application.ActiveExplorer().Selection[1];
                if(selObject is Outlook.MailItem)
                {
                    Outlook.MailItem mailItem = (selObject as Outlook.MailItem);
                    string header = mailItem.PropertyAccessor.GetProperty("http://schemas.microsoft.com/mapi/proptag/0x007D001F");

                    string[] headerFields = header.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
                    string smtpTo = "";

                    foreach(var line in headerFields)
                    {
                        if (line.StartsWith("To:"))
                        {
                            // Source = "To: Name <smtp address>"
                            string smtp = line.Split(':')[1];

                            // Header may contain name and SMTP and could have the SMTP address enclosed in <smtp address>"
                            smtpTo = smtp.Contains("<") ? smtp.Split('<','>')[1] : smtp;


                            // User Property
                            Outlook.UserProperties props = mailItem.UserProperties;
                            props.Add("SMTPToAddress", Outlook.OlUserPropertyType.olText);

                            Outlook.UserProperty smtpAddressProperty = props.Find("SMTPToAddress");
                            smtpAddressProperty.Value = smtpTo;
                            //mailItem.Save();
                            break;
                        }
                    }

                    // To prevent event from double-firing, check the EntryId of the MailItem
                    if(lastEntryId != mailItem.EntryID)
                    {
                        MessageBox.Show($"Subject: \"{mailItem.Subject}\"{Environment.NewLine}Address: {smtpTo}");
                    }

                    lastEntryId = mailItem.EntryID;
                    //TODO: Marshal.ReleaseComObject(productUserProperties);
                }
            }
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
            // Note: Outlook no longer raises this event. If you have code that 
            //    must run when Outlook shuts down, see https://go.microsoft.com/fwlink/?LinkId=506785
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }

        #endregion
    }
}
