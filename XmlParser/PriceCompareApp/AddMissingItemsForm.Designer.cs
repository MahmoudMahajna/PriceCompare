namespace PriceCompareApp
{
    partial class AddMissingItemsForm
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
            this.lstBoxItemsNotFound = new System.Windows.Forms.ListBox();
            this.lstboxItemsInStore = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstBoxItemsNotFound
            // 
            this.lstBoxItemsNotFound.FormattingEnabled = true;
            this.lstBoxItemsNotFound.Location = new System.Drawing.Point(12, 30);
            this.lstBoxItemsNotFound.Name = "lstBoxItemsNotFound";
            this.lstBoxItemsNotFound.Size = new System.Drawing.Size(200, 329);
            this.lstBoxItemsNotFound.TabIndex = 0;
            // 
            // lstboxItemsInStore
            // 
            this.lstboxItemsInStore.FormattingEnabled = true;
            this.lstboxItemsInStore.Location = new System.Drawing.Point(266, 56);
            this.lstboxItemsInStore.Name = "lstboxItemsInStore";
            this.lstboxItemsInStore.Size = new System.Drawing.Size(200, 303);
            this.lstboxItemsInStore.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(472, 330);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(55, 29);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(266, 30);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(115, 20);
            this.txtSearch.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(387, 30);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(79, 20);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // AddMissingItemsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 428);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstboxItemsInStore);
            this.Controls.Add(this.lstBoxItemsNotFound);
            this.Name = "AddMissingItemsForm";
            this.Text = "AddMissingItemsForm";
            this.Load += new System.EventHandler(this.AddMissingItemsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBoxItemsNotFound;
        private System.Windows.Forms.ListBox lstboxItemsInStore;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
    }
}