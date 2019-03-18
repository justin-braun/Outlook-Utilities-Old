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

namespace WCOutlookUtilities.MergeFolders
{
    public partial class MergeFoldersMain : Form
    {
        public MergeFoldersMain()
        {
            InitializeComponent();
        }

        private void MergeFoldersMain_Load(object sender, EventArgs e)
        {
            // Listbox Source Properties
            listBoxMergeSource.DisplayMember = "FolderPath";
            listBoxMergeSource.ValueMember = "FolderId";
            
            // Listbox Dest Properties
            listBoxMergeDest.DisplayMember = "FolderPath";
            listBoxMergeDest.ValueMember = "FolderId";

            // Load folders
            LoadFolders();

        }

        private void LoadFolders()
        {

            // Get folders in the default store
            Outlook.Folder root = Globals.ThisAddIn.Application.Session.
                DefaultStore.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderInbox) as Outlook.Folder;

            // Instantiate helper and get Outlook folder list
            Helpers.OutlookHelpers oh = new Helpers.OutlookHelpers();
            List<OutlookMailFolder> folderList = oh.GetFolderList(root);

            // Clear both list boxes
            listBoxMergeDest.Items.Clear();
            listBoxMergeSource.Items.Clear();

            // Fill list boxes with folder info
            foreach(var item in folderList)
            {
                listBoxMergeSource.Items.Add(item);
                listBoxMergeDest.Items.Add(item);
            }

        }

        private void buttonStartMerge_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"You have selected to merge {((OutlookMailFolder)listBoxMergeSource.SelectedItem).FolderName} ({((OutlookMailFolder)listBoxMergeSource.SelectedItem).FolderId} with {((OutlookMailFolder)listBoxMergeDest.SelectedItem).FolderName} ({((OutlookMailFolder)listBoxMergeDest.SelectedItem).FolderId}.");
        }
    }
}
