namespace WindowsFormsApplication1
{
    partial class Satış_İşlemi
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SatışButton = new System.Windows.Forms.Button();
            this.SepeteEkleButton = new System.Windows.Forms.Button();
            this.SeçiliSatırıSilButton = new System.Windows.Forms.Button();
            this.AlıcıAdText = new System.Windows.Forms.TextBox();
            this.BarkodText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AlıcıTelText = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AdetText = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.ÜrünAdıText = new System.Windows.Forms.TextBox();
            this.StokMiktarıLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ToplamSatışFiyatıText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ÜrünAdetSatışText = new System.Windows.Forms.TextBox();
            this.FaturaIDText = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SepetTutarıLabel = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.SatışYapanPersonelİsimText = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.PersonelTcText = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.SatışİptalButton = new System.Windows.Forms.Button();
            this.BelirliAdetÇıkartButton = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.ÇıkartılacakAdetText = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.KameraCombo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(433, 162);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(713, 425);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // SatışButton
            // 
            this.SatışButton.Location = new System.Drawing.Point(15, 171);
            this.SatışButton.Name = "SatışButton";
            this.SatışButton.Size = new System.Drawing.Size(306, 41);
            this.SatışButton.TabIndex = 1;
            this.SatışButton.Text = "Satışı Gerçekleştir";
            this.SatışButton.UseVisualStyleBackColor = true;
            this.SatışButton.Click += new System.EventHandler(this.SatışButton_Click);
            // 
            // SepeteEkleButton
            // 
            this.SepeteEkleButton.Location = new System.Drawing.Point(161, 247);
            this.SepeteEkleButton.Name = "SepeteEkleButton";
            this.SepeteEkleButton.Size = new System.Drawing.Size(116, 28);
            this.SepeteEkleButton.TabIndex = 2;
            this.SepeteEkleButton.Text = "Sepete Ekle";
            this.SepeteEkleButton.UseVisualStyleBackColor = true;
            this.SepeteEkleButton.Click += new System.EventHandler(this.SepeteEkleButton_Click);
            // 
            // SeçiliSatırıSilButton
            // 
            this.SeçiliSatırıSilButton.Location = new System.Drawing.Point(1182, 288);
            this.SeçiliSatırıSilButton.Name = "SeçiliSatırıSilButton";
            this.SeçiliSatırıSilButton.Size = new System.Drawing.Size(301, 33);
            this.SeçiliSatırıSilButton.TabIndex = 3;
            this.SeçiliSatırıSilButton.Text = "Seçili Satırdaki Ürünü Çıkart";
            this.SeçiliSatırıSilButton.UseVisualStyleBackColor = true;
            this.SeçiliSatırıSilButton.Click += new System.EventHandler(this.SeçiliSatırıSilButton_Click);
            // 
            // AlıcıAdText
            // 
            this.AlıcıAdText.Location = new System.Drawing.Point(159, 26);
            this.AlıcıAdText.Name = "AlıcıAdText";
            this.AlıcıAdText.Size = new System.Drawing.Size(114, 27);
            this.AlıcıAdText.TabIndex = 4;
            // 
            // BarkodText
            // 
            this.BarkodText.Location = new System.Drawing.Point(161, 36);
            this.BarkodText.Name = "BarkodText";
            this.BarkodText.Size = new System.Drawing.Size(114, 27);
            this.BarkodText.TabIndex = 6;
            this.BarkodText.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Barkod No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Toplam Satış Fiyatı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Adet";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AlıcıTelText);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.AlıcıAdText);
            this.groupBox1.Location = new System.Drawing.Point(12, 161);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 130);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alıcı Bilgileri";
            // 
            // AlıcıTelText
            // 
            this.AlıcıTelText.Location = new System.Drawing.Point(157, 68);
            this.AlıcıTelText.Mask = "0000000000";
            this.AlıcıTelText.Name = "AlıcıTelText";
            this.AlıcıTelText.Size = new System.Drawing.Size(120, 27);
            this.AlıcıTelText.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(91, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "Alıcı Tel";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Alıcı Adı";
            // 
            // AdetText
            // 
            this.AdetText.Location = new System.Drawing.Point(161, 105);
            this.AdetText.Name = "AdetText";
            this.AdetText.Size = new System.Drawing.Size(114, 27);
            this.AdetText.TabIndex = 13;
            this.AdetText.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.ÜrünAdıText);
            this.groupBox2.Controls.Add(this.StokMiktarıLabel);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.ToplamSatışFiyatıText);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.ÜrünAdetSatışText);
            this.groupBox2.Controls.Add(this.BarkodText);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.SepeteEkleButton);
            this.groupBox2.Controls.Add(this.AdetText);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 288);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(414, 299);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sepet İşlemleri";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(86, 75);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 19);
            this.label14.TabIndex = 21;
            this.label14.Text = "Ürün Adı";
            // 
            // ÜrünAdıText
            // 
            this.ÜrünAdıText.Location = new System.Drawing.Point(161, 72);
            this.ÜrünAdıText.Name = "ÜrünAdıText";
            this.ÜrünAdıText.ReadOnly = true;
            this.ÜrünAdıText.Size = new System.Drawing.Size(114, 27);
            this.ÜrünAdıText.TabIndex = 20;
            // 
            // StokMiktarıLabel
            // 
            this.StokMiktarıLabel.AutoSize = true;
            this.StokMiktarıLabel.Location = new System.Drawing.Point(373, 108);
            this.StokMiktarıLabel.Name = "StokMiktarıLabel";
            this.StokMiktarıLabel.Size = new System.Drawing.Size(0, 19);
            this.StokMiktarıLabel.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(281, 108);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 19);
            this.label12.TabIndex = 18;
            this.label12.Text = "Stok Miktarı";
            // 
            // ToplamSatışFiyatıText
            // 
            this.ToplamSatışFiyatıText.Location = new System.Drawing.Point(159, 170);
            this.ToplamSatışFiyatıText.Name = "ToplamSatışFiyatıText";
            this.ToplamSatışFiyatıText.ReadOnly = true;
            this.ToplamSatışFiyatıText.Size = new System.Drawing.Size(116, 27);
            this.ToplamSatışFiyatıText.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 19);
            this.label8.TabIndex = 15;
            this.label8.Text = "Adet Satış Fiyatı";
            // 
            // ÜrünAdetSatışText
            // 
            this.ÜrünAdetSatışText.Location = new System.Drawing.Point(159, 138);
            this.ÜrünAdetSatışText.Name = "ÜrünAdetSatışText";
            this.ÜrünAdetSatışText.ReadOnly = true;
            this.ÜrünAdetSatışText.Size = new System.Drawing.Size(116, 27);
            this.ÜrünAdetSatışText.TabIndex = 14;
            // 
            // FaturaIDText
            // 
            this.FaturaIDText.Location = new System.Drawing.Point(190, 67);
            this.FaturaIDText.Name = "FaturaIDText";
            this.FaturaIDText.ReadOnly = true;
            this.FaturaIDText.Size = new System.Drawing.Size(131, 27);
            this.FaturaIDText.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(116, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 19);
            this.label9.TabIndex = 16;
            this.label9.Text = "Fatura ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(98, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 19);
            this.label10.TabIndex = 18;
            this.label10.Text = "Sepet Tutarı";
            // 
            // SepetTutarıLabel
            // 
            this.SepetTutarıLabel.AutoSize = true;
            this.SepetTutarıLabel.Location = new System.Drawing.Point(186, 39);
            this.SepetTutarıLabel.Name = "SepetTutarıLabel";
            this.SepetTutarıLabel.Size = new System.Drawing.Size(0, 19);
            this.SepetTutarıLabel.TabIndex = 19;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 137);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(173, 19);
            this.label15.TabIndex = 20;
            this.label15.Text = "Satış Yapan Personel İsmi";
            // 
            // SatışYapanPersonelİsimText
            // 
            this.SatışYapanPersonelİsimText.Location = new System.Drawing.Point(190, 134);
            this.SatışYapanPersonelİsimText.Name = "SatışYapanPersonelİsimText";
            this.SatışYapanPersonelİsimText.ReadOnly = true;
            this.SatışYapanPersonelİsimText.Size = new System.Drawing.Size(131, 27);
            this.SatışYapanPersonelİsimText.TabIndex = 21;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.PersonelTcText);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.FaturaIDText);
            this.groupBox3.Controls.Add(this.SatışYapanPersonelİsimText);
            this.groupBox3.Controls.Add(this.SatışButton);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.SepetTutarıLabel);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(1162, 364);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(327, 223);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Satış Onayı";
            // 
            // PersonelTcText
            // 
            this.PersonelTcText.Location = new System.Drawing.Point(190, 101);
            this.PersonelTcText.Name = "PersonelTcText";
            this.PersonelTcText.ReadOnly = true;
            this.PersonelTcText.Size = new System.Drawing.Size(131, 27);
            this.PersonelTcText.TabIndex = 23;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(98, 104);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(86, 19);
            this.label17.TabIndex = 22;
            this.label17.Text = "Personel TC";
            // 
            // SatışİptalButton
            // 
            this.SatışİptalButton.Location = new System.Drawing.Point(1182, 327);
            this.SatışİptalButton.Name = "SatışİptalButton";
            this.SatışİptalButton.Size = new System.Drawing.Size(301, 31);
            this.SatışİptalButton.TabIndex = 23;
            this.SatışİptalButton.Text = "Satış İptali";
            this.SatışİptalButton.UseVisualStyleBackColor = true;
            this.SatışİptalButton.Click += new System.EventHandler(this.SatışİptalButton_Click);
            // 
            // BelirliAdetÇıkartButton
            // 
            this.BelirliAdetÇıkartButton.Location = new System.Drawing.Point(20, 61);
            this.BelirliAdetÇıkartButton.Name = "BelirliAdetÇıkartButton";
            this.BelirliAdetÇıkartButton.Size = new System.Drawing.Size(301, 37);
            this.BelirliAdetÇıkartButton.TabIndex = 24;
            this.BelirliAdetÇıkartButton.Text = "Seçili Üründen Belirtilen Adette Çıkart";
            this.BelirliAdetÇıkartButton.UseVisualStyleBackColor = true;
            this.BelirliAdetÇıkartButton.Click += new System.EventHandler(this.BelirliAdetÇıkartButton_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(2, 31);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(218, 19);
            this.label16.TabIndex = 25;
            this.label16.Text = "Çıkartılmak İstenen Adet Miktarı";
            // 
            // ÇıkartılacakAdetText
            // 
            this.ÇıkartılacakAdetText.Location = new System.Drawing.Point(221, 28);
            this.ÇıkartılacakAdetText.Name = "ÇıkartılacakAdetText";
            this.ÇıkartılacakAdetText.Size = new System.Drawing.Size(100, 27);
            this.ÇıkartılacakAdetText.TabIndex = 26;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BelirliAdetÇıkartButton);
            this.groupBox4.Controls.Add(this.ÇıkartılacakAdetText);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Location = new System.Drawing.Point(1162, 162);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(327, 118);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Adet Çıkart";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1456, 121);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(33, 35);
            this.button6.TabIndex = 28;
            this.button6.Text = "X";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(456, 615);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // KameraCombo
            // 
            this.KameraCombo.FormattingEnabled = true;
            this.KameraCombo.Location = new System.Drawing.Point(562, 638);
            this.KameraCombo.Name = "KameraCombo";
            this.KameraCombo.Size = new System.Drawing.Size(121, 27);
            this.KameraCombo.TabIndex = 30;
            this.KameraCombo.Visible = false;
            // 
            // Satış_İşlemi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1512, 725);
            this.Controls.Add(this.KameraCombo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.SatışİptalButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SeçiliSatırıSilButton);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Satış_İşlemi";
            this.Text = "Sepet / Satış İşlemleri";
            this.Load += new System.EventHandler(this.Satış_İşlemi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button SatışButton;
        private System.Windows.Forms.Button SepeteEkleButton;
        private System.Windows.Forms.Button SeçiliSatırıSilButton;
        private System.Windows.Forms.TextBox AlıcıAdText;
        private System.Windows.Forms.TextBox BarkodText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AdetText;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ÜrünAdetSatışText;
        private System.Windows.Forms.TextBox ToplamSatışFiyatıText;
        private System.Windows.Forms.TextBox FaturaIDText;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label SepetTutarıLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label StokMiktarıLabel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox ÜrünAdıText;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox SatışYapanPersonelİsimText;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button SatışİptalButton;
        private System.Windows.Forms.Button BelirliAdetÇıkartButton;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox ÇıkartılacakAdetText;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox PersonelTcText;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox KameraCombo;
        private System.Windows.Forms.MaskedTextBox AlıcıTelText;
    }
}