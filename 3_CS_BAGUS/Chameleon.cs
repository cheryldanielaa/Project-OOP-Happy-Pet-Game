using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace _3_CS_BAGUS
{
    [Serializable]
    public class Chameleon : Pet
    {
        #region data members
        private Color currentColor;
        #endregion

        #region constructor
        public Chameleon(string name, Image picture, Player owner, Color currentColor):base(name, picture, owner)
        {
            this.CurrentColor = currentColor;
        }
        #endregion

        #region properties
        public Color CurrentColor { get => currentColor; set => currentColor = value; }
        #endregion

        #region methods
        public override string DisplayData()
        {
            string data = base.DisplayPet() +
                "\nCurrent Color : " + this.CurrentColor;
            return data;
        }

        public override void Sleep()
        {
            if (base.Health <= 40)
            {
                base.Owner.Coins += (int)(60 * 0.5 * 100);
            }
            else
            {
                base.Owner.Coins += (int)((100 - base.Health) * 0.5 * 100);
            }
            if (base.Energy <= 40)
            {
                base.Owner.Coins += (int)(60 * 0.5 * 100);
            }
            else
            {
                base.Owner.Coins += (int)((100 - base.Energy) * 0.5 * 100);
            }
            base.Health += 60;
            base.Energy += 60;
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
                base.Owner.Coins += (int)((100 - base.Health) * 0.5 * 100);
            }
            base.Health += 30;
            base.Energy += 50;
        }
        #endregion
    }
}