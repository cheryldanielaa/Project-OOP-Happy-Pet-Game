using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace _3_CS_BAGUS
{
    [Serializable]
    public class Fish : Pet
    {
        #region data members
        private string environment;
        #endregion

        #region constructor
        public Fish(string name, Image picture, Player owner, string environment):base(name, picture, owner) 
        {
            this.Environment = environment;
        }
        #endregion

        #region properties
        public string Environment
        {
            get => environment;
            set
            {
                if (value != "")
                {
                    environment = value;
                }
                else
                {
                    throw new Exception("Environment cannot be empty");
                }
            }
        }
        #endregion

        #region methods
        public override string DisplayData()
        {
            string data = base.DisplayPet() +
                 "\nEnvironment : " + this.Environment;
            return data;
        }

        public override void Feed()
        {
            if (base.Health <= 80)
            {
                base.Owner.Coins += (int)(20 * 0.5 * 100);
            }
            else
            {
                base.Owner.Coins += (int)((100 - base.Health) * 0.5 * 100);
            }
            if (base.Energy <= 60)
            {
                base.Owner.Coins += (int)(40 * 0.5 * 100);
            }
            else
            {
                base.Owner.Coins += (int)((100 - base.Energy) * 0.5 * 100);
            }
            base.Health += 20;
            base.Energy += 40;
        }

        public void Clean()
        {
            if(base.Owner.Coins >= 500)
            {
                if (base.Health <= 40)
                {
                    base.Owner.Coins += (int)(60 * 0.5 * 100);
                }
                else
                {
                    base.Owner.Coins += (int)((100 - base.Health) * 0.5 * 100);
                }
                if (base.Happiness <= 50)
                {
                    base.Owner.Coins += (int)(50 * 0.5 * 100);
                }
                else
                {
                    base.Owner.Coins += (int)((100 - base.Happiness) * 0.5 * 100);
                }
                base.Health += 60;
                base.Happiness += 50;
            }
            else
            {
                throw new Exception("You need 500 coins to clean the aquarium");
            }
        }
        #endregion
    }
}