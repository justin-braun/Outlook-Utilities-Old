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
            this.SuspendLayout();
            // 
            // listBoxMergeSource
            // 
            this.listBoxMergeSource.FormattingEnabled = true;
            this.listBoxMergeSource.Location = new System.Drawing.Point(22, 38);
            this.listBoxMergeSource.Name = "listBoxMergeSource";
            this.listBoxMergeSource.ScrollAlwaysVisible = true;
            this.listBoxMergeSource.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxMergeSource.Size = new System.Drawing.Size(284, 290);
            this.listBoxMergeSource.Sorted = true;
            this.listBoxMergeSource.TabIndex = 0;
            // 
            // listBoxMergeDest
            // 
            this.listBoxMergeDest.FormattingEnabled = true;
            this.listBoxMergeDest.Location = new System.Drawing.Point(449, 38);
            this.listBoxMergeDest.Name = "listBoxMergeDest";
            this.listBoxMergeDest.ScrollAlwaysVisible = true;
            this.listBoxMergeDest.Size = new System.Drawing.Size(284, 290);
            this.listBoxMergeDest.Sorted = true;
            this.listBoxMergeDest.TabIndex = 1;
            // 
            // buttonStartMerge
            // 
            this.buttonStartMerge.Location = new System.Drawing.Point(341, 175);
            this.buttonStartMerge.Name = "buttonStartMerge";
            this.buttonStartMerge.Size = new System.Drawing.Size(75, 23);
            this.buttonStartMerge.TabIndex = 2;
            this.buttonStartMerge.Text = "Merge >>";
            this.buttonStartMerge.UseVisualStyleBackColor = true;
            this.buttonStartMerge.Click += new System.EventHandler(this.buttonStartMerge_Click);
            // 
            // checkBoxRemoveSourceFolder
            // 
            this.checkBoxRemoveSourceFolder.AutoSize = true;
            this.checkBoxRemoveSourceFolder.Location = new System.Drawing.Point(22, 335);
            this.checkBoxRemoveSourceFolder.Name = "checkBoxRemoveSourceFolder";
            this.checkBoxRemoveSourceFolder.Size = new System.Drawing.Size(186, 17);
            this.checkBoxRemoveSourceFolder.TabIndex = 3;
            this.checkBoxRemoveSourceFolder.Text = "Remove source folder after merge";
            this.checkBoxRemoveSourceFolder.UseVisualStyleBackColor = true;
            // 
            // checkBoxFoldersWithItemsOnly
            // 
            this.checkBoxFoldersWithItemsOnly.AutoSize = true;
            this.checkBoxFoldersWithItemsOnly.Checked = true;
            this.checkBoxFoldersWithItemsOnly.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxFoldersWithItemsOnly.Location = new System.Drawing.Point(22, 358);
            this.checkBoxFoldersWithItemsOnly.Name = "checkBoxFoldersWithItemsOnly";
            this.checkBoxFoldersWithItemsOnly.Size = new System.Drawing.Size(195, 17);
            this.checkBoxFoldersWithItemsOnly.TabIndex = 4;
            this.checkBoxFoldersWithItemsOnly.Text = "Only show folders that contain items";
            this.checkBoxFoldersWithItemsOnly.UseVisualStyleBackColor = true;
            this.checkBoxFoldersWithItemsOnly.CheckedChanged += new System.EventHandler(this.checkBoxFoldersWithItemsOnly_CheckedChanged);
            // 
            // checkBoxFoldersWithoutChildren
            // 
            this.checkBoxFoldersWithoutChildren.AutoSize = true;
            this.checkBoxFoldersWithoutChildren.Checked = true;
            this.checkBoxFoldersWithoutChildren.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxFoldersWithoutChildren.Location = new System.Drawing.Point(22, 381);
            this.checkBoxFoldersWithoutChildren.Name = "checkBoxFoldersWithoutChildren";
            this.checkBoxFoldersWithoutChildren.Size = new System.Drawing.Size(186, 17);
            this.checkBoxFoldersWithoutChildren.TabIndex = 5;
            this.checkBoxFoldersWithoutChildren.Text = "Only show folders without children";
            this.checkBoxFoldersWithoutChildren.UseVisualStyleBackColor = true;
            this.checkBoxFoldersWithoutChildren.CheckedChanged += new System.EventHandler(this.checkBoxFoldersWithoutChildren_CheckedChanged);
            // 
            // MergeFoldersMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 411);
            this.Controls.Add(this.checkBoxFoldersWithoutChildren);
            this.Controls.Add(this.checkBoxFoldersWithItemsOnly);
            this.Controls.Add(this.checkBoxRemoveSourceFolder);
            this.Controls.Add(this.buttonStartMerge);
            this.Controls.Add(this.listBoxMergeDest);
            this.Controls.Add(this.listBoxMergeSource);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MergeFoldersMain";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Merge Folders";
            this.Load += new System.EventHandler(this.MergeFoldersMain_Load);
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
    }
}