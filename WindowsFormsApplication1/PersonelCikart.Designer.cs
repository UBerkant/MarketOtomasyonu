namespace WindowsFormsApplication1
{
    partial class PersonelCikart
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PersonelCikartButton = new System.Windows.Forms.Button();
            this.PersonelTcText = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PersonelCikartButton);
            this.groupBox1.Controls.Add(this.PersonelTcText);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(23, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(252, 131);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personeli Çıkart";
            // 
            // PersonelCikartButton
            // 
            this.PersonelCikartButton.Location = new System.Drawing.Point(18, 75);
            this.PersonelCikartButton.Name = "PersonelCikartButton";
            this.PersonelCikartButton.Size = new System.Drawing.Size(208, 34);
            this.PersonelCikartButton.TabIndex = 6;
            this.PersonelCikartButton.Text = "Personeli Çıkart";
            this.PersonelCikartButton.UseVisualStyleBackColor = true;
            this.PersonelCikartButton.Click += new System.EventHandler(this.PersonelCikartButton_Click);
            // 
            // PersonelTcText
            // 
            this.PersonelTcText.Location = new System.Drawing.Point(106, 37);
            this.PersonelTcText.Mask = "00000000000";
            this.PersonelTcText.Name = "PersonelTcText";
            this.PersonelTcText.Size = new System.Drawing.Size(120, 27);
            this.PersonelTcText.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Personel TC";
            // 
            // PersonelCikart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 150);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PersonelCikart";
            this.Text = "PersonelCikart";
            this.Load += new System.EventHandler(this.PersonelCikart_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button PersonelCikartButton;
        private System.Windows.Forms.MaskedTextBox PersonelTcText;
        private System.Windows.Forms.Label label2;
    }
}