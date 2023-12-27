namespace WindowsFormsApplication1
{
    partial class StokSorgulama
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ÜrünYeniSatışText = new System.Windows.Forms.TextBox();
            this.BarkodText = new System.Windows.Forms.TextBox();
            this.SorgulaButton = new System.Windows.Forms.Button();
            this.ListeYenileButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Sorgulama = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BarkodText3 = new System.Windows.Forms.TextBox();
            this.FiyatGüncelleButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ÜrünAlışText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ÜrünAdetText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BarkodText2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SiparişVerButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Sorgulama.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Barkod No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(856, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 19);
            this.label2.TabIndex = 2;
            // 
            // ÜrünYeniSatışText
            // 
            this.ÜrünYeniSatışText.Location = new System.Drawing.Point(127, 59);
            this.ÜrünYeniSatışText.Name = "ÜrünYeniSatışText";
            this.ÜrünYeniSatışText.Size = new System.Drawing.Size(276, 27);
            this.ÜrünYeniSatışText.TabIndex = 7;
            // 
            // BarkodText
            // 
            this.BarkodText.Location = new System.Drawing.Point(127, 39);
            this.BarkodText.Name = "BarkodText";
            this.BarkodText.Size = new System.Drawing.Size(276, 27);
            this.BarkodText.TabIndex = 8;
            // 
            // SorgulaButton
            // 
            this.SorgulaButton.Location = new System.Drawing.Point(48, 72);
            this.SorgulaButton.Name = "SorgulaButton";
            this.SorgulaButton.Size = new System.Drawing.Size(355, 46);
            this.SorgulaButton.TabIndex = 9;
            this.SorgulaButton.Text = "Sorgula";
            this.SorgulaButton.UseVisualStyleBackColor = true;
            this.SorgulaButton.Click += new System.EventHandler(this.SorgulaButton_Click);
            // 
            // ListeYenileButton
            // 
            this.ListeYenileButton.Location = new System.Drawing.Point(123, 73);
            this.ListeYenileButton.Name = "ListeYenileButton";
            this.ListeYenileButton.Size = new System.Drawing.Size(218, 54);
            this.ListeYenileButton.TabIndex = 10;
            this.ListeYenileButton.Text = "Listeyi Yenile";
            this.ListeYenileButton.UseVisualStyleBackColor = true;
            this.ListeYenileButton.Click += new System.EventHandler(this.ListeYenileButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(769, 711);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Sorgulama
            // 
            this.Sorgulama.Controls.Add(this.BarkodText);
            this.Sorgulama.Controls.Add(this.label1);
            this.Sorgulama.Controls.Add(this.SorgulaButton);
            this.Sorgulama.Location = new System.Drawing.Point(788, 54);
            this.Sorgulama.Name = "Sorgulama";
            this.Sorgulama.Size = new System.Drawing.Size(451, 126);
            this.Sorgulama.TabIndex = 12;
            this.Sorgulama.TabStop = false;
            this.Sorgulama.Text = "Ürün Sorgulama";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BarkodText3);
            this.groupBox1.Controls.Add(this.FiyatGüncelleButton);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ÜrünYeniSatışText);
            this.groupBox1.Location = new System.Drawing.Point(788, 397);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(451, 156);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Satış Fiyatı Güncelleme";
            // 
            // BarkodText3
            // 
            this.BarkodText3.Location = new System.Drawing.Point(127, 26);
            this.BarkodText3.Name = "BarkodText3";
            this.BarkodText3.Size = new System.Drawing.Size(276, 27);
            this.BarkodText3.TabIndex = 17;
            // 
            // FiyatGüncelleButton
            // 
            this.FiyatGüncelleButton.Location = new System.Drawing.Point(32, 92);
            this.FiyatGüncelleButton.Name = "FiyatGüncelleButton";
            this.FiyatGüncelleButton.Size = new System.Drawing.Size(371, 47);
            this.FiyatGüncelleButton.TabIndex = 10;
            this.FiyatGüncelleButton.Text = "Satış Fiyatı Güncelle";
            this.FiyatGüncelleButton.UseVisualStyleBackColor = true;
            this.FiyatGüncelleButton.Click += new System.EventHandler(this.FiyatGüncelleButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 62);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "Yeni Satış Fiyatı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 29);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Barkod No";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ListeYenileButton);
            this.groupBox2.Location = new System.Drawing.Point(792, 559);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(451, 164);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1162, 710);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(276, 27);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1257, 393);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(359, 344);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1197, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(42, 36);
            this.button4.TabIndex = 15;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ÜrünAlışText);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.ÜrünAdetText);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.BarkodText2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.SiparişVerButton);
            this.groupBox3.Location = new System.Drawing.Point(788, 186);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(451, 205);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sipariş";
            // 
            // ÜrünAlışText
            // 
            this.ÜrünAlışText.Location = new System.Drawing.Point(127, 72);
            this.ÜrünAlışText.Name = "ÜrünAlışText";
            this.ÜrünAlışText.Size = new System.Drawing.Size(276, 27);
            this.ÜrünAlışText.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 75);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "Adet Alış Fiyatı";
            // 
            // ÜrünAdetText
            // 
            this.ÜrünAdetText.Location = new System.Drawing.Point(127, 105);
            this.ÜrünAdetText.Name = "ÜrünAdetText";
            this.ÜrünAdetText.Size = new System.Drawing.Size(276, 27);
            this.ÜrünAdetText.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(80, 108);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Adet";
            // 
            // BarkodText2
            // 
            this.BarkodText2.Location = new System.Drawing.Point(127, 39);
            this.BarkodText2.Name = "BarkodText2";
            this.BarkodText2.Size = new System.Drawing.Size(276, 27);
            this.BarkodText2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Barkod No";
            // 
            // SiparişVerButton
            // 
            this.SiparişVerButton.Location = new System.Drawing.Point(49, 138);
            this.SiparişVerButton.Name = "SiparişVerButton";
            this.SiparişVerButton.Size = new System.Drawing.Size(355, 46);
            this.SiparişVerButton.TabIndex = 9;
            this.SiparişVerButton.Text = "Sipariş Ver";
            this.SiparişVerButton.UseVisualStyleBackColor = true;
            this.SiparişVerButton.Click += new System.EventHandler(this.SiparişVerButton_Click);
            // 
            // StokSorgulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 736);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Sorgulama);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StokSorgulama";
            this.Text = "Stok Bilgileri";
            this.Load += new System.EventHandler(this.StokSorgulama_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Sorgulama.ResumeLayout(false);
            this.Sorgulama.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ÜrünYeniSatışText;
        private System.Windows.Forms.TextBox BarkodText;
        private System.Windows.Forms.Button SorgulaButton;
        private System.Windows.Forms.Button ListeYenileButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox Sorgulama;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button FiyatGüncelleButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox BarkodText3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox BarkodText2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SiparişVerButton;
        private System.Windows.Forms.TextBox ÜrünAlışText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ÜrünAdetText;
        private System.Windows.Forms.Label label6;
    }
}