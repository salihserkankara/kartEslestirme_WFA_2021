
namespace kart_eslestirme
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.flp1 = new System.Windows.Forms.FlowLayoutPanel();
            this.uc_dakika = new System.Windows.Forms.Timer(this.components);
            this.bir_saniye_tmr = new System.Windows.Forms.Timer(this.components);
            this.uc_dakika_lbl = new System.Windows.Forms.Label();
            this.dogru_mu_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flp1
            // 
            this.flp1.Location = new System.Drawing.Point(13, 13);
            this.flp1.Name = "flp1";
            this.flp1.Size = new System.Drawing.Size(640, 640);
            this.flp1.TabIndex = 0;
            // 
            // uc_dakika
            // 
            this.uc_dakika.Interval = 1000;
            this.uc_dakika.Tick += new System.EventHandler(this.uc_dakika_Tick);
            // 
            // bir_saniye_tmr
            // 
            this.bir_saniye_tmr.Interval = 1000;
            this.bir_saniye_tmr.Tick += new System.EventHandler(this.bir_saniye_tmr_Tick);
            // 
            // uc_dakika_lbl
            // 
            this.uc_dakika_lbl.AutoSize = true;
            this.uc_dakika_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uc_dakika_lbl.Location = new System.Drawing.Point(12, 656);
            this.uc_dakika_lbl.Name = "uc_dakika_lbl";
            this.uc_dakika_lbl.Size = new System.Drawing.Size(48, 25);
            this.uc_dakika_lbl.TabIndex = 1;
            this.uc_dakika_lbl.Text = "180";
            // 
            // dogru_mu_lbl
            // 
            this.dogru_mu_lbl.AutoSize = true;
            this.dogru_mu_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dogru_mu_lbl.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.dogru_mu_lbl.Location = new System.Drawing.Point(257, 656);
            this.dogru_mu_lbl.Name = "dogru_mu_lbl";
            this.dogru_mu_lbl.Size = new System.Drawing.Size(0, 25);
            this.dogru_mu_lbl.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(629, 656);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Webdings", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label2.Location = new System.Drawing.Point(592, 656);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "a";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 681);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dogru_mu_lbl);
            this.Controls.Add(this.uc_dakika_lbl);
            this.Controls.Add(this.flp1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flp1;
        private System.Windows.Forms.Timer uc_dakika;
        private System.Windows.Forms.Timer bir_saniye_tmr;
        private System.Windows.Forms.Label uc_dakika_lbl;
        private System.Windows.Forms.Label dogru_mu_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

