namespace _3_CS_BAGUS
{
    partial class FormSelectPet
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
            this.buttonPlay = new System.Windows.Forms.Button();
            this.comboBoxEnvironment = new System.Windows.Forms.ComboBox();
            this.labelEnvironment = new System.Windows.Forms.Label();
            this.textBoxPetName = new System.Windows.Forms.TextBox();
            this.labelPetName = new System.Windows.Forms.Label();
            this.textBoxPlayerName = new System.Windows.Forms.TextBox();
            this.labelSelectPet = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxDifficulty = new System.Windows.Forms.ComboBox();
            this.radioButtonChameleon = new System.Windows.Forms.RadioButton();
            this.radioButtonFish = new System.Windows.Forms.RadioButton();
            this.radioButtonCat = new System.Windows.Forms.RadioButton();
            this.radioButtonPig = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // buttonPlay
            // 
            this.buttonPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonPlay.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlay.ForeColor = System.Drawing.Color.Black;
            this.buttonPlay.Location = new System.Drawing.Point(883, 700);
            this.buttonPlay.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(315, 61);
            this.buttonPlay.TabIndex = 21;
            this.buttonPlay.Text = "Lets Play";
            this.buttonPlay.UseVisualStyleBackColor = false;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // comboBoxEnvironment
            // 
            this.comboBoxEnvironment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEnvironment.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEnvironment.FormattingEnabled = true;
            this.comboBoxEnvironment.Items.AddRange(new object[] {
            "River",
            "Sea",
            "Pond"});
            this.comboBoxEnvironment.Location = new System.Drawing.Point(1422, 598);
            this.comboBoxEnvironment.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.comboBoxEnvironment.Name = "comboBoxEnvironment";
            this.comboBoxEnvironment.Size = new System.Drawing.Size(273, 53);
            this.comboBoxEnvironment.TabIndex = 20;
            // 
            // labelEnvironment
            // 
            this.labelEnvironment.AutoSize = true;
            this.labelEnvironment.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnvironment.Location = new System.Drawing.Point(1189, 601);
            this.labelEnvironment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEnvironment.Name = "labelEnvironment";
            this.labelEnvironment.Size = new System.Drawing.Size(234, 45);
            this.labelEnvironment.TabIndex = 19;
            this.labelEnvironment.Text = "Environment :";
            // 
            // textBoxPetName
            // 
            this.textBoxPetName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPetName.Location = new System.Drawing.Point(597, 601);
            this.textBoxPetName.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBoxPetName.Name = "textBoxPetName";
            this.textBoxPetName.Size = new System.Drawing.Size(312, 52);
            this.textBoxPetName.TabIndex = 18;
            // 
            // labelPetName
            // 
            this.labelPetName.AutoSize = true;
            this.labelPetName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPetName.Location = new System.Drawing.Point(263, 605);
            this.labelPetName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPetName.Name = "labelPetName";
            this.labelPetName.Size = new System.Drawing.Size(298, 45);
            this.labelPetName.TabIndex = 17;
            this.labelPetName.Text = "Enter Pet Name :";
            // 
            // textBoxPlayerName
            // 
            this.textBoxPlayerName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPlayerName.Location = new System.Drawing.Point(459, 80);
            this.textBoxPlayerName.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBoxPlayerName.Name = "textBoxPlayerName";
            this.textBoxPlayerName.Size = new System.Drawing.Size(312, 52);
            this.textBoxPlayerName.TabIndex = 13;
            // 
            // labelSelectPet
            // 
            this.labelSelectPet.AutoSize = true;
            this.labelSelectPet.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectPet.Location = new System.Drawing.Point(129, 160);
            this.labelSelectPet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSelectPet.Name = "labelSelectPet";
            this.labelSelectPet.Size = new System.Drawing.Size(293, 45);
            this.labelSelectPet.TabIndex = 12;
            this.labelSelectPet.Text = "Select Your Pet :\r\n";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(125, 85);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(317, 45);
            this.labelName.TabIndex = 11;
            this.labelName.Text = "Enter Your Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1076, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 45);
            this.label1.TabIndex = 22;
            this.label1.Text = "Difficulty :";
            // 
            // comboBoxDifficulty
            // 
            this.comboBoxDifficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDifficulty.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDifficulty.FormattingEnabled = true;
            this.comboBoxDifficulty.Items.AddRange(new object[] {
            "Easy",
            "Normal",
            "Hard"});
            this.comboBoxDifficulty.Location = new System.Drawing.Point(1284, 89);
            this.comboBoxDifficulty.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.comboBoxDifficulty.Name = "comboBoxDifficulty";
            this.comboBoxDifficulty.Size = new System.Drawing.Size(273, 53);
            this.comboBoxDifficulty.TabIndex = 23;
            // 
            // radioButtonChameleon
            // 
            this.radioButtonChameleon.BackgroundImage = global::_3_CS_BAGUS.Properties.Resources.chameleon_happy;
            this.radioButtonChameleon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.radioButtonChameleon.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButtonChameleon.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonChameleon.Location = new System.Drawing.Point(1267, 265);
            this.radioButtonChameleon.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.radioButtonChameleon.Name = "radioButtonChameleon";
            this.radioButtonChameleon.Size = new System.Drawing.Size(264, 231);
            this.radioButtonChameleon.TabIndex = 16;
            this.radioButtonChameleon.Text = "Chameleon";
            this.radioButtonChameleon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButtonChameleon.UseVisualStyleBackColor = true;
            this.radioButtonChameleon.CheckedChanged += new System.EventHandler(this.radioButtonChameleon_CheckedChanged);
            // 
            // radioButtonFish
            // 
            this.radioButtonFish.BackgroundImage = global::_3_CS_BAGUS.Properties.Resources.fish_happy;
            this.radioButtonFish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.radioButtonFish.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButtonFish.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFish.Location = new System.Drawing.Point(781, 265);
            this.radioButtonFish.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.radioButtonFish.Name = "radioButtonFish";
            this.radioButtonFish.Size = new System.Drawing.Size(264, 231);
            this.radioButtonFish.TabIndex = 15;
            this.radioButtonFish.Text = "Fish";
            this.radioButtonFish.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButtonFish.UseVisualStyleBackColor = true;
            this.radioButtonFish.CheckedChanged += new System.EventHandler(this.radioButtonFish_CheckedChanged);
            // 
            // radioButtonCat
            // 
            this.radioButtonCat.BackgroundImage = global::_3_CS_BAGUS.Properties.Resources.cat_happy;
            this.radioButtonCat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.radioButtonCat.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButtonCat.Checked = true;
            this.radioButtonCat.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCat.Location = new System.Drawing.Point(311, 265);
            this.radioButtonCat.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.radioButtonCat.Name = "radioButtonCat";
            this.radioButtonCat.Size = new System.Drawing.Size(264, 248);
            this.radioButtonCat.TabIndex = 14;
            this.radioButtonCat.TabStop = true;
            this.radioButtonCat.Text = "Cat";
            this.radioButtonCat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButtonCat.UseVisualStyleBackColor = true;
            this.radioButtonCat.CheckedChanged += new System.EventHandler(this.radioButtonCat_CheckedChanged);
            // 
            // radioButtonPig
            // 
            this.radioButtonPig.BackgroundImage = global::_3_CS_BAGUS.Properties.Resources.pig_happy;
            this.radioButtonPig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.radioButtonPig.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButtonPig.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonPig.Location = new System.Drawing.Point(1718, 248);
            this.radioButtonPig.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.radioButtonPig.Name = "radioButtonPig";
            this.radioButtonPig.Size = new System.Drawing.Size(282, 248);
            this.radioButtonPig.TabIndex = 24;
            this.radioButtonPig.Text = "Pig";
            this.radioButtonPig.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButtonPig.UseVisualStyleBackColor = true;
            this.radioButtonPig.CheckedChanged += new System.EventHandler(this.radioButtonPig_CheckedChanged);
            // 
            // FormSelectPet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(2123, 828);
            this.Controls.Add(this.radioButtonPig);
            this.Controls.Add(this.comboBoxDifficulty);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.comboBoxEnvironment);
            this.Controls.Add(this.labelEnvironment);
            this.Controls.Add(this.textBoxPetName);
            this.Controls.Add(this.labelPetName);
            this.Controls.Add(this.radioButtonChameleon);
            this.Controls.Add(this.radioButtonFish);
            this.Controls.Add(this.radioButtonCat);
            this.Controls.Add(this.textBoxPlayerName);
            this.Controls.Add(this.labelSelectPet);
            this.Controls.Add(this.labelName);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "FormSelectPet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Pet";
            this.Load += new System.EventHandler(this.FormSelectPet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.ComboBox comboBoxEnvironment;
        private System.Windows.Forms.Label labelEnvironment;
        private System.Windows.Forms.TextBox textBoxPetName;
        private System.Windows.Forms.Label labelPetName;
        private System.Windows.Forms.RadioButton radioButtonChameleon;
        private System.Windows.Forms.RadioButton radioButtonFish;
        private System.Windows.Forms.RadioButton radioButtonCat;
        private System.Windows.Forms.TextBox textBoxPlayerName;
        private System.Windows.Forms.Label labelSelectPet;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxDifficulty;
        private System.Windows.Forms.RadioButton radioButtonPig;
    }
}