using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _3_CS_BAGUS
{
    [Serializable]
    public abstract class Pet
    {
        #region data members
        private int energy;
        private int health;
        private int happiness;
        private string name;
        private Image picture;
        private Player owner; //1 pet has 1 owner >> aggregation
        private List<Toy> listToys = new List<Toy>(); //1 pet has n toys >>composition

        #endregion

        #region constructors
        public Pet(string name, Image picture, Player owner)
        {
            this.Energy = 100;
            this.Health = 100;
            this.Happiness = 100;
            this.Name = name;
            this.Picture = picture;
            this.Owner = owner;
            this.ListToys = listToys;
        }
        #endregion

        #region properties
        public int Energy
        {
            get => energy;
            set
            {
                if(value>=10 && value <= 100)
                {
                    energy = value;
                }
                else if (value < 10)
                {
                    energy = 10;
                }
                else if (value > 100)
                {
                    energy = 100;
                }
               
            }
        }
        public int Health
        {
            get => health;
            set
            {
                if (value >= 10 && value <= 100)
                {
                    health = value;
                }
                else if (value < 10)
                {
                    health = 10;
                }
                else if (value > 100)
                {
                    health = 100;
                }
            }
        }
        public int Happiness
        {
            get => happiness;
            set
            {
                if (value >= 10 && value <= 100)
                {
                    happiness = value;
                }
                else if (value < 10)
                {
                    happiness = 10;
                }
                else if (value > 100)
                {
                    happiness = 100;
                }
            }
        }

        public string Name
        {
            get => name;
            set
            {
                if (value != "")
                {
                    name = value;
                }
                else
                {
                    throw new Exception("Pet's name cannot be empty");
                }
            }
        }
        public Image Picture { get => picture; set => picture = value; }
        public Player Owner { get => owner; set => owner = value; }
        public List<Toy> ListToys { get => listToys; private set => listToys = value; }

        public Outfit Outfit
        {
            get => default;
            set
            {
            }
        }
        #endregion

        #region methods
        public abstract string DisplayData();
        protected string DisplayPet()
        {
            string data = this.Name +
                        "\nHealth : " + this.Health +
                        " % Energy : " + this.Energy +
                        " % Happiness : " + this.Happiness + " %";
            return data;
        }

        public void Buy(Toy newToy)
        {
            bool sudahPunya = false;
            if (this.Owner.Coins >= newToy.Price)
            {
                //lakukan pengecekan apakah toy yg akan dimiliki sdh dimiliki atau belum
                foreach (Toy toy in this.ListToys)
                {
                    if (toy.Name == newToy.Name)
                    {
                        sudahPunya = true;
                        break;
                    }
                }
                //jika blm memiliki toy, maka toy bs dibeli
                if (sudahPunya == false)
                {
                    this.ListToys.Add(newToy);
                    this.Owner.Coins -= newToy.Price;
                }
                //jika sdh memiliki toy, maka munculkan exception
                else if (sudahPunya == true)
                {
                    throw new Exception("You already have " + newToy.Name +". Please buy another item.");
                }
            }
            else
            {
                throw new Exception("You don't have enough coins to buy the item");
            }
        }

        //semua pet bisa feed
        public abstract void Feed();

        //beberapa feed bisa sleep
        public virtual void Sleep()
        {
            return;
        }

        //asumsi terdapat beberapa pet yg bisa play
        public virtual void Play(Toy toy)
        {
            return;
        }

        public string CheckHealthPet()
        {
            string status = "";
            //cek status health
            if (this.Health >= 10 && this.Health <= 25)
            {
                status = "Very Poor";
            }
            else if (this.Health >= 26 && this.Health <= 60)
            {
                status = "Poor";
            }
            else if (this.Health >= 61 && this.Health <= 80)
            {
                status = "Good";
            }
            else if (this.Health > 80 && this.Health <= 100)
            {
                status = "Very Good";
            }
            return status;
        }
        public string CheckEnergyPet()
        {
            string status = "";
            if (this.Energy >= 10 && this.Energy <= 50)
            {
                status = "Weak";
            }
            else if (this.Energy >= 51 && this.Energy <= 75)
            {
                status = "Moderate";
            }
            else if (this.Energy >= 76 && this.Energy <= 100)
            {
                status = "Strong";

            }
            return status;
        }

        public string CheckHappinessPet()
        {
            string status = "";
            //cek status happiness

            if (this.Happiness >= 10 && this.Happiness <= 60)
            {
                status = "Unhappy";
            }
            else if (this.Happiness >= 61 && this.Happiness <= 100)
            {
                status = "Happy";
            }
            return status;

        }

        public virtual void Vaccination()
        {

        }

        public void AddIndicatorPotion(Potion potion)
        {
            this.Happiness += potion.BenefitHappiness;
            this.Energy += potion.BenefitEnergy;
            this.Health += potion.BenefitHealth;
        }

    }
    #endregion


}