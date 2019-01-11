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

namespace WCOutlookUtilities.GoToFolder
{
    public partial class GoToFolderForm : Form
    {
        List<OutlookMailFolder> OutlookFolders = new List<OutlookMailFolder>();

        public GoToFolderForm()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GoToFolderForm_Load(object sender, EventArgs e)
        {
            textSearch.BringToFront();
            listResults.BringToFront();

            // Listbox Properties
            listResults.DisplayMember = "FolderPath";
            listResults.ValueMember = "FolderId";

            // Refresh Folder List
            RefreshFolderList();
        }

        public void RefreshFolderList()
        {
            //Refresh folder list
            GetFolderList();

            // Textbox Focus
            textSearch.Focus();
        }

        private void GetFolderList()
        {
            // Clear folder array
            if (OutlookFolders != null)
                OutlookFolders.Clear();

            // Get folders in the default store
            Outlook.Folder root = Globals.ThisAddIn.Application.Session.
                DefaultStore.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderInbox) as Outlook.Folder;

            //Enumerate and add to array
            EnumerateFolders(root);
        }

        private void EnumerateFolders(Outlook.Folder folder)
        {
            // Get folders in the default store
            Outlook.Folders childFolders = folder.Folders;

            if (childFolders.Count == 0)
            {
                // Write the folder path object.
                OutlookFolders.Add(new OutlookMailFolder
                {
                    FolderName = folder.Name,
                    FullFolderPath = folder.FolderPath,
                    FolderPath = Regex.Replace(folder.FolderPath, @"\\\\(.*?)\\", "\\").Replace(@"\", @"/"),
                    FolderId = folder.EntryID
                });
            }
            else
            {
                // Write the folder path object.
                OutlookFolders.Add(new OutlookMailFolder
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

        private void FindFolder(string searchString)
        {
            listResults.Items.Clear();

            foreach (OutlookMailFolder folder in OutlookFolders)
            {
                if (folder.FolderName.ToLower().Contains(searchString.ToLower()))
                {
                    listResults.Items.Add(folder);
                }
            }

            if (listResults.Items.Count > 0)
            {
                listResults.SelectedIndex = 0;
                buttonOK.Enabled = true;
            }
            else
            {
                buttonOK.Enabled = false;
            }

            if (textSearch.Text == "")
            {
                listResults.Items.Clear();
                buttonOK.Enabled = false;
            }
        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            // Search for folder
            FindFolder(textSearch.Text);
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            // Go to selected folder
            this.Close();
            Outlook.MAPIFolder folder = Globals.ThisAddIn.Application.Session.GetFolderFromID(((OutlookMailFolder)listResults.SelectedItem).FolderId);
            Globals.ThisAddIn.Application.ActiveExplorer().CurrentFolder = folder;


        }
    }
}
