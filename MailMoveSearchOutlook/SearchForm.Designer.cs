namespace MailMoveSearchOutlook
{
    partial class SearchForm
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
            this.textSearch = new System.Windows.Forms.TextBox();
            this.listResults = new System.Windows.Forms.ListBox();
            this.buttonMove = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textSearch
            // 
            this.textSearch.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSearch.Location = new System.Drawing.Point(31, 42);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(293, 22);
            this.textSearch.TabIndex = 0;
            this.textSearch.TextChanged += new System.EventHandler(this.textSearch_TextChanged);
            // 
            // listResults
            // 
            this.listResults.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listResults.FormattingEnabled = true;
            this.listResults.Location = new System.Drawing.Point(31, 81);
            this.listResults.Name = "listResults";
            this.listResults.ScrollAlwaysVisible = true;
            this.listResults.Size = new System.Drawing.Size(293, 147);
            this.listResults.Sorted = true;
            this.listResults.TabIndex = 1;
            this.listResults.SelectedIndexChanged += new System.EventHandler(this.listResults_SelectedIndexChanged);
            // 
            // buttonMove
            // 
            this.buttonMove.Enabled = false;
            this.buttonMove.Location = new System.Drawing.Point(249, 243);
            this.buttonMove.Name = "buttonMove";
            this.buttonMove.Size = new System.Drawing.Size(75, 23);
            this.buttonMove.TabIndex = 2;
            this.buttonMove.Text = "&Move";
            this.buttonMove.UseVisualStyleBackColor = true;
            this.buttonMove.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search for inbox folder containing:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // SearchForm
            // 
            this.AcceptButton = this.buttonMove;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 288);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonMove);
            this.Controls.Add(this.listResults);
            this.Controls.Add(this.textSearch);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Move Selected Message";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.ListBox listResults;
        private System.Windows.Forms.Button buttonMove;
        private System.Windows.Forms.Label label1;
    }
}