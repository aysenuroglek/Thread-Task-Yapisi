namespace ThreadYapısı
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
            this.txt_VeriGirdi = new System.Windows.Forms.TextBox();
            this.btn_baslat = new System.Windows.Forms.Button();
            this.btn_verigonder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_VeriGirdi
            // 
            this.txt_VeriGirdi.Location = new System.Drawing.Point(21, 28);
            this.txt_VeriGirdi.Multiline = true;
            this.txt_VeriGirdi.Name = "txt_VeriGirdi";
            this.txt_VeriGirdi.Size = new System.Drawing.Size(387, 270);
            this.txt_VeriGirdi.TabIndex = 0;
            // 
            // btn_baslat
            // 
            this.btn_baslat.Location = new System.Drawing.Point(536, 73);
            this.btn_baslat.Name = "btn_baslat";
            this.btn_baslat.Size = new System.Drawing.Size(75, 23);
            this.btn_baslat.TabIndex = 1;
            this.btn_baslat.Text = "Başlat";
            this.btn_baslat.UseVisualStyleBackColor = true;
            this.btn_baslat.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_verigonder
            // 
            this.btn_verigonder.Location = new System.Drawing.Point(548, 157);
            this.btn_verigonder.Name = "btn_verigonder";
            this.btn_verigonder.Size = new System.Drawing.Size(75, 23);
            this.btn_verigonder.TabIndex = 2;
            this.btn_verigonder.Text = "Veri Gönder";
            this.btn_verigonder.UseVisualStyleBackColor = true;
            this.btn_verigonder.Click += new System.EventHandler(this.btn_verigonder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_verigonder);
            this.Controls.Add(this.btn_baslat);
            this.Controls.Add(this.txt_VeriGirdi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_VeriGirdi;
        private System.Windows.Forms.Button btn_baslat;
        private System.Windows.Forms.Button btn_verigonder;
    }
}

