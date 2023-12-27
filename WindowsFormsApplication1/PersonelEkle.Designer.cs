namespace WindowsFormsApplication1
{
    partial class PersonelEkle
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PersonelTelText = new System.Windows.Forms.MaskedTextBox();
            this.PersonelMailUzantıCombo = new System.Windows.Forms.ComboBox();
            this.PersonelPuanNumeric = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PersonelMarketIdNumeric = new System.Windows.Forms.NumericUpDown();
            this.PersonelÜnvanText = new System.Windows.Forms.TextBox();
            this.PersonelMailText = new System.Windows.Forms.TextBox();
            this.PersonelAdresText = new System.Windows.Forms.RichTextBox();
            this.PersonelEkleButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.PersonelTcText = new System.Windows.Forms.MaskedTextBox();
            this.PersonelSoyadText = new System.Windows.Forms.TextBox();
            this.PersonelAdText = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PersonelPuanNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonelMarketIdNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "TC No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tel No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mail Adresi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(104, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ünvan";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PersonelTelText);
            this.groupBox1.Controls.Add(this.PersonelMailUzantıCombo);
            this.groupBox1.Controls.Add(this.PersonelPuanNumeric);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.PersonelMarketIdNumeric);
            this.groupBox1.Controls.Add(this.PersonelÜnvanText);
            this.groupBox1.Controls.Add(this.PersonelMailText);
            this.groupBox1.Controls.Add(this.PersonelAdresText);
            this.groupBox1.Controls.Add(this.PersonelEkleButton);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.PersonelTcText);
            this.groupBox1.Controls.Add(this.PersonelSoyadText);
            this.groupBox1.Controls.Add(this.PersonelAdText);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(526, 502);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // PersonelTelText
            // 
            this.PersonelTelText.Location = new System.Drawing.Point(160, 139);
            this.PersonelTelText.Mask = "0000000000";
            this.PersonelTelText.Name = "PersonelTelText";
            this.PersonelTelText.Size = new System.Drawing.Size(115, 27);
            this.PersonelTelText.TabIndex = 20;
            // 
            // PersonelMailUzantıCombo
            // 
            this.PersonelMailUzantıCombo.FormattingEnabled = true;
            this.PersonelMailUzantıCombo.Location = new System.Drawing.Point(281, 178);
            this.PersonelMailUzantıCombo.Name = "PersonelMailUzantıCombo";
            this.PersonelMailUzantıCombo.Size = new System.Drawing.Size(198, 27);
            this.PersonelMailUzantıCombo.TabIndex = 19;
            // 
            // PersonelPuanNumeric
            // 
            this.PersonelPuanNumeric.Location = new System.Drawing.Point(160, 416);
            this.PersonelPuanNumeric.Name = "PersonelPuanNumeric";
            this.PersonelPuanNumeric.Size = new System.Drawing.Size(187, 27);
            this.PersonelPuanNumeric.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(43, 418);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 19);
            this.label9.TabIndex = 17;
            this.label9.Text = "Başlangıç Puanı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 378);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 19);
            this.label7.TabIndex = 16;
            this.label7.Text = "Çalışacağı Market Id";
            // 
            // PersonelMarketIdNumeric
            // 
            this.PersonelMarketIdNumeric.Location = new System.Drawing.Point(162, 376);
            this.PersonelMarketIdNumeric.Name = "PersonelMarketIdNumeric";
            this.PersonelMarketIdNumeric.Size = new System.Drawing.Size(186, 27);
            this.PersonelMarketIdNumeric.TabIndex = 15;
            // 
            // PersonelÜnvanText
            // 
            this.PersonelÜnvanText.Location = new System.Drawing.Point(163, 216);
            this.PersonelÜnvanText.Name = "PersonelÜnvanText";
            this.PersonelÜnvanText.Size = new System.Drawing.Size(185, 27);
            this.PersonelÜnvanText.TabIndex = 14;
            // 
            // PersonelMailText
            // 
            this.PersonelMailText.Location = new System.Drawing.Point(162, 178);
            this.PersonelMailText.Name = "PersonelMailText";
            this.PersonelMailText.Size = new System.Drawing.Size(113, 27);
            this.PersonelMailText.TabIndex = 13;
            // 
            // PersonelAdresText
            // 
            this.PersonelAdresText.Location = new System.Drawing.Point(163, 256);
            this.PersonelAdresText.Name = "PersonelAdresText";
            this.PersonelAdresText.Size = new System.Drawing.Size(316, 114);
            this.PersonelAdresText.TabIndex = 12;
            this.PersonelAdresText.Text = "";
            // 
            // PersonelEkleButton
            // 
            this.PersonelEkleButton.Location = new System.Drawing.Point(163, 449);
            this.PersonelEkleButton.Name = "PersonelEkleButton";
            this.PersonelEkleButton.Size = new System.Drawing.Size(185, 40);
            this.PersonelEkleButton.TabIndex = 7;
            this.PersonelEkleButton.Text = "Personel Ekle";
            this.PersonelEkleButton.UseVisualStyleBackColor = true;
            this.PersonelEkleButton.Click += new System.EventHandler(this.PersonelEkleButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(75, 259);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 19);
            this.label8.TabIndex = 11;
            this.label8.Text = "Açık Adresi";
            // 
            // PersonelTcText
            // 
            this.PersonelTcText.Location = new System.Drawing.Point(163, 101);
            this.PersonelTcText.Mask = "00000000000";
            this.PersonelTcText.Name = "PersonelTcText";
            this.PersonelTcText.Size = new System.Drawing.Size(112, 27);
            this.PersonelTcText.TabIndex = 8;
            // 
            // PersonelSoyadText
            // 
            this.PersonelSoyadText.Location = new System.Drawing.Point(163, 64);
            this.PersonelSoyadText.Name = "PersonelSoyadText";
            this.PersonelSoyadText.Size = new System.Drawing.Size(185, 27);
            this.PersonelSoyadText.TabIndex = 7;
            // 
            // PersonelAdText
            // 
            this.PersonelAdText.Location = new System.Drawing.Point(163, 26);
            this.PersonelAdText.Name = "PersonelAdText";
            this.PersonelAdText.Size = new System.Drawing.Size(185, 27);
            this.PersonelAdText.TabIndex = 6;
            // 
            // PersonelEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 530);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PersonelEkle";
            this.Text = "PersonelEkle";
            this.Load += new System.EventHandler(this.PersonelEkle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PersonelPuanNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonelMarketIdNumeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown PersonelMarketIdNumeric;
        private System.Windows.Forms.TextBox PersonelÜnvanText;
        private System.Windows.Forms.TextBox PersonelMailText;
        private System.Windows.Forms.RichTextBox PersonelAdresText;
        private System.Windows.Forms.Button PersonelEkleButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox PersonelTcText;
        private System.Windows.Forms.TextBox PersonelSoyadText;
        private System.Windows.Forms.TextBox PersonelAdText;
        private System.Windows.Forms.NumericUpDown PersonelPuanNumeric;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox PersonelMailUzantıCombo;
        private System.Windows.Forms.MaskedTextBox PersonelTelText;
    }
}