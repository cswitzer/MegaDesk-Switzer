namespace MegaDesk_Switzer
{
    partial class AddQuote
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
            this.widthLabel = new System.Windows.Forms.Label();
            this.depthLabel = new System.Windows.Forms.Label();
            this.widthUpDown = new System.Windows.Forms.NumericUpDown();
            this.depthUpDown = new System.Windows.Forms.NumericUpDown();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.deskSizeGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.customerNameText = new System.Windows.Forms.TextBox();
            this.saveQuoteBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.numDrawersLabel = new System.Windows.Forms.Label();
            this.numDrawersUpDown = new System.Windows.Forms.NumericUpDown();
            this.surfaceMaterialLabel = new System.Windows.Forms.Label();
            this.comSurfaceMaterial = new System.Windows.Forms.ComboBox();
            this.deliveryLabel = new System.Windows.Forms.Label();
            this.comDelivery = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.widthUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthUpDown)).BeginInit();
            this.deskSizeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDrawersUpDown)).BeginInit();
            this.SuspendLayout();
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
            // widthUpDown
            // 
            this.widthUpDown.Location = new System.Drawing.Point(72, 38);
            this.widthUpDown.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.widthUpDown.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.widthUpDown.Name = "widthUpDown";
            this.widthUpDown.Size = new System.Drawing.Size(120, 20);
            this.widthUpDown.TabIndex = 2;
            this.widthUpDown.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // depthUpDown
            // 
            this.depthUpDown.Location = new System.Drawing.Point(72, 76);
            this.depthUpDown.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.depthUpDown.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.depthUpDown.Name = "depthUpDown";
            this.depthUpDown.Size = new System.Drawing.Size(120, 20);
            this.depthUpDown.TabIndex = 3;
            this.depthUpDown.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameLabel.Location = new System.Drawing.Point(12, 66);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(152, 24);
            this.customerNameLabel.TabIndex = 4;
            this.customerNameLabel.Text = "Customer Name:";
            // 
            // deskSizeGroupBox
            // 
            this.deskSizeGroupBox.Controls.Add(this.widthLabel);
            this.deskSizeGroupBox.Controls.Add(this.depthLabel);
            this.deskSizeGroupBox.Controls.Add(this.depthUpDown);
            this.deskSizeGroupBox.Controls.Add(this.widthUpDown);
            this.deskSizeGroupBox.Location = new System.Drawing.Point(16, 124);
            this.deskSizeGroupBox.Name = "deskSizeGroupBox";
            this.deskSizeGroupBox.Size = new System.Drawing.Size(209, 115);
            this.deskSizeGroupBox.TabIndex = 5;
            this.deskSizeGroupBox.TabStop = false;
            this.deskSizeGroupBox.Text = "Desk Size";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 37);
            this.label1.TabIndex = 7;
            this.label1.Text = "New Quote";
            // 
            // customerNameText
            // 
            this.customerNameText.Location = new System.Drawing.Point(167, 70);
            this.customerNameText.Name = "customerNameText";
            this.customerNameText.Size = new System.Drawing.Size(252, 20);
            this.customerNameText.TabIndex = 8;
            // 
            // saveQuoteBtn
            // 
            this.saveQuoteBtn.Location = new System.Drawing.Point(101, 282);
            this.saveQuoteBtn.Name = "saveQuoteBtn";
            this.saveQuoteBtn.Size = new System.Drawing.Size(120, 30);
            this.saveQuoteBtn.TabIndex = 9;
            this.saveQuoteBtn.Text = "Save Quote";
            this.saveQuoteBtn.UseVisualStyleBackColor = true;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(246, 282);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(120, 30);
            this.cancelBtn.TabIndex = 10;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // numDrawersLabel
            // 
            this.numDrawersLabel.AutoSize = true;
            this.numDrawersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDrawersLabel.Location = new System.Drawing.Point(231, 139);
            this.numDrawersLabel.Name = "numDrawersLabel";
            this.numDrawersLabel.Size = new System.Drawing.Size(150, 20);
            this.numDrawersLabel.TabIndex = 4;
            this.numDrawersLabel.Text = "Number of Drawers:";
            // 
            // numDrawersUpDown
            // 
            this.numDrawersUpDown.Location = new System.Drawing.Point(387, 139);
            this.numDrawersUpDown.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numDrawersUpDown.Name = "numDrawersUpDown";
            this.numDrawersUpDown.Size = new System.Drawing.Size(73, 20);
            this.numDrawersUpDown.TabIndex = 11;
            // 
            // surfaceMaterialLabel
            // 
            this.surfaceMaterialLabel.AutoSize = true;
            this.surfaceMaterialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surfaceMaterialLabel.Location = new System.Drawing.Point(252, 174);
            this.surfaceMaterialLabel.Name = "surfaceMaterialLabel";
            this.surfaceMaterialLabel.Size = new System.Drawing.Size(129, 20);
            this.surfaceMaterialLabel.TabIndex = 12;
            this.surfaceMaterialLabel.Text = "Surface Material:";
            // 
            // comSurfaceMaterial
            // 
            this.comSurfaceMaterial.FormattingEnabled = true;
            this.comSurfaceMaterial.Location = new System.Drawing.Point(387, 173);
            this.comSurfaceMaterial.Name = "comSurfaceMaterial";
            this.comSurfaceMaterial.Size = new System.Drawing.Size(74, 21);
            this.comSurfaceMaterial.TabIndex = 13;
            // 
            // deliveryLabel
            // 
            this.deliveryLabel.AutoSize = true;
            this.deliveryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deliveryLabel.Location = new System.Drawing.Point(313, 212);
            this.deliveryLabel.Name = "deliveryLabel";
            this.deliveryLabel.Size = new System.Drawing.Size(68, 20);
            this.deliveryLabel.TabIndex = 14;
            this.deliveryLabel.Text = "Delivery:";
            // 
            // comDelivery
            // 
            this.comDelivery.FormattingEnabled = true;
            this.comDelivery.Location = new System.Drawing.Point(387, 211);
            this.comDelivery.Name = "comDelivery";
            this.comDelivery.Size = new System.Drawing.Size(74, 21);
            this.comDelivery.TabIndex = 15;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.comDelivery);
            this.Controls.Add(this.deliveryLabel);
            this.Controls.Add(this.comSurfaceMaterial);
            this.Controls.Add(this.surfaceMaterialLabel);
            this.Controls.Add(this.numDrawersUpDown);
            this.Controls.Add(this.numDrawersLabel);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveQuoteBtn);
            this.Controls.Add(this.customerNameText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deskSizeGroupBox);
            this.Controls.Add(this.customerNameLabel);
            this.Name = "AddQuote";
            this.Text = "Add Quote";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddQuoteMenu_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.widthUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthUpDown)).EndInit();
            this.deskSizeGroupBox.ResumeLayout(false);
            this.deskSizeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDrawersUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label depthLabel;
        private System.Windows.Forms.NumericUpDown widthUpDown;
        private System.Windows.Forms.NumericUpDown depthUpDown;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.GroupBox deskSizeGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox customerNameText;
        private System.Windows.Forms.Button saveQuoteBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label numDrawersLabel;
        private System.Windows.Forms.NumericUpDown numDrawersUpDown;
        private System.Windows.Forms.Label surfaceMaterialLabel;
        private System.Windows.Forms.ComboBox comSurfaceMaterial;
        private System.Windows.Forms.Label deliveryLabel;
        private System.Windows.Forms.ComboBox comDelivery;
    }
}