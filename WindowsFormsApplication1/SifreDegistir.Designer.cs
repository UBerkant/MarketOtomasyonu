namespace WindowsFormsApplication1
{
    partial class SifreDegistir
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
            this.ŞifreDeğiştirButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.YeniŞifreText = new System.Windows.Forms.TextBox();
            this.YeniŞifreTekrarText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.KullanıcıAdLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ŞifreDeğiştirButton);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.YeniŞifreText);
            this.groupBox1.Controls.Add(this.YeniŞifreTekrarText);
            this.groupBox1.Location = new System.Drawing.Point(246, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(341, 149);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // ŞifreDeğiştirButton
            // 
            this.ŞifreDeğiştirButton.Location = new System.Drawing.Point(161, 93);
            this.ŞifreDeğiştirButton.Name = "ŞifreDeğiştirButton";
            this.ŞifreDeğiştirButton.Size = new System.Drawing.Size(140, 31);
            this.ŞifreDeğiştirButton.TabIndex = 1;
            this.ŞifreDeğiştirButton.Text = "Şifreyi Değiştir";
            this.ŞifreDeğiştirButton.UseVisualStyleBackColor = true;
            this.ŞifreDeğiştirButton.Click += new System.EventHandler(this.ŞifreDeğiştirButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tekrar Giriniz";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Yeni Şifre";
            // 
            // YeniŞifreText
            // 
            this.YeniŞifreText.Location = new System.Drawing.Point(108, 27);
            this.YeniŞifreText.Name = "YeniŞifreText";
            this.YeniŞifreText.Size = new System.Drawing.Size(193, 27);
            this.YeniŞifreText.TabIndex = 1;
            // 
            // YeniŞifreTekrarText
            // 
            this.YeniŞifreTekrarText.Location = new System.Drawing.Point(108, 60);
            this.YeniŞifreTekrarText.Name = "YeniŞifreTekrarText";
            this.YeniŞifreTekrarText.Size = new System.Drawing.Size(193, 27);
            this.YeniŞifreTekrarText.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "İşlem Yapılacak Kullanıcı Adı";
            // 
            // KullanıcıAdLabel
            // 
            this.KullanıcıAdLabel.AutoSize = true;
            this.KullanıcıAdLabel.Location = new System.Drawing.Point(67, 73);
            this.KullanıcıAdLabel.Name = "KullanıcıAdLabel";
            this.KullanıcıAdLabel.Size = new System.Drawing.Size(76, 19);
            this.KullanıcıAdLabel.TabIndex = 9;
            this.KullanıcıAdLabel.Text = "Kullanıcı : ";
            // 
            // SifreDegistir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 191);
            this.Controls.Add(this.KullanıcıAdLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SifreDegistir";
            this.Text = "SifreDegistir";
            this.Load += new System.EventHandler(this.SifreDegistir_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ŞifreDeğiştirButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox YeniŞifreText;
        private System.Windows.Forms.TextBox YeniŞifreTekrarText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label KullanıcıAdLabel;
    }
}