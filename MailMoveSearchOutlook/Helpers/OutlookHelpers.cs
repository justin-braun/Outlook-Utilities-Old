using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace WCOutlookUtilities.Helpers
{
    public class OutlookHelpers
    {
        List<OutlookMailFolder> FolderList = new List<OutlookMailFolder>();

        public List<OutlookMailFolder> GetFolderList(Outlook.Folder rootFolder, bool ChildrenOnly = false, bool ItemsOnly = false)
        {
            // Get folders in the default store
            //Outlook.Folder root = Globals.ThisAddIn.Application.Session.
            //    DefaultStore.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderInbox) as Outlook.Folder;

            FolderList.Clear();

            //Enumerate and add to array
            EnumerateFolders(rootFolder, ChildrenOnly, ItemsOnly);
            return FolderList;
        }

        private void EnumerateFolders(Outlook.Folder folder, bool ChildrenOnly, bool ItemsOnly)
        {
            // Get folders in the default store
            Outlook.Folders childFolders = folder.Folders;

            if (childFolders.Count == 0)
            {
                // Write the folder path object.
                if (ItemsOnly == true && folder.Items.Count > 0)
                {
                    FolderList.Add(new OutlookMailFolder
                    {
                        FolderName = folder.Name,
                        FullFolderPath = folder.FolderPath,
                        FolderPath = Regex.Replace(folder.FolderPath, @"\\\\(.*?)\\", "\\").Replace(@"\", @"/"),
                        FolderId = folder.EntryID
                    });
                }
                else if (ItemsOnly == false)
                {
                    FolderList.Add(new OutlookMailFolder
                    {
                        FolderName = folder.Name,
                        FullFolderPath = folder.FolderPath,
                        FolderPath = Regex.Replace(folder.FolderPath, @"\\\\(.*?)\\", "\\").Replace(@"\", @"/"),
                        FolderId = folder.EntryID
                    });
                }
            }

            if (ChildrenOnly == false && childFolders.Count != 0)
            {
                // Write the folder path object.
                if (ItemsOnly == true && folder.Items.Count > 0)
                {
                    FolderList.Add(new OutlookMailFolder
                    {
                        FolderName = folder.Name,
                        FullFolderPath = folder.FolderPath,
                        FolderPath = Regex.Replace(folder.FolderPath, @"\\\\(.*?)\\", "\\").Replace(@"\", @"/"),
                        FolderId = folder.EntryID
                    });
                }
                else if (ItemsOnly == false)
                {
                    FolderList.Add(new OutlookMailFolder
                    {
                        FolderName = folder.Name,
                        FullFolderPath = folder.FolderPath,
                        FolderPath = Regex.Replace(folder.FolderPath, @"\\\\(.*?)\\", "\\").Replace(@"\", @"/"),
                        FolderId = folder.EntryID
                    });
                }
            }

            foreach (Outlook.Folder childFolder in childFolders)
            {
                EnumerateFolders(childFolder, ChildrenOnly, ItemsOnly);
            }
            //}

            //// Get folders in the default store
            //Outlook.Folders childFolders = folder.Folders;

            //if (childFolders.Count == 0)
            //{
            //    // Write the folder path object.
            //    FolderList.Add(new OutlookMailFolder
            //    {
            //        FolderName = folder.Name,
            //        FullFolderPath = folder.FolderPath,
            //        FolderPath = Regex.Replace(folder.FolderPath, @"\\\\(.*?)\\", "\\").Replace(@"\", @"/"),
            //        FolderId = folder.EntryID
            //    });
            //}
            //else
            //{
            //    // Write the folder path object.
            //    FolderList.Add(new OutlookMailFolder
            //    {
            //        FolderName = folder.Name,
            //        FullFolderPath = folder.FolderPath,
            //        FolderPath = Regex.Replace(folder.FolderPath, @"\\\\(.*?)\\", "\\").Replace(@"\", @"/"),
            //        FolderId = folder.EntryID
            //    });

            //    foreach (Outlook.Folder childFolder in childFolders)
            //    {
            //        EnumerateFolders(childFolder, ChildrenOnly);
            //    }
            //}
        }

        public static void MoveFolderItems(Outlook.Folder sourceFolder, OutlookMailFolder destFolder)
        {
            Outlook.MAPIFolder dest = Globals.ThisAddIn.Application.Session.GetFolderFromID(destFolder.FolderId);
            int counter = sourceFolder.Items.Count;

            Outlook.Items sourceItems = sourceFolder.Items;

            for (int i = sourceItems.Count; i>=1;i--)
            {
                Outlook.MailItem moveItem = sourceItems[i] as Outlook.MailItem;
                if(moveItem != null)
                {
                    moveItem.Move(dest);
                }
                
            }

            //foreach (object item in sourceItems)
            //{
            //    Outlook.MailItem moveItem = item as Outlook.MailItem;
            //    if (moveItem != null)
            //    {
            //        moveItem.Move(dest);
            //    }

            //}
        }

    }
}
