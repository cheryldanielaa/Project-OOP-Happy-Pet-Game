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
    public partial class FormSelectToys : Form
    {
        
        FormGame frmGame;
        Toy selectedToys;
        

        public FormSelectToys()
        {
            InitializeComponent();
        }

        private void linkLabelBuyHere_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormToysShop form = new FormToysShop();
            form.Owner = this;
            form.ShowDialog();
        }

        private void FormSelectToys_Load(object sender, EventArgs e)
        {
            frmGame = (FormGame)this.Owner;
            if (frmGame.myPet.ListToys.Count>0)
            {
                comboBoxToys.DataSource = frmGame.myPet.ListToys;
                comboBoxToys.DisplayMember = "Name";
            }
        }

        private void comboBoxToys_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedToys = (Toy) comboBoxToys.SelectedItem;
            labelToysData.Text = selectedToys.DisplayData();
            pictureBoxToy.Image = selectedToys.Picture;
        }

        private void buttonUse_Click(object sender, EventArgs e)
        {

                if (frmGame.myPet is Cat)
                {
                    if (selectedToys.Name == "Ball")
                    {
                        frmGame.pictureBoxPet.Image = Properties.Resources.cat_play_ball;
                    }
                    else if (selectedToys.Name == "Stick")
                    {
                        frmGame.pictureBoxPet.Image = Properties.Resources.cat_play_stick;
                    }
                    else if (selectedToys.Name == "Yarn")
                    {
                        frmGame.pictureBoxPet.Image = Properties.Resources.cat_play_yarn;
                    }
                }
                else if (frmGame.myPet is Pig)
                {
                    if (selectedToys.Name == "Ball")
                    {
                        frmGame.pictureBoxPet.Image = Properties.Resources.pig_play_ball;
                    }
                    else if (selectedToys.Name == "Stick")
                    {
                        frmGame.pictureBoxPet.Image = Properties.Resources.pig_play_stick;
                    }
                    else if (selectedToys.Name == "Yarn")
                    {
                        frmGame.pictureBoxPet.Image = Properties.Resources.pig_play_yarn;
                    }
                }

                frmGame.myPet.Play(selectedToys);
                frmGame.labelPetData.Text = frmGame.myPet.DisplayData();
                frmGame.labelPlayerData.Text = frmGame.myPlayer.DisplayData();
                frmGame.timerActivities.Start();
                this.Close();

            
        }
    }
}
