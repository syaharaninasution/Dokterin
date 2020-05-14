namespace UAS_PBO
{
    partial class Periksa
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
            this.lblNama = new System.Windows.Forms.Label();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.lblUsia = new System.Windows.Forms.Label();
            this.tbUsia = new System.Windows.Forms.TextBox();
            this.btnDeteksi = new System.Windows.Forms.Button();
            this.lblJudul = new System.Windows.Forms.Label();
            this.lblGejala = new System.Windows.Forms.Label();
            this.cbNafsu = new System.Windows.Forms.CheckBox();
            this.cbDemam = new System.Windows.Forms.CheckBox();
            this.cbBatuk = new System.Windows.Forms.CheckBox();
            this.cbDiare = new System.Windows.Forms.CheckBox();
            this.cbPusing = new System.Windows.Forms.CheckBox();
            this.cbMual = new System.Windows.Forms.CheckBox();
            this.cbLemas = new System.Windows.Forms.CheckBox();
            this.cbPenurunanBB = new System.Windows.Forms.CheckBox();
            this.cbMuntah = new System.Windows.Forms.CheckBox();
            this.tbHasil = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbDiseaseDetector = new System.Windows.Forms.PictureBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDiseaseDetector)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNama.Location = new System.Drawing.Point(22, 72);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(40, 14);
            this.lblNama.TabIndex = 0;
            this.lblNama.Text = "Nama";
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(97, 72);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(100, 20);
            this.tbNama.TabIndex = 1;
            // 
            // lblUsia
            // 
            this.lblUsia.AutoSize = true;
            this.lblUsia.BackColor = System.Drawing.Color.Goldenrod;
            this.lblUsia.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsia.Location = new System.Drawing.Point(22, 114);
            this.lblUsia.Name = "lblUsia";
            this.lblUsia.Size = new System.Drawing.Size(31, 14);
            this.lblUsia.TabIndex = 2;
            this.lblUsia.Text = "Usia";
            // 
            // tbUsia
            // 
            this.tbUsia.Location = new System.Drawing.Point(97, 112);
            this.tbUsia.Name = "tbUsia";
            this.tbUsia.Size = new System.Drawing.Size(100, 20);
            this.tbUsia.TabIndex = 3;
            // 
            // btnDeteksi
            // 
            this.btnDeteksi.BackColor = System.Drawing.Color.LightGreen;
            this.btnDeteksi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeteksi.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeteksi.Location = new System.Drawing.Point(150, 303);
            this.btnDeteksi.Name = "btnDeteksi";
            this.btnDeteksi.Size = new System.Drawing.Size(75, 28);
            this.btnDeteksi.TabIndex = 11;
            this.btnDeteksi.Text = "DETEKSI";
            this.btnDeteksi.UseVisualStyleBackColor = false;
            this.btnDeteksi.Click += new System.EventHandler(this.btnDeteksi_Click);
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.BackColor = System.Drawing.Color.Goldenrod;
            this.lblJudul.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudul.ForeColor = System.Drawing.Color.White;
            this.lblJudul.Location = new System.Drawing.Point(19, 29);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(190, 25);
            this.lblJudul.TabIndex = 12;
            this.lblJudul.Text = "Disease Detector";
            // 
            // lblGejala
            // 
            this.lblGejala.AutoSize = true;
            this.lblGejala.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGejala.Location = new System.Drawing.Point(21, 151);
            this.lblGejala.Name = "lblGejala";
            this.lblGejala.Size = new System.Drawing.Size(337, 14);
            this.lblGejala.TabIndex = 13;
            this.lblGejala.Text = "Pilih 2 atau lebih gejala yang Anda rasakan sekarang :";
            // 
            // cbNafsu
            // 
            this.cbNafsu.AutoSize = true;
            this.cbNafsu.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNafsu.Location = new System.Drawing.Point(25, 192);
            this.cbNafsu.Name = "cbNafsu";
            this.cbNafsu.Size = new System.Drawing.Size(88, 30);
            this.cbNafsu.TabIndex = 18;
            this.cbNafsu.Text = "Nafsu makan\r\nberkurang";
            this.cbNafsu.UseVisualStyleBackColor = true;
            // 
            // cbDemam
            // 
            this.cbDemam.AutoSize = true;
            this.cbDemam.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDemam.Location = new System.Drawing.Point(25, 233);
            this.cbDemam.Name = "cbDemam";
            this.cbDemam.Size = new System.Drawing.Size(61, 17);
            this.cbDemam.TabIndex = 19;
            this.cbDemam.Text = "Demam";
            this.cbDemam.UseVisualStyleBackColor = true;
            // 
            // cbBatuk
            // 
            this.cbBatuk.AutoSize = true;
            this.cbBatuk.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBatuk.Location = new System.Drawing.Point(25, 268);
            this.cbBatuk.Name = "cbBatuk";
            this.cbBatuk.Size = new System.Drawing.Size(53, 17);
            this.cbBatuk.TabIndex = 20;
            this.cbBatuk.Text = "Batuk";
            this.cbBatuk.UseVisualStyleBackColor = true;
            // 
            // cbDiare
            // 
            this.cbDiare.AutoSize = true;
            this.cbDiare.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDiare.Location = new System.Drawing.Point(150, 199);
            this.cbDiare.Name = "cbDiare";
            this.cbDiare.Size = new System.Drawing.Size(51, 17);
            this.cbDiare.TabIndex = 21;
            this.cbDiare.Text = "Diare";
            this.cbDiare.UseVisualStyleBackColor = true;
            // 
            // cbPusing
            // 
            this.cbPusing.AutoSize = true;
            this.cbPusing.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPusing.Location = new System.Drawing.Point(150, 233);
            this.cbPusing.Name = "cbPusing";
            this.cbPusing.Size = new System.Drawing.Size(57, 17);
            this.cbPusing.TabIndex = 22;
            this.cbPusing.Text = "Pusing";
            this.cbPusing.UseVisualStyleBackColor = true;
            // 
            // cbMual
            // 
            this.cbMual.AutoSize = true;
            this.cbMual.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMual.Location = new System.Drawing.Point(150, 268);
            this.cbMual.Name = "cbMual";
            this.cbMual.Size = new System.Drawing.Size(48, 17);
            this.cbMual.TabIndex = 23;
            this.cbMual.Text = "Mual";
            this.cbMual.UseVisualStyleBackColor = true;
            // 
            // cbLemas
            // 
            this.cbLemas.AutoSize = true;
            this.cbLemas.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLemas.Location = new System.Drawing.Point(275, 199);
            this.cbLemas.Name = "cbLemas";
            this.cbLemas.Size = new System.Drawing.Size(56, 17);
            this.cbLemas.TabIndex = 24;
            this.cbLemas.Text = "Lemas";
            this.cbLemas.UseVisualStyleBackColor = true;
            // 
            // cbPenurunanBB
            // 
            this.cbPenurunanBB.AutoSize = true;
            this.cbPenurunanBB.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPenurunanBB.Location = new System.Drawing.Point(275, 226);
            this.cbPenurunanBB.Name = "cbPenurunanBB";
            this.cbPenurunanBB.Size = new System.Drawing.Size(107, 30);
            this.cbPenurunanBB.TabIndex = 25;
            this.cbPenurunanBB.Text = "Penurunan Berat\r\nBadan Signifikan";
            this.cbPenurunanBB.UseVisualStyleBackColor = true;
            // 
            // cbMuntah
            // 
            this.cbMuntah.AutoSize = true;
            this.cbMuntah.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMuntah.Location = new System.Drawing.Point(275, 268);
            this.cbMuntah.Name = "cbMuntah";
            this.cbMuntah.Size = new System.Drawing.Size(102, 17);
            this.cbMuntah.TabIndex = 26;
            this.cbMuntah.Text = "Muntah-muntah";
            this.cbMuntah.UseVisualStyleBackColor = true;
            // 
            // tbHasil
            // 
            this.tbHasil.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHasil.Location = new System.Drawing.Point(17, 340);
            this.tbHasil.Multiline = true;
            this.tbHasil.Name = "tbHasil";
            this.tbHasil.Size = new System.Drawing.Size(360, 98);
            this.tbHasil.TabIndex = 27;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Goldenrod;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::UAS_PBO.Properties.Resources.close2;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pbDiseaseDetector
            // 
            this.pbDiseaseDetector.Image = global::UAS_PBO.Properties.Resources.doctor;
            this.pbDiseaseDetector.Location = new System.Drawing.Point(274, 6);
            this.pbDiseaseDetector.Name = "pbDiseaseDetector";
            this.pbDiseaseDetector.Size = new System.Drawing.Size(110, 109);
            this.pbDiseaseDetector.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDiseaseDetector.TabIndex = 17;
            this.pbDiseaseDetector.TabStop = false;
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.LightGreen;
            this.btnSimpan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSimpan.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.Location = new System.Drawing.Point(292, 402);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 27);
            this.btnSimpan.TabIndex = 29;
            this.btnSimpan.Text = "SIMPAN";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // Periksa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(396, 450);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbHasil);
            this.Controls.Add(this.cbMuntah);
            this.Controls.Add(this.cbPenurunanBB);
            this.Controls.Add(this.cbLemas);
            this.Controls.Add(this.cbMual);
            this.Controls.Add(this.cbPusing);
            this.Controls.Add(this.cbDiare);
            this.Controls.Add(this.cbBatuk);
            this.Controls.Add(this.cbDemam);
            this.Controls.Add(this.cbNafsu);
            this.Controls.Add(this.pbDiseaseDetector);
            this.Controls.Add(this.lblGejala);
            this.Controls.Add(this.lblJudul);
            this.Controls.Add(this.btnDeteksi);
            this.Controls.Add(this.tbUsia);
            this.Controls.Add(this.lblUsia);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.lblNama);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Periksa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Periksa";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDiseaseDetector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.Label lblUsia;
        private System.Windows.Forms.TextBox tbUsia;
        private System.Windows.Forms.Button btnDeteksi;
        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Label lblGejala;
        private System.Windows.Forms.PictureBox pbDiseaseDetector;
        private System.Windows.Forms.CheckBox cbNafsu;
        private System.Windows.Forms.CheckBox cbDemam;
        private System.Windows.Forms.CheckBox cbBatuk;
        private System.Windows.Forms.CheckBox cbDiare;
        private System.Windows.Forms.CheckBox cbPusing;
        private System.Windows.Forms.CheckBox cbMual;
        private System.Windows.Forms.CheckBox cbLemas;
        private System.Windows.Forms.CheckBox cbPenurunanBB;
        private System.Windows.Forms.CheckBox cbMuntah;
        private System.Windows.Forms.TextBox tbHasil;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSimpan;
    }
}