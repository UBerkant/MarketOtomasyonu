namespace WindowsFormsApplication1
{
    partial class urunsiparis
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
            this.BarkodText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ÜrünAlButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ÜrünAlışFiyatıText = new System.Windows.Forms.TextBox();
            this.ÜrünAdetText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BarkodText
            // 
            this.BarkodText.Location = new System.Drawing.Point(167, 22);
            this.BarkodText.Margin = new System.Windows.Forms.Padding(4);
            this.BarkodText.Name = "BarkodText";
            this.BarkodText.Size = new System.Drawing.Size(132, 27);
            this.BarkodText.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Barkod No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 92);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Adet Sayısı";
            // 
            // ÜrünAlButton
            // 
            this.ÜrünAlButton.Location = new System.Drawing.Point(93, 133);
            this.ÜrünAlButton.Name = "ÜrünAlButton";
            this.ÜrünAlButton.Size = new System.Drawing.Size(206, 49);
            this.ÜrünAlButton.TabIndex = 6;
            this.ÜrünAlButton.Text = "Ürünü Sipariş Ver";
            this.ÜrünAlButton.UseVisualStyleBackColor = true;
            this.ÜrünAlButton.Click += new System.EventHandler(this.ÜrünAlButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 59);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ürün Adet Alış Fiyatı";
            // 
            // ÜrünAlışFiyatıText
            // 
            this.ÜrünAlışFiyatıText.Location = new System.Drawing.Point(167, 56);
            this.ÜrünAlışFiyatıText.Name = "ÜrünAlışFiyatıText";
            this.ÜrünAlışFiyatıText.Size = new System.Drawing.Size(132, 27);
            this.ÜrünAlışFiyatıText.TabIndex = 9;
            // 
            // ÜrünAdetText
            // 
            this.ÜrünAdetText.Location = new System.Drawing.Point(167, 89);
            this.ÜrünAdetText.Name = "ÜrünAdetText";
            this.ÜrünAdetText.Size = new System.Drawing.Size(132, 27);
            this.ÜrünAdetText.TabIndex = 12;
            // 
            // urunsiparis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 207);
            this.Controls.Add(this.ÜrünAdetText);
            this.Controls.Add(this.ÜrünAlışFiyatıText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ÜrünAlButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BarkodText);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "urunsiparis";
            this.Text = "urunsiparis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox BarkodText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ÜrünAlButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ÜrünAlışFiyatıText;
        private System.Windows.Forms.TextBox ÜrünAdetText;
    }
}