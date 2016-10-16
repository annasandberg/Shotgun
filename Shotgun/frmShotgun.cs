using System;
using System.Windows.Forms;

namespace Shotgun
{
    public partial class frmShotgun : Form
    {
        int yourShots = 0;
        int compShots = 0;
        string[] compActArray = new string[0];

        public frmShotgun()
        {
            InitializeComponent();
            ResetGame();
        }

        private void ResetGame()
        {
            btnShotgun.Enabled = false;
            btnShoot.Enabled = false;
            btnBlock.Enabled = true;
            btnLoad.Enabled = true;
            lblWinner.Hide();
            lblLooser.Hide();
            yourShots = 0;
            compShots = 0;
            UpdateShotsLeft();
            btnPlayAgain.Visible = false;
            picBoxCompStart.BringToFront();
            picBoxYouStart.BringToFront();
        }

        private void UpdateShotsLeft()
        {
            lblCompShotsLeftCount.Text = compShots.ToString();
            lblYourShotsLeftCount.Text = yourShots.ToString();
        }

        private string ComputerAction()
        {
            if (yourShots == 0)
            {
                if (compShots == 0)
                {
                    compActArray = new string[] { "load" };
                }
                if (compShots == 1 || compShots == 2)
                {
                    compActArray = new string[] { "shoot", "load" };
                }
                if (compShots >= 3)
                {
                    compActArray = new string[] { "shoot", "load", "shotgun" };
                }
            }
            else if (yourShots > 0)
            {
                if (compShots == 0)
                {
                    compActArray = new string[] { "block", "load" };
                }
                if (compShots == 1 || compShots == 2)
                {
                    compActArray = new string[] { "shoot", "block", "load" };
                }
                if (compShots >= 3)
                {
                    compActArray = new string[] { "shoot", "block", "load", "shotgun" };
                }
            }
            
            string compAction = compActArray[new Random().Next(0, compActArray.Length)];
            return compAction;
        }

        /// <summary>
        /// Disables all buttons except the Play Again button.
        /// </summary>
        private void DisableActionButtons()
        {
            btnShoot.Enabled = false;
            btnLoad.Enabled = false;
            btnBlock.Enabled = false;
            btnShotgun.Enabled = false;
            btnPlayAgain.Visible = true;
            btnPlayAgain.BringToFront();
        }

        private void YouLoose()
        {
            lblLooser.Show();
            lblLooser.BringToFront();
            DisableActionButtons();
        }

        private void YouWin()
        {
            lblWinner.Show();
            lblWinner.BringToFront();
            DisableActionButtons();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string computerAction = ComputerAction();
            yourShots++;
            picYouLoad.BringToFront();
            btnShoot.Enabled = true;
            if (yourShots>=3)
            {
                btnShotgun.Enabled = true;
            }
            if (computerAction == "shoot")
            {
                compShots--;
                picCompShoot.BringToFront();
                YouLoose();
            }
            if (computerAction == "shotgun")
            {
                compShots--;
                picCompShotgun.BringToFront();
                YouLoose();
            }
            if (computerAction == "load")
            {
                compShots++;
                picCompLoad.BringToFront();
            }
            if (computerAction == "block")
            {
                picCompBlock.BringToFront();
            }
            UpdateShotsLeft();

        }

        private void btnShoot_Click(object sender, EventArgs e)
        {
            string computerAction = ComputerAction();
            yourShots--;
            picYouShoot.BringToFront();

            if (computerAction == "load" )
            {
                compShots++;
                picCompLoad.BringToFront();
                YouWin();
            }
            else if (computerAction == "block")
            {
                picCompBlock.BringToFront();

                if (yourShots <3)
                {
                    btnShotgun.Enabled = false;
                }
                if (yourShots==0)
                {
                    btnShoot.Enabled = false;
                }
            }
            else if (computerAction == "shoot")
            {
                compShots--;
                picCompShoot.BringToFront();

                if (yourShots < 3)
                {
                    btnShotgun.Enabled = false;
                }
                if (yourShots == 0)
                {
                    btnShoot.Enabled = false;
                }
            }
            else if (computerAction == "shotgun")
            {
                compShots--;
                picCompShotgun.BringToFront();
                YouLoose();
            }
            UpdateShotsLeft();

        }

        private void btnShotgun_Click(object sender, EventArgs e)
        {
            string computerAction = ComputerAction();
            yourShots--;
            picYouShotgun.BringToFront();

            if (computerAction == "shotgun")
            {
                compShots--;
                picCompShotgun.BringToFront();

                if (yourShots<3)
                {
                    btnShotgun.Enabled = false;
                }
            }
            else
            {
                if (computerAction == "shoot")
                {
                    compShots--;
                    picCompShoot.BringToFront();
                }

                if (computerAction == "block")
                {
                    picCompBlock.BringToFront();
                }

                if (computerAction == "load")
                {
                    compShots++;
                    picCompLoad.BringToFront();
                }

                YouWin();
            }

            UpdateShotsLeft();
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void btnBlock_Click(object sender, EventArgs e)
        {
            string computerAction = ComputerAction();
            picYouBlock.BringToFront();

            if (computerAction == "shoot")
            {
                compShots--;
                picCompShoot.BringToFront();     
            }
            if (computerAction == "shotgun")
            {
                compShots--;
                picCompShotgun.BringToFront();
                YouLoose();
            }
            if (computerAction == "load")
            {
                compShots++;
                picCompLoad.BringToFront();
            }
            if (computerAction == "block")
            {
                picCompBlock.BringToFront();
            }
            UpdateShotsLeft();
        }
    }
}
