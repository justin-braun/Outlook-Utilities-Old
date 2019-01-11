﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;

namespace WCOutlookUtilities
{
    public partial class Ribbon1
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
    }
}
