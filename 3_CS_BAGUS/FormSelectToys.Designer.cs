namespace _3_CS_BAGUS
{
    partial class FormSelectToys
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
            this.linkLabelBuyHere = new System.Windows.Forms.LinkLabel();
            this.labelAsk = new System.Windows.Forms.Label();
            this.buttonUse = new System.Windows.Forms.Button();
            this.labelToysData = new System.Windows.Forms.Label();
            this.comboBoxToys = new System.Windows.Forms.ComboBox();
            this.labelSelectToys = new System.Windows.Forms.Label();
            this.pictureBoxToy = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxToy)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabelBuyHere
            // 
            this.linkLabelBuyHere.AutoSize = true;
            this.linkLabelBuyHere.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelBuyHere.Location = new System.Drawing.Point(292, 599);
            this.linkLabelBuyHere.Name = "linkLabelBuyHere";
            this.linkLabelBuyHere.Size = new System.Drawing.Size(121, 35);
            this.linkLabelBuyHere.TabIndex = 12;
            this.linkLabelBuyHere.TabStop = true;
            this.linkLabelBuyHere.Text = "Buy Here";
            this.linkLabelBuyHere.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelBuyHere_LinkClicked);
            // 
            // labelAsk
            // 
            this.labelAsk.AutoSize = true;
            this.labelAsk.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAsk.Location = new System.Drawing.Point(15, 599);
            this.labelAsk.Name = "labelAsk";
            this.labelAsk.Size = new System.Drawing.Size(263, 35);
            this.labelAsk.TabIndex = 11;
            this.labelAsk.Text = "Don\'t have any toys?";
            // 
            // buttonUse
            // 
            this.buttonUse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonUse.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUse.Location = new System.Drawing.Point(70, 485);
            this.buttonUse.Name = "buttonUse";
            this.buttonUse.Size = new System.Drawing.Size(297, 60);
            this.buttonUse.TabIndex = 10;
            this.buttonUse.Text = "Use";
            this.buttonUse.UseVisualStyleBackColor = false;
            this.buttonUse.Click += new System.EventHandler(this.buttonUse_Click);
            // 
            // labelToysData
            // 
            this.labelToysData.BackColor = System.Drawing.Color.White;
            this.labelToysData.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelToysData.Location = new System.Drawing.Point(108, 340);
            this.labelToysData.Name = "labelToysData";
            this.labelToysData.Size = new System.Drawing.Size(206, 124);
            this.labelToysData.TabIndex = 9;
            this.labelToysData.Text = "Toys Data";
            this.labelToysData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxToys
            // 
            this.comboBoxToys.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxToys.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxToys.FormattingEnabled = true;
            this.comboBoxToys.Location = new System.Drawing.Point(21, 83);
            this.comboBoxToys.Name = "comboBoxToys";
            this.comboBoxToys.Size = new System.Drawing.Size(410, 47);
            this.comboBoxToys.TabIndex = 8;
            this.comboBoxToys.SelectedIndexChanged += new System.EventHandler(this.comboBoxToys_SelectedIndexChanged);
            // 
            // labelSelectToys
            // 
            this.labelSelectToys.AutoSize = true;
            this.labelSelectToys.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectToys.Location = new System.Drawing.Point(106, 18);
            this.labelSelectToys.Name = "labelSelectToys";
            this.labelSelectToys.Size = new System.Drawing.Size(233, 45);
            this.labelSelectToys.TabIndex = 7;
            this.labelSelectToys.Text = "Select Toys :";
            // 
            // pictureBoxToy
            // 
            this.pictureBoxToy.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxToy.Location = new System.Drawing.Point(136, 159);
            this.pictureBoxToy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxToy.Name = "pictureBoxToy";
            this.pictureBoxToy.Size = new System.Drawing.Size(165, 161);
            this.pictureBoxToy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxToy.TabIndex = 13;
            this.pictureBoxToy.TabStop = false;
            // 
            // FormSelectToys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(443, 684);
            this.Controls.Add(this.pictureBoxToy);
            this.Controls.Add(this.linkLabelBuyHere);
            this.Controls.Add(this.labelAsk);
            this.Controls.Add(this.buttonUse);
            this.Controls.Add(this.labelToysData);
            this.Controls.Add(this.comboBoxToys);
            this.Controls.Add(this.labelSelectToys);
            this.Name = "FormSelectToys";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Toys";
            this.Load += new System.EventHandler(this.FormSelectToys_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxToy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBoxToy;
        private System.Windows.Forms.LinkLabel linkLabelBuyHere;
        private System.Windows.Forms.Label labelAsk;
        private System.Windows.Forms.Button buttonUse;
        private System.Windows.Forms.Label labelToysData;
        public System.Windows.Forms.ComboBox comboBoxToys;
        private System.Windows.Forms.Label labelSelectToys;
    }
}