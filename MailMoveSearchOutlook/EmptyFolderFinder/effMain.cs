using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace WCOutlookUtilities.EmptyFolderFinder
{
    public partial class effMain : Form
    {
        public effMain()
        {
            InitializeComponent();
        }

        private void effMain_Load(object sender, EventArgs e)
        {

            //for(int i = 1; i <= 50; i++)
            //{
            //    listFolders.Items.Add($"Test {i.ToString()}");
            //}

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            // Close form
            this.Close();

        }

        private void listFolders_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Toggle delete option
            toggleDeleteOption();
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            Find();
        }

        void Find()
        {
            // Clear list
            listFolders.Items.Clear();

            //Find folders
            FindEmptyFolders();

            // Toggle Select Folder Buttons
            ToggleSelectFolderButtons();
        }

        void toggleDeleteOption()
        {
            if(listFolders.CheckedItems.Count > 0)
            {
                buttonDelete.Enabled = true;
            }
            else
            {
                buttonDelete.Enabled = false;
            }
        }

        void ToggleSelectFolderButtons()
        {
            if (listFolders.Items.Count > 0)
            {
                buttonSelectAll.Enabled = true;
                buttonUnselectAll.Enabled = true;
            }
            else
            {
                buttonSelectAll.Enabled = false;
                buttonUnselectAll.Enabled = false;
            }

            // Toggle delete option
            toggleDeleteOption();
        }

        void FindEmptyFolders()
        {
            // Get folders in the default store
            if(checkIncludeInbox.Checked)
            {
                // Set root as inbox
                Outlook.Folder root = Globals.ThisAddIn.Application.Session.
                    DefaultStore.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderInbox) as Outlook.Folder;

                //Enumerate and add to array
                EnumerateFolders(root);
            }

            if(checkIncludeDeleted.Checked)
            {
                // Set root as inbox
                Outlook.Folder root = Globals.ThisAddIn.Application.Session.
                    DefaultStore.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderDeletedItems) as Outlook.Folder;

                //Enumerate and add to array
                EnumerateFolders(root);
            }

        }

        void EnumerateFolders(Outlook.Folder folder)
        {
            // Uses recursion to enumerate Outlook subfolders.

            Outlook.Folders childFolders = folder.Folders;
            if (childFolders.Count > 0)
            {
                foreach (Outlook.Folder childFolder in childFolders)
                {
                    if (childFolder.Items.Count == 0 && childFolder.Folders.Count == 0)
                    {
                        listFolders.Items.Add(childFolder.FolderPath);
                    }


                    // Call EnumerateFolders using childFolder.
                    EnumerateFolders(childFolder);
                }
            }
        }

        private void buttonSelectAll_Click(object sender, EventArgs e)
        {
            // Select all items in the listbox
            for (int i = 0; i <= listFolders.Items.Count - 1; i++)
            {
                listFolders.SetItemChecked(i, true);
            }

            // Toggle delete option
            toggleDeleteOption();
        }

        private void buttonUnselectAll_Click(object sender, EventArgs e)
        {
            // Unselect all items in the listbox
            for (int i = 0; i <= listFolders.Items.Count - 1; i++)
            {
                listFolders.SetItemChecked(i, false);
            }

            // Toggle delete option
            toggleDeleteOption();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult result =
                MessageBox.Show(
                    "This operation is not reversible.  Are you sure you want to DELETE all of the folders that you have selected?  Click 'Yes' if you want to continue.",
                    "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.No)
                return;


            foreach (object item in listFolders.CheckedItems)
            {
                //MessageBox.Show(item.ToString());
                try
                {
                    Outlook.Folder folder = GetFolderObject(item.ToString());
                    folder.Delete();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    continue;
                }

            }

            // Refresh the find
            Find();

        }

        // Returns Folder object based on folder path
        private Outlook.Folder GetFolderObject(string folderPath)
        {
            Outlook.Folder folder;
            string backslash = @"\";
            try
            {
                if (folderPath.StartsWith(@"\\"))
                {
                    folderPath = folderPath.Remove(0, 2);
                }
                String[] folders =
                    folderPath.Split(backslash.ToCharArray());
                folder =
                    Globals.ThisAddIn.Application.Session.Folders[folders[0]]
                    as Outlook.Folder;
                if (folder != null)
                {
                    for (int i = 1; i <= folders.GetUpperBound(0); i++)
                    {
                        Outlook.Folders subFolders = folder.Folders;
                        folder = subFolders[folders[i]]
                            as Outlook.Folder;
                        if (folder == null)
                        {
                            return null;
                        }
                    }
                }
                return folder;
            }
            catch { return null; }
        }
    }
}
