namespace WCOutlookUtilities.EmptyFolderFinder
{
    partial class effMain
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
            this.listFolders = new System.Windows.Forms.CheckedListBox();
            this.buttonFind = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSelectAll = new System.Windows.Forms.Button();
            this.buttonUnselectAll = new System.Windows.Forms.Button();
            this.checkIncludeInbox = new System.Windows.Forms.CheckBox();
            this.checkIncludeDeleted = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listFolders
            // 
            this.listFolders.CheckOnClick = true;
            this.listFolders.FormattingEnabled = true;
            this.listFolders.Location = new System.Drawing.Point(12, 12);
            this.listFolders.Name = "listFolders";
            this.listFolders.Size = new System.Drawing.Size(400, 244);
            this.listFolders.Sorted = true;
            this.listFolders.TabIndex = 0;
            this.listFolders.SelectedIndexChanged += new System.EventHandler(this.listFolders_SelectedIndexChanged);
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(419, 12);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(75, 23);
            this.buttonFind.TabIndex = 1;
            this.buttonFind.Text = "Find";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Enabled = false;
            this.buttonDelete.Location = new System.Drawing.Point(419, 42);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonSelectAll
            // 
            this.buttonSelectAll.Enabled = false;
            this.buttonSelectAll.Location = new System.Drawing.Point(13, 263);
            this.buttonSelectAll.Name = "buttonSelectAll";
            this.buttonSelectAll.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectAll.TabIndex = 3;
            this.buttonSelectAll.Text = "Select All";
            this.buttonSelectAll.UseVisualStyleBackColor = true;
            this.buttonSelectAll.Click += new System.EventHandler(this.buttonSelectAll_Click);
            // 
            // buttonUnselectAll
            // 
            this.buttonUnselectAll.Enabled = false;
            this.buttonUnselectAll.Location = new System.Drawing.Point(95, 263);
            this.buttonUnselectAll.Name = "buttonUnselectAll";
            this.buttonUnselectAll.Size = new System.Drawing.Size(75, 23);
            this.buttonUnselectAll.TabIndex = 4;
            this.buttonUnselectAll.Text = "Unselect All";
            this.buttonUnselectAll.UseVisualStyleBackColor = true;
            this.buttonUnselectAll.Click += new System.EventHandler(this.buttonUnselectAll_Click);
            // 
            // checkIncludeInbox
            // 
            this.checkIncludeInbox.AutoSize = true;
            this.checkIncludeInbox.Checked = true;
            this.checkIncludeInbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkIncludeInbox.Location = new System.Drawing.Point(269, 263);
            this.checkIncludeInbox.Name = "checkIncludeInbox";
            this.checkIncludeInbox.Size = new System.Drawing.Size(52, 17);
            this.checkIncludeInbox.TabIndex = 5;
            this.checkIncludeInbox.Text = "Inbox";
            this.checkIncludeInbox.UseVisualStyleBackColor = true;
            // 
            // checkIncludeDeleted
            // 
            this.checkIncludeDeleted.AutoSize = true;
            this.checkIncludeDeleted.Checked = true;
            this.checkIncludeDeleted.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkIncludeDeleted.Location = new System.Drawing.Point(327, 262);
            this.checkIncludeDeleted.Name = "checkIncludeDeleted";
            this.checkIncludeDeleted.Size = new System.Drawing.Size(91, 17);
            this.checkIncludeDeleted.TabIndex = 6;
            this.checkIncludeDeleted.Text = "Deleted Items";
            this.checkIncludeDeleted.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Include:";
            // 
            // effMain
            // 
            this.AcceptButton = this.buttonFind;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 298);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkIncludeDeleted);
            this.Controls.Add(this.checkIncludeInbox);
            this.Controls.Add(this.buttonUnselectAll);
            this.Controls.Add(this.buttonSelectAll);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.listFolders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "effMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Empty Folder Finder";
            this.Load += new System.EventHandler(this.effMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox listFolders;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSelectAll;
        private System.Windows.Forms.Button buttonUnselectAll;
        private System.Windows.Forms.CheckBox checkIncludeInbox;
        private System.Windows.Forms.CheckBox checkIncludeDeleted;
        private System.Windows.Forms.Label label1;
    }
}