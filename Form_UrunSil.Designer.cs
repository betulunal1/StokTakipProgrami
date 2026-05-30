namespace Stok_Program
{
    partial class Form_UrunSil
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
            this.txtSilBarkod = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Silinecek Ürünün Barkod No:";
            // 
            // txtSilBarkod
            // 
            this.txtSilBarkod.Location = new System.Drawing.Point(438, 150);
            this.txtSilBarkod.Name = "txtSilBarkod";
            this.txtSilBarkod.Size = new System.Drawing.Size(100, 22);
            this.txtSilBarkod.TabIndex = 1;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(279, 226);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(214, 50);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Ürünü Sistemden Tamamen Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // Form_UrunSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.txtSilBarkod);
            this.Controls.Add(this.label1);
            this.Name = "Form_UrunSil";
            this.Text = "Form_UrunSil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSilBarkod;
        private System.Windows.Forms.Button btnSil;
    }
}