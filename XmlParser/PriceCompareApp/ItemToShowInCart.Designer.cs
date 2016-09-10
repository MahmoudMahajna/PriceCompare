namespace PriceCompareApp
{
    partial class ItemToShowInCart
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nmItemCount = new System.Windows.Forms.NumericUpDown();
            this.lblItemName = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmItemCount)).BeginInit();
            this.SuspendLayout();
            // 
            // nmItemCount
            // 
            this.nmItemCount.Location = new System.Drawing.Point(425, 11);
            this.nmItemCount.Name = "nmItemCount";
            this.nmItemCount.Size = new System.Drawing.Size(48, 20);
            this.nmItemCount.TabIndex = 0;
            this.nmItemCount.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Location = new System.Drawing.Point(3, 13);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(35, 13);
            this.lblItemName.TabIndex = 1;
            this.lblItemName.Text = "label1";
            this.lblItemName.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(525, 11);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(19, 23);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "X";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // ItemToShowInCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.nmItemCount);
            this.Name = "ItemToShowInCart";
            this.Size = new System.Drawing.Size(547, 45);
            this.Load += new System.EventHandler(this.ItemToShowInCart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmItemCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nmItemCount;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Button btnRemove;
    }
}
