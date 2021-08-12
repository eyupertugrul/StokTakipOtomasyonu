
namespace StokTakipOtomasyonu
{
    partial class FormMarka
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
            this.BtnEkle = new System.Windows.Forms.Button();
            this.LblKategori = new System.Windows.Forms.Label();
            this.LblMarka = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BtnEkle
            // 
            this.BtnEkle.Location = new System.Drawing.Point(156, 128);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(75, 23);
            this.BtnEkle.TabIndex = 0;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.UseVisualStyleBackColor = true;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // LblKategori
            // 
            this.LblKategori.AutoSize = true;
            this.LblKategori.Location = new System.Drawing.Point(47, 45);
            this.LblKategori.Name = "LblKategori";
            this.LblKategori.Size = new System.Drawing.Size(46, 13);
            this.LblKategori.TabIndex = 1;
            this.LblKategori.Text = "Kategori";
            // 
            // LblMarka
            // 
            this.LblMarka.AutoSize = true;
            this.LblMarka.Location = new System.Drawing.Point(47, 82);
            this.LblMarka.Name = "LblMarka";
            this.LblMarka.Size = new System.Drawing.Size(37, 13);
            this.LblMarka.TabIndex = 2;
            this.LblMarka.Text = "Marka";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(110, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // FormMarka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(312, 202);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LblMarka);
            this.Controls.Add(this.LblKategori);
            this.Controls.Add(this.BtnEkle);
            this.Name = "FormMarka";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marka Sayfası";
            this.Load += new System.EventHandler(this.FormMarka_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.Label LblKategori;
        private System.Windows.Forms.Label LblMarka;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}