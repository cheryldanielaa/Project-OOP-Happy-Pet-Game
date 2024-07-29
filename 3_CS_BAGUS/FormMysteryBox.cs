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
    public partial class FormMysteryBox : Form
    {
        FormGame formGame;
        public FormMysteryBox()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (formGame.myPlayer.Coins >= 500)
            {
                formGame.myPlayer.Coins -= 500;
                Random rnd = new Random();
                int price = rnd.Next(500, 1000);
                formGame.myPlayer.Coins += price;
                MessageBox.Show("Congrats!! You get " + price + " coins");
            }
            else
            {
                MessageBox.Show("Sorry, your coins aret enough");
            }
            this.Close();
        }

        private void FormMysteryBox_Load(object sender, EventArgs e)
        {
            formGame = (FormGame)this.Owner;
        }
    }
}
