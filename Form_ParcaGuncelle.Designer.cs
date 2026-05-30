namespace Stok_Program
{
    partial class Form_ParcaGuncelle
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
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtYeniAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtYeniFiyat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtYeniStok = new System.Windows.Forms.TextBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Barkod No:";
            // 
            // txtBarkod
            // 
            this.txtBarkod.Location = new System.Drawing.Point(203, 27);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(100, 22);
            this.txtBarkod.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Yeni Ürün Adı:";
            // 
            // txtYeniAd
            // 
            this.txtYeniAd.Location = new System.Drawing.Point(203, 80);
            this.txtYeniAd.Name = "txtYeniAd";
            this.txtYeniAd.Size = new System.Drawing.Size(100, 22);
            this.txtYeniAd.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Yeni Satış Fiyatı:";
            // 
            // txtYeniFiyat
            // 
            this.txtYeniFiyat.Location = new System.Drawing.Point(203, 139);
            this.txtYeniFiyat.Name = "txtYeniFiyat";
            this.txtYeniFiyat.Size = new System.Drawing.Size(100, 22);
            this.txtYeniFiyat.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Yeni Stok Miktarı:";
            // 
            // txtYeniStok
            // 
            this.txtYeniStok.Location = new System.Drawing.Point(203, 183);
            this.txtYeniStok.Name = "txtYeniStok";
            this.txtYeniStok.Size = new System.Drawing.Size(100, 22);
            this.txtYeniStok.TabIndex = 7;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnGuncelle.Location = new System.Drawing.Point(78, 255);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(150, 32);
            this.btnGuncelle.TabIndex = 8;
            this.btnGuncelle.Text = "Bilgileri Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // Form_ParcaGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.txtYeniStok);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtYeniFiyat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtYeniAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBarkod);
            this.Controls.Add(this.label1);
            this.Name = "Form_ParcaGuncelle";
            this.Text = "Form_ParcaGuncelle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtYeniAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtYeniFiyat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtYeniStok;
        private System.Windows.Forms.Button btnGuncelle;
    }
}