namespace PriceCompareApp
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
            this.cbMinItems1 = new System.Windows.Forms.ComboBox();
            this.cbMaxItems1 = new System.Windows.Forms.ComboBox();
            this.minPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.maxPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.minPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.maxPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.cbMinItems2 = new System.Windows.Forms.ComboBox();
            this.cbMaxItems2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
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
            // cbMinItems1
            // 
            this.cbMinItems1.FormattingEnabled = true;
            this.cbMinItems1.Location = new System.Drawing.Point(54, 480);
            this.cbMinItems1.Name = "cbMinItems1";
            this.cbMinItems1.Size = new System.Drawing.Size(121, 21);
            this.cbMinItems1.TabIndex = 11;
            this.cbMinItems1.SelectedIndexChanged += new System.EventHandler(this.cbMinItems1_SelectedIndexChanged);
            // 
            // cbMaxItems1
            // 
            this.cbMaxItems1.FormattingEnabled = true;
            this.cbMaxItems1.Location = new System.Drawing.Point(54, 562);
            this.cbMaxItems1.Name = "cbMaxItems1";
            this.cbMaxItems1.Size = new System.Drawing.Size(121, 21);
            this.cbMaxItems1.TabIndex = 12;
            this.cbMaxItems1.SelectedIndexChanged += new System.EventHandler(this.cbMaxItems1_SelectedIndexChanged);
            // 
            // minPanel1
            // 
            this.minPanel1.Location = new System.Drawing.Point(54, 507);
            this.minPanel1.Name = "minPanel1";
            this.minPanel1.Size = new System.Drawing.Size(334, 49);
            this.minPanel1.TabIndex = 13;
            // 
            // maxPanel1
            // 
            this.maxPanel1.Location = new System.Drawing.Point(54, 589);
            this.maxPanel1.Name = "maxPanel1";
            this.maxPanel1.Size = new System.Drawing.Size(334, 49);
            this.maxPanel1.TabIndex = 14;
            // 
            // minPanel2
            // 
            this.minPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.minPanel2.Location = new System.Drawing.Point(405, 507);
            this.minPanel2.Name = "minPanel2";
            this.minPanel2.Size = new System.Drawing.Size(334, 49);
            this.minPanel2.TabIndex = 18;
            // 
            // maxPanel2
            // 
            this.maxPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.maxPanel2.Location = new System.Drawing.Point(405, 589);
            this.maxPanel2.Name = "maxPanel2";
            this.maxPanel2.Size = new System.Drawing.Size(334, 49);
            this.maxPanel2.TabIndex = 17;
            // 
            // cbMinItems2
            // 
            this.cbMinItems2.FormattingEnabled = true;
            this.cbMinItems2.Location = new System.Drawing.Point(618, 480);
            this.cbMinItems2.Name = "cbMinItems2";
            this.cbMinItems2.Size = new System.Drawing.Size(121, 21);
            this.cbMinItems2.TabIndex = 16;
            this.cbMinItems2.SelectedIndexChanged += new System.EventHandler(this.cbMinItems2_SelectedIndexChanged);
            // 
            // cbMaxItems2
            // 
            this.cbMaxItems2.FormattingEnabled = true;
            this.cbMaxItems2.Location = new System.Drawing.Point(618, 562);
            this.cbMaxItems2.Name = "cbMaxItems2";
            this.cbMaxItems2.Size = new System.Drawing.Size(121, 21);
            this.cbMaxItems2.TabIndex = 15;
            this.cbMaxItems2.SelectedIndexChanged += new System.EventHandler(this.cbMaxItems2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 480);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Min 3 Items price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(525, 483);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Min 3 Items price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(181, 565);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Max 3 Items price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(522, 565);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Max 3 Items price";
            // 
            // PriceCompareStoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(799, 671);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.minPanel2);
            this.Controls.Add(this.maxPanel2);
            this.Controls.Add(this.maxPanel1);
            this.Controls.Add(this.cbMinItems2);
            this.Controls.Add(this.minPanel1);
            this.Controls.Add(this.cbMaxItems2);
            this.Controls.Add(this.cbMaxItems1);
            this.Controls.Add(this.cbMinItems1);
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
        private System.Windows.Forms.ComboBox cbMinItems1;
        private System.Windows.Forms.ComboBox cbMaxItems1;
        private System.Windows.Forms.FlowLayoutPanel minPanel1;
        private System.Windows.Forms.FlowLayoutPanel maxPanel1;
        private System.Windows.Forms.FlowLayoutPanel minPanel2;
        private System.Windows.Forms.FlowLayoutPanel maxPanel2;
        private System.Windows.Forms.ComboBox cbMinItems2;
        private System.Windows.Forms.ComboBox cbMaxItems2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}