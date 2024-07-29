using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3_CS_BAGUS
{
    [Serializable]
    public class Player
    {
        #region data members
        private string name;
        private int coins;
        private DateTime lastPlay;
        private string level;
        #endregion

        #region constructor
        public Player(string name, int coins, DateTime lastPlay, string level)
        {
            this.Name = name;
            this.Coins = coins;
            this.LastPlay = lastPlay;
            this.Level = level;
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
                    throw new Exception("Player's name cannot be empty");
                }
            }
        }
        public int Coins
        {
            get => coins;
            set
            {
                if (value >= 0)
                {
                    coins = value;
                }
                else
                {
                    coins = 0;
                }
            }
        }
        public DateTime LastPlay { get => lastPlay; set => lastPlay = value; } //untuk menghapus data pemain yang sudah lama tidak bermain
        public string Level
        {
            get => level;
            set
            {
                if (value != "")
                {
                    level = value;
                }
                else
                {
                    throw new Exception("Pilih level");
                }
            }
        }
        #endregion

        #region methods
        public string DisplayData()
        {
            string data = this.Name +
                            "\nCoins : " + this.Coins +
                            "\nLevels : " + this.Level;

            return data;
        }
        #endregion
    }
}