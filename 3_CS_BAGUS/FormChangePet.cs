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
    public partial class FormChangePet : Form
    {
        FormGame frmGame;
        public FormChangePet()
        {
            InitializeComponent();
        }

        private void radioButtonCat_CheckedChanged(object sender, EventArgs e)
        {
            labelEnvironment.Visible = false;
            comboBoxEnvironment.Visible = false;
        }

        private void radioButtonFish_CheckedChanged(object sender, EventArgs e)
        {
            labelEnvironment.Visible = true;
            comboBoxEnvironment.Visible = true;
        }

        private void radioButtonChameleon_CheckedChanged(object sender, EventArgs e)
        {
            labelEnvironment.Visible = false;
            comboBoxEnvironment.Visible = false;
        }

        private void FormChangePet_Load(object sender, EventArgs e)
        {
            frmGame = (FormGame)this.Owner;
        }

        
        private void buttonPlay_Click(object sender, EventArgs e)
        {
            try
            {
                int index = frmGame.listPlayer.IndexOf(frmGame.myPlayer);
                frmGame.listPet.Remove(frmGame.myPet);
                if (radioButtonFish.Checked)
                {
                    //buat objek fish baru
                    frmGame.myPet = new Fish(textBoxPetName.Text, radioButtonFish.BackgroundImage, frmGame.myPlayer, comboBoxEnvironment.Text);
                    frmGame.listPet.Insert(index, frmGame.myPet);
                    frmGame.StartGame();
                    frmGame.myPet.Owner.Coins = 100;
                    frmGame.myPet.Owner.LastPlay = DateTime.Now;
                }
                else if (radioButtonCat.Checked)
                {
                    //buat objek cat baru
                    frmGame.myPet = new Cat(textBoxPetName.Text, radioButtonCat.BackgroundImage, frmGame.myPlayer);
                    frmGame.listPet.Insert(index, frmGame.myPet);
                    frmGame.StartGame();
                    frmGame.myPet.Owner.Coins = 100;
                    frmGame.myPet.Owner.LastPlay = DateTime.Now;
                }
                else if (radioButtonChameleon.Checked)
                {
                    frmGame.myPet = new Chameleon(textBoxPetName.Text, radioButtonChameleon.BackgroundImage, frmGame.myPlayer,Color.Green);
                    frmGame.listPet.Insert(index, frmGame.myPet);
                    frmGame.StartGame();
                    frmGame.myPet.Owner.Coins = 100;
                    frmGame.myPet.Owner.LastPlay = DateTime.Now;
                }
                else if (radioButtonPig.Checked)
                {
                    //buat objek cat baru
                    frmGame.myPet = new Pig(textBoxPetName.Text, radioButtonPig.BackgroundImage, frmGame.myPlayer);
                    frmGame.listPet.Insert(index, frmGame.myPet);
                    frmGame.StartGame();
                    frmGame.myPet.Owner.Coins = 100;
                    frmGame.myPet.Owner.LastPlay = DateTime.Now;
                }

                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
