using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;

namespace _3_CS_BAGUS
{
    [Serializable]
    public class Cat : Pet
    {
        #region data members
        private bool vaccinationStatus;
        private List<Outfit> listOutfit = new List<Outfit>(); //1 cat has n outfit >>composition
        #endregion

        #region constructor
        public Cat(string name, Image picture, Player owner):
            base( name, picture, owner)
        {
            //status vaksinasi dibuat false saat pertama kali bermain
            this.VaccinationStatus = false;
            this.ListOutfit = listOutfit;
        }
        #endregion

        #region
        public bool VaccinationStatus { get => vaccinationStatus; set => vaccinationStatus = value; }
        public List<Outfit> ListOutfit { get => listOutfit; private set => listOutfit = value; }
        #endregion

        #region methods
        public override string DisplayData()
        {
            string status = "No";
            if (this.VaccinationStatus == true)
            {
                status = "Yes";
            }
            string data = base.DisplayPet() +
                          "\nVaccination Status : " + status;
            return data;
        }
        public override void Feed()
        {
            if (base.Health <= 70)
            {
                base.Owner.Coins += (int)(30 * 0.5 * 100);
            }
            else
            {
                base.Owner.Coins += (int)((100 - base.Health) * 0.5 * 100);
            }
            if (base.Energy <= 50)
            {
                base.Owner.Coins += (int)(50 * 0.5 * 100);
            }
            else
            {
                base.Owner.Coins += (int)((100 - base.Energy) * 0.5 * 100);
            }
            base.Health += 30;
            base.Energy += 50;
        }

        public override void Sleep()
        {
            if (base.Health <= 80)
            {
                base.Owner.Coins += (int)(20 * 0.5 * 100);
            }
            else
            {
                base.Owner.Coins += (int)((100 - base.Health) * 0.5 * 100);
            }
            if (base.Energy <= 30)
            {
                base.Owner.Coins += (int)(70 * 0.5 * 100);
            }
            else
            {
                base.Owner.Coins += (int)((100 - base.Energy) * 0.5 * 100);
            }
            base.Health += 20;
            base.Energy += 70;
        }

        public override void Play(Toy toy)
        {
            base.Happiness += 50;
            base.Energy -= 30;

            if (toy != null)
            {
                base.Happiness += toy.Benefit;
            }
        }

        public void Bath()
        {
            if (base.Health <= 70)
            {
                base.Owner.Coins += (int)(30 * 0.5 * 100);
            }
            else
            {
                base.Owner.Coins += (int)((100 - base.Health) * 0.5 * 100);
            }
            base.Health += 30;
        }
        public override void Vaccination()
        {
            if(this.Owner.Coins >=1000 && this.VaccinationStatus == false)
            {
                this.Owner.Coins -= 1000;
                this.VaccinationStatus = true;
                if (base.Health <= 60)
                {
                    base.Owner.Coins += (int)(40 * 0.5 * 100);
                }
                else
                {
                    base.Owner.Coins += (int)((100 - base.Health) * 0.5 * 100);
                }
                base.Health += 40;
                base.Happiness -= 10;
            }
            else if (this.VaccinationStatus == true)
            {
                throw new Exception("Your cat has been vaccinated");
            }
            else if (this.Owner.Coins < 1000)
            {
                throw new Exception("You need >=1000 coins to vaccinate your cat");
            }
        }

        public void BuyOutfit(Outfit newOutfit)
        {
            bool sudahPunya = false;
            if (base.Owner.Coins >= newOutfit.Price)
            {
                foreach (Outfit outfit in this.ListOutfit)
                {
                    if (outfit.Name == newOutfit.Name)
                    {
                        sudahPunya = true;
                        break;
                    }
                }
                if (sudahPunya == false)
                {
                    base.Owner.Coins -= newOutfit.Price;
                    this.ListOutfit.Add(newOutfit);
                }
                else if (sudahPunya == true)
                {
                    throw new Exception("You already have this item");
                }

            }
            else
            {
                throw new Exception("Sorry, you don't have enough coins to but this item");
            }
        }

        public void WearOutfit(Outfit outfit)
        {
            if (outfit != null)
            {
                base.Happiness += outfit.Benefit;
            }

        }
        #endregion
    }
}