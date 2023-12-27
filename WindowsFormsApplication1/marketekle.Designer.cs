namespace WindowsFormsApplication1
{
    partial class marketekle
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
            this.MarketAdresiText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MarketAdıText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MarketEkleButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MarketMailUzantıCombo = new System.Windows.Forms.ComboBox();
            this.MarketILCombo = new System.Windows.Forms.ComboBox();
            this.MarketILceCombo = new System.Windows.Forms.ComboBox();
            this.MarketTelText = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.MarketVergiText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MarketMail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MarketAdresiText
            // 
            this.MarketAdresiText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MarketAdresiText.Location = new System.Drawing.Point(142, 257);
            this.MarketAdresiText.Margin = new System.Windows.Forms.Padding(4);
            this.MarketAdresiText.Multiline = true;
            this.MarketAdresiText.Name = "MarketAdresiText";
            this.MarketAdresiText.Size = new System.Drawing.Size(780, 130);
            this.MarketAdresiText.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(35, 260);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Market Adresi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(2, 182);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Market Mail Adresi";
            // 
            // MarketAdıText
            // 
            this.MarketAdıText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MarketAdıText.Location = new System.Drawing.Point(142, 27);
            this.MarketAdıText.Margin = new System.Windows.Forms.Padding(4);
            this.MarketAdıText.Name = "MarketAdıText";
            this.MarketAdıText.Size = new System.Drawing.Size(351, 27);
            this.MarketAdıText.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 144);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Market Telefon No";
            // 
            // MarketEkleButton
            // 
            this.MarketEkleButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MarketEkleButton.Location = new System.Drawing.Point(7, 18);
            this.MarketEkleButton.Margin = new System.Windows.Forms.Padding(4);
            this.MarketEkleButton.Name = "MarketEkleButton";
            this.MarketEkleButton.Size = new System.Drawing.Size(207, 105);
            this.MarketEkleButton.TabIndex = 8;
            this.MarketEkleButton.Text = "Marketi Sisteme Ekle";
            this.MarketEkleButton.UseVisualStyleBackColor = true;
            this.MarketEkleButton.Click += new System.EventHandler(this.MarketEkleButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MarketMailUzantıCombo);
            this.groupBox1.Controls.Add(this.MarketILCombo);
            this.groupBox1.Controls.Add(this.MarketILceCombo);
            this.groupBox1.Controls.Add(this.MarketTelText);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.MarketVergiText);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.MarketMail);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.MarketAdresiText);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.MarketAdıText);
            this.groupBox1.Location = new System.Drawing.Point(16, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(940, 412);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // MarketMailUzantıCombo
            // 
            this.MarketMailUzantıCombo.FormattingEnabled = true;
            this.MarketMailUzantıCombo.Location = new System.Drawing.Point(308, 179);
            this.MarketMailUzantıCombo.Name = "MarketMailUzantıCombo";
            this.MarketMailUzantıCombo.Size = new System.Drawing.Size(191, 27);
            this.MarketMailUzantıCombo.TabIndex = 23;
            // 
            // MarketILCombo
            // 
            this.MarketILCombo.FormattingEnabled = true;
            this.MarketILCombo.Location = new System.Drawing.Point(142, 65);
            this.MarketILCombo.Name = "MarketILCombo";
            this.MarketILCombo.Size = new System.Drawing.Size(159, 27);
            this.MarketILCombo.TabIndex = 16;
            this.MarketILCombo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // MarketILceCombo
            // 
            this.MarketILceCombo.FormattingEnabled = true;
            this.MarketILceCombo.Location = new System.Drawing.Point(142, 103);
            this.MarketILceCombo.Name = "MarketILceCombo";
            this.MarketILceCombo.Size = new System.Drawing.Size(159, 27);
            this.MarketILceCombo.TabIndex = 17;
            // 
            // MarketTelText
            // 
            this.MarketTelText.Location = new System.Drawing.Point(142, 141);
            this.MarketTelText.Mask = "0000000000";
            this.MarketTelText.Name = "MarketTelText";
            this.MarketTelText.Size = new System.Drawing.Size(108, 27);
            this.MarketTelText.TabIndex = 22;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.MarketEkleButton);
            this.groupBox2.Location = new System.Drawing.Point(617, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(221, 130);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(21, 222);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 19);
            this.label8.TabIndex = 21;
            this.label8.Text = "Market Vergi No";
            // 
            // MarketVergiText
            // 
            this.MarketVergiText.Location = new System.Drawing.Point(142, 219);
            this.MarketVergiText.Name = "MarketVergiText";
            this.MarketVergiText.Size = new System.Drawing.Size(357, 27);
            this.MarketVergiText.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(42, 106);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 19);
            this.label6.TabIndex = 18;
            this.label6.Text = "Market İlçesi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(64, 68);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "Market İli";
            // 
            // MarketMail
            // 
            this.MarketMail.Location = new System.Drawing.Point(142, 179);
            this.MarketMail.Margin = new System.Windows.Forms.Padding(4);
            this.MarketMail.Name = "MarketMail";
            this.MarketMail.Size = new System.Drawing.Size(159, 27);
            this.MarketMail.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(61, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "Market Adı";
            // 
            // marketekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 452);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "marketekle";
            this.Text = "marketekle";
            this.Load += new System.EventHandler(this.marketekle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox MarketAdresiText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MarketAdıText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button MarketEkleButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox MarketVergiText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox MarketMail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox MarketTelText;
        private System.Windows.Forms.ComboBox MarketILCombo;
        private System.Windows.Forms.ComboBox MarketILceCombo;
        private System.Windows.Forms.ComboBox MarketMailUzantıCombo;
    }
}