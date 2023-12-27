namespace WindowsFormsApplication1
{
    partial class giris
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
            this.KullanıcıAdıText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GirisButton = new System.Windows.Forms.Button();
            this.SifreText = new System.Windows.Forms.TextBox();
            this.Cikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(10, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // KullanıcıAdıText
            // 
            this.KullanıcıAdıText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KullanıcıAdıText.Location = new System.Drawing.Point(123, 79);
            this.KullanıcıAdıText.Margin = new System.Windows.Forms.Padding(4);
            this.KullanıcıAdıText.Name = "KullanıcıAdıText";
            this.KullanıcıAdıText.Size = new System.Drawing.Size(302, 27);
            this.KullanıcıAdıText.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(61, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre";
            // 
            // GirisButton
            // 
            this.GirisButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GirisButton.Location = new System.Drawing.Point(80, 188);
            this.GirisButton.Margin = new System.Windows.Forms.Padding(4);
            this.GirisButton.Name = "GirisButton";
            this.GirisButton.Size = new System.Drawing.Size(290, 47);
            this.GirisButton.TabIndex = 4;
            this.GirisButton.Text = "Giris Yap";
            this.GirisButton.UseVisualStyleBackColor = true;
            this.GirisButton.Click += new System.EventHandler(this.GirisButton_Click);
            this.GirisButton.Enter += new System.EventHandler(this.GirisButton_Click);
            // 
            // SifreText
            // 
            this.SifreText.Location = new System.Drawing.Point(123, 133);
            this.SifreText.Margin = new System.Windows.Forms.Padding(4);
            this.SifreText.Name = "SifreText";
            this.SifreText.Size = new System.Drawing.Size(300, 27);
            this.SifreText.TabIndex = 5;
            this.SifreText.UseSystemPasswordChar = true;
            // 
            // Cikis
            // 
            this.Cikis.Location = new System.Drawing.Point(446, 12);
            this.Cikis.Name = "Cikis";
            this.Cikis.Size = new System.Drawing.Size(34, 34);
            this.Cikis.TabIndex = 6;
            this.Cikis.Text = "X";
            this.Cikis.UseVisualStyleBackColor = true;
            this.Cikis.Click += new System.EventHandler(this.Cikis_Click);
            // 
            // giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 284);
            this.Controls.Add(this.Cikis);
            this.Controls.Add(this.SifreText);
            this.Controls.Add(this.GirisButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.KullanıcıAdıText);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "giris";
            this.Load += new System.EventHandler(this.giris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox KullanıcıAdıText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button GirisButton;
        private System.Windows.Forms.TextBox SifreText;
        private System.Windows.Forms.Button Cikis;
    }
}