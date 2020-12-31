namespace WCOutlookUtilities.MergeFolders
{
    partial class MergeFoldersMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxMergeSource = new System.Windows.Forms.ListBox();
            this.listBoxMergeDest = new System.Windows.Forms.ListBox();
            this.buttonStartMerge = new System.Windows.Forms.Button();
            this.checkBoxRemoveSourceFolder = new System.Windows.Forms.CheckBox();
            this.checkBoxFoldersWithItemsOnly = new System.Windows.Forms.CheckBox();
            this.checkBoxFoldersWithoutChildren = new System.Windows.Forms.CheckBox();
            this.sourceFilterTextbox = new System.Windows.Forms.TextBox();
            this.destFilterTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupOptions = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxMergeSource
            // 
            this.listBoxMergeSource.FormattingEnabled = true;
            this.listBoxMergeSource.ItemHeight = 25;
            this.listBoxMergeSource.Location = new System.Drawing.Point(46, 145);
            this.listBoxMergeSource.Margin = new System.Windows.Forms.Padding(6);
            this.listBoxMergeSource.Name = "listBoxMergeSource";
            this.listBoxMergeSource.ScrollAlwaysVisible = true;
            this.listBoxMergeSource.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxMergeSource.Size = new System.Drawing.Size(564, 554);
            this.listBoxMergeSource.Sorted = true;
            this.listBoxMergeSource.TabIndex = 0;
            // 
            // listBoxMergeDest
            // 
            this.listBoxMergeDest.FormattingEnabled = true;
            this.listBoxMergeDest.ItemHeight = 25;
            this.listBoxMergeDest.Location = new System.Drawing.Point(900, 145);
            this.listBoxMergeDest.Margin = new System.Windows.Forms.Padding(6);
            this.listBoxMergeDest.Name = "listBoxMergeDest";
            this.listBoxMergeDest.ScrollAlwaysVisible = true;
            this.listBoxMergeDest.Size = new System.Drawing.Size(564, 554);
            this.listBoxMergeDest.Sorted = true;
            this.listBoxMergeDest.TabIndex = 1;
            // 
            // buttonStartMerge
            // 
            this.buttonStartMerge.Location = new System.Drawing.Point(1314, 725);
            this.buttonStartMerge.Margin = new System.Windows.Forms.Padding(6);
            this.buttonStartMerge.Name = "buttonStartMerge";
            this.buttonStartMerge.Size = new System.Drawing.Size(150, 44);
            this.buttonStartMerge.TabIndex = 2;
            this.buttonStartMerge.Text = "&Merge";
            this.buttonStartMerge.UseVisualStyleBackColor = true;
            this.buttonStartMerge.Click += new System.EventHandler(this.buttonStartMerge_Click);
            // 
            // checkBoxRemoveSourceFolder
            // 
            this.checkBoxRemoveSourceFolder.AutoSize = true;
            this.checkBoxRemoveSourceFolder.Location = new System.Drawing.Point(39, 149);
            this.checkBoxRemoveSourceFolder.Margin = new System.Windows.Forms.Padding(6);
            this.checkBoxRemoveSourceFolder.Name = "checkBoxRemoveSourceFolder";
            this.checkBoxRemoveSourceFolder.Size = new System.Drawing.Size(369, 29);
            this.checkBoxRemoveSourceFolder.TabIndex = 3;
            this.checkBoxRemoveSourceFolder.Text = "Remove source folder after merge";
            this.checkBoxRemoveSourceFolder.UseVisualStyleBackColor = true;
            // 
            // checkBoxFoldersWithItemsOnly
            // 
            this.checkBoxFoldersWithItemsOnly.AutoSize = true;
            this.checkBoxFoldersWithItemsOnly.Location = new System.Drawing.Point(39, 60);
            this.checkBoxFoldersWithItemsOnly.Margin = new System.Windows.Forms.Padding(6);
            this.checkBoxFoldersWithItemsOnly.Name = "checkBoxFoldersWithItemsOnly";
            this.checkBoxFoldersWithItemsOnly.Size = new System.Drawing.Size(506, 29);
            this.checkBoxFoldersWithItemsOnly.TabIndex = 4;
            this.checkBoxFoldersWithItemsOnly.Text = "Only show source folders that contain mail items";
            this.checkBoxFoldersWithItemsOnly.UseVisualStyleBackColor = true;
            this.checkBoxFoldersWithItemsOnly.CheckedChanged += new System.EventHandler(this.checkBoxFoldersWithItemsOnly_CheckedChanged);
            // 
            // checkBoxFoldersWithoutChildren
            // 
            this.checkBoxFoldersWithoutChildren.AutoSize = true;
            this.checkBoxFoldersWithoutChildren.Checked = true;
            this.checkBoxFoldersWithoutChildren.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxFoldersWithoutChildren.Enabled = false;
            this.checkBoxFoldersWithoutChildren.Location = new System.Drawing.Point(39, 104);
            this.checkBoxFoldersWithoutChildren.Margin = new System.Windows.Forms.Padding(6);
            this.checkBoxFoldersWithoutChildren.Name = "checkBoxFoldersWithoutChildren";
            this.checkBoxFoldersWithoutChildren.Size = new System.Drawing.Size(442, 29);
            this.checkBoxFoldersWithoutChildren.TabIndex = 5;
            this.checkBoxFoldersWithoutChildren.Text = "Only show source folders without children";
            this.checkBoxFoldersWithoutChildren.UseVisualStyleBackColor = true;
            this.checkBoxFoldersWithoutChildren.CheckedChanged += new System.EventHandler(this.checkBoxFoldersWithoutChildren_CheckedChanged);
            // 
            // sourceFilterTextbox
            // 
            this.sourceFilterTextbox.Location = new System.Drawing.Point(46, 72);
            this.sourceFilterTextbox.Name = "sourceFilterTextbox";
            this.sourceFilterTextbox.Size = new System.Drawing.Size(524, 31);
            this.sourceFilterTextbox.TabIndex = 6;
            this.sourceFilterTextbox.TextChanged += new System.EventHandler(this.sourceFilterTextbox_TextChanged);
            // 
            // destFilterTextbox
            // 
            this.destFilterTextbox.Location = new System.Drawing.Point(900, 72);
            this.destFilterTextbox.Name = "destFilterTextbox";
            this.destFilterTextbox.Size = new System.Drawing.Size(524, 31);
            this.destFilterTextbox.TabIndex = 7;
            this.destFilterTextbox.TextChanged += new System.EventHandler(this.destFilterTextbox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Filter:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(895, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Filter:";
            // 
            // groupOptions
            // 
            this.groupOptions.Controls.Add(this.checkBoxFoldersWithoutChildren);
            this.groupOptions.Controls.Add(this.checkBoxRemoveSourceFolder);
            this.groupOptions.Controls.Add(this.checkBoxFoldersWithItemsOnly);
            this.groupOptions.Location = new System.Drawing.Point(51, 834);
            this.groupOptions.Name = "groupOptions";
            this.groupOptions.Size = new System.Drawing.Size(1413, 232);
            this.groupOptions.TabIndex = 10;
            this.groupOptions.TabStop = false;
            this.groupOptions.Text = "Options";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(652, 410);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 37);
            this.label3.TabIndex = 11;
            this.label3.Text = "Merge To >>";
            // 
            // MergeFoldersMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1514, 1122);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupOptions);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.destFilterTextbox);
            this.Controls.Add(this.sourceFilterTextbox);
            this.Controls.Add(this.buttonStartMerge);
            this.Controls.Add(this.listBoxMergeDest);
            this.Controls.Add(this.listBoxMergeSource);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MergeFoldersMain";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Merge Folders";
            this.Load += new System.EventHandler(this.MergeFoldersMain_Load);
            this.groupOptions.ResumeLayout(false);
            this.groupOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxMergeSource;
        private System.Windows.Forms.ListBox listBoxMergeDest;
        private System.Windows.Forms.Button buttonStartMerge;
        private System.Windows.Forms.CheckBox checkBoxRemoveSourceFolder;
        private System.Windows.Forms.CheckBox checkBoxFoldersWithItemsOnly;
        private System.Windows.Forms.CheckBox checkBoxFoldersWithoutChildren;
        private System.Windows.Forms.TextBox sourceFilterTextbox;
        private System.Windows.Forms.TextBox destFilterTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupOptions;
        private System.Windows.Forms.Label label3;
    }
}