using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_CS_BAGUS
{
    public partial class FormSelectPlayer : Form
    {
        FormGame frmGame;
        public FormSelectPlayer()
        {
            InitializeComponent();
        }

        private void linkLabelClickHere_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormSelectPet form = new FormSelectPet();
            form.Owner = this;
            form.ShowDialog();
        }

        private void FormSelectPlayer_Load(object sender, EventArgs e)
        {
            frmGame = (FormGame)this.Owner;
            if (frmGame.listPlayer.Count > 0)
            {
                comboBoxPlayer.DataSource = frmGame.listPlayer;
                comboBoxPlayer.DisplayMember = "Name";
            }
            
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            //dapatkan objek player yg dipilih user
            frmGame.myPlayer = (Player)comboBoxPlayer.SelectedItem;

            foreach (Pet pet in frmGame.listPet)
            {
                if (pet.Owner.Name == frmGame.myPlayer.Name)
                {
                    frmGame.myPet = pet;
                }
            }
            frmGame.StartGame();
            this.Close();
        }
    }
}
