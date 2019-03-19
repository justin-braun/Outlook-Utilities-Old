using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Microsoft.Office.Tools.Ribbon;

namespace WCOutlookUtilities
{
    public partial class OutlookRibbon
    {
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void buttonMoveMessage_Click(object sender, RibbonControlEventArgs e)
        {          
            SearchForm sf = new SearchForm();
            sf.ShowDialog();
        }

        private void buttonFinder_Click(object sender, RibbonControlEventArgs e)
        {
            EmptyFolderFinder.effMain eff = new EmptyFolderFinder.effMain();
            eff.ShowDialog();
        }

        private void buttonSearchMain_Click(object sender, RibbonControlEventArgs e)
        {
            SearchForm sf = new SearchForm();
            sf.ShowDialog();
        }

        private void buttonGoToFolder_Click(object sender, RibbonControlEventArgs e)
        {
            GoToFolder.GoToFolderForm form = new GoToFolder.GoToFolderForm();
            form.ShowDialog();
        }

        private void buttonTabGoToFolder_Click(object sender, RibbonControlEventArgs e)
        {
            buttonGoToFolder_Click(sender, e);
        }

        private void buttonAbout_Click(object sender, RibbonControlEventArgs e)
        {
            About.AboutForm aboutForm = new About.AboutForm();
            aboutForm.ShowDialog();
        }

        private void searchMoveSplitButton_Click(object sender, RibbonControlEventArgs e)
        {
            SearchForm sf = new SearchForm();
            sf.ShowDialog();
        }

        private void buttonSearchMove_Click(object sender, RibbonControlEventArgs e)
        {
            SearchForm sf = new SearchForm();
            sf.ShowDialog();
        }

        private void buttonMergeFolders_Click(object sender, RibbonControlEventArgs e)
        {
            MergeFolders.MergeFoldersMain form = new MergeFolders.MergeFoldersMain();
            form.ShowDialog();
        }

        private void buttonTabMergeFolders_Click(object sender, RibbonControlEventArgs e)
        {
            MergeFolders.MergeFoldersMain form = new MergeFolders.MergeFoldersMain();
            form.ShowDialog();
        }

        //public RibbonDropDownItem CreateRibbonDropDownItem()
        //{
        //    return this.Factory.CreateRibbonDropDownItem();
        //}

        //public RibbonMenu CreateRibbonMenu()
        //{
        //    return this.Factory.CreateRibbonMenu();
        //}

        //public RibbonButton CreateRibbonButton()
        //{
        //    RibbonButton button = this.Factory.CreateRibbonButton();
        //    button.Click += new RibbonControlEventHandler(button_click);
        //    return button;
        //}

        //private void button_click(object sender, RibbonControlEventArgs e)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
