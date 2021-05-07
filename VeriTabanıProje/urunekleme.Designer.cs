
namespace VeriTabanıProje
{
    partial class urunekleme
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.birimfiyat = new System.Windows.Forms.TextBox();
            this.labelbirim = new System.Windows.Forms.Label();
            this.aciklama = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.urun_miktar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.urunad = new System.Windows.Forms.TextBox();
            this.urunadlabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hamcombo = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 209);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(541, 175);
            this.dataGridView1.TabIndex = 0;
            // 
            // birimfiyat
            // 
            this.birimfiyat.Location = new System.Drawing.Point(241, 72);
            this.birimfiyat.Name = "birimfiyat";
            this.birimfiyat.Size = new System.Drawing.Size(177, 22);
            this.birimfiyat.TabIndex = 35;
            this.birimfiyat.TextChanged += new System.EventHandler(this.birimfiyat_TextChanged);
            // 
            // labelbirim
            // 
            this.labelbirim.AutoSize = true;
            this.labelbirim.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelbirim.Location = new System.Drawing.Point(7, 72);
            this.labelbirim.Name = "labelbirim";
            this.labelbirim.Size = new System.Drawing.Size(116, 17);
            this.labelbirim.TabIndex = 34;
            this.labelbirim.Text = "Urun Birim Fiyat :";
            this.labelbirim.Click += new System.EventHandler(this.labelbirim_Click);
            // 
            // aciklama
            // 
            this.aciklama.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.aciklama.Location = new System.Drawing.Point(241, 173);
            this.aciklama.Multiline = true;
            this.aciklama.Name = "aciklama";
            this.aciklama.Size = new System.Drawing.Size(177, 22);
            this.aciklama.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(12, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 17);
            this.label8.TabIndex = 32;
            this.label8.Text = "Urun Açıklaması :";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // urun_miktar
            // 
            this.urun_miktar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.urun_miktar.Location = new System.Drawing.Point(241, 140);
            this.urun_miktar.Name = "urun_miktar";
            this.urun_miktar.Size = new System.Drawing.Size(177, 22);
            this.urun_miktar.TabIndex = 31;
            this.urun_miktar.TextChanged += new System.EventHandler(this.urun_miktar_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(7, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "Gerekli Hammadde Miktarı :";
            // 
            // urunad
            // 
            this.urunad.Location = new System.Drawing.Point(241, 40);
            this.urunad.Name = "urunad";
            this.urunad.Size = new System.Drawing.Size(177, 22);
            this.urunad.TabIndex = 29;
            // 
            // urunadlabel
            // 
            this.urunadlabel.AutoSize = true;
            this.urunadlabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.urunadlabel.Location = new System.Drawing.Point(8, 45);
            this.urunadlabel.Name = "urunadlabel";
            this.urunadlabel.Size = new System.Drawing.Size(70, 17);
            this.urunadlabel.TabIndex = 28;
            this.urunadlabel.Text = "Urun AD :";
            this.urunadlabel.Click += new System.EventHandler(this.urunadlabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(7, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 17);
            this.label1.TabIndex = 36;
            this.label1.Text = "Gerekli Hammadde :";
            // 
            // hamcombo
            // 
            this.hamcombo.FormattingEnabled = true;
            this.hamcombo.Location = new System.Drawing.Point(241, 105);
            this.hamcombo.Name = "hamcombo";
            this.hamcombo.Size = new System.Drawing.Size(177, 24);
            this.hamcombo.TabIndex = 37;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(424, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 35);
            this.button1.TabIndex = 38;
            this.button1.Text = "Onayla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
            this.button1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button1_MouseMove);
            this.button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button1_MouseUp);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(424, 78);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 35);
            this.button2.TabIndex = 39;
            this.button2.Text = "Yeni Ürün";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(476, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 25);
            this.label9.TabIndex = 42;
            this.label9.Text = "_";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(505, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 25);
            this.label7.TabIndex = 41;
            this.label7.Text = "<";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(528, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 25);
            this.label5.TabIndex = 40;
            this.label5.Text = "X";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(424, 117);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 37);
            this.button3.TabIndex = 61;
            this.button3.Text = "Yeni Mesaj";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(424, 158);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(131, 37);
            this.button4.TabIndex = 60;
            this.button4.Text = "Gelen Mesaj";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(10, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 63;
            // 
            // urunekleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(563, 396);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.hamcombo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.birimfiyat);
            this.Controls.Add(this.labelbirim);
            this.Controls.Add(this.aciklama);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.urun_miktar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.urunad);
            this.Controls.Add(this.urunadlabel);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "urunekleme";
            this.Text = "urunekleme";
            this.Load += new System.EventHandler(this.urunekleme_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.urunekleme_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.urunekleme_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.urunekleme_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox birimfiyat;
        private System.Windows.Forms.Label labelbirim;
        private System.Windows.Forms.TextBox aciklama;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox urun_miktar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox urunad;
        private System.Windows.Forms.Label urunadlabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox hamcombo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}