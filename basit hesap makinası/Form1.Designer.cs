namespace basit_hesap_makinası
{
    partial class Form1
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
            this.txtSayi1 = new System.Windows.Forms.TextBox();
            this.txtSayi2 = new System.Windows.Forms.TextBox();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.btnArtı = new System.Windows.Forms.Button();
            this.btnCıkar = new System.Windows.Forms.Button();
            this.btnbolme = new System.Windows.Forms.Button();
            this.btnCarp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSayi1
            // 
            this.txtSayi1.Location = new System.Drawing.Point(203, 65);
            this.txtSayi1.Name = "txtSayi1";
            this.txtSayi1.Size = new System.Drawing.Size(100, 20);
            this.txtSayi1.TabIndex = 0;
            this.txtSayi1.TextChanged += new System.EventHandler(this.txt1_TextChanged);
            // 
            // txtSayi2
            // 
            this.txtSayi2.Location = new System.Drawing.Point(354, 65);
            this.txtSayi2.Name = "txtSayi2";
            this.txtSayi2.Size = new System.Drawing.Size(100, 20);
            this.txtSayi2.TabIndex = 1;
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(203, 127);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(38, 13);
            this.lblSonuc.TabIndex = 2;
            this.lblSonuc.Text = "Sonuc";
            // 
            // btnArtı
            // 
            this.btnArtı.Location = new System.Drawing.Point(206, 180);
            this.btnArtı.Name = "btnArtı";
            this.btnArtı.Size = new System.Drawing.Size(75, 23);
            this.btnArtı.TabIndex = 3;
            this.btnArtı.Text = "+";
            this.btnArtı.UseVisualStyleBackColor = true;
            this.btnArtı.Click += new System.EventHandler(this.btnArtı_Click);
            // 
            // btnCıkar
            // 
            this.btnCıkar.Location = new System.Drawing.Point(354, 270);
            this.btnCıkar.Name = "btnCıkar";
            this.btnCıkar.Size = new System.Drawing.Size(75, 23);
            this.btnCıkar.TabIndex = 4;
            this.btnCıkar.Text = "-";
            this.btnCıkar.UseVisualStyleBackColor = true;
            this.btnCıkar.Click += new System.EventHandler(this.btnCıkar_Click);
            // 
            // btnbolme
            // 
            this.btnbolme.Location = new System.Drawing.Point(354, 185);
            this.btnbolme.Name = "btnbolme";
            this.btnbolme.Size = new System.Drawing.Size(75, 23);
            this.btnbolme.TabIndex = 5;
            this.btnbolme.Text = "\\";
            this.btnbolme.UseVisualStyleBackColor = true;
            this.btnbolme.Click += new System.EventHandler(this.btnEksi_Click);
            // 
            // btnCarp
            // 
            this.btnCarp.Location = new System.Drawing.Point(206, 270);
            this.btnCarp.Name = "btnCarp";
            this.btnCarp.Size = new System.Drawing.Size(75, 26);
            this.btnCarp.TabIndex = 6;
            this.btnCarp.Text = "*";
            this.btnCarp.UseVisualStyleBackColor = true;
            this.btnCarp.Click += new System.EventHandler(this.btnCarp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCarp);
            this.Controls.Add(this.btnbolme);
            this.Controls.Add(this.btnCıkar);
            this.Controls.Add(this.btnArtı);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.txtSayi2);
            this.Controls.Add(this.txtSayi1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSayi1;
        private System.Windows.Forms.TextBox txtSayi2;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Button btnArtı;
        private System.Windows.Forms.Button btnCıkar;
        private System.Windows.Forms.Button btnbolme;
        private System.Windows.Forms.Button btnCarp;
    }
}

