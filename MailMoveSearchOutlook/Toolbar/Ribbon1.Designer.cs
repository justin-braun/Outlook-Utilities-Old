namespace WCOutlookUtilities
{
    partial class Ribbon1 : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon1()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.buttonMoveMessage = this.Factory.CreateRibbonButton();
            this.buttonGoToFolder = this.Factory.CreateRibbonButton();
            this.tab2 = this.Factory.CreateRibbonTab();
            this.group2 = this.Factory.CreateRibbonGroup();
            this.buttonFinder = this.Factory.CreateRibbonButton();
            this.buttonSearchMain = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.group1.SuspendLayout();
            this.tab2.SuspendLayout();
            this.group2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.ControlId.OfficeId = "TabMail";
            this.tab1.Groups.Add(this.group1);
            this.tab1.Label = "TabMail";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Items.Add(this.buttonMoveMessage);
            this.group1.Items.Add(this.buttonGoToFolder);
            this.group1.Label = "WC Utilities";
            this.group1.Name = "group1";
            // 
            // buttonMoveMessage
            // 
            this.buttonMoveMessage.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.buttonMoveMessage.Label = "Search && Move";
            this.buttonMoveMessage.Name = "buttonMoveMessage";
            this.buttonMoveMessage.OfficeImageId = "ResearchPane";
            this.buttonMoveMessage.ShowImage = true;
            this.buttonMoveMessage.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonMoveMessage_Click);
            // 
            // buttonGoToFolder
            // 
            this.buttonGoToFolder.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.buttonGoToFolder.Label = "Go to Folder";
            this.buttonGoToFolder.Name = "buttonGoToFolder";
            this.buttonGoToFolder.OfficeImageId = "FileFind";
            this.buttonGoToFolder.ShowImage = true;
            this.buttonGoToFolder.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonGoToFolder_Click);
            // 
            // tab2
            // 
            this.tab2.Groups.Add(this.group2);
            this.tab2.Label = "WC Utilities";
            this.tab2.Name = "tab2";
            // 
            // group2
            // 
            this.group2.Items.Add(this.buttonFinder);
            this.group2.Items.Add(this.buttonSearchMain);
            this.group2.Name = "group2";
            // 
            // buttonFinder
            // 
            this.buttonFinder.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.buttonFinder.Label = "Empty Folder Finder";
            this.buttonFinder.Name = "buttonFinder";
            this.buttonFinder.OfficeImageId = "FileFind";
            this.buttonFinder.ShowImage = true;
            this.buttonFinder.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonFinder_Click);
            // 
            // buttonSearchMain
            // 
            this.buttonSearchMain.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.buttonSearchMain.Label = "Search && Move";
            this.buttonSearchMain.Name = "buttonSearchMain";
            this.buttonSearchMain.OfficeImageId = "ResearchPane";
            this.buttonSearchMain.ShowImage = true;
            this.buttonSearchMain.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonSearchMain_Click);
            // 
            // Ribbon1
            // 
            this.Name = "Ribbon1";
            this.RibbonType = "Microsoft.Outlook.Explorer";
            this.Tabs.Add(this.tab1);
            this.Tabs.Add(this.tab2);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.tab2.ResumeLayout(false);
            this.tab2.PerformLayout();
            this.group2.ResumeLayout(false);
            this.group2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonMoveMessage;
        private Microsoft.Office.Tools.Ribbon.RibbonTab tab2;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group2;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonFinder;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonSearchMain;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonGoToFolder;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon1 Ribbon1
        {
            get { return this.GetRibbon<Ribbon1>(); }
        }
    }
}
