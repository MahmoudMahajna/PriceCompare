namespace PriceCompare.App
{
    partial class PriceCompareStoresForm
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
            this.itemsToComparePanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.itemsToComparePanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.cbChains1 = new System.Windows.Forms.ComboBox();
            this.cbStores1 = new System.Windows.Forms.ComboBox();
            this.cbStores2 = new System.Windows.Forms.ComboBox();
            this.cbChains2 = new System.Windows.Forms.ComboBox();
            this.lblTotalPrice1 = new System.Windows.Forms.Label();
            this.lblTotalPrice2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // itemsToComparePanel1
            // 
            this.itemsToComparePanel1.AutoScroll = true;
            this.itemsToComparePanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.itemsToComparePanel1.Location = new System.Drawing.Point(54, 95);
            this.itemsToComparePanel1.Name = "itemsToComparePanel1";
            this.itemsToComparePanel1.Size = new System.Drawing.Size(334, 346);
            this.itemsToComparePanel1.TabIndex = 0;
            // 
            // itemsToComparePanel2
            // 
            this.itemsToComparePanel2.AutoScroll = true;
            this.itemsToComparePanel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.itemsToComparePanel2.Location = new System.Drawing.Point(405, 95);
            this.itemsToComparePanel2.Name = "itemsToComparePanel2";
            this.itemsToComparePanel2.Size = new System.Drawing.Size(334, 346);
            this.itemsToComparePanel2.TabIndex = 1;
            // 
            // cbChains1
            // 
            this.cbChains1.FormattingEnabled = true;
            this.cbChains1.Location = new System.Drawing.Point(54, 12);
            this.cbChains1.Name = "cbChains1";
            this.cbChains1.Size = new System.Drawing.Size(257, 21);
            this.cbChains1.TabIndex = 2;
            this.cbChains1.Text = "Choose chain...";
            this.cbChains1.SelectedIndexChanged += new System.EventHandler(this.cbChains1_SelectedIndexChanged);
            // 
            // cbStores1
            // 
            this.cbStores1.FormattingEnabled = true;
            this.cbStores1.Location = new System.Drawing.Point(107, 39);
            this.cbStores1.Name = "cbStores1";
            this.cbStores1.Size = new System.Drawing.Size(204, 21);
            this.cbStores1.TabIndex = 3;
            this.cbStores1.Text = "Choose store...";
            this.cbStores1.SelectedIndexChanged += new System.EventHandler(this.cbStores1_SelectedIndexChanged);
            // 
            // cbStores2
            // 
            this.cbStores2.FormattingEnabled = true;
            this.cbStores2.Location = new System.Drawing.Point(458, 39);
            this.cbStores2.Name = "cbStores2";
            this.cbStores2.Size = new System.Drawing.Size(204, 21);
            this.cbStores2.TabIndex = 5;
            this.cbStores2.Text = "Choose store...";
            this.cbStores2.SelectedIndexChanged += new System.EventHandler(this.cbStores2_SelectedIndexChanged);
            // 
            // cbChains2
            // 
            this.cbChains2.FormattingEnabled = true;
            this.cbChains2.Location = new System.Drawing.Point(405, 12);
            this.cbChains2.Name = "cbChains2";
            this.cbChains2.Size = new System.Drawing.Size(257, 21);
            this.cbChains2.TabIndex = 4;
            this.cbChains2.Text = "Choose chain...";
            this.cbChains2.SelectedIndexChanged += new System.EventHandler(this.cbChains2_SelectedIndexChanged);
            // 
            // lblTotalPrice1
            // 
            this.lblTotalPrice1.AutoSize = true;
            this.lblTotalPrice1.Location = new System.Drawing.Point(51, 444);
            this.lblTotalPrice1.Name = "lblTotalPrice1";
            this.lblTotalPrice1.Size = new System.Drawing.Size(35, 13);
            this.lblTotalPrice1.TabIndex = 6;
            this.lblTotalPrice1.Text = "label1";
            this.lblTotalPrice1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTotalPrice2
            // 
            this.lblTotalPrice2.AutoSize = true;
            this.lblTotalPrice2.Location = new System.Drawing.Point(661, 444);
            this.lblTotalPrice2.Name = "lblTotalPrice2";
            this.lblTotalPrice2.Size = new System.Drawing.Size(35, 13);
            this.lblTotalPrice2.TabIndex = 7;
            this.lblTotalPrice2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 444);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "NIS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(702, 444);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "NIS";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(358, 447);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // PriceCompareStoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 495);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTotalPrice2);
            this.Controls.Add(this.lblTotalPrice1);
            this.Controls.Add(this.cbStores2);
            this.Controls.Add(this.cbChains2);
            this.Controls.Add(this.cbStores1);
            this.Controls.Add(this.cbChains1);
            this.Controls.Add(this.itemsToComparePanel2);
            this.Controls.Add(this.itemsToComparePanel1);
            this.Name = "PriceCompareStoresForm";
            this.Text = "PriceCompareStoresForm";
            this.Load += new System.EventHandler(this.PriceCompareStoresForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel itemsToComparePanel1;
        private System.Windows.Forms.FlowLayoutPanel itemsToComparePanel2;
        private System.Windows.Forms.ComboBox cbChains1;
        private System.Windows.Forms.ComboBox cbStores1;
        private System.Windows.Forms.ComboBox cbStores2;
        private System.Windows.Forms.ComboBox cbChains2;
        private System.Windows.Forms.Label lblTotalPrice1;
        private System.Windows.Forms.Label lblTotalPrice2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCalculate;
    }
}