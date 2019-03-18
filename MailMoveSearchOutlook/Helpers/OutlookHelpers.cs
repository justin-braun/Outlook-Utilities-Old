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

        public List<OutlookMailFolder> GetFolderList(Outlook.Folder rootFolder)
        {
            // Get folders in the default store
            //Outlook.Folder root = Globals.ThisAddIn.Application.Session.
            //    DefaultStore.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderInbox) as Outlook.Folder;

            FolderList.Clear();

            //Enumerate and add to array
            EnumerateFolders(rootFolder);
            return FolderList;
        }

        private void EnumerateFolders(Outlook.Folder folder)
        {
            // Get folders in the default store
            Outlook.Folders childFolders = folder.Folders;

            if (childFolders.Count == 0)
            {
                // Write the folder path object.
                FolderList.Add(new OutlookMailFolder
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
                FolderList.Add(new OutlookMailFolder
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
    }
}
