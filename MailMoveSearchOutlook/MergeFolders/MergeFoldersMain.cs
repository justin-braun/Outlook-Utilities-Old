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
        List<OutlookMailFolder> filteredFolderList = new List<OutlookMailFolder>();
        List<OutlookMailFolder> allFolderList = new List<OutlookMailFolder>();

        enum FolderSource
        {
            source, destination
        }

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
            Helpers.OutlookHelpers helper = new Helpers.OutlookHelpers();
            filteredFolderList = helper.GetFolderList(root, checkBoxFoldersWithoutChildren.Checked, checkBoxFoldersWithItemsOnly.Checked);
            allFolderList = helper.GetFolderList(root, false, checkBoxFoldersWithItemsOnly.Checked);

            // Clear both list boxes
            listBoxMergeDest.Items.Clear();
            listBoxMergeSource.Items.Clear();

            // Fill list boxes with folder info
            //listBoxMergeSource.DataSource = filteredFolderList;
            //listBoxMergeDest.DataSource = allFolderList;
            listBoxMergeSource.Items.AddRange(filteredFolderList.ToArray());
            listBoxMergeDest.Items.AddRange(allFolderList.ToArray());

        }

        private void buttonStartMerge_Click(object sender, EventArgs e)
        {
            //MessageBox.Show($"You have selected to merge {((OutlookMailFolder)listBoxMergeSource.SelectedItem).FolderName} ({((OutlookMailFolder)listBoxMergeSource.SelectedItem).FolderId} with {((OutlookMailFolder)listBoxMergeDest.SelectedItem).FolderName} ({((OutlookMailFolder)listBoxMergeDest.SelectedItem).FolderId}.");
            if(((OutlookMailFolder)listBoxMergeSource.SelectedItem).FolderId == ((OutlookMailFolder)listBoxMergeDest.SelectedItem).FolderId)
            {
                MessageBox.Show("Source and destination folders are the same.  Select a different destination folder for the merge.");
                return;
            }

            try
            {
                if (listBoxMergeSource.SelectedItems.Count > 0 && listBoxMergeDest.SelectedItems.Count > 0)
                {
                    foreach (var sourceFolder in listBoxMergeSource.SelectedItems)
                    {
                        // Move selected items from source folder to destination folder
                        MergeItems(Globals.ThisAddIn.Application.Session.GetFolderFromID(((OutlookMailFolder)sourceFolder).FolderId) as Outlook.Folder,
                                ((OutlookMailFolder)listBoxMergeDest.SelectedItem));
                    }

                    // delete source folder if option is selected
                    if(checkBoxRemoveSourceFolder.Checked)
                    {
                        foreach (var sourceFolder in listBoxMergeSource.SelectedItems)
                        {
                            // Move selected items from source folder to destination folder
                            Outlook.Folder folder = Globals.ThisAddIn.Application.Session.GetFolderFromID(((OutlookMailFolder)sourceFolder).FolderId) as Outlook.Folder;
                            folder.Delete();
                        }
                    }

                    MessageBox.Show("Merge completed successfully.");

                    // Refresh Folder List
                    LoadFolders();

                    // Clear filters
                    sourceFilterTextbox.Text = "";
                    destFilterTextbox.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error moving mail items. {ex.Message}");
            }

        }

        private void MergeItems(Outlook.Folder sourceFolder, OutlookMailFolder destFolder)
        {
            //MessageBox.Show($"{sourceFolder.Items.Count} items moving");
            Helpers.OutlookHelpers.MoveFolderItems(sourceFolder, destFolder);
        }

        private void checkBoxFoldersWithItemsOnly_CheckedChanged(object sender, EventArgs e)
        {
            LoadFolders();
        }

        private void checkBoxFoldersWithoutChildren_CheckedChanged(object sender, EventArgs e)
        {
            LoadFolders();
        }

        private void FindFolder(List<OutlookMailFolder> folders, FolderSource source, string searchString)
        {
            if(source == FolderSource.source)
            {
                listBoxMergeSource.Items.Clear();
                listBoxMergeSource.Items.AddRange(folders.Where(i => i.FolderPath.ToLower().Contains(sourceFilterTextbox.Text.ToLower())).ToArray());
            }
            else if (source == FolderSource.destination)
            {
                listBoxMergeDest.Items.Clear();
                listBoxMergeDest.Items.AddRange(folders.Where(i => i.FolderPath.ToLower().Contains(destFilterTextbox.Text.ToLower())).ToArray());
            }
        }

        private void sourceFilterTextbox_TextChanged(object sender, EventArgs e)
        {
            FindFolder(filteredFolderList,FolderSource.source, sourceFilterTextbox.Text);
        }

        private void destFilterTextbox_TextChanged(object sender, EventArgs e)
        {
            FindFolder(allFolderList, FolderSource.destination, destFilterTextbox.Text);
        }
    }
}
