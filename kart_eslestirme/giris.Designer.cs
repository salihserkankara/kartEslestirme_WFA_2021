﻿
namespace kart_eslestirme
{
    partial class giris
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
            this.basla_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // basla_btn
            // 
            this.basla_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.basla_btn.Location = new System.Drawing.Point(12, 12);
            this.basla_btn.Name = "basla_btn";
            this.basla_btn.Size = new System.Drawing.Size(600, 417);
            this.basla_btn.TabIndex = 0;
            this.basla_btn.Text = "BAŞLAMAK İÇİN TIKLAYINIZ";
            this.basla_btn.UseVisualStyleBackColor = true;
            this.basla_btn.Click += new System.EventHandler(this.basla_btn_Click);
            // 
            // giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.basla_btn);
            this.Name = "giris";
            this.Text = "giris";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button basla_btn;
    }
}