namespace _3_CS_BAGUS
{
    partial class FormGame
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
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pauseGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelActivities = new System.Windows.Forms.Panel();
            this.buttonChangeColor = new System.Windows.Forms.Button();
            this.buttonSleep = new System.Windows.Forms.Button();
            this.buttonClean = new System.Windows.Forms.Button();
            this.buttonVaccinate = new System.Windows.Forms.Button();
            this.buttonBath = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonFeed = new System.Windows.Forms.Button();
            this.pictureBoxPet = new System.Windows.Forms.PictureBox();
            this.panelData = new System.Windows.Forms.Panel();
            this.labelPetData = new System.Windows.Forms.Label();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.labelPlayerData = new System.Windows.Forms.Label();
            this.timerActivities = new System.Windows.Forms.Timer(this.components);
            this.timerIndicator = new System.Windows.Forms.Timer(this.components);
            this.panelFeature = new System.Windows.Forms.Panel();
            this.buttonMysteryBox = new System.Windows.Forms.Button();
            this.buttonOutside = new System.Windows.Forms.Button();
            this.buttonOutfitShop = new System.Windows.Forms.Button();
            this.buttonTutorial = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panelActivities.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPet)).BeginInit();
            this.panelData.SuspendLayout();
            this.panelFeature.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(77, 37);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // changePetToolStripMenuItem
            // 
            this.changePetToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.changePetToolStripMenuItem.Name = "changePetToolStripMenuItem";
            this.changePetToolStripMenuItem.Size = new System.Drawing.Size(249, 42);
            this.changePetToolStripMenuItem.Text = "Change Pet";
            this.changePetToolStripMenuItem.Click += new System.EventHandler(this.changePetToolStripMenuItem_Click);
            // 
            // resetGameToolStripMenuItem
            // 
            this.resetGameToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.resetGameToolStripMenuItem.Name = "resetGameToolStripMenuItem";
            this.resetGameToolStripMenuItem.Size = new System.Drawing.Size(249, 42);
            this.resetGameToolStripMenuItem.Text = "Reset Game";
            this.resetGameToolStripMenuItem.Click += new System.EventHandler(this.resetGameToolStripMenuItem_Click);
            // 
            // playGameToolStripMenuItem
            // 
            this.playGameToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.playGameToolStripMenuItem.Name = "playGameToolStripMenuItem";
            this.playGameToolStripMenuItem.Size = new System.Drawing.Size(249, 42);
            this.playGameToolStripMenuItem.Text = "Play Game";
            this.playGameToolStripMenuItem.Click += new System.EventHandler(this.playGameToolStripMenuItem_Click);
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playGameToolStripMenuItem,
            this.resetGameToolStripMenuItem,
            this.changePetToolStripMenuItem});
            this.gameToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(90, 37);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.pauseGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1378, 41);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pauseGameToolStripMenuItem
            // 
            this.pauseGameToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pauseGameToolStripMenuItem.Name = "pauseGameToolStripMenuItem";
            this.pauseGameToolStripMenuItem.Size = new System.Drawing.Size(93, 37);
            this.pauseGameToolStripMenuItem.Text = "Pause";
            this.pauseGameToolStripMenuItem.Click += new System.EventHandler(this.pauseGameToolStripMenuItem_Click);
            // 
            // panelActivities
            // 
            this.panelActivities.BackColor = System.Drawing.Color.Transparent;
            this.panelActivities.Controls.Add(this.buttonChangeColor);
            this.panelActivities.Controls.Add(this.buttonSleep);
            this.panelActivities.Controls.Add(this.buttonClean);
            this.panelActivities.Controls.Add(this.buttonVaccinate);
            this.panelActivities.Controls.Add(this.buttonBath);
            this.panelActivities.Controls.Add(this.buttonPlay);
            this.panelActivities.Controls.Add(this.buttonFeed);
            this.panelActivities.Location = new System.Drawing.Point(78, 640);
            this.panelActivities.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelActivities.Name = "panelActivities";
            this.panelActivities.Size = new System.Drawing.Size(1271, 75);
            this.panelActivities.TabIndex = 9;
            // 
            // buttonChangeColor
            // 
            this.buttonChangeColor.BackColor = System.Drawing.Color.Red;
            this.buttonChangeColor.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChangeColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonChangeColor.Location = new System.Drawing.Point(1088, 12);
            this.buttonChangeColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonChangeColor.Name = "buttonChangeColor";
            this.buttonChangeColor.Size = new System.Drawing.Size(179, 45);
            this.buttonChangeColor.TabIndex = 6;
            this.buttonChangeColor.Text = "Change Color";
            this.buttonChangeColor.UseVisualStyleBackColor = false;
            this.buttonChangeColor.Click += new System.EventHandler(this.buttonChangeColor_Click);
            // 
            // buttonSleep
            // 
            this.buttonSleep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonSleep.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSleep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonSleep.Location = new System.Drawing.Point(908, 12);
            this.buttonSleep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSleep.Name = "buttonSleep";
            this.buttonSleep.Size = new System.Drawing.Size(142, 45);
            this.buttonSleep.TabIndex = 5;
            this.buttonSleep.Text = "Sleep";
            this.buttonSleep.UseVisualStyleBackColor = false;
            this.buttonSleep.Click += new System.EventHandler(this.buttonSleep_Click);
            // 
            // buttonClean
            // 
            this.buttonClean.BackColor = System.Drawing.Color.Green;
            this.buttonClean.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClean.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonClean.Location = new System.Drawing.Point(728, 12);
            this.buttonClean.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonClean.Name = "buttonClean";
            this.buttonClean.Size = new System.Drawing.Size(142, 45);
            this.buttonClean.TabIndex = 4;
            this.buttonClean.Text = "Clean";
            this.buttonClean.UseVisualStyleBackColor = false;
            this.buttonClean.Click += new System.EventHandler(this.buttonClean_Click);
            // 
            // buttonVaccinate
            // 
            this.buttonVaccinate.BackColor = System.Drawing.Color.Olive;
            this.buttonVaccinate.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVaccinate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonVaccinate.Location = new System.Drawing.Point(548, 12);
            this.buttonVaccinate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonVaccinate.Name = "buttonVaccinate";
            this.buttonVaccinate.Size = new System.Drawing.Size(142, 45);
            this.buttonVaccinate.TabIndex = 3;
            this.buttonVaccinate.Text = "Vaccinate";
            this.buttonVaccinate.UseVisualStyleBackColor = false;
            this.buttonVaccinate.Click += new System.EventHandler(this.buttonVaccinate_Click);
            // 
            // buttonBath
            // 
            this.buttonBath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonBath.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonBath.Location = new System.Drawing.Point(368, 12);
            this.buttonBath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBath.Name = "buttonBath";
            this.buttonBath.Size = new System.Drawing.Size(142, 45);
            this.buttonBath.TabIndex = 2;
            this.buttonBath.Text = "Bath";
            this.buttonBath.UseVisualStyleBackColor = false;
            this.buttonBath.Click += new System.EventHandler(this.buttonBath_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.BackColor = System.Drawing.Color.Purple;
            this.buttonPlay.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonPlay.Location = new System.Drawing.Point(188, 12);
            this.buttonPlay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(142, 45);
            this.buttonPlay.TabIndex = 1;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = false;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonFeed
            // 
            this.buttonFeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonFeed.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFeed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonFeed.Location = new System.Drawing.Point(8, 12);
            this.buttonFeed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFeed.Name = "buttonFeed";
            this.buttonFeed.Size = new System.Drawing.Size(142, 45);
            this.buttonFeed.TabIndex = 0;
            this.buttonFeed.Text = "Feed";
            this.buttonFeed.UseVisualStyleBackColor = false;
            this.buttonFeed.Click += new System.EventHandler(this.buttonFeed_Click);
            // 
            // pictureBoxPet
            // 
            this.pictureBoxPet.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxPet.Location = new System.Drawing.Point(577, 349);
            this.pictureBoxPet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxPet.Name = "pictureBoxPet";
            this.pictureBoxPet.Size = new System.Drawing.Size(250, 258);
            this.pictureBoxPet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPet.TabIndex = 10;
            this.pictureBoxPet.TabStop = false;
            // 
            // panelData
            // 
            this.panelData.BackColor = System.Drawing.Color.Transparent;
            this.panelData.Controls.Add(this.labelPetData);
            this.panelData.Controls.Add(this.labelDateTime);
            this.panelData.Controls.Add(this.labelPlayerData);
            this.panelData.Location = new System.Drawing.Point(12, 58);
            this.panelData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(1354, 114);
            this.panelData.TabIndex = 11;
            // 
            // labelPetData
            // 
            this.labelPetData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.labelPetData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPetData.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPetData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelPetData.Location = new System.Drawing.Point(279, 4);
            this.labelPetData.Name = "labelPetData";
            this.labelPetData.Size = new System.Drawing.Size(737, 107);
            this.labelPetData.TabIndex = 2;
            this.labelPetData.Text = "labelPetData";
            this.labelPetData.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelDateTime
            // 
            this.labelDateTime.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateTime.Location = new System.Drawing.Point(1052, 11);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(299, 32);
            this.labelDateTime.TabIndex = 1;
            this.labelDateTime.Text = "labelDateTime";
            // 
            // labelPlayerData
            // 
            this.labelPlayerData.AutoSize = true;
            this.labelPlayerData.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayerData.Location = new System.Drawing.Point(10, 14);
            this.labelPlayerData.Name = "labelPlayerData";
            this.labelPlayerData.Size = new System.Drawing.Size(161, 29);
            this.labelPlayerData.TabIndex = 0;
            this.labelPlayerData.Text = "labelPlayerData";
            // 
            // timerActivities
            // 
            this.timerActivities.Interval = 1000;
            this.timerActivities.Tick += new System.EventHandler(this.timerActivities_Tick);
            // 
            // timerIndicator
            // 
            this.timerIndicator.Interval = 1000;
            this.timerIndicator.Tick += new System.EventHandler(this.timerIndicator_Tick);
            // 
            // panelFeature
            // 
            this.panelFeature.BackColor = System.Drawing.Color.Transparent;
            this.panelFeature.Controls.Add(this.buttonMysteryBox);
            this.panelFeature.Controls.Add(this.buttonOutside);
            this.panelFeature.Controls.Add(this.buttonOutfitShop);
            this.panelFeature.Location = new System.Drawing.Point(1166, 196);
            this.panelFeature.Name = "panelFeature";
            this.panelFeature.Size = new System.Drawing.Size(200, 351);
            this.panelFeature.TabIndex = 12;
            // 
            // buttonMysteryBox
            // 
            this.buttonMysteryBox.BackgroundImage = global::_3_CS_BAGUS.Properties.Resources.mystery_box;
            this.buttonMysteryBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMysteryBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMysteryBox.Location = new System.Drawing.Point(37, 236);
            this.buttonMysteryBox.Name = "buttonMysteryBox";
            this.buttonMysteryBox.Size = new System.Drawing.Size(146, 100);
            this.buttonMysteryBox.TabIndex = 2;
            this.buttonMysteryBox.UseVisualStyleBackColor = true;
            this.buttonMysteryBox.Click += new System.EventHandler(this.buttonMysteryBox_Click);
            // 
            // buttonOutside
            // 
            this.buttonOutside.BackgroundImage = global::_3_CS_BAGUS.Properties.Resources.outside_icon;
            this.buttonOutside.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonOutside.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOutside.Location = new System.Drawing.Point(37, 124);
            this.buttonOutside.Name = "buttonOutside";
            this.buttonOutside.Size = new System.Drawing.Size(146, 100);
            this.buttonOutside.TabIndex = 1;
            this.buttonOutside.UseVisualStyleBackColor = true;
            this.buttonOutside.Click += new System.EventHandler(this.buttonOutside_Click);
            // 
            // buttonOutfitShop
            // 
            this.buttonOutfitShop.BackgroundImage = global::_3_CS_BAGUS.Properties.Resources.outfit_shop;
            this.buttonOutfitShop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonOutfitShop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOutfitShop.Location = new System.Drawing.Point(37, 13);
            this.buttonOutfitShop.Name = "buttonOutfitShop";
            this.buttonOutfitShop.Size = new System.Drawing.Size(146, 100);
            this.buttonOutfitShop.TabIndex = 0;
            this.buttonOutfitShop.UseVisualStyleBackColor = true;
            this.buttonOutfitShop.Click += new System.EventHandler(this.buttonOutfitShop_Click);
            // 
            // buttonTutorial
            // 
            this.buttonTutorial.BackColor = System.Drawing.Color.Transparent;
            this.buttonTutorial.BackgroundImage = global::_3_CS_BAGUS.Properties.Resources.lamp;
            this.buttonTutorial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonTutorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTutorial.Location = new System.Drawing.Point(12, 196);
            this.buttonTutorial.Name = "buttonTutorial";
            this.buttonTutorial.Size = new System.Drawing.Size(88, 83);
            this.buttonTutorial.TabIndex = 2;
            this.buttonTutorial.UseVisualStyleBackColor = false;
            this.buttonTutorial.Click += new System.EventHandler(this.buttonTutorial_Click);
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_3_CS_BAGUS.Properties.Resources.Room;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1378, 744);
            this.Controls.Add(this.buttonTutorial);
            this.Controls.Add(this.panelFeature);
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.pictureBoxPet);
            this.Controls.Add(this.panelActivities);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Happy Pet Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormGame_FormClosing);
            this.Load += new System.EventHandler(this.FormGame_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelActivities.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPet)).EndInit();
            this.panelData.ResumeLayout(false);
            this.panelData.PerformLayout();
            this.panelFeature.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panelActivities;
        private System.Windows.Forms.Button buttonChangeColor;
        private System.Windows.Forms.Button buttonSleep;
        private System.Windows.Forms.Button buttonClean;
        private System.Windows.Forms.Button buttonVaccinate;
        private System.Windows.Forms.Button buttonBath;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonFeed;
        public System.Windows.Forms.PictureBox pictureBoxPet;
        public System.Windows.Forms.Panel panelData;
        public System.Windows.Forms.Label labelPetData;
        public System.Windows.Forms.Label labelDateTime;
        public System.Windows.Forms.Label labelPlayerData;
        public System.Windows.Forms.Timer timerActivities;
        private System.Windows.Forms.ToolStripMenuItem pauseGameToolStripMenuItem;
        private System.Windows.Forms.Panel panelFeature;
        private System.Windows.Forms.Button buttonOutside;
        private System.Windows.Forms.Button buttonOutfitShop;
        private System.Windows.Forms.Button buttonTutorial;
        public System.Windows.Forms.Timer timerIndicator;
        private System.Windows.Forms.Button buttonMysteryBox;
    }
}

