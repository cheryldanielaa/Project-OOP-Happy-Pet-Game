using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_CS_BAGUS
{
    public partial class FormOutside : Form
    {
        FormGame frmGame;
        public List<Potion> listPotion = new List<Potion>();
        Potion healthPotion, specialPotion, energyPotion, happinessPotion;
        SoundPlayer sound;
        private void FormOutside_KeyDown(object sender, KeyEventArgs e)
        {
            //supaya berubah ketika arrow right
            if (e.KeyCode.Equals(Keys.Left))
            {
                if (pet.Left - 40 > 0)
                {
                    pet.Left -= 40;
                }

            }
            else if (e.KeyCode.Equals(Keys.Right))
            {
                if (pet.Left + 40 < (this.Width - pet.Width))
                {
                    pet.Left += 40;
                }
            }
            else if (e.KeyCode.Equals(Keys.Up))
            {
                if (pet.Top - 40 > 0)
                {
                    pet.Top -= 40;
                }
            }
            else if (e.KeyCode.Equals(Keys.Down))
            {
                if (pet.Top + 40 < (this.Height - pet.Height))
                {
                    pet.Top += 40;
                }
            }

            Random rnd = new Random();
            x = rnd.Next(300, 800);
            y = rnd.Next(200, 400);

            if (pet.Bounds.IntersectsWith(health_potion.Bounds))
            {
                //ubah lokasi potion
                health_potion.Location = new Point(x, y);

                //tambah indikator
                frmGame.myPet.AddIndicatorPotion(healthPotion);

                //bunyi
                sound.Play();
            }
            else if (pet.Bounds.IntersectsWith(energy_potion.Bounds))
            {
                //ubah lokasi potion
                energy_potion.Location = new Point(x, y);

                //tambah indikator
                frmGame.myPet.AddIndicatorPotion(energyPotion);

                sound.Play();
            }

            else if (pet.Bounds.IntersectsWith(happiness_potion.Bounds))
            {
                //ubah lokasi potion
                happiness_potion.Location = new Point(x, y);

                //tambah indikator
                frmGame.myPet.AddIndicatorPotion(happinessPotion);

                sound.Play();
            }

            else if (pet.Bounds.IntersectsWith(special_potion.Bounds))
            {
                //ubah lokasi potion
                special_potion.Location = new Point(x, y);

                //tambah indikator
                frmGame.myPet.AddIndicatorPotion(specialPotion);

                sound.Play();
            }

        }

        private void timerIndicator_Tick(object sender, EventArgs e)
        {
            labelPlayerData.Text = frmGame.labelPlayerData.Text;
            labelPetData.Text = frmGame.labelPetData.Text;
            labelDateTime.Text = frmGame.labelDateTime.Text;
        }

        private void pet_Click(object sender, EventArgs e)
        {

        }

        int x, y;
        public FormOutside()
        {
            InitializeComponent();
        }

        private void FormOutside_Load(object sender, EventArgs e)
        {
            frmGame = (FormGame)this.Owner;
            labelPlayerData.Text = frmGame.labelPlayerData.Text;
            labelPetData.Text = frmGame.labelPetData.Text;
            labelDateTime.Text = frmGame.labelDateTime.Text;

            if (frmGame.myPet is Cat )
            {
                pet.Image = Properties.Resources.cat_happy;
            }
            else if (frmGame.myPet is Pig)
            {
                pet.Image = Properties.Resources.pig_happy;
            }

            healthPotion = new Potion("health potion", 0, 0, 50, Properties.Resources.health_potion);
            this.listPotion.Add(healthPotion);
            specialPotion = new Potion("special potion", 75, 75, 75, Properties.Resources.special_potion);
            this.listPotion.Add(specialPotion);
            energyPotion = new Potion("energy potion", 0, 50, 0, Properties.Resources.energy_potion);
            this.listPotion.Add(energyPotion);
            happinessPotion = new Potion("happiness potion", 50, 0, 0, Properties.Resources.happiness_potion);
            this.listPotion.Add(happinessPotion);

            sound = new SoundPlayer(Properties.Resources.hap);
        }


    }
}
