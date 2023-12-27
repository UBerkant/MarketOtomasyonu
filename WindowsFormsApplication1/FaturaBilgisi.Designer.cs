namespace WindowsFormsApplication1
{
    partial class FaturaBilgisi
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
            this.FaturaBilgisiData = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FaturaIDText = new System.Windows.Forms.TextBox();
            this.FaturaGörButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FaturaBilgisiData)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FaturaBilgisiData
            // 
            this.FaturaBilgisiData.AllowUserToAddRows = false;
            this.FaturaBilgisiData.AllowUserToDeleteRows = false;
            this.FaturaBilgisiData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FaturaBilgisiData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FaturaBilgisiData.Location = new System.Drawing.Point(316, 18);
            this.FaturaBilgisiData.Margin = new System.Windows.Forms.Padding(4);
            this.FaturaBilgisiData.Name = "FaturaBilgisiData";
            this.FaturaBilgisiData.ReadOnly = true;
            this.FaturaBilgisiData.Size = new System.Drawing.Size(909, 379);
            this.FaturaBilgisiData.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FaturaIDText);
            this.groupBox1.Controls.Add(this.FaturaGörButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(295, 130);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // FaturaIDText
            // 
            this.FaturaIDText.Location = new System.Drawing.Point(105, 27);
            this.FaturaIDText.Name = "FaturaIDText";
            this.FaturaIDText.Size = new System.Drawing.Size(183, 27);
            this.FaturaIDText.TabIndex = 2;
            // 
            // FaturaGörButton
            // 
            this.FaturaGörButton.Location = new System.Drawing.Point(91, 70);
            this.FaturaGörButton.Name = "FaturaGörButton";
            this.FaturaGörButton.Size = new System.Drawing.Size(197, 36);
            this.FaturaGörButton.TabIndex = 1;
            this.FaturaGörButton.Text = "Faturayı Görüntüle";
            this.FaturaGörButton.UseVisualStyleBackColor = true;
            this.FaturaGörButton.Click += new System.EventHandler(this.FaturaGörButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fatura ID";
            // 
            // FaturaBilgisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 410);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.FaturaBilgisiData);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FaturaBilgisi";
            this.Text = "FaturaBilgisi";
            ((System.ComponentModel.ISupportInitialize)(this.FaturaBilgisiData)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView FaturaBilgisiData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox FaturaIDText;
        private System.Windows.Forms.Button FaturaGörButton;
        private System.Windows.Forms.Label label1;
    }
}