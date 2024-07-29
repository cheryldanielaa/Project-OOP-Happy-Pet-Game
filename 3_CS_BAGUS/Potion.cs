using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace _3_CS_BAGUS
{
    [Serializable]
    public class Potion
    {
         #region data member
        private string name;
        private int benefitHappiness;
        private int benefitEnergy;
        private int benefitHealth;
        private Image picture;
        #endregion

        #region constructor
        public Potion(string name, int benefitHappiness, int benefitEnergy, int benefitHealth, Image picture)
        {
            this.Name = name;
            this.BenefitHappiness = benefitHappiness;
            this.BenefitEnergy = benefitEnergy;
            this.BenefitHealth = benefitHealth;
            this.Picture = picture;
        }
        #endregion

        #region properties
        public string Name { get => name; set => name = value; }
        public int BenefitHappiness { get => benefitHappiness; set => benefitHappiness = value; }
        public int BenefitEnergy { get => benefitEnergy; set => benefitEnergy = value; }
        public int BenefitHealth { get => benefitHealth; set => benefitHealth = value; }
        public Image Picture { get => picture; set => picture = value; }
        #endregion

    }
}