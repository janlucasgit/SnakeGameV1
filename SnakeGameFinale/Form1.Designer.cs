namespace SnakeGameFinale
{
    partial class Form1
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
            this.StartButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.background = new System.Windows.Forms.PictureBox();
            this.score = new System.Windows.Forms.Label();
            this.Highscore = new System.Windows.Forms.Label();
            this.gametimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(914, 12);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(116, 40);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartGame);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(914, 58);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(116, 40);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelGame);
            // 
            // background
            // 
            this.background.BackColor = System.Drawing.Color.DarkGray;
            this.background.Location = new System.Drawing.Point(12, 12);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(896, 801);
            this.background.TabIndex = 2;
            this.background.TabStop = false;
            this.background.Paint += new System.Windows.Forms.PaintEventHandler(this.UpdatePictureBoxGraph);
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.BackColor = System.Drawing.SystemColors.Control;
            this.score.Location = new System.Drawing.Point(914, 101);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(56, 16);
            this.score.TabIndex = 3;
            this.score.Text = "Score: 0";
            this.score.Click += new System.EventHandler(this.score_Click);
            // 
            // Highscore
            // 
            this.Highscore.AutoSize = true;
            this.Highscore.BackColor = System.Drawing.Color.White;
            this.Highscore.Location = new System.Drawing.Point(914, 127);
            this.Highscore.Name = "Highscore";
            this.Highscore.Size = new System.Drawing.Size(69, 16);
            this.Highscore.TabIndex = 4;
            this.Highscore.Text = "Highscore";
            // 
            // gametimer
            // 
            this.gametimer.Interval = 40;
            this.gametimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(1042, 825);
            this.Controls.Add(this.Highscore);
            this.Controls.Add(this.score);
            this.Controls.Add(this.background);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.StartButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.PictureBox background;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label Highscore;
        private System.Windows.Forms.Timer gametimer;
    }
}

