﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace _3_CS_BAGUS
{
    [Serializable]
    public class Outfit
    {
        #region data members
        private string name;
        private int price;
        private int benefit;
        private Image picture;
        #endregion


        #region constructor
        public Outfit(string name, int price,  Image picture, int benefit)
        {
            this.Name = name;
            this.Price = price;
            this.Benefit = benefit;
            this.Picture = picture;
        }

        #endregion

        #region properties
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
                    throw new Exception("Name cannot be empty");
                }
            }
        }
        public int Price
        {
            get => price;
            set
            {
                if (value > 0)
                {
                    price = value;
                }
                else
                {
                    price = 0;
                }
            }
        }
        public int Benefit
        {
            get => benefit;
            set
            {
                if (value > 1)
                {
                    benefit = value;
                }
                else
                {
                    benefit = 1;
                }
            }
        }
        public Image Picture { get => picture; set => picture = value; }

        #endregion
        public string DisplayData()
        {
            string data = this.Name +
                "\n" + this.Price + " coins" +
                "\n+ " + this.Benefit + " % ";
            return data;
        }
        #region methods

        #endregion
    }
}