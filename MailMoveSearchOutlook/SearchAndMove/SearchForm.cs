﻿using Outlook = Microsoft.Office.Interop.Outlook;
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

namespace WCOutlookUtilities
{


    public partial class SearchForm : Form
    {
        List<OutlookMailFolder> OutlookFolders = new List<OutlookMailFolder>();

        public SearchForm()
        {
            InitializeComponent();
        }

        private void SearchForm_Load(object sender, EventArgs e)
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
            //// Move selected item to selected folder
            //Outlook.Selection items = Globals.ThisAddIn.Application.ActiveExplorer().Selection;

            ////MessageBox.Show("Moving " + items.Count.ToString() + " items");
            //foreach (var item in items)
            //{
            //    if (item is Outlook.MailItem)
            //    {
            //        Outlook.MailItem mail = (Outlook.MailItem)item;

            //        try
            //        {
            //            mail.Move(Globals.ThisAddIn.Application.Session.GetFolderFromID(((OutlookMailFolder)listResults.SelectedItem).FolderId));
            //        }
            //        catch (Exception ex)
            //        {
            //            MessageBox.Show(ex.Message);
            //        }
            //    }
            //}

            bool isMessage = false;

            // Check for mail thread
            Outlook.Selection sel = Globals.ThisAddIn.Application.ActiveExplorer().Selection;
            Outlook.Selection conv = sel.GetSelection(Outlook.OlSelectionContents.olConversationHeaders) as Outlook.Selection;


            // Move if it is an individual message selected
            foreach (var item in sel)
            {
                if (item is Outlook.MailItem)
                {
                    Outlook.MailItem mail = (Outlook.MailItem)item;

                    try
                    {
                        mail.Move(Globals.ThisAddIn.Application.Session.GetFolderFromID(((OutlookMailFolder)listResults.SelectedItem).FolderId));
                        isMessage = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }

            // Move if it is whole conversation thread selected
            if (isMessage == false)
            {
                foreach (Outlook.ConversationHeader cHeader in conv)
                {
                    Outlook.SimpleItems items = cHeader.GetItems();
                    //MessageBox.Show(items.Count.ToString());

                    for (int i = 1; i <= items.Count; i++)
                    {
                        if (items[i] is Outlook.MailItem)
                        {
                            Outlook.MailItem mail = items[i] as Outlook.MailItem;

                            try
                            {
                                mail.Move(Globals.ThisAddIn.Application.Session.GetFolderFromID(((OutlookMailFolder)listResults.SelectedItem).FolderId));
                                isMessage = false;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }
                }
            }

            // Close form           
            this.Close();

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }

        private void buttonNewFolder_Click(object sender, EventArgs e)
        {
            // Create a new folder
            Outlook.MAPIFolder newFolder = Globals.ThisAddIn.Application.Session.PickFolder();
            if (newFolder != null)
                textSearch.Text = newFolder.Name;

            // Refresh Folder List
            RefreshFolderList();

            // Assume Re-Search for search term
            listResults.Items.Clear();
            FindFolder(textSearch.Text);
        }

        private void EnumerateConversation(object item, Outlook.Conversation conversation)
        {

        }

    }

}