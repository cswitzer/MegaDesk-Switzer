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
            ((System.ComponentModel.ISupportInitialize)(this.widthUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthUpDown)).BeginInit();
            this.deskSizeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthLabel.Location = new System.Drawing.Point(6, 34);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(63, 24);
            this.widthLabel.TabIndex = 0;
            this.widthLabel.Text = "Width:";
            // 
            // depthLabel
            // 
            this.depthLabel.AutoSize = true;
            this.depthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depthLabel.Location = new System.Drawing.Point(6, 74);
            this.depthLabel.Name = "depthLabel";
            this.depthLabel.Size = new System.Drawing.Size(65, 24);
            this.depthLabel.TabIndex = 1;
            this.depthLabel.Text = "Depth:";
            // 
            // widthUpDown
            // 
            this.widthUpDown.Location = new System.Drawing.Point(72, 38);
            this.widthUpDown.Name = "widthUpDown";
            this.widthUpDown.Size = new System.Drawing.Size(120, 20);
            this.widthUpDown.TabIndex = 2;
            // 
            // depthUpDown
            // 
            this.depthUpDown.Location = new System.Drawing.Point(72, 79);
            this.depthUpDown.Name = "depthUpDown";
            this.depthUpDown.Size = new System.Drawing.Size(120, 20);
            this.depthUpDown.TabIndex = 3;
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameLabel.Location = new System.Drawing.Point(124, 70);
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
            this.deskSizeGroupBox.Location = new System.Drawing.Point(128, 124);
            this.deskSizeGroupBox.Name = "deskSizeGroupBox";
            this.deskSizeGroupBox.Size = new System.Drawing.Size(209, 125);
            this.deskSizeGroupBox.TabIndex = 5;
            this.deskSizeGroupBox.TabStop = false;
            this.deskSizeGroupBox.Text = "Desk Size";
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deskSizeGroupBox);
            this.Controls.Add(this.customerNameLabel);
            this.Name = "AddQuote";
            this.Text = "Add Quote";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddQuoteMenu_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.widthUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthUpDown)).EndInit();
            this.deskSizeGroupBox.ResumeLayout(false);
            this.deskSizeGroupBox.PerformLayout();
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
    }
}