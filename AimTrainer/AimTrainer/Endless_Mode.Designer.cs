
namespace AimTrainer
{
    partial class Endless_Mode
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Endless_Mode));
            this.lblscore = new System.Windows.Forms.Label();
            this.lblAccuracy = new System.Windows.Forms.Label();
            this.lbltimer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblHitmarker = new System.Windows.Forms.Label();
            this.btnTarget = new System.Windows.Forms.Button();
            this.lbltwenty = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblscore
            // 
            this.lblscore.AutoSize = true;
            this.lblscore.BackColor = System.Drawing.Color.Transparent;
            this.lblscore.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblscore.Location = new System.Drawing.Point(0, 580);
            this.lblscore.Name = "lblscore";
            this.lblscore.Size = new System.Drawing.Size(51, 20);
            this.lblscore.TabIndex = 1;
            this.lblscore.Text = "Score";
            this.lblscore.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblAccuracy
            // 
            this.lblAccuracy.AutoSize = true;
            this.lblAccuracy.BackColor = System.Drawing.Color.Transparent;
            this.lblAccuracy.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblAccuracy.Location = new System.Drawing.Point(0, 600);
            this.lblAccuracy.Name = "lblAccuracy";
            this.lblAccuracy.Size = new System.Drawing.Size(74, 20);
            this.lblAccuracy.TabIndex = 4;
            this.lblAccuracy.Text = "Accuracy";
            this.lblAccuracy.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lbltimer
            // 
            this.lbltimer.AutoSize = true;
            this.lbltimer.BackColor = System.Drawing.Color.Transparent;
            this.lbltimer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbltimer.Location = new System.Drawing.Point(0, 560);
            this.lbltimer.Name = "lbltimer";
            this.lbltimer.Size = new System.Drawing.Size(43, 20);
            this.lbltimer.TabIndex = 7;
            this.lbltimer.Text = "Time";
            this.lbltimer.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lbltimer.Click += new System.EventHandler(this.lbltimer_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblHitmarker
            // 
            this.lblHitmarker.AutoSize = true;
            this.lblHitmarker.BackColor = System.Drawing.Color.Transparent;
            this.lblHitmarker.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lblHitmarker.Image = ((System.Drawing.Image)(resources.GetObject("lblHitmarker.Image")));
            this.lblHitmarker.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblHitmarker.Location = new System.Drawing.Point(341, 192);
            this.lblHitmarker.Name = "lblHitmarker";
            this.lblHitmarker.Size = new System.Drawing.Size(0, 58);
            this.lblHitmarker.TabIndex = 6;
            this.lblHitmarker.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTarget
            // 
            this.btnTarget.BackColor = System.Drawing.Color.Transparent;
            this.btnTarget.BackgroundImage = global::AimTrainer.Properties.Resources.Target_03;
            this.btnTarget.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTarget.FlatAppearance.BorderSize = 0;
            this.btnTarget.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnTarget.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnTarget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTarget.Location = new System.Drawing.Point(508, 136);
            this.btnTarget.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTarget.Name = "btnTarget";
            this.btnTarget.Size = new System.Drawing.Size(188, 195);
            this.btnTarget.TabIndex = 0;
            this.btnTarget.TabStop = false;
            this.btnTarget.UseVisualStyleBackColor = false;
            this.btnTarget.Click += new System.EventHandler(this.btnTarget_Click);
            // 
            // lbltwenty
            // 
            this.lbltwenty.AutoSize = true;
            this.lbltwenty.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbltwenty.Location = new System.Drawing.Point(0, 540);
            this.lbltwenty.Name = "lbltwenty";
            this.lbltwenty.Size = new System.Drawing.Size(0, 20);
            this.lbltwenty.TabIndex = 8;
            // 
            // Endless_Mode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1130, 620);
            this.Controls.Add(this.lbltwenty);
            this.Controls.Add(this.lbltimer);
            this.Controls.Add(this.lblHitmarker);
            this.Controls.Add(this.lblscore);
            this.Controls.Add(this.lblAccuracy);
            this.Controls.Add(this.btnTarget);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Endless_Mode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Endless Mode";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Endless_Mode_Load);
            this.Click += new System.EventHandler(this.Endless_Mode_Click);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Endless_Mode_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTarget;
        private System.Windows.Forms.Label lblscore;
        private System.Windows.Forms.Label lblAccuracy;
        private System.Windows.Forms.Label lblHitmarker;
        private System.Windows.Forms.Label lbltimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbltwenty;
    }
}

