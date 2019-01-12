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
    }
}
