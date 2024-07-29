namespace _3_CS_BAGUS
{
    partial class FormChangePet
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
            this.labelSelectPet = new System.Windows.Forms.Label();
            this.radioButtonPig = new System.Windows.Forms.RadioButton();
            this.radioButtonChameleon = new System.Windows.Forms.RadioButton();
            this.radioButtonFish = new System.Windows.Forms.RadioButton();
            this.radioButtonCat = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // buttonPlay
            // 
            this.buttonPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonPlay.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlay.ForeColor = System.Drawing.Color.Black;
            this.buttonPlay.Location = new System.Drawing.Point(937, 610);
            this.buttonPlay.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(315, 61);
            this.buttonPlay.TabIndex = 32;
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
            this.comboBoxEnvironment.Location = new System.Drawing.Point(1503, 493);
            this.comboBoxEnvironment.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxEnvironment.Name = "comboBoxEnvironment";
            this.comboBoxEnvironment.Size = new System.Drawing.Size(273, 53);
            this.comboBoxEnvironment.TabIndex = 31;
            // 
            // labelEnvironment
            // 
            this.labelEnvironment.AutoSize = true;
            this.labelEnvironment.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnvironment.Location = new System.Drawing.Point(1268, 499);
            this.labelEnvironment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEnvironment.Name = "labelEnvironment";
            this.labelEnvironment.Size = new System.Drawing.Size(234, 45);
            this.labelEnvironment.TabIndex = 30;
            this.labelEnvironment.Text = "Environment :";
            // 
            // textBoxPetName
            // 
            this.textBoxPetName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPetName.Location = new System.Drawing.Point(598, 496);
            this.textBoxPetName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPetName.Name = "textBoxPetName";
            this.textBoxPetName.Size = new System.Drawing.Size(312, 52);
            this.textBoxPetName.TabIndex = 29;
            // 
            // labelPetName
            // 
            this.labelPetName.AutoSize = true;
            this.labelPetName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPetName.Location = new System.Drawing.Point(266, 499);
            this.labelPetName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPetName.Name = "labelPetName";
            this.labelPetName.Size = new System.Drawing.Size(298, 45);
            this.labelPetName.TabIndex = 28;
            this.labelPetName.Text = "Enter Pet Name :";
            // 
            // labelSelectPet
            // 
            this.labelSelectPet.AutoSize = true;
            this.labelSelectPet.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectPet.Location = new System.Drawing.Point(68, 55);
            this.labelSelectPet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSelectPet.Name = "labelSelectPet";
            this.labelSelectPet.Size = new System.Drawing.Size(293, 45);
            this.labelSelectPet.TabIndex = 23;
            this.labelSelectPet.Text = "Select Your Pet :\r\n";
            // 
            // radioButtonPig
            // 
            this.radioButtonPig.BackgroundImage = global::_3_CS_BAGUS.Properties.Resources.pig_happy;
            this.radioButtonPig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.radioButtonPig.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButtonPig.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonPig.Location = new System.Drawing.Point(1666, 162);
            this.radioButtonPig.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonPig.Name = "radioButtonPig";
            this.radioButtonPig.Size = new System.Drawing.Size(284, 256);
            this.radioButtonPig.TabIndex = 33;
            this.radioButtonPig.TabStop = true;
            this.radioButtonPig.Text = "Pig";
            this.radioButtonPig.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButtonPig.UseVisualStyleBackColor = true;
            // 
            // radioButtonChameleon
            // 
            this.radioButtonChameleon.BackgroundImage = global::_3_CS_BAGUS.Properties.Resources.chameleon_happy;
            this.radioButtonChameleon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.radioButtonChameleon.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButtonChameleon.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonChameleon.Location = new System.Drawing.Point(1205, 162);
            this.radioButtonChameleon.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonChameleon.Name = "radioButtonChameleon";
            this.radioButtonChameleon.Size = new System.Drawing.Size(264, 231);
            this.radioButtonChameleon.TabIndex = 27;
            this.radioButtonChameleon.TabStop = true;
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
            this.radioButtonFish.Location = new System.Drawing.Point(720, 162);
            this.radioButtonFish.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonFish.Name = "radioButtonFish";
            this.radioButtonFish.Size = new System.Drawing.Size(264, 231);
            this.radioButtonFish.TabIndex = 26;
            this.radioButtonFish.TabStop = true;
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
            this.radioButtonCat.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCat.Location = new System.Drawing.Point(249, 162);
            this.radioButtonCat.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonCat.Name = "radioButtonCat";
            this.radioButtonCat.Size = new System.Drawing.Size(264, 246);
            this.radioButtonCat.TabIndex = 25;
            this.radioButtonCat.TabStop = true;
            this.radioButtonCat.Text = "Cat";
            this.radioButtonCat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButtonCat.UseVisualStyleBackColor = true;
            this.radioButtonCat.CheckedChanged += new System.EventHandler(this.radioButtonCat_CheckedChanged);
            // 
            // FormChangePet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(2074, 702);
            this.Controls.Add(this.radioButtonPig);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.comboBoxEnvironment);
            this.Controls.Add(this.labelEnvironment);
            this.Controls.Add(this.textBoxPetName);
            this.Controls.Add(this.labelPetName);
            this.Controls.Add(this.radioButtonChameleon);
            this.Controls.Add(this.radioButtonFish);
            this.Controls.Add(this.radioButtonCat);
            this.Controls.Add(this.labelSelectPet);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormChangePet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Pet";
            this.Load += new System.EventHandler(this.FormChangePet_Load);
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
        private System.Windows.Forms.Label labelSelectPet;
        private System.Windows.Forms.RadioButton radioButtonPig;
    }
}