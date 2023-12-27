namespace WindowsFormsApplication1
{
    partial class Market
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
            this.label1 = new System.Windows.Forms.Label();
            this.MarketIdText = new System.Windows.Forms.TextBox();
            this.MarketSorgulaButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ListeYenileButton = new System.Windows.Forms.Button();
            this.MarketSilButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MarketIdText2 = new System.Windows.Forms.TextBox();
            this.MarketVergiNumarasıText = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(965, 600);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.MarketIdText);
            this.groupBox1.Controls.Add(this.MarketSorgulaButton);
            this.groupBox1.Location = new System.Drawing.Point(986, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(463, 176);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sorgulama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Market ID";
            // 
            // MarketIdText
            // 
            this.MarketIdText.Location = new System.Drawing.Point(170, 40);
            this.MarketIdText.Name = "MarketIdText";
            this.MarketIdText.Size = new System.Drawing.Size(249, 27);
            this.MarketIdText.TabIndex = 4;
            // 
            // MarketSorgulaButton
            // 
            this.MarketSorgulaButton.Location = new System.Drawing.Point(8, 96);
            this.MarketSorgulaButton.Margin = new System.Windows.Forms.Padding(4);
            this.MarketSorgulaButton.Name = "MarketSorgulaButton";
            this.MarketSorgulaButton.Size = new System.Drawing.Size(443, 54);
            this.MarketSorgulaButton.TabIndex = 0;
            this.MarketSorgulaButton.Text = "Sorgula";
            this.MarketSorgulaButton.UseVisualStyleBackColor = true;
            this.MarketSorgulaButton.Click += new System.EventHandler(this.MarketSorgulaButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ListeYenileButton);
            this.groupBox3.Location = new System.Drawing.Point(986, 509);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(459, 104);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // ListeYenileButton
            // 
            this.ListeYenileButton.Location = new System.Drawing.Point(7, 27);
            this.ListeYenileButton.Name = "ListeYenileButton";
            this.ListeYenileButton.Size = new System.Drawing.Size(445, 59);
            this.ListeYenileButton.TabIndex = 2;
            this.ListeYenileButton.Text = "Listeyi Yenile";
            this.ListeYenileButton.UseVisualStyleBackColor = true;
            this.ListeYenileButton.Click += new System.EventHandler(this.ListeYenileButton_Click);
            // 
            // MarketSilButton
            // 
            this.MarketSilButton.Location = new System.Drawing.Point(7, 103);
            this.MarketSilButton.Margin = new System.Windows.Forms.Padding(4);
            this.MarketSilButton.Name = "MarketSilButton";
            this.MarketSilButton.Size = new System.Drawing.Size(443, 34);
            this.MarketSilButton.TabIndex = 1;
            this.MarketSilButton.Text = "Marketi Sil";
            this.MarketSilButton.UseVisualStyleBackColor = true;
            this.MarketSilButton.Click += new System.EventHandler(this.MarketSilButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Market ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Market Vergi Numarası";
            // 
            // MarketIdText2
            // 
            this.MarketIdText2.Location = new System.Drawing.Point(169, 28);
            this.MarketIdText2.Name = "MarketIdText2";
            this.MarketIdText2.Size = new System.Drawing.Size(281, 27);
            this.MarketIdText2.TabIndex = 4;
            // 
            // MarketVergiNumarasıText
            // 
            this.MarketVergiNumarasıText.Location = new System.Drawing.Point(170, 63);
            this.MarketVergiNumarasıText.Name = "MarketVergiNumarasıText";
            this.MarketVergiNumarasıText.Size = new System.Drawing.Size(282, 27);
            this.MarketVergiNumarasıText.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.MarketVergiNumarasıText);
            this.groupBox2.Controls.Add(this.MarketIdText2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.MarketSilButton);
            this.groupBox2.Location = new System.Drawing.Point(986, 197);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(459, 160);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Marketi Sil / Kaldır";
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(986, 364);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(459, 138);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            // 
            // Market
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1462, 629);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Market";
            this.Text = "Market";
            this.Load += new System.EventHandler(this.Market_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button MarketSorgulaButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button ListeYenileButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MarketIdText;
        private System.Windows.Forms.Button MarketSilButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MarketIdText2;
        private System.Windows.Forms.TextBox MarketVergiNumarasıText;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}