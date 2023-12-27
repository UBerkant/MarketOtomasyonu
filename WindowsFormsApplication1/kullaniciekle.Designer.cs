namespace WindowsFormsApplication1
{
    partial class kullaniciekle
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
            this.AdText = new System.Windows.Forms.TextBox();
            this.SoyadText = new System.Windows.Forms.TextBox();
            this.ŞifreText = new System.Windows.Forms.TextBox();
            this.OlusturButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AdminCheck = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.MailText = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.UnvanText = new System.Windows.Forms.TextBox();
            this.TcMaskedText = new System.Windows.Forms.MaskedTextBox();
            this.TelMaskedText = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.MailUzantıCombo = new System.Windows.Forms.ComboBox();
            this.KullanıcıAdıText = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // AdText
            // 
            this.AdText.Location = new System.Drawing.Point(146, 65);
            this.AdText.Margin = new System.Windows.Forms.Padding(4);
            this.AdText.Name = "AdText";
            this.AdText.Size = new System.Drawing.Size(265, 27);
            this.AdText.TabIndex = 0;
            // 
            // SoyadText
            // 
            this.SoyadText.Location = new System.Drawing.Point(146, 103);
            this.SoyadText.Margin = new System.Windows.Forms.Padding(4);
            this.SoyadText.Name = "SoyadText";
            this.SoyadText.Size = new System.Drawing.Size(265, 27);
            this.SoyadText.TabIndex = 1;
            // 
            // ŞifreText
            // 
            this.ŞifreText.Location = new System.Drawing.Point(146, 141);
            this.ŞifreText.Margin = new System.Windows.Forms.Padding(4);
            this.ŞifreText.Name = "ŞifreText";
            this.ŞifreText.Size = new System.Drawing.Size(265, 27);
            this.ŞifreText.TabIndex = 2;
            // 
            // OlusturButton
            // 
            this.OlusturButton.Location = new System.Drawing.Point(212, 373);
            this.OlusturButton.Margin = new System.Windows.Forms.Padding(4);
            this.OlusturButton.Name = "OlusturButton";
            this.OlusturButton.Size = new System.Drawing.Size(100, 34);
            this.OlusturButton.TabIndex = 4;
            this.OlusturButton.Text = "Oluştur";
            this.OlusturButton.UseVisualStyleBackColor = true;
            this.OlusturButton.Click += new System.EventHandler(this.OlusturButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ad*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Soyad*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mail*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Telefon*";
            // 
            // AdminCheck
            // 
            this.AdminCheck.AutoSize = true;
            this.AdminCheck.Location = new System.Drawing.Point(230, 343);
            this.AdminCheck.Name = "AdminCheck";
            this.AdminCheck.Size = new System.Drawing.Size(69, 23);
            this.AdminCheck.TabIndex = 10;
            this.AdminCheck.Text = "Admin";
            this.AdminCheck.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Şifre*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(175, 321);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "* Alanlar Boş Geçilemez";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 290);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 19);
            this.label8.TabIndex = 16;
            this.label8.Text = "İş Ünvanınız*";
            // 
            // MailText
            // 
            this.MailText.Location = new System.Drawing.Point(146, 249);
            this.MailText.Name = "MailText";
            this.MailText.Size = new System.Drawing.Size(132, 27);
            this.MailText.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(63, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 19);
            this.label9.TabIndex = 18;
            this.label9.Text = "TC No*";
            // 
            // UnvanText
            // 
            this.UnvanText.Location = new System.Drawing.Point(146, 287);
            this.UnvanText.Name = "UnvanText";
            this.UnvanText.Size = new System.Drawing.Size(265, 27);
            this.UnvanText.TabIndex = 19;
            // 
            // TcMaskedText
            // 
            this.TcMaskedText.Location = new System.Drawing.Point(146, 179);
            this.TcMaskedText.Mask = "00000000000";
            this.TcMaskedText.Name = "TcMaskedText";
            this.TcMaskedText.Size = new System.Drawing.Size(132, 27);
            this.TcMaskedText.TabIndex = 20;
            // 
            // TelMaskedText
            // 
            this.TelMaskedText.Location = new System.Drawing.Point(146, 213);
            this.TelMaskedText.Mask = "0000000000";
            this.TelMaskedText.Name = "TelMaskedText";
            this.TelMaskedText.Size = new System.Drawing.Size(132, 27);
            this.TelMaskedText.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(590, 457);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.MailUzantıCombo);
            this.groupBox2.Controls.Add(this.KullanıcıAdıText);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.AdText);
            this.groupBox2.Controls.Add(this.TelMaskedText);
            this.groupBox2.Controls.Add(this.SoyadText);
            this.groupBox2.Controls.Add(this.TcMaskedText);
            this.groupBox2.Controls.Add(this.ŞifreText);
            this.groupBox2.Controls.Add(this.UnvanText);
            this.groupBox2.Controls.Add(this.OlusturButton);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.MailText);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.AdminCheck);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(6, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(571, 436);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            // 
            // MailUzantıCombo
            // 
            this.MailUzantıCombo.FormattingEnabled = true;
            this.MailUzantıCombo.Location = new System.Drawing.Point(290, 249);
            this.MailUzantıCombo.Name = "MailUzantıCombo";
            this.MailUzantıCombo.Size = new System.Drawing.Size(206, 27);
            this.MailUzantıCombo.TabIndex = 24;
            // 
            // KullanıcıAdıText
            // 
            this.KullanıcıAdıText.Location = new System.Drawing.Point(146, 27);
            this.KullanıcıAdıText.Name = "KullanıcıAdıText";
            this.KullanıcıAdıText.Size = new System.Drawing.Size(265, 27);
            this.KullanıcıAdıText.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 19);
            this.label10.TabIndex = 22;
            this.label10.Text = "Kullanıcı Adı*";
            // 
            // kullaniciekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 477);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "kullaniciekle";
            this.Text = "kullaniciekle";
            this.Load += new System.EventHandler(this.kullaniciekle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox AdText;
        private System.Windows.Forms.TextBox SoyadText;
        private System.Windows.Forms.TextBox ŞifreText;
        private System.Windows.Forms.Button OlusturButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox AdminCheck;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox MailText;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox UnvanText;
        private System.Windows.Forms.MaskedTextBox TcMaskedText;
        private System.Windows.Forms.MaskedTextBox TelMaskedText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox KullanıcıAdıText;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox MailUzantıCombo;
    }
}