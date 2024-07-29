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
    public partial class FormSelectPet : Form
    {
        FormGame frmGame;
        public FormSelectPet()
        {
            InitializeComponent();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            try
            {
                //ciptakan objek player di form game dulu
                frmGame.myPlayer = new Player(textBoxPlayerName.Text, 100, DateTime.Now, comboBoxDifficulty.Text);

                //ciptakan objek pet sesuai pilihan
                if (radioButtonCat.Checked)
                {
                    frmGame.myPet = new Cat(textBoxPetName.Text, radioButtonCat.BackgroundImage, frmGame.myPlayer);
                }
                else if (radioButtonFish.Checked)
                {
                    frmGame.myPet = new Fish(textBoxPetName.Text, radioButtonFish.BackgroundImage, frmGame.myPlayer,
                                    comboBoxEnvironment.Text);
                }
                else if (radioButtonChameleon.Checked)
                {
                    frmGame.myPet = new Chameleon(textBoxPetName.Text, radioButtonChameleon.BackgroundImage, frmGame.myPlayer,
                                    Color.Green);
                }
                else if (radioButtonPig.Checked)
                {
                    frmGame.myPet = new Pig(textBoxPetName.Text, radioButtonPig.BackgroundImage, frmGame.myPlayer);
                }


                //cek apakah player sudah ada di listPlayer atau belum
                bool punyaPlayer = false;
                foreach(Player player in frmGame.listPlayer)
                {
                    if(player.Name == frmGame.myPet.Owner.Name)
                    {
                        punyaPlayer = true;
                        break;
                    }
                }
                if(punyaPlayer == true)
                {
                    MessageBox.Show("Player dengan nama " + frmGame.myPet.Owner.Name + " sudah tersedia. Silahkan gunakan nama lain!");
                }
                else //jika player blm digunakan maka bisa dijalankan
                {
                    //simpan player dan pet ke dalam list
                    frmGame.listPet.Add(frmGame.myPet);
                    frmGame.listPlayer.Add(frmGame.myPlayer);
                    //method untuk memulai permainan
                    frmGame.StartGame();

                    //tutup form ini dan owner dr form ini (select player)
                    this.Close();
                    this.Owner.Close();
                }     

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormSelectPet_Load(object sender, EventArgs e)
        {
            frmGame = (FormGame)this.Owner.Owner;
            labelEnvironment.Visible = false;
            comboBoxEnvironment.Visible = false;

            textBoxPlayerName.Text = "Player 1";
            textBoxPetName.Text = "My Pet";
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

        private void radioButtonPig_CheckedChanged(object sender, EventArgs e)
        {
            labelEnvironment.Visible = false;
            comboBoxEnvironment.Visible = false;
        }
    }
}
