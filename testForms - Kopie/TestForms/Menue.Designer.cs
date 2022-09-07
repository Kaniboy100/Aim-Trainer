
namespace Aim_Trainer
{
    partial class Menue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menue));
            this.lblTitel = new System.Windows.Forms.Label();
            this.btnRe1 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitel
            // 
            this.lblTitel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitel.AutoEllipsis = true;
            this.lblTitel.AutoSize = true;
            this.lblTitel.BackColor = System.Drawing.Color.Transparent;
            this.lblTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 75F);
            this.lblTitel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblTitel.Location = new System.Drawing.Point(560, 11);
            this.lblTitel.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(427, 142);
            this.lblTitel.TabIndex = 1;
            this.lblTitel.Text = "MENÜ";
            this.lblTitel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitel.Click += new System.EventHandler(this.lblTitel_Click);
            // 
            // btnRe1
            // 
            this.btnRe1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRe1.AutoEllipsis = true;
            this.btnRe1.AutoSize = true;
            this.btnRe1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))), ((int)(((byte)(120)))));
            this.btnRe1.FlatAppearance.BorderSize = 0;
            this.btnRe1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRe1.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.btnRe1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnRe1.Location = new System.Drawing.Point(593, 174);
            this.btnRe1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnRe1.Name = "btnRe1";
            this.btnRe1.Size = new System.Drawing.Size(340, 56);
            this.btnRe1.TabIndex = 2;
            this.btnRe1.Text = "RETURN";
            this.btnRe1.UseVisualStyleBackColor = false;
            this.btnRe1.Click += new System.EventHandler(this.btnRe1_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.AutoEllipsis = true;
            this.btnExit.AutoSize = true;
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))), ((int)(((byte)(120)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnExit.Location = new System.Drawing.Point(593, 244);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(340, 56);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // Menue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1540, 409);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRe1);
            this.Controls.Add(this.lblTitel);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "Menue";
            this.Text = "Menue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.Button btnRe1;
        private System.Windows.Forms.Button btnExit;
    }
}