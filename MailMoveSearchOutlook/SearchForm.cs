using Outlook = Microsoft.Office.Interop.Outlook;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace MailMoveSearchOutlook
{


    public partial class SearchForm : Form
    {
        List<OutlookFolder> OutlookFolders = new List<OutlookFolder>();

        public SearchForm()
        {
            InitializeComponent();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            // Listbox Properties
            listResults.DisplayMember = "FolderPath";
            listResults.ValueMember = "FolderId";

            //Refresh folder list
            GetFolderList();

            // Textbox Focus
            textSearch.Focus();

            // Selections
            // Highlighted item
            //var items = Globals.ThisAddIn.Application.ActiveExplorer().Selection;
            //MessageBox.Show(items.Count.ToString() + " messages selected.");

        }

        public void GetFolderList()
        {
            Outlook.Folder root = Globals.ThisAddIn.Application.Session.
                DefaultStore.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderInbox) as Outlook.Folder;
            EnumerateFolders(root);
        }

        public void EnumerateFolders(Outlook.Folder folder)
        {
            Outlook.Folders childFolders = folder.Folders;

            if (childFolders.Count == 0)
            {
                // Write the folder path object.
                OutlookFolders.Add(new OutlookFolder {
                    FolderName = folder.Name,
                    FullFolderPath = folder.FolderPath,
                    FolderPath = Regex.Replace(folder.FolderPath, @"\\\\(.*?)\\","\\").Replace(@"\", @"/"),
                    FolderId = folder.EntryID });
            }
            else
            {
                // Write the folder path object.
                OutlookFolders.Add(new OutlookFolder
                {
                    FolderName = folder.Name,
                    FullFolderPath = folder.FolderPath,
                    FolderPath = Regex.Replace(folder.FolderPath, @"\\\\(.*?)\\", "\\").Replace(@"\", @"/"),
                    FolderId = folder.EntryID
                });

                foreach (Outlook.Folder childFolder in childFolders)
                {
                    EnumerateFolders(childFolder);
                }
            }
        }

        public void FindFolder(string searchString)
        {
            foreach(OutlookFolder folder in OutlookFolders)
            {
                if(folder.FolderName.ToLower().Contains(searchString.ToLower()))
                {
                    listResults.Items.Add(folder);
                }
            }
        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            listResults.Items.Clear();
            FindFolder(textSearch.Text);

            if(listResults.Items.Count > 0)
            {
                listResults.SelectedIndex = 0;
                buttonMove.Enabled = true;
            }
            else
            {
                buttonMove.Enabled = false;
            }

            if(textSearch.Text == "")
            {
                listResults.Items.Clear();
                buttonMove.Enabled = false;
            }
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            // Move selected item to selected folder
            Outlook.Selection items = Globals.ThisAddIn.Application.ActiveExplorer().Selection;

            //MessageBox.Show("Moving " + items.Count.ToString() + " items");
            foreach(var item in items)
            {
                if(item is Outlook.MailItem)
                {
                    Outlook.MailItem mail = (Outlook.MailItem)item;

                    try
                    {
                        mail.Move(Globals.ThisAddIn.Application.Session.GetFolderFromID(((OutlookFolder)listResults.SelectedItem).FolderId));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }

            this.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listResults_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

    public class OutlookFolder
    {
        public string FolderName { get; set; }
        public string FullFolderPath { get; set; }
        public string FolderPath { get; set; }
        public string FolderId { get; set; }
    }
}
