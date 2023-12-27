namespace WindowsFormsApplication1
{
    partial class PersonelSorgulama
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PersonelGörüntüleButton = new System.Windows.Forms.Button();
            this.PersonelAdText = new System.Windows.Forms.TextBox();
            this.PersonelTcText = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.PuanGüncelleButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.PersonelPuanNumeric = new System.Windows.Forms.NumericUpDown();
            this.ListeYenileButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.BilgiGüncelleButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PersonelPuanNumeric)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 18);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(769, 590);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PersonelGörüntüleButton);
            this.groupBox1.Location = new System.Drawing.Point(792, 210);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(397, 82);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personeli Görüntüle";
            // 
            // PersonelGörüntüleButton
            // 
            this.PersonelGörüntüleButton.Location = new System.Drawing.Point(11, 27);
            this.PersonelGörüntüleButton.Name = "PersonelGörüntüleButton";
            this.PersonelGörüntüleButton.Size = new System.Drawing.Size(374, 44);
            this.PersonelGörüntüleButton.TabIndex = 6;
            this.PersonelGörüntüleButton.Text = "Görüntüle";
            this.PersonelGörüntüleButton.UseVisualStyleBackColor = true;
            this.PersonelGörüntüleButton.Click += new System.EventHandler(this.PersonelGörüntüleButton_Click);
            // 
            // PersonelAdText
            // 
            this.PersonelAdText.Location = new System.Drawing.Point(938, 66);
            this.PersonelAdText.Name = "PersonelAdText";
            this.PersonelAdText.Size = new System.Drawing.Size(139, 27);
            this.PersonelAdText.TabIndex = 8;
            // 
            // PersonelTcText
            // 
            this.PersonelTcText.Location = new System.Drawing.Point(939, 112);
            this.PersonelTcText.Mask = "00000000000";
            this.PersonelTcText.Name = "PersonelTcText";
            this.PersonelTcText.Size = new System.Drawing.Size(139, 27);
            this.PersonelTcText.TabIndex = 7;
            this.PersonelTcText.TextChanged += new System.EventHandler(this.PersonelTcText_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(847, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Personel TC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(847, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Personel Ad";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.PuanGüncelleButton);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.PersonelPuanNumeric);
            this.groupBox2.Location = new System.Drawing.Point(792, 299);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(398, 121);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Puanla";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.maskedTextBox2);
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Location = new System.Drawing.Point(0, 158);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(385, 146);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(129, 60);
            this.maskedTextBox2.Mask = "00000000000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(126, 27);
            this.maskedTextBox2.TabIndex = 8;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(128, 57);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(155, 54);
            this.button4.TabIndex = 4;
            this.button4.Text = "Listeyi Yenile";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // PuanGüncelleButton
            // 
            this.PuanGüncelleButton.Location = new System.Drawing.Point(11, 70);
            this.PuanGüncelleButton.Name = "PuanGüncelleButton";
            this.PuanGüncelleButton.Size = new System.Drawing.Size(374, 44);
            this.PuanGüncelleButton.TabIndex = 8;
            this.PuanGüncelleButton.Text = "Puanı Güncelle";
            this.PuanGüncelleButton.UseVisualStyleBackColor = true;
            this.PuanGüncelleButton.Click += new System.EventHandler(this.PuanGüncelleButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Personel Yeni Puan";
            // 
            // PersonelPuanNumeric
            // 
            this.PersonelPuanNumeric.Location = new System.Drawing.Point(145, 27);
            this.PersonelPuanNumeric.Name = "PersonelPuanNumeric";
            this.PersonelPuanNumeric.Size = new System.Drawing.Size(139, 27);
            this.PersonelPuanNumeric.TabIndex = 9;
            // 
            // ListeYenileButton
            // 
            this.ListeYenileButton.Location = new System.Drawing.Point(130, 26);
            this.ListeYenileButton.Name = "ListeYenileButton";
            this.ListeYenileButton.Size = new System.Drawing.Size(155, 54);
            this.ListeYenileButton.TabIndex = 4;
            this.ListeYenileButton.Text = "Listeyi Yenile";
            this.ListeYenileButton.UseVisualStyleBackColor = true;
            this.ListeYenileButton.Click += new System.EventHandler(this.ListeYenileButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ListeYenileButton);
            this.groupBox3.Location = new System.Drawing.Point(792, 521);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(398, 87);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.BilgiGüncelleButton);
            this.groupBox5.Location = new System.Drawing.Point(792, 426);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(398, 102);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            // 
            // BilgiGüncelleButton
            // 
            this.BilgiGüncelleButton.Location = new System.Drawing.Point(6, 24);
            this.BilgiGüncelleButton.Name = "BilgiGüncelleButton";
            this.BilgiGüncelleButton.Size = new System.Drawing.Size(379, 54);
            this.BilgiGüncelleButton.TabIndex = 4;
            this.BilgiGüncelleButton.Text = "Seçili Personel Bilgi Güncelleme";
            this.BilgiGüncelleButton.UseVisualStyleBackColor = true;
            this.BilgiGüncelleButton.Click += new System.EventHandler(this.BilgiGüncelleButton_Click);
            // 
            // PersonelSorgulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 619);
            this.Controls.Add(this.PersonelAdText);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.PersonelTcText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PersonelSorgulama";
            this.Text = "PersonelSorgulama";
            this.Load += new System.EventHandler(this.PersonelSorgulama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PersonelPuanNumeric)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox PersonelTcText;
        private System.Windows.Forms.Button PersonelGörüntüleButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button PuanGüncelleButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown PersonelPuanNumeric;
        private System.Windows.Forms.Button ListeYenileButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button BilgiGüncelleButton;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.TextBox PersonelAdText;
    }
}