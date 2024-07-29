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
    public partial class FormToysShop : Form
    {
        FormGame frmGame;
        Toy toy1, toy2, toy3;
        //list untuk menyimpan semua barang yang tersedia di toko
        List<Toy> listToys = new List<Toy>();
        public FormToysShop()
        {
            InitializeComponent();
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButtonBall.Checked)
                {
                    frmGame.myPet.Buy(toy1);
                }
                else if (radioButtonStick.Checked)
                {
                    frmGame.myPet.Buy(toy2);
                }
                else if (radioButtonYarn.Checked) 
                {
                    frmGame.myPet.Buy(toy3);
                }
                MessageBox.Show("New item has been added to your drawer");

                //close form ini, update data player dan pet
                this.Close();
                this.Owner.Close();
                frmGame.labelPetData.Text = frmGame.myPet.DisplayData();
                frmGame.labelPlayerData.Text = frmGame.myPlayer.DisplayData();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void CreateToys()
        {
            toy1 = new Toy("Ball", 300, 10, Properties.Resources.cat_toys_ball);
            listToys.Add(toy1);
            labelBallData.Text = toy1.DisplayData();

            toy2 = new Toy("Stick", 200, 5, Properties.Resources.cat_toys_stick);
            listToys.Add(toy2);
            labelStickData.Text = toy2.DisplayData();

            toy3 = new Toy("Yarn", 500, 20, Properties.Resources.cat_toys_yarn);
            listToys.Add(toy3);
            labelYarnData.Text = toy3.DisplayData();
        }
        private void FormToysShop_Load(object sender, EventArgs e)
        {
            frmGame = (FormGame)this.Owner.Owner;
            CreateToys();
        }
    }
}
