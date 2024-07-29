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
    public partial class FormSelectOutfit : Form
    {
        FormGame frmGame;
        Outfit selectedOutfit;
        public FormSelectOutfit()
        {
            InitializeComponent();
        }

        private void FormSelectOutfit_Load(object sender, EventArgs e)
        {
            frmGame = (FormGame)this.Owner;
            frmGame = (FormGame)this.Owner;
            Cat cat = ((Cat)frmGame.myPet);
            if (cat.ListOutfit.Count > 0)
            {
                comboBoxOutfit.DataSource = ((Cat)frmGame.myPet).ListOutfit;
                comboBoxOutfit.DisplayMember = "Name";
            }
        }

        private void comboBoxOutfit_SelectedIndexChanged(object sender, EventArgs e)
        {

            selectedOutfit = (Outfit)comboBoxOutfit.SelectedItem;
            labelOutfitData.Text = selectedOutfit.DisplayData();
            pictureBoxImage.Image = selectedOutfit.Picture;
        }

        private void buttonUse_Click(object sender, EventArgs e)
        {
            ((Cat)frmGame.myPet).WearOutfit(selectedOutfit);
            if (selectedOutfit.Name == "sunglasses")
            {
                frmGame.pictureBoxPet.Image = Properties.Resources.cat_sunglasses;
            }
            else if (selectedOutfit.Name == "ribbon")
            {
                frmGame.pictureBoxPet.Image = Properties.Resources.cat_ribbon;
            }
            else if (selectedOutfit.Name == "glasses")
            {
                frmGame.pictureBoxPet.Image = Properties.Resources.cat_glasses;
            }
            else if (selectedOutfit.Name == "collar")
            {
                frmGame.pictureBoxPet.Image = Properties.Resources.cat_collar;
            }
            else if (selectedOutfit.Name == "cap")
            {
                frmGame.pictureBoxPet.Image = Properties.Resources.cat_cap;
            }
            else if (selectedOutfit.Name == "special outfit")
            {
                frmGame.pictureBoxPet.Image = Properties.Resources.cat_outfit;
            }
            else if (selectedOutfit.Name == "scarf")
            {
                frmGame.pictureBoxPet.Image = Properties.Resources.cat_scarf;
            }

            this.Close();

        }

        private void linkLabelClickHere_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormOutfit form = new FormOutfit();
            form.Owner = this;
            form.ShowDialog();
        }
    }
}
