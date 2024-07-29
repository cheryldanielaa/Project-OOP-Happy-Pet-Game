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
    public partial class FormPauseGame : Form
    {
        FormGame frmGame;
        public FormPauseGame()
        {
            InitializeComponent();
        }

        private void FormPauseGame_Load(object sender, EventArgs e)
        {
            frmGame = (FormGame)this.Owner;

        }

        private void buttonResumeGame_Click(object sender, EventArgs e)
        {
            this.Close();
            frmGame.timerIndicator.Start();
        }
    }
}
