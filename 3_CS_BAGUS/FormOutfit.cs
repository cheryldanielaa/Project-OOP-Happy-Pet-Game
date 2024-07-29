using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_CS_BAGUS
{
    public partial class FormOutfit : Form
    {
        FormGame frmGame;
        Outfit glasses, sunglasses, specialOutfit, collar, scarf, ribbon, cap;

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            try
            {
                if (frmGame.myPet is Cat)
                {
                    if (radioButtonGlasses.Checked)
                    {
                        ((Cat)frmGame.myPet).BuyOutfit(glasses);
                    }
                    else if (radioButtonRibbon.Checked)
                    {
                        ((Cat)frmGame.myPet).BuyOutfit(ribbon);
                    }
                    else if (radioButtonCap.Checked)
                    {
                        ((Cat)frmGame.myPet).BuyOutfit(cap);
                    }
                    else if (radioButtonScarf.Checked)
                    {
                        ((Cat)frmGame.myPet).BuyOutfit(cap);
                    }
                    else if (radioButtonSpecialUniform.Checked)
                    {
                        ((Cat)frmGame.myPet).BuyOutfit(specialOutfit);
                    }
                    else if (radioButtonScarf.Checked)
                    {
                        ((Cat)frmGame.myPet).BuyOutfit(scarf);
                    }
                    else if (radioButtonSunglasses.Checked)
                    {
                        ((Cat)frmGame.myPet).BuyOutfit(sunglasses);
                    }
                    MessageBox.Show("Your item has been saved to drawer");
                    this.Close();
                    this.Owner.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public List<Outfit> listOutfit = new List<Outfit>();
        public FormOutfit()
        {
            InitializeComponent();
        }

        private void comboBoxOutfit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxOutfit.Text == "Head Accessories")
            {
                labelRibbon.Visible = true;
                radioButtonRibbon.Visible = true;
                labelCap.Visible = true;
                radioButtonCap.Visible = true;

                labelSunglasses.Visible = false;
                radioButtonSunglasses.Visible = false;
                radioButtonGlasses.Visible = false;
                labelGlasses.Visible = false;

                labelScarf.Visible = false;
                labelCollar.Visible = false;
                radioButtonCollar.Visible = false;
                radioButtonScarf.Visible = false;

                labelSpecialUniform.Visible = false;
                radioButtonSpecialUniform.Visible = false;
            }
            else if (comboBoxOutfit.Text == "Glasses")
            {
                labelRibbon.Visible = false;
                radioButtonRibbon.Visible = false;
                labelCap.Visible = false;
                radioButtonCap.Visible = false;

                labelSunglasses.Visible = true;
                radioButtonSunglasses.Visible = true;
                radioButtonGlasses.Visible = true;
                labelGlasses.Visible = true;

                labelScarf.Visible = false;
                labelCollar.Visible = false;
                radioButtonCollar.Visible = false;
                radioButtonScarf.Visible = false;

                labelSpecialUniform.Visible = false;
                radioButtonSpecialUniform.Visible = false;
            }
            else if (comboBoxOutfit.Text == "Neck Accessories")
            {
                labelSunglasses.Visible = false;
                radioButtonSunglasses.Visible = false;
                radioButtonGlasses.Visible = false;
                labelGlasses.Visible = false;

                labelRibbon.Visible = false;
                radioButtonRibbon.Visible = false;
                labelCap.Visible = false;
                radioButtonCap.Visible = false;

                labelScarf.Visible = true;
                labelCollar.Visible = true;
                radioButtonCollar.Visible = true;
                radioButtonScarf.Visible = true;

                labelSpecialUniform.Visible = false;
                radioButtonSpecialUniform.Visible = false;
            }

            else if (comboBoxOutfit.Text == "Special Uniform")
            {
                labelSunglasses.Visible = false;
                radioButtonSunglasses.Visible = false;
                radioButtonGlasses.Visible = false;
                labelGlasses.Visible = false;

                labelRibbon.Visible = false;
                radioButtonRibbon.Visible = false;
                labelCap.Visible = false;
                radioButtonCap.Visible = false;

                labelScarf.Visible = false;
                labelCollar.Visible = false;
                radioButtonCollar.Visible = false;
                radioButtonScarf.Visible = false;

                labelSpecialUniform.Visible = true;
                radioButtonSpecialUniform.Visible = true;
            }
        }

        private void FormOutfit_Load(object sender, EventArgs e)
        {
            frmGame = (FormGame)this.Owner.Owner;
            comboBoxOutfit.SelectedIndex = 0;
            labelSunglasses.Visible = false;
            radioButtonSunglasses.Visible = false;
            radioButtonGlasses.Visible = false;
            labelGlasses.Visible = false;


            labelScarf.Visible = false;
            labelCollar.Visible = false;
            radioButtonCollar.Visible = false;
            radioButtonScarf.Visible = false;

            labelSpecialUniform.Visible = false;
            radioButtonSpecialUniform.Visible = false;

            //buat objek
            sunglasses = new Outfit("sunglasses", 300, Properties.Resources.sunglasses, 10);
            listOutfit.Add(sunglasses);
            labelSunglasses.Text = sunglasses.DisplayData();

            glasses = new Outfit("glasses", 250, Properties.Resources.rounded_glasses, 8);
            listOutfit.Add(glasses);
            labelGlasses.Text = glasses.DisplayData();

            ribbon = new Outfit("ribbon", 100, Properties.Resources.ribbon, 2);
            listOutfit.Add(ribbon);
            labelRibbon.Text = ribbon.DisplayData();

            cap = new Outfit("cap", 200, Properties.Resources.hat, 5);
            listOutfit.Add(cap);
            labelCap.Text = cap.DisplayData();

            scarf = new Outfit("scarf", 300, Properties.Resources.scarf, 12);
            listOutfit.Add(scarf);
            labelScarf.Text = scarf.DisplayData();

            collar = new Outfit("collar", 300, Properties.Resources.collar, 12);
            listOutfit.Add(collar);
            labelCollar.Text = collar.DisplayData();

            specialOutfit = new Outfit("Winter Outfit", 1000, Properties.Resources.outfit, 30);
            listOutfit.Add(specialOutfit);
            labelSpecialUniform.Text = specialOutfit.DisplayData();

            //unchecked semua radioButton
            radioButtonCap.Checked = false;
            radioButtonCollar.Checked = false;
            radioButtonGlasses.Checked = false;
            radioButtonRibbon.Checked = false;
            radioButtonScarf.Checked = false;
            radioButtonSpecialUniform.Checked = false;
            radioButtonSunglasses.Checked = false;
        }
    }
}
