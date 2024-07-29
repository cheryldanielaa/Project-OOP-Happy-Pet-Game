using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _3_CS_BAGUS
{
    public partial class FormGame : Form
    {
        //ciptakan objek player dan pet
        public Pet myPet;
        public Player myPlayer;

        //simpan player dan pet dalam list
        public BindingList<Player> listPlayer = new BindingList<Player>();
        public BindingList<Pet> listPet = new BindingList<Pet>();
        int detik;

        public FormGame()
        {
            InitializeComponent();
        }

        public void StartGame() //method untuk memulai permainan
        {
                //tampilkan data player dan pet di label yang ada di form game
                labelPlayerData.Text = myPlayer.DisplayData();
                labelPetData.Text = myPet.DisplayData();
                //tampilkan datetime
                labelDateTime.Text = DateTime.Now.ToString();
                panelData.Visible = true;
                panelActivities.Visible = true;
                pictureBoxPet.Image = myPet.Picture;
                pictureBoxPet.Visible = true;
                panelFeature.Visible = true;
                 buttonTutorial.Visible = true;
            this.BackgroundImage = Properties.Resources.Room;

            //atur enable/disable button tergantung jenis pet
            if (myPet is Cat)
            {
                buttonFeed.Enabled = true;
                buttonPlay.Enabled = true;
                buttonSleep.Enabled = true;
                buttonBath.Enabled = true;
                buttonVaccinate.Enabled = true;
                buttonClean.Enabled = false;
                buttonChangeColor.Enabled = false;
                buttonOutfitShop.Enabled = true;
                buttonOutside.Enabled = true;
            }
            else if (myPet is Fish)
            {
                buttonFeed.Enabled = true;
                buttonPlay.Enabled = false;
                buttonSleep.Enabled = false;
                buttonBath.Enabled = false;
                buttonVaccinate.Enabled = false;
                buttonClean.Enabled = true;
                buttonChangeColor.Enabled = false;
                buttonOutfitShop.Enabled = false;
                buttonOutside.Enabled = false;
            }
            else if (myPet is Chameleon)
            {
                buttonFeed.Enabled = true;
                buttonPlay.Enabled = false;
                buttonSleep.Enabled = true;
                buttonBath.Enabled = false;
                buttonVaccinate.Enabled = false;
                buttonClean.Enabled = false;
                buttonChangeColor.Enabled = true;
                buttonOutfitShop.Enabled = false;
                buttonOutside.Enabled = false;

            }
            else if (myPet is Pig)
            {
                buttonFeed.Enabled = true;
                buttonPlay.Enabled = true;
                buttonSleep.Enabled = true;
                buttonBath.Enabled = true;
                buttonVaccinate.Enabled = true;
                buttonClean.Enabled = false;
                buttonChangeColor.Enabled = false;
                buttonOutfitShop.Enabled = false;
                buttonOutside.Enabled = true;

            }
            //level
            if (myPlayer.Level == "Easy")
            {
                timerIndicator.Interval = 10000;
            }
            else if (myPlayer.Level == "Normal")
            {
                timerIndicator.Interval = 5000;
            }
            else if (myPlayer.Level == "Hard")
            {
                timerIndicator.Interval = 1000;
            }
            timerIndicator.Start();

        }
       
        private void FormGame_Load(object sender, EventArgs e)
        {
            FormTutorial form = new FormTutorial();
            form.Owner = this;
            form.ShowDialog();

            panelActivities.Visible = false;
            panelData.Visible = false;
            panelFeature.Visible = false;
            buttonTutorial.Visible = false;

            this.BackgroundImage = Properties.Resources.happy_pet_game;

           ReadFilePet("pet.hpg");
           ReadFilePlayer("player.hpg");
        }

        private void playGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSelectPlayer form = new FormSelectPlayer();
            form.Owner = this;
            form.ShowDialog();

            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            FormSelectToys form = new FormSelectToys();
            form.Owner = this;
            form.ShowDialog();
        }

        private void ChangeImageActivities(string activity)
        {
            if(myPet  is Cat)
            {
               if(activity == "feed")
                {
                    pictureBoxPet.Image = Properties.Resources.cat_feed;
                }
               else if(activity =="sleep")
                {
                    pictureBoxPet.Image = Properties.Resources.cat_sleep;
                }
               else if(activity == "vaccinate")
                {
                    pictureBoxPet.Image = Properties.Resources.cat_vaccinate;
                }
               else if(activity == "bath")
                {
                    this.BackgroundImage = Properties.Resources.bathroom;
                    pictureBoxPet.Image = Properties.Resources.cat_bath;
                }
               else if(activity == "-")
                {
                    pictureBoxPet.Image = Properties.Resources.cat_happy;
                }
            }
            else if(myPet is Fish)
            {
                if (activity == "clean")
                {
                    pictureBoxPet.Image = Properties.Resources.fish_clean;
                }
                else if(activity == "feed")
                {
                    pictureBoxPet.Image = Properties.Resources.fish_feed;
                }
                else if (activity == "-")
                {
                    pictureBoxPet.Image = Properties.Resources.fish_happy;
                }
            }
            else if(myPet is Chameleon)
            {
                if(activity == "feed")
                {
                    pictureBoxPet.Image = Properties.Resources.chameleon_feed;
                }
                else if(activity == "sleep")
                {
                    pictureBoxPet.Image = Properties.Resources.chameleon_sleep;
                }
                else if(activity == "change color")
                {
                    pictureBoxPet.Image = Properties.Resources.chameleon_purple;
                }
                else if (activity == "-")
                {

                    pictureBoxPet.Image = Properties.Resources.chameleon_happy;
                }
            }
            else if (myPet is Pig)
            {
                if (activity == "feed")
                {
                    pictureBoxPet.Image = Properties.Resources.pig_feed;
                }
                else if (activity == "sleep")
                {
                    pictureBoxPet.Image = Properties.Resources.pig_sleep;
                }
                else if (activity == "vaccinate")
                {
                    pictureBoxPet.Image = Properties.Resources.pig_vaccination;
                }
                else if (activity == "bath")
                {
                    this.BackgroundImage = Properties.Resources.bathroom;
                    pictureBoxPet.Image = Properties.Resources.pig_shower;
                }
                else if (activity == "-")
                {
                    pictureBoxPet.Image = Properties.Resources.pig_happy;
                }

            }
            if(myPet is Chameleon)
            {
                ((Chameleon)myPet).CurrentColor = Color.Green;
            }

            if(activity == "-")
            {
                panelActivities.Enabled = true;
            }
            else
            {
                panelActivities.Enabled = false;
            }
            detik = 0;
            timerActivities.Interval = 1000;
            timerActivities.Start();

        }

        private void buttonFeed_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Room;
            myPet.Feed();
            labelPetData.Text = myPet.DisplayData();
            labelPlayerData.Text = myPlayer.DisplayData();
            this.ChangeImageActivities("feed");
        }

        private void buttonBath_Click(object sender, EventArgs e)
        {
            if(myPet is Cat)
            {
                ((Cat)myPet).Bath();
                labelPetData.Text = myPet.DisplayData();
                labelPlayerData.Text = myPlayer.DisplayData();
                this.ChangeImageActivities("bath");
            }
            else if (myPet is Pig)
            {
                ((Pig)myPet).Bath();
                labelPetData.Text = myPet.DisplayData();
                labelPlayerData.Text = myPlayer.DisplayData();
                this.ChangeImageActivities("bath");
            }
        }

        private void buttonVaccinate_Click(object sender, EventArgs e)
        {
            try
            {
                this.BackgroundImage = Properties.Resources.Room;
                if (myPet is Cat)
                {
                    ((Cat)myPet).Vaccination();
                    labelPetData.Text = myPet.DisplayData();
                    labelPlayerData.Text = myPlayer.DisplayData();
                    this.ChangeImageActivities("vaccinate");
                }
                else if (myPet is Pig)
                {

                    ((Pig)myPet).Vaccination();
                    labelPetData.Text = myPet.DisplayData();
                    labelPlayerData.Text = myPlayer.DisplayData();
                    this.ChangeImageActivities("vaccinate");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {
            try
            {
                this.BackgroundImage = Properties.Resources.Room;
                if (myPet is Fish)
                {
                    ((Fish)myPet).Clean();
                    labelPetData.Text = myPet.DisplayData();
                    labelPlayerData.Text = myPlayer.DisplayData();
                    this.ChangeImageActivities("clean");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
        }

        private void buttonSleep_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Room;
            if (myPet is Cat || myPet is Chameleon || myPet is Pig)
            {
                myPet.Sleep();
                labelPetData.Text = myPet.DisplayData();
                labelPlayerData.Text = myPlayer.DisplayData();
                this.ChangeImageActivities("sleep");
            }
            if(myPet is Chameleon)
            {
                ((Chameleon)myPet).CurrentColor = Color.Green;
            }
        }

        private void buttonChangeColor_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Room;
            if (myPet is Chameleon)
            {
                //gimana biar waktu selain opsi change color, color nya balik ke green
                ((Chameleon)myPet).CurrentColor = Color.Purple;
                labelPetData.Text = myPet.DisplayData();
                labelPlayerData.Text = myPlayer.DisplayData();
                this.ChangeImageActivities("change color");
            }
        }

        private void timerActivities_Tick(object sender, EventArgs e)
        {
            //misal setelah 3 detik, gambar kembali ke bentuk semula
            detik++;
            if (detik == 3)
            {
                timerActivities.Stop();
                //setelah 3 detik maka gmbr pet kembali ke bentuk semula
                this.ChangeImageActivities("-");
            }
        }

        
        
        private void timerIndicator_Tick(object sender, EventArgs e)
        {
            //setiap detik, indikator berkurang 5%
            myPet.Happiness -= 5;
            myPet.Energy -= 5;
            myPet.Health -= 5;

            //cek status pet
            //apabila status pet weak, unhappy, dan very poor, maka game over
            if (myPet.CheckHappinessPet()=="Unhappy" && 
                myPet.CheckEnergyPet() == "Weak" &&
                myPet.CheckHealthPet() == "Very Poor")
            {
                timerIndicator.Stop();
                MessageBox.Show("Sorry, you lose the game");
                pictureBoxPet.Visible = false;
                panelActivities.Visible = false;
                panelData.Visible = false;
                panelFeature.Visible = false;
                this.BackgroundImage = Properties.Resources.happy_pet_game;
                buttonTutorial.Visible = false;
                listPet.Remove(myPet);
                listPlayer.Remove(myPlayer);

                //close semua form selain main form
                foreach (Form form in Application.OpenForms)
                {
                    if (form.Name != "FormGame")
                    {
                        form.Close();
                    }
                }
            }

            labelPlayerData.Text = myPlayer.DisplayData();
            labelPetData.Text = myPet.DisplayData();
            labelDateTime.Text = DateTime.Now.ToString();     
            
            //update status lastPlayed pemain
            myPet.Owner.LastPlay = DateTime.Now;
        }

        public void SaveFilePlayer(string fileName)
        {
            FileStream myFile = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryFormatter myFormatter = new BinaryFormatter();
            myFormatter.Serialize(myFile, listPlayer);
            myFile.Close();
        }
        public void SaveFilePet(string fileName)
        {
            FileStream myFile = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryFormatter myFormatter = new BinaryFormatter();
            myFormatter.Serialize(myFile, listPet);
            myFile.Close();
        }

        public void ReadFilePet(string fileName)
        {
            if (File.Exists(fileName))
            {
                FileStream myFile = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                BinaryFormatter myFormatter = new BinaryFormatter();
                listPet = (BindingList<Pet>)myFormatter.Deserialize(myFile);
                myFile.Close();
            }
        }

        public void ReadFilePlayer (string fileName)
        {
            if (File.Exists(fileName))
            {
                FileStream myFile = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                BinaryFormatter myFormatter = new BinaryFormatter();
                listPlayer = (BindingList<Player>)myFormatter.Deserialize(myFile);
                myFile.Close();
            }
        }

        private void FormGame_FormClosing(object sender, FormClosingEventArgs e)
        {
                this.SaveFilePet("pet.hpg");
                this.SaveFilePlayer("player.hpg"); 
        }

        private void changePetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(myPlayer!=null)
            {
                FormChangePet form = new FormChangePet();
                form.Owner = this;
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select your player first!");
            }
        }

        private void resetGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to reset your data?", "Confirmation",MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)                
                {
                    //hapus file yg sdh disimpan
                    if (File.Exists("pet.hpg"))
                    {
                        File.Delete("pet.hpg");
                    }
                    if (File.Exists("player.hpg"))
                    {
                        File.Delete("player.hpg");
                    }
                    //hapus semua list&player
                    listPet.Clear();
                    listPlayer.Clear();

                    //close semua form selain formGame

                    foreach (Form form in Application.OpenForms)
                    {
                        if (form.Name != "FormGame")
                        {
                            form.Close();
                        }
                    }

                    panelData.Visible = false;
                    panelActivities.Visible = false;
                    pictureBoxPet.Visible = false;
                    panelFeature.Visible = false;
                    timerIndicator.Stop();

                this.BackgroundImage = Properties.Resources.happy_pet_game;
                }            
        }

        private void buttonTutorial_Click(object sender, EventArgs e)
        {
            FormTutorial form = new FormTutorial();
            form.Owner = this;
            form.ShowDialog();
        }

        private void buttonOutfitShop_Click(object sender, EventArgs e)
        {
            FormSelectOutfit form = new FormSelectOutfit();
            form.Owner = this;
            form.ShowDialog();
        }

        private void buttonOutside_Click(object sender, EventArgs e)
        {
            FormOutside form = new FormOutside();
            form.Owner = this;
            form.ShowDialog();
        }

        private void pauseGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPauseGame form = new FormPauseGame();
            form.Owner = this;
            //apabila dipause, maka semua indicator berhenti
            if (myPet is Cat || myPet is Fish || myPet is Chameleon || myPet is Pig)
            {
                timerIndicator.Stop();
                form.ShowDialog();
                buttonTutorial.Visible = false;
            }
        }

        private void buttonMysteryBox_Click(object sender, EventArgs e)
        {
            FormMysteryBox form = new FormMysteryBox();
            form.Owner = this;
            form.ShowDialog();
        }
    }
}
