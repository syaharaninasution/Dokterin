namespace UAS_PBO
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
            this.lblJudul = new System.Windows.Forms.Label();
            this.btnPeriksa = new System.Windows.Forms.Button();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.lblSelamatDatang = new System.Windows.Forms.Label();
            this.btnRiwayat = new System.Windows.Forms.Button();
            this.pbHati = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbHati)).BeginInit();
            this.SuspendLayout();
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudul.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblJudul.Location = new System.Drawing.Point(106, 58);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(103, 25);
            this.lblJudul.TabIndex = 0;
            this.lblJudul.Text = "Dokterin";
            // 
            // btnPeriksa
            // 
            this.btnPeriksa.BackColor = System.Drawing.Color.LightCoral;
            this.btnPeriksa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPeriksa.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeriksa.ForeColor = System.Drawing.Color.Maroon;
            this.btnPeriksa.Location = new System.Drawing.Point(99, 227);
            this.btnPeriksa.Name = "btnPeriksa";
            this.btnPeriksa.Size = new System.Drawing.Size(180, 37);
            this.btnPeriksa.TabIndex = 1;
            this.btnPeriksa.Text = "Periksa";
            this.btnPeriksa.UseVisualStyleBackColor = false;
            this.btnPeriksa.Click += new System.EventHandler(this.btnPeriksa_Click);
            // 
            // btnKeluar
            // 
            this.btnKeluar.BackColor = System.Drawing.Color.LightCoral;
            this.btnKeluar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKeluar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeluar.ForeColor = System.Drawing.Color.Maroon;
            this.btnKeluar.Location = new System.Drawing.Point(12, 386);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(75, 34);
            this.btnKeluar.TabIndex = 3;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.UseVisualStyleBackColor = false;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // lblSelamatDatang
            // 
            this.lblSelamatDatang.AutoSize = true;
            this.lblSelamatDatang.BackColor = System.Drawing.Color.Firebrick;
            this.lblSelamatDatang.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelamatDatang.ForeColor = System.Drawing.Color.Coral;
            this.lblSelamatDatang.Location = new System.Drawing.Point(12, 138);
            this.lblSelamatDatang.Name = "lblSelamatDatang";
            this.lblSelamatDatang.Size = new System.Drawing.Size(342, 46);
            this.lblSelamatDatang.TabIndex = 6;
            this.lblSelamatDatang.Text = "        Selamat Datang di Dokterin\r\n   Silahkan Pilih Menu di Bawah Ini\r\n";
            // 
            // btnRiwayat
            // 
            this.btnRiwayat.BackColor = System.Drawing.Color.LightCoral;
            this.btnRiwayat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRiwayat.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRiwayat.ForeColor = System.Drawing.Color.Maroon;
            this.btnRiwayat.Location = new System.Drawing.Point(99, 283);
            this.btnRiwayat.Name = "btnRiwayat";
            this.btnRiwayat.Size = new System.Drawing.Size(180, 37);
            this.btnRiwayat.TabIndex = 7;
            this.btnRiwayat.Text = "Riwayat Periksa";
            this.btnRiwayat.UseVisualStyleBackColor = false;
            this.btnRiwayat.Click += new System.EventHandler(this.btnRiwayat_Click);
            // 
            // pbHati
            // 
            this.pbHati.BackColor = System.Drawing.Color.Transparent;
            this.pbHati.Image = global::UAS_PBO.Properties.Resources.png_file_name_health_600__2_;
            this.pbHati.Location = new System.Drawing.Point(215, 39);
            this.pbHati.Name = "pbHati";
            this.pbHati.Size = new System.Drawing.Size(64, 64);
            this.pbHati.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHati.TabIndex = 5;
            this.pbHati.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(396, 450);
            this.Controls.Add(this.btnRiwayat);
            this.Controls.Add(this.lblSelamatDatang);
            this.Controls.Add(this.pbHati);
            this.Controls.Add(this.btnKeluar);
            this.Controls.Add(this.btnPeriksa);
            this.Controls.Add(this.lblJudul);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbHati)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Button btnPeriksa;
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.PictureBox pbHati;
        private System.Windows.Forms.Label lblSelamatDatang;
        private System.Windows.Forms.Button btnRiwayat;
    }
}

