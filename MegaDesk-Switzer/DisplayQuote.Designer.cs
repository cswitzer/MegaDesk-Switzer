namespace MegaDesk_Switzer
{
    partial class DisplayQuote
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
            this.customerNameText2 = new System.Windows.Forms.TextBox();
            this.customerNameLabel2 = new System.Windows.Forms.Label();
            this.comDelivery2 = new System.Windows.Forms.ComboBox();
            this.deliveryLabel = new System.Windows.Forms.Label();
            this.comSurfaceMaterial2 = new System.Windows.Forms.ComboBox();
            this.surfaceMaterialLabel = new System.Windows.Forms.Label();
            this.numDrawersUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numDrawersLabel = new System.Windows.Forms.Label();
            this.deskSizeGroupBox2 = new System.Windows.Forms.GroupBox();
            this.widthLabel = new System.Windows.Forms.Label();
            this.depthLabel = new System.Windows.Forms.Label();
            this.depthUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.widthUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.closeBtn = new System.Windows.Forms.Button();
            this.totalPriceGroupBox = new System.Windows.Forms.GroupBox();
            this.totalPriceText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numDrawersUpDown2)).BeginInit();
            this.deskSizeGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depthUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthUpDown2)).BeginInit();
            this.totalPriceGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerNameText2
            // 
            this.customerNameText2.Location = new System.Drawing.Point(187, 41);
            this.customerNameText2.Name = "customerNameText2";
            this.customerNameText2.Size = new System.Drawing.Size(252, 20);
            this.customerNameText2.TabIndex = 10;
            // 
            // customerNameLabel2
            // 
            this.customerNameLabel2.AutoSize = true;
            this.customerNameLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameLabel2.Location = new System.Drawing.Point(32, 37);
            this.customerNameLabel2.Name = "customerNameLabel2";
            this.customerNameLabel2.Size = new System.Drawing.Size(152, 24);
            this.customerNameLabel2.TabIndex = 9;
            this.customerNameLabel2.Text = "Customer Name:";
            // 
            // comDelivery2
            // 
            this.comDelivery2.FormattingEnabled = true;
            this.comDelivery2.Location = new System.Drawing.Point(391, 177);
            this.comDelivery2.Name = "comDelivery2";
            this.comDelivery2.Size = new System.Drawing.Size(74, 21);
            this.comDelivery2.TabIndex = 22;
            // 
            // deliveryLabel
            // 
            this.deliveryLabel.AutoSize = true;
            this.deliveryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deliveryLabel.Location = new System.Drawing.Point(317, 178);
            this.deliveryLabel.Name = "deliveryLabel";
            this.deliveryLabel.Size = new System.Drawing.Size(68, 20);
            this.deliveryLabel.TabIndex = 21;
            this.deliveryLabel.Text = "Delivery:";
            // 
            // comSurfaceMaterial2
            // 
            this.comSurfaceMaterial2.FormattingEnabled = true;
            this.comSurfaceMaterial2.Location = new System.Drawing.Point(391, 139);
            this.comSurfaceMaterial2.Name = "comSurfaceMaterial2";
            this.comSurfaceMaterial2.Size = new System.Drawing.Size(74, 21);
            this.comSurfaceMaterial2.TabIndex = 20;
            // 
            // surfaceMaterialLabel
            // 
            this.surfaceMaterialLabel.AutoSize = true;
            this.surfaceMaterialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surfaceMaterialLabel.Location = new System.Drawing.Point(256, 140);
            this.surfaceMaterialLabel.Name = "surfaceMaterialLabel";
            this.surfaceMaterialLabel.Size = new System.Drawing.Size(129, 20);
            this.surfaceMaterialLabel.TabIndex = 19;
            this.surfaceMaterialLabel.Text = "Surface Material:";
            // 
            // numDrawersUpDown2
            // 
            this.numDrawersUpDown2.Location = new System.Drawing.Point(391, 105);
            this.numDrawersUpDown2.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numDrawersUpDown2.Name = "numDrawersUpDown2";
            this.numDrawersUpDown2.Size = new System.Drawing.Size(73, 20);
            this.numDrawersUpDown2.TabIndex = 18;
            // 
            // numDrawersLabel
            // 
            this.numDrawersLabel.AutoSize = true;
            this.numDrawersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDrawersLabel.Location = new System.Drawing.Point(235, 105);
            this.numDrawersLabel.Name = "numDrawersLabel";
            this.numDrawersLabel.Size = new System.Drawing.Size(150, 20);
            this.numDrawersLabel.TabIndex = 16;
            this.numDrawersLabel.Text = "Number of Drawers:";
            // 
            // deskSizeGroupBox2
            // 
            this.deskSizeGroupBox2.Controls.Add(this.widthLabel);
            this.deskSizeGroupBox2.Controls.Add(this.depthLabel);
            this.deskSizeGroupBox2.Controls.Add(this.depthUpDown2);
            this.deskSizeGroupBox2.Controls.Add(this.widthUpDown2);
            this.deskSizeGroupBox2.Location = new System.Drawing.Point(20, 89);
            this.deskSizeGroupBox2.Name = "deskSizeGroupBox2";
            this.deskSizeGroupBox2.Size = new System.Drawing.Size(209, 115);
            this.deskSizeGroupBox2.TabIndex = 17;
            this.deskSizeGroupBox2.TabStop = false;
            this.deskSizeGroupBox2.Text = "Desk Size";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthLabel.Location = new System.Drawing.Point(9, 38);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(54, 20);
            this.widthLabel.TabIndex = 0;
            this.widthLabel.Text = "Width:";
            // 
            // depthLabel
            // 
            this.depthLabel.AutoSize = true;
            this.depthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depthLabel.Location = new System.Drawing.Point(6, 76);
            this.depthLabel.Name = "depthLabel";
            this.depthLabel.Size = new System.Drawing.Size(57, 20);
            this.depthLabel.TabIndex = 1;
            this.depthLabel.Text = "Depth:";
            // 
            // depthUpDown2
            // 
            this.depthUpDown2.Location = new System.Drawing.Point(72, 76);
            this.depthUpDown2.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.depthUpDown2.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.depthUpDown2.Name = "depthUpDown2";
            this.depthUpDown2.Size = new System.Drawing.Size(120, 20);
            this.depthUpDown2.TabIndex = 3;
            this.depthUpDown2.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // widthUpDown2
            // 
            this.widthUpDown2.Location = new System.Drawing.Point(72, 38);
            this.widthUpDown2.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.widthUpDown2.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.widthUpDown2.Name = "widthUpDown2";
            this.widthUpDown2.Size = new System.Drawing.Size(120, 20);
            this.widthUpDown2.TabIndex = 2;
            this.widthUpDown2.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(187, 319);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(120, 30);
            this.closeBtn.TabIndex = 23;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // totalPriceGroupBox
            // 
            this.totalPriceGroupBox.Controls.Add(this.totalPriceText);
            this.totalPriceGroupBox.Location = new System.Drawing.Point(132, 222);
            this.totalPriceGroupBox.Name = "totalPriceGroupBox";
            this.totalPriceGroupBox.Size = new System.Drawing.Size(225, 78);
            this.totalPriceGroupBox.TabIndex = 24;
            this.totalPriceGroupBox.TabStop = false;
            this.totalPriceGroupBox.Text = "Total Price:";
            // 
            // totalPriceText
            // 
            this.totalPriceText.Location = new System.Drawing.Point(55, 32);
            this.totalPriceText.Name = "totalPriceText";
            this.totalPriceText.Size = new System.Drawing.Size(120, 20);
            this.totalPriceText.TabIndex = 0;
            // 
            // DisplayQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.totalPriceGroupBox);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.comDelivery2);
            this.Controls.Add(this.deliveryLabel);
            this.Controls.Add(this.comSurfaceMaterial2);
            this.Controls.Add(this.surfaceMaterialLabel);
            this.Controls.Add(this.numDrawersUpDown2);
            this.Controls.Add(this.numDrawersLabel);
            this.Controls.Add(this.deskSizeGroupBox2);
            this.Controls.Add(this.customerNameText2);
            this.Controls.Add(this.customerNameLabel2);
            this.Name = "DisplayQuote";
            this.Text = "Display Quote";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DisplayQuote_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.numDrawersUpDown2)).EndInit();
            this.deskSizeGroupBox2.ResumeLayout(false);
            this.deskSizeGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depthUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthUpDown2)).EndInit();
            this.totalPriceGroupBox.ResumeLayout(false);
            this.totalPriceGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox customerNameText2;
        private System.Windows.Forms.Label customerNameLabel2;
        private System.Windows.Forms.ComboBox comDelivery2;
        private System.Windows.Forms.Label deliveryLabel;
        private System.Windows.Forms.ComboBox comSurfaceMaterial2;
        private System.Windows.Forms.Label surfaceMaterialLabel;
        private System.Windows.Forms.NumericUpDown numDrawersUpDown2;
        private System.Windows.Forms.Label numDrawersLabel;
        private System.Windows.Forms.GroupBox deskSizeGroupBox2;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label depthLabel;
        private System.Windows.Forms.NumericUpDown depthUpDown2;
        private System.Windows.Forms.NumericUpDown widthUpDown2;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.GroupBox totalPriceGroupBox;
        private System.Windows.Forms.TextBox totalPriceText;
    }
}