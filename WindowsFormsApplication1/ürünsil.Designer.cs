namespace WindowsFormsApplication1
{
    partial class ürünsil
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
            this.label3 = new System.Windows.Forms.Label();
            this.BarkodText = new System.Windows.Forms.TextBox();
            this.ÜrünSilButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(8, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Barkod No";
            // 
            // BarkodText
            // 
            this.BarkodText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BarkodText.Location = new System.Drawing.Point(130, 12);
            this.BarkodText.Name = "BarkodText";
            this.BarkodText.Size = new System.Drawing.Size(264, 27);
            this.BarkodText.TabIndex = 9;
            // 
            // ÜrünSilButton
            // 
            this.ÜrünSilButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ÜrünSilButton.Location = new System.Drawing.Point(458, 12);
            this.ÜrünSilButton.Name = "ÜrünSilButton";
            this.ÜrünSilButton.Size = new System.Drawing.Size(152, 50);
            this.ÜrünSilButton.TabIndex = 6;
            this.ÜrünSilButton.Text = "Ürünü Sil";
            this.ÜrünSilButton.UseVisualStyleBackColor = true;
            this.ÜrünSilButton.Click += new System.EventHandler(this.ÜrünSilButton_Click);
            // 
            // ürünsil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 80);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BarkodText);
            this.Controls.Add(this.ÜrünSilButton);
            this.Name = "ürünsil";
            this.Text = "ürünsil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox BarkodText;
        private System.Windows.Forms.Button ÜrünSilButton;
    }
}