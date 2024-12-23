using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TitleScreen
{
    public partial class GameOverScreen : Form
    {
        public GameOverScreen()
        {
            InitializeComponent();
        }

        //When the form loads
        private void GameOverScreen_Load(object sender, EventArgs e)
        {
            //----------------modify the correct word here
            //correctWordLbl.Text = ();

            //----------------modify the score label here
            //playerScoreLbl.Text = ();

            //----------------modify the highscore label here
            //playerHighScoreLbl.Text = ();
        }

        //When user exits
        private void GameOverScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //GAME OVER PANEL BUTTONS ONCLICK
        private void gameOverBtns_Click(object sender, EventArgs e)
        {
            // Cast the sender to Button
            CustomButton clickedButton = sender as CustomButton;
            if (clickedButton != null)
            {
                switch (clickedButton)
                {
                    case var _ when clickedButton == playAgainBtn:
                        //play again button logic
                        this.Hide();
                        TitleScreen titleScreen1 = new TitleScreen();
                        titleScreen1.MenuPnl.Visible = false;
                        titleScreen1.CategoryPnl.Visible = true;
                        titleScreen1.Show();
                        break;
                    case var _ when clickedButton == mainMenuBtn:
                        //main menu buton logic
                        this.Hide();
                        TitleScreen titleScreen2 = new TitleScreen();
                        titleScreen2.Show();
                        break;
                    case var _ when clickedButton == leaderboardsBtn2:
                        // leaderboards button logic
                        //this.Hide();
                        //--------------------------------------- put your code here to show the leaderboards screen
                        break;
                    case var _ when clickedButton == exitBtn:
                        //exit button logic
                        ConfirmExitPnl.Visible = true;
                        GameOverPnl.Visible = false;
                        break;
                    default:
                        MessageBox.Show("bug");
                        break;
                }
            }
        }

        //CONFIRM EXIT PANEL BUTTONS ONCLICK
        private void confirmExitBtns_Click(object sender, EventArgs e)
        {
            // Cast the sender to Button
            CustomButton clickedButton = sender as CustomButton;
            if (clickedButton != null)
            {
                switch (clickedButton)
                {
                    case var _ when clickedButton == denyExitBtn:
                        //deny exit button logic
                        ConfirmExitPnl.Visible = false;
                        GameOverPnl.Visible = true;
                        
                        break;
                    case var _ when clickedButton == confirmExitBtn:
                        //main menu buton logic
                        Application.Exit();
                        break;
                    default:
                        MessageBox.Show("bug");
                        break;
                }
            }
        }

        //all Buttons MouseHover
        private void allBtn_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        //all Button MouseLeave
        private void allBtn_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }
    }
}
