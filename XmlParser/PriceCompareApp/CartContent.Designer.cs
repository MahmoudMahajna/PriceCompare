namespace PriceCompareApp
{
    partial class CartContent
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
            this.CartContentPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnComparePrices = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CartContentPanel
            // 
            this.CartContentPanel.AutoScroll = true;
            this.CartContentPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CartContentPanel.Location = new System.Drawing.Point(85, 31);
            this.CartContentPanel.Name = "CartContentPanel";
            this.CartContentPanel.Size = new System.Drawing.Size(639, 340);
            this.CartContentPanel.TabIndex = 0;
            // 
            // btnComparePrices
            // 
            this.btnComparePrices.Location = new System.Drawing.Point(537, 399);
            this.btnComparePrices.Name = "btnComparePrices";
            this.btnComparePrices.Size = new System.Drawing.Size(187, 23);
            this.btnComparePrices.TabIndex = 1;
            this.btnComparePrices.Text = "Compare prices";
            this.btnComparePrices.UseVisualStyleBackColor = true;
            this.btnComparePrices.Click += new System.EventHandler(this.btnComparePrices_Click);
            // 
            // CartContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(792, 446);
            this.Controls.Add(this.btnComparePrices);
            this.Controls.Add(this.CartContentPanel);
            this.Name = "CartContent";
            this.Text = "CartContent";
            this.Load += new System.EventHandler(this.CartContent_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel CartContentPanel;
        private System.Windows.Forms.Button btnComparePrices;
    }
}