using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace _3_CS_BAGUS
{
    [Serializable]
    public class Pig : Pet
    {
        #region data member
        private bool vaccinationStatus;
        #endregion

        #region constructor
        public Pig(string name, Image picture, Player owner) :
            base(name, picture, owner)
        {
            this.VaccinationStatus = vaccinationStatus;
        }
        #endregion

        #region properties
        public bool VaccinationStatus { get => vaccinationStatus; set => vaccinationStatus = value; }
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

        public override void Vaccination()
        {
            if (this.Owner.Coins >= 2000 && this.VaccinationStatus == false)
            {
                this.Owner.Coins -= 2000;
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
                throw new Exception("Your pig has been vaccinated");
            }
            else if (this.Owner.Coins < 2000)
            {
                throw new Exception("You need >=2000 coins to vaccinate your pig");
            }
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
        public override void Play(Toy toy)
        {
            base.Happiness += 50;
            base.Energy -= 30;

            if (toy != null)
            {
                base.Happiness += toy.Benefit;
            }
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
        #endregion
    }
}