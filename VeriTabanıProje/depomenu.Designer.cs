
namespace VeriTabanıProje
{
    partial class depomenu
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
            this.buttonTeslim = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonKargo = new System.Windows.Forms.Button();
            this.btnstokdurum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonTeslim
            // 
            this.buttonTeslim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTeslim.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonTeslim.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonTeslim.Location = new System.Drawing.Point(343, 47);
            this.buttonTeslim.Margin = new System.Windows.Forms.Padding(4);
            this.buttonTeslim.Name = "buttonTeslim";
            this.buttonTeslim.Size = new System.Drawing.Size(128, 260);
            this.buttonTeslim.TabIndex = 39;
            this.buttonTeslim.Text = "TESLİM DURUMU";
            this.buttonTeslim.UseVisualStyleBackColor = true;
            this.buttonTeslim.Click += new System.EventHandler(this.buttonTeslim_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(446, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 25);
            this.label7.TabIndex = 38;
            this.label7.Text = "X";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(416, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 25);
            this.label8.TabIndex = 37;
            this.label8.Text = "<";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // buttonKargo
            // 
            this.buttonKargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKargo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonKargo.Location = new System.Drawing.Point(175, 47);
            this.buttonKargo.Margin = new System.Windows.Forms.Padding(4);
            this.buttonKargo.Name = "buttonKargo";
            this.buttonKargo.Size = new System.Drawing.Size(132, 260);
            this.buttonKargo.TabIndex = 36;
            this.buttonKargo.Text = "KARGOYA VER";
            this.buttonKargo.UseVisualStyleBackColor = true;
            this.buttonKargo.Click += new System.EventHandler(this.buttonKargo_Click);
            // 
            // btnstokdurum
            // 
            this.btnstokdurum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnstokdurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnstokdurum.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnstokdurum.Location = new System.Drawing.Point(11, 47);
            this.btnstokdurum.Margin = new System.Windows.Forms.Padding(4);
            this.btnstokdurum.Name = "btnstokdurum";
            this.btnstokdurum.Size = new System.Drawing.Size(128, 260);
            this.btnstokdurum.TabIndex = 35;
            this.btnstokdurum.Text = "STOK DURUMLARI";
            this.btnstokdurum.UseVisualStyleBackColor = true;
            this.btnstokdurum.Click += new System.EventHandler(this.btnstokdurum_Click);
            // 
            // depomenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(493, 329);
            this.Controls.Add(this.buttonTeslim);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonKargo);
            this.Controls.Add(this.btnstokdurum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "depomenu";
            this.Text = "depomenu";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.depomenu_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.depomenu_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.depomenu_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonTeslim;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonKargo;
        private System.Windows.Forms.Button btnstokdurum;
    }
}