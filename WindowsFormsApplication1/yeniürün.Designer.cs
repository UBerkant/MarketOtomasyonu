namespace WindowsFormsApplication1
{
    partial class yeniürün
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
            this.ÜrünBilgiText = new System.Windows.Forms.TextBox();
            this.ÜrünEkleButton = new System.Windows.Forms.Button();
            this.ÜrünSatışFiyatText = new System.Windows.Forms.TextBox();
            this.ÜrünAdıText = new System.Windows.Forms.TextBox();
            this.BarkodText = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.ÇıkışButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ÜrünBilgiText
            // 
            this.ÜrünBilgiText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ÜrünBilgiText.Location = new System.Drawing.Point(709, 182);
            this.ÜrünBilgiText.Margin = new System.Windows.Forms.Padding(4);
            this.ÜrünBilgiText.Multiline = true;
            this.ÜrünBilgiText.Name = "ÜrünBilgiText";
            this.ÜrünBilgiText.Size = new System.Drawing.Size(563, 125);
            this.ÜrünBilgiText.TabIndex = 9;
            // 
            // ÜrünEkleButton
            // 
            this.ÜrünEkleButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ÜrünEkleButton.Location = new System.Drawing.Point(909, 328);
            this.ÜrünEkleButton.Margin = new System.Windows.Forms.Padding(4);
            this.ÜrünEkleButton.Name = "ÜrünEkleButton";
            this.ÜrünEkleButton.Size = new System.Drawing.Size(363, 180);
            this.ÜrünEkleButton.TabIndex = 8;
            this.ÜrünEkleButton.Text = "Ürünü Ekle";
            this.ÜrünEkleButton.UseVisualStyleBackColor = true;
            this.ÜrünEkleButton.Click += new System.EventHandler(this.ÜrünEkleButton_Click);
            // 
            // ÜrünSatışFiyatText
            // 
            this.ÜrünSatışFiyatText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ÜrünSatışFiyatText.Location = new System.Drawing.Point(709, 134);
            this.ÜrünSatışFiyatText.Margin = new System.Windows.Forms.Padding(4);
            this.ÜrünSatışFiyatText.Name = "ÜrünSatışFiyatText";
            this.ÜrünSatışFiyatText.Size = new System.Drawing.Size(351, 27);
            this.ÜrünSatışFiyatText.TabIndex = 12;
            // 
            // ÜrünAdıText
            // 
            this.ÜrünAdıText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ÜrünAdıText.Location = new System.Drawing.Point(709, 85);
            this.ÜrünAdıText.Margin = new System.Windows.Forms.Padding(4);
            this.ÜrünAdıText.Name = "ÜrünAdıText";
            this.ÜrünAdıText.Size = new System.Drawing.Size(351, 27);
            this.ÜrünAdıText.TabIndex = 11;
            // 
            // BarkodText
            // 
            this.BarkodText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BarkodText.Location = new System.Drawing.Point(709, 37);
            this.BarkodText.Margin = new System.Windows.Forms.Padding(4);
            this.BarkodText.Name = "BarkodText";
            this.BarkodText.Size = new System.Drawing.Size(351, 27);
            this.BarkodText.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(16, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(520, 490);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(16, 821);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(485, 27);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(601, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "Barkod No";
            // 
            // ÇıkışButton
            // 
            this.ÇıkışButton.Location = new System.Drawing.Point(1229, 18);
            this.ÇıkışButton.Margin = new System.Windows.Forms.Padding(4);
            this.ÇıkışButton.Name = "ÇıkışButton";
            this.ÇıkışButton.Size = new System.Drawing.Size(43, 56);
            this.ÇıkışButton.TabIndex = 16;
            this.ÇıkışButton.Text = "X";
            this.ÇıkışButton.UseVisualStyleBackColor = true;
            this.ÇıkışButton.Click += new System.EventHandler(this.ÇıkışButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(576, 186);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 19);
            this.label1.TabIndex = 17;
            this.label1.Text = "Ürün Bilgileri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(614, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Ürün Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(550, 138);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 19);
            this.label4.TabIndex = 19;
            this.label4.Text = "Ürün Satış Fiyatı";
            // 
            // yeniürün
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 548);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ÇıkışButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ÜrünSatışFiyatText);
            this.Controls.Add(this.ÜrünAdıText);
            this.Controls.Add(this.BarkodText);
            this.Controls.Add(this.ÜrünBilgiText);
            this.Controls.Add(this.ÜrünEkleButton);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "yeniürün";
            this.Text = "yeniürün";
            this.Load += new System.EventHandler(this.yeniürün_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ÜrünBilgiText;
        private System.Windows.Forms.Button ÜrünEkleButton;
        private System.Windows.Forms.TextBox ÜrünSatışFiyatText;
        private System.Windows.Forms.TextBox ÜrünAdıText;
        private System.Windows.Forms.TextBox BarkodText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ÇıkışButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}