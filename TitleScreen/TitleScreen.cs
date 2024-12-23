using System;
using System.Media;

namespace TitleScreen
{
    public partial class TitleScreen : Form
    {
        public TitleScreen()
        {
            InitializeComponent();
        }

        //when the form starts
        private void TitleScreen_Load(object sender, EventArgs e)
        {
            // plays the background music
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = "C:\\Users\\Sojeee\\OneDrive\\Desktop\\TitleScreen\\TitleScreen\\resources\\audio\\PikuNiku - The Mountain Village.wav";
            player.PlayLooping();
        }

        //when the form is closed
        private void TitleScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //MENU PANEL BUTTONS ONCLICK
        private void menuBtns_Click(object sender, EventArgs e)
        {
            CustomButton clickedButton = sender as CustomButton;
            if (clickedButton != null)
            {
                switch (clickedButton)
                {
                    case var _ when clickedButton == settingsBtn:
                        //this.Hide();
                        // -------------------- put code here to should show the settings screen
                        break;
                    case var _ when clickedButton == leaderboardsBtn:
                        //this.Hide();
                        // -------------------- put code here to show the leaderboards screen
                        break;
                    case var _ when clickedButton == audioBtn:
                        //audio button logic
                        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();
                        player1.Stop();
                        audioBtn.Visible = false;
                        muteBtn.Visible = true;
                        break;
                        
                    case var _ when clickedButton == muteBtn:
                        //mute button logic
                        System.Media.SoundPlayer player2 = new System.Media.SoundPlayer();
                        player2.SoundLocation = "C:\\Users\\Sojeee\\source\\repos\\TitleScreen\\TitleScreen\\resources\\audio\\PikuNiku - The Mountain Village.wav";
                        player2.PlayLooping();
                        muteBtn.Visible = false;
                        audioBtn.Visible = true;
                        break;

                    case var _ when clickedButton == playBtn:
                        MenuPnl.Visible = false;
                        CategoryPnl.Visible = true;
                        break;
                    case var _ when clickedButton == howToPlayBtn:
                        MenuPnl.Visible = false;
                        Page1Pnl.Visible = true;
                        break;
                    default:
                        MessageBox.Show("bug");
                        break;
                }
            }
        }

        //CATEGORY PANEL BUTTONS ONCLICK
        private void categoryBtns_Click(object sender, EventArgs e)
        {
            // Cast the sender to Button
            CustomButton clickedButton = sender as CustomButton;
            if (clickedButton != null) { if (clickedButton == categoryBackBtn) {/*category back button logic*/ CategoryPnl.Visible = false; MenuPnl.Visible = true; } }
            CustomGradientButton clickedGradientButton = sender as CustomGradientButton;
            if (clickedGradientButton != null)
            {
                switch (clickedGradientButton)
                {
                    case var _ when clickedGradientButton == categoryCountryBtn:
                        // COUNTRY BUTTON LOGIC
                        //this.Hide();
                        // ------------------------- your code here to show the main game screen with category of "Country"
                        this.Hide();
                        GameOverScreen GameOverScreen = new GameOverScreen();
                        GameOverScreen.Show();
                        break;
                    case var _ when clickedGradientButton == categoryAnimalsBtn:
                        //ANIMALS BUTTON LOGIC
                        //this.Hide();
                        // ------------------------- your code here to show the main game screen with category of "Animals"
                        break;
                    case var _ when clickedGradientButton == categoryFruitsBtn:
                        //FRUITS AND VEGETABLES BUTTON LOGIC
                        //this.Hide();
                        // ------------------------- your code here to show the main game screen with category of "Fruits and Vegetables"
                        break;
                    case var _ when clickedGradientButton == categoryOccupationBtn:
                        //OCCUPATION BUTTON LOGIC
                        //this.Hide();
                        // ------------------------- your code here to show the main game screen with category of "Occupation"
                        break;
                    default:
                        MessageBox.Show("bug");
                        break;
                }
            }
        }

        //HOW TO PLAY PANEL BUTTONS ONCLICK
        private void howToPlayBtns_Click(object sender, EventArgs e)
        {
            // Cast the sender to Button
            CustomButton clickedButton = sender as CustomButton;
            if (clickedButton != null)
            {
                switch (clickedButton)
                {
                    case var _ when clickedButton == backToMenu1Btn:
                        Page1Pnl.Visible = false;
                        Page5Pnl.Visible = false;
                        MenuPnl.Visible = true;
                        break;
                    case var _ when clickedButton == next1Btn:
                        // next button logic for Page 1
                        Page1Pnl.Visible=false;
                        Page2Pnl.Visible = true;
                        break;
                    case var _ when clickedButton == previous2Btn:
                        //previous button logic for Page 2
                        Page2Pnl.Visible = false;
                        Page1Pnl.Visible = true;
                        break;
                    case var _ when clickedButton == next2Btn:
                        //next button logic for Page 2
                        Page2Pnl.Visible = false;
                        Page3Pnl.Visible = true;
                        break;
                    case var _ when clickedButton == previous3Btn:
                        //previous button button logic for Page 3
                        Page3Pnl.Visible = false;
                        Page2Pnl.Visible = true;
                        break;
                    case var _ when clickedButton == next3Btn:
                        //next button logic for Page 3
                        Page3Pnl.Visible = false;
                        Page4Pnl.Visible = true;
                        break;
                    case var _ when clickedButton == previous4Btn:
                        //previous button logic for Page 4
                        Page4Pnl.Visible = false;
                        Page3Pnl.Visible = true;
                        break;
                    case var _ when clickedButton == next4Btn:
                        //next button logic for Page 4
                        Page4Pnl.Visible = false;
                        Page5Pnl.Visible = true;
                        break;
                    case var _ when clickedButton == previous5Btn:
                        //previous button logic for Page 5
                        Page5Pnl.Visible = false;
                        Page4Pnl.Visible = true;
                        break;
                    case var _ when clickedButton == backToMenuBtn:
                        //back to menu button logic for page 5
                        Page5Pnl.Visible = false;
                        MenuPnl.Visible = true;
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
