namespace _3_CS_BAGUS
{
    partial class FormSelectOutfit
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
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabelClickHere = new System.Windows.Forms.LinkLabel();
            this.labelNewOutfit = new System.Windows.Forms.Label();
            this.buttonUse = new System.Windows.Forms.Button();
            this.labelOutfitData = new System.Windows.Forms.Label();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.comboBoxOutfit = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 31);
            this.label1.TabIndex = 27;
            this.label1.Text = "Select Outfit";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLabelClickHere
            // 
            this.linkLabelClickHere.AutoSize = true;
            this.linkLabelClickHere.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelClickHere.Location = new System.Drawing.Point(289, 630);
            this.linkLabelClickHere.Name = "linkLabelClickHere";
            this.linkLabelClickHere.Size = new System.Drawing.Size(125, 31);
            this.linkLabelClickHere.TabIndex = 26;
            this.linkLabelClickHere.TabStop = true;
            this.linkLabelClickHere.Text = "Click Here";
            this.linkLabelClickHere.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelClickHere_LinkClicked);
            // 
            // labelNewOutfit
            // 
            this.labelNewOutfit.AutoSize = true;
            this.labelNewOutfit.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewOutfit.Location = new System.Drawing.Point(11, 629);
            this.labelNewOutfit.Name = "labelNewOutfit";
            this.labelNewOutfit.Size = new System.Drawing.Size(260, 31);
            this.labelNewOutfit.TabIndex = 25;
            this.labelNewOutfit.Text = "Don\'t have any outfit?";
            // 
            // buttonUse
            // 
            this.buttonUse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonUse.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUse.Location = new System.Drawing.Point(99, 542);
            this.buttonUse.Name = "buttonUse";
            this.buttonUse.Size = new System.Drawing.Size(239, 49);
            this.buttonUse.TabIndex = 24;
            this.buttonUse.Text = "Use";
            this.buttonUse.UseVisualStyleBackColor = false;
            this.buttonUse.Click += new System.EventHandler(this.buttonUse_Click);
            // 
            // labelOutfitData
            // 
            this.labelOutfitData.BackColor = System.Drawing.Color.White;
            this.labelOutfitData.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOutfitData.Location = new System.Drawing.Point(32, 392);
            this.labelOutfitData.Name = "labelOutfitData";
            this.labelOutfitData.Size = new System.Drawing.Size(376, 119);
            this.labelOutfitData.TabIndex = 23;
            this.labelOutfitData.Text = "Outfit Data";
            this.labelOutfitData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.Location = new System.Drawing.Point(81, 130);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(257, 243);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImage.TabIndex = 22;
            this.pictureBoxImage.TabStop = false;
            // 
            // comboBoxOutfit
            // 
            this.comboBoxOutfit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOutfit.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxOutfit.FormattingEnabled = true;
            this.comboBoxOutfit.Location = new System.Drawing.Point(81, 64);
            this.comboBoxOutfit.Name = "comboBoxOutfit";
            this.comboBoxOutfit.Size = new System.Drawing.Size(266, 41);
            this.comboBoxOutfit.TabIndex = 21;
            this.comboBoxOutfit.SelectedIndexChanged += new System.EventHandler(this.comboBoxOutfit_SelectedIndexChanged);
            // 
            // FormSelectOutfit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(429, 681);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabelClickHere);
            this.Controls.Add(this.labelNewOutfit);
            this.Controls.Add(this.buttonUse);
            this.Controls.Add(this.labelOutfitData);
            this.Controls.Add(this.pictureBoxImage);
            this.Controls.Add(this.comboBoxOutfit);
            this.Name = "FormSelectOutfit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSelectOutfit";
            this.Load += new System.EventHandler(this.FormSelectOutfit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabelClickHere;
        private System.Windows.Forms.Label labelNewOutfit;
        private System.Windows.Forms.Button buttonUse;
        private System.Windows.Forms.Label labelOutfitData;
        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.ComboBox comboBoxOutfit;
    }
}