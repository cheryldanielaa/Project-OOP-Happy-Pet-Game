namespace _3_CS_BAGUS
{
    partial class FormPauseGame
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
            this.buttonResumeGame = new System.Windows.Forms.Button();
            this.labelPause = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonResumeGame
            // 
            this.buttonResumeGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonResumeGame.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResumeGame.Location = new System.Drawing.Point(277, 261);
            this.buttonResumeGame.Name = "buttonResumeGame";
            this.buttonResumeGame.Size = new System.Drawing.Size(242, 54);
            this.buttonResumeGame.TabIndex = 3;
            this.buttonResumeGame.Text = "Resume";
            this.buttonResumeGame.UseVisualStyleBackColor = false;
            this.buttonResumeGame.Click += new System.EventHandler(this.buttonResumeGame_Click);
            // 
            // labelPause
            // 
            this.labelPause.AutoSize = true;
            this.labelPause.BackColor = System.Drawing.Color.Transparent;
            this.labelPause.Font = new System.Drawing.Font("Comic Sans MS", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPause.ForeColor = System.Drawing.Color.Chocolate;
            this.labelPause.Location = new System.Drawing.Point(271, 136);
            this.labelPause.Name = "labelPause";
            this.labelPause.Size = new System.Drawing.Size(259, 78);
            this.labelPause.TabIndex = 2;
            this.labelPause.Text = "PAUSED";
            // 
            // FormPauseGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonResumeGame);
            this.Controls.Add(this.labelPause);
            this.Name = "FormPauseGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pause Game";
            this.Load += new System.EventHandler(this.FormPauseGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonResumeGame;
        private System.Windows.Forms.Label labelPause;
    }
}