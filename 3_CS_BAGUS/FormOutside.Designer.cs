namespace _3_CS_BAGUS
{
    partial class FormOutside
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
            this.components = new System.ComponentModel.Container();
            this.panelData = new System.Windows.Forms.Panel();
            this.labelPetData = new System.Windows.Forms.Label();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.labelPlayerData = new System.Windows.Forms.Label();
            this.timerIndicator = new System.Windows.Forms.Timer(this.components);
            this.health_potion = new System.Windows.Forms.PictureBox();
            this.pet = new System.Windows.Forms.PictureBox();
            this.happiness_potion = new System.Windows.Forms.PictureBox();
            this.special_potion = new System.Windows.Forms.PictureBox();
            this.energy_potion = new System.Windows.Forms.PictureBox();
            this.panelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.health_potion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.happiness_potion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.special_potion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.energy_potion)).BeginInit();
            this.SuspendLayout();
            // 
            // panelData
            // 
            this.panelData.BackColor = System.Drawing.Color.Transparent;
            this.panelData.Controls.Add(this.labelPetData);
            this.panelData.Controls.Add(this.labelDateTime);
            this.panelData.Controls.Add(this.labelPlayerData);
            this.panelData.Location = new System.Drawing.Point(16, 51);
            this.panelData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(1805, 142);
            this.panelData.TabIndex = 19;
            // 
            // labelPetData
            // 
            this.labelPetData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.labelPetData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPetData.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPetData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelPetData.Location = new System.Drawing.Point(372, 5);
            this.labelPetData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPetData.Name = "labelPetData";
            this.labelPetData.Size = new System.Drawing.Size(982, 133);
            this.labelPetData.TabIndex = 2;
            this.labelPetData.Text = "labelPetData";
            this.labelPetData.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelDateTime
            // 
            this.labelDateTime.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateTime.Location = new System.Drawing.Point(1403, 14);
            this.labelDateTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(399, 40);
            this.labelDateTime.TabIndex = 1;
            this.labelDateTime.Text = "labelDateTime";
            // 
            // labelPlayerData
            // 
            this.labelPlayerData.AutoSize = true;
            this.labelPlayerData.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayerData.Location = new System.Drawing.Point(13, 18);
            this.labelPlayerData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPlayerData.Name = "labelPlayerData";
            this.labelPlayerData.Size = new System.Drawing.Size(209, 36);
            this.labelPlayerData.TabIndex = 0;
            this.labelPlayerData.Text = "labelPlayerData";
            // 
            // timerIndicator
            // 
            this.timerIndicator.Enabled = true;
            this.timerIndicator.Interval = 1;
            this.timerIndicator.Tick += new System.EventHandler(this.timerIndicator_Tick);
            // 
            // health_potion
            // 
            this.health_potion.BackColor = System.Drawing.Color.Transparent;
            this.health_potion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.health_potion.Image = global::_3_CS_BAGUS.Properties.Resources.health_potion;
            this.health_potion.Location = new System.Drawing.Point(105, 650);
            this.health_potion.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.health_potion.Name = "health_potion";
            this.health_potion.Size = new System.Drawing.Size(249, 202);
            this.health_potion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.health_potion.TabIndex = 18;
            this.health_potion.TabStop = false;
            // 
            // pet
            // 
            this.pet.BackColor = System.Drawing.Color.Transparent;
            this.pet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pet.Location = new System.Drawing.Point(768, 599);
            this.pet.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pet.Name = "pet";
            this.pet.Size = new System.Drawing.Size(331, 280);
            this.pet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pet.TabIndex = 17;
            this.pet.TabStop = false;
            this.pet.Click += new System.EventHandler(this.pet_Click);
            // 
            // happiness_potion
            // 
            this.happiness_potion.BackColor = System.Drawing.Color.Transparent;
            this.happiness_potion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.happiness_potion.Image = global::_3_CS_BAGUS.Properties.Resources.happiness_potion;
            this.happiness_potion.Location = new System.Drawing.Point(88, 234);
            this.happiness_potion.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.happiness_potion.Name = "happiness_potion";
            this.happiness_potion.Size = new System.Drawing.Size(249, 202);
            this.happiness_potion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.happiness_potion.TabIndex = 22;
            this.happiness_potion.TabStop = false;
            // 
            // special_potion
            // 
            this.special_potion.BackColor = System.Drawing.Color.Transparent;
            this.special_potion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.special_potion.Image = global::_3_CS_BAGUS.Properties.Resources.special_potion;
            this.special_potion.Location = new System.Drawing.Point(1411, 256);
            this.special_potion.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.special_potion.Name = "special_potion";
            this.special_potion.Size = new System.Drawing.Size(249, 202);
            this.special_potion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.special_potion.TabIndex = 21;
            this.special_potion.TabStop = false;
            // 
            // energy_potion
            // 
            this.energy_potion.BackColor = System.Drawing.Color.Transparent;
            this.energy_potion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.energy_potion.Image = global::_3_CS_BAGUS.Properties.Resources.energy_potion;
            this.energy_potion.Location = new System.Drawing.Point(1384, 632);
            this.energy_potion.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.energy_potion.Name = "energy_potion";
            this.energy_potion.Size = new System.Drawing.Size(249, 202);
            this.energy_potion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.energy_potion.TabIndex = 20;
            this.energy_potion.TabStop = false;
            // 
            // FormOutside
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_3_CS_BAGUS.Properties.Resources.garden;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1837, 930);
            this.Controls.Add(this.health_potion);
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.pet);
            this.Controls.Add(this.happiness_potion);
            this.Controls.Add(this.special_potion);
            this.Controls.Add(this.energy_potion);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormOutside";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormOutside";
            this.Load += new System.EventHandler(this.FormOutside_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormOutside_KeyDown);
            this.panelData.ResumeLayout(false);
            this.panelData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.health_potion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.happiness_potion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.special_potion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.energy_potion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox health_potion;
        public System.Windows.Forms.Panel panelData;
        public System.Windows.Forms.Label labelPetData;
        public System.Windows.Forms.Label labelDateTime;
        public System.Windows.Forms.Label labelPlayerData;
        public System.Windows.Forms.PictureBox pet;
        private System.Windows.Forms.Timer timerIndicator;
        public System.Windows.Forms.PictureBox happiness_potion;
        public System.Windows.Forms.PictureBox special_potion;
        public System.Windows.Forms.PictureBox energy_potion;
    }
}