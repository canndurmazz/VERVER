﻿namespace VeriTabanıProje
{
    partial class yonetimgiris
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.kullaniciSifre = new System.Windows.Forms.TextBox();
            this.kullaniciAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(188, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 17);
            this.label4.TabIndex = 41;
            this.label4.Text = "<";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(211, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 17);
            this.label3.TabIndex = 40;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(124, 108);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 30);
            this.button1.TabIndex = 39;
            this.button1.Text = "Giriş";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kullaniciSifre
            // 
            this.kullaniciSifre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.kullaniciSifre.Location = new System.Drawing.Point(81, 65);
            this.kullaniciSifre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kullaniciSifre.Name = "kullaniciSifre";
            this.kullaniciSifre.Size = new System.Drawing.Size(145, 22);
            this.kullaniciSifre.TabIndex = 38;
            // 
            // kullaniciAd
            // 
            this.kullaniciAd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.kullaniciAd.Location = new System.Drawing.Point(81, 31);
            this.kullaniciAd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kullaniciAd.Name = "kullaniciAd";
            this.kullaniciAd.Size = new System.Drawing.Size(145, 22);
            this.kullaniciAd.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(5, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 36;
            this.label2.Text = "Şifre :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(21, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "ID :";
            // 
            // yonetimgiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(235, 149);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kullaniciSifre);
            this.Controls.Add(this.kullaniciAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "yonetimgiris";
            this.Text = "yonetimgiris";
            this.Load += new System.EventHandler(this.yonetimgiris_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.yonetimgiris_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.yonetimgiris_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.yonetimgiris_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox kullaniciSifre;
        private System.Windows.Forms.TextBox kullaniciAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}