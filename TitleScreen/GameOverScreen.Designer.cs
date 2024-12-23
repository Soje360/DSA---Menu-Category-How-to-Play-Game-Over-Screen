namespace TitleScreen
{
    partial class GameOverScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameOverScreen));
            gameOverLbl = new Label();
            label1 = new Label();
            linePbx = new PictureBox();
            correctWordLbl = new Label();
            scoreLbl = new Label();
            highScoreLbl = new Label();
            playAgainBtn = new CustomButton();
            mainMenuBtn = new CustomButton();
            leaderboardsBtn2 = new CustomButton();
            exitBtn = new CustomButton();
            GameOverPnl = new Panel();
            playerHighScoreLbl = new Label();
            playerScoreLbl = new Label();
            ConfirmExitPnl = new Panel();
            denyExitBtn = new CustomButton();
            confirmExitLbl = new Label();
            confirmExitBtn = new CustomButton();
            ((System.ComponentModel.ISupportInitialize)linePbx).BeginInit();
            GameOverPnl.SuspendLayout();
            ConfirmExitPnl.SuspendLayout();
            SuspendLayout();
            // 
            // gameOverLbl
            // 
            gameOverLbl.AutoSize = true;
            gameOverLbl.Font = new Font("Verdana", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gameOverLbl.ForeColor = Color.White;
            gameOverLbl.Location = new Point(100, 63);
            gameOverLbl.Name = "gameOverLbl";
            gameOverLbl.Size = new Size(229, 38);
            gameOverLbl.TabIndex = 0;
            gameOverLbl.Text = "GAME OVER";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(90, 119);
            label1.Name = "label1";
            label1.Size = new Size(260, 46);
            label1.TabIndex = 1;
            label1.Text = "Better Luck Next Time!\r\nThe Correct Word Is:\r\n";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // linePbx
            // 
            linePbx.Image = (Image)resources.GetObject("linePbx.Image");
            linePbx.Location = new Point(124, 194);
            linePbx.Name = "linePbx";
            linePbx.Size = new Size(187, 25);
            linePbx.SizeMode = PictureBoxSizeMode.CenterImage;
            linePbx.TabIndex = 2;
            linePbx.TabStop = false;
            // 
            // correctWordLbl
            // 
            correctWordLbl.AutoSize = true;
            correctWordLbl.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            correctWordLbl.ForeColor = Color.White;
            correctWordLbl.Location = new Point(147, 184);
            correctWordLbl.Name = "correctWordLbl";
            correctWordLbl.Size = new Size(145, 18);
            correctWordLbl.TabIndex = 3;
            correctWordLbl.Text = "CORRECT WORD";
            correctWordLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // scoreLbl
            // 
            scoreLbl.AutoSize = true;
            scoreLbl.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            scoreLbl.ForeColor = Color.White;
            scoreLbl.Location = new Point(169, 230);
            scoreLbl.Name = "scoreLbl";
            scoreLbl.Size = new Size(103, 18);
            scoreLbl.TabIndex = 4;
            scoreLbl.Text = "Your Score:\r\n";
            scoreLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // highScoreLbl
            // 
            highScoreLbl.AutoSize = true;
            highScoreLbl.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            highScoreLbl.ForeColor = Color.White;
            highScoreLbl.Location = new Point(169, 289);
            highScoreLbl.Name = "highScoreLbl";
            highScoreLbl.Size = new Size(101, 18);
            highScoreLbl.TabIndex = 5;
            highScoreLbl.Text = "High Score:\r\n";
            highScoreLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // playAgainBtn
            // 
            playAgainBtn.BackColor = Color.FromArgb(106, 149, 148);
            playAgainBtn.FlatAppearance.BorderSize = 0;
            playAgainBtn.FlatStyle = FlatStyle.Flat;
            playAgainBtn.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            playAgainBtn.ForeColor = Color.White;
            playAgainBtn.Location = new Point(131, 348);
            playAgainBtn.Name = "playAgainBtn";
            playAgainBtn.Size = new Size(180, 39);
            playAgainBtn.TabIndex = 6;
            playAgainBtn.Text = "PLAY AGAIN";
            playAgainBtn.UseVisualStyleBackColor = false;
            playAgainBtn.Click += gameOverBtns_Click;
            playAgainBtn.MouseLeave += allBtn_MouseLeave;
            playAgainBtn.MouseHover += allBtn_MouseHover;
            // 
            // mainMenuBtn
            // 
            mainMenuBtn.BackColor = Color.FromArgb(106, 149, 148);
            mainMenuBtn.FlatAppearance.BorderSize = 0;
            mainMenuBtn.FlatStyle = FlatStyle.Flat;
            mainMenuBtn.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mainMenuBtn.ForeColor = Color.White;
            mainMenuBtn.Location = new Point(131, 393);
            mainMenuBtn.Name = "mainMenuBtn";
            mainMenuBtn.Size = new Size(180, 39);
            mainMenuBtn.TabIndex = 7;
            mainMenuBtn.Text = "MAIN MENU";
            mainMenuBtn.UseVisualStyleBackColor = false;
            mainMenuBtn.Click += gameOverBtns_Click;
            mainMenuBtn.MouseLeave += allBtn_MouseLeave;
            mainMenuBtn.MouseHover += allBtn_MouseHover;
            // 
            // leaderboardsBtn2
            // 
            leaderboardsBtn2.BackColor = Color.FromArgb(106, 149, 148);
            leaderboardsBtn2.FlatAppearance.BorderSize = 0;
            leaderboardsBtn2.FlatStyle = FlatStyle.Flat;
            leaderboardsBtn2.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            leaderboardsBtn2.ForeColor = Color.White;
            leaderboardsBtn2.Location = new Point(114, 438);
            leaderboardsBtn2.Name = "leaderboardsBtn2";
            leaderboardsBtn2.Size = new Size(215, 39);
            leaderboardsBtn2.TabIndex = 8;
            leaderboardsBtn2.Text = "LEADERBOARDS";
            leaderboardsBtn2.UseVisualStyleBackColor = false;
            leaderboardsBtn2.Click += gameOverBtns_Click;
            leaderboardsBtn2.MouseLeave += allBtn_MouseLeave;
            leaderboardsBtn2.MouseHover += allBtn_MouseHover;
            // 
            // exitBtn
            // 
            exitBtn.BackColor = Color.FromArgb(106, 149, 148);
            exitBtn.FlatAppearance.BorderSize = 0;
            exitBtn.FlatStyle = FlatStyle.Flat;
            exitBtn.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitBtn.ForeColor = Color.White;
            exitBtn.Location = new Point(182, 483);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(72, 39);
            exitBtn.TabIndex = 9;
            exitBtn.Text = "EXIT";
            exitBtn.UseVisualStyleBackColor = false;
            exitBtn.Click += gameOverBtns_Click;
            exitBtn.MouseLeave += allBtn_MouseLeave;
            exitBtn.MouseHover += allBtn_MouseHover;
            // 
            // GameOverPnl
            // 
            GameOverPnl.Controls.Add(playerHighScoreLbl);
            GameOverPnl.Controls.Add(playerScoreLbl);
            GameOverPnl.Controls.Add(exitBtn);
            GameOverPnl.Controls.Add(gameOverLbl);
            GameOverPnl.Controls.Add(leaderboardsBtn2);
            GameOverPnl.Controls.Add(label1);
            GameOverPnl.Controls.Add(mainMenuBtn);
            GameOverPnl.Controls.Add(correctWordLbl);
            GameOverPnl.Controls.Add(playAgainBtn);
            GameOverPnl.Controls.Add(linePbx);
            GameOverPnl.Controls.Add(highScoreLbl);
            GameOverPnl.Controls.Add(scoreLbl);
            GameOverPnl.Location = new Point(0, 0);
            GameOverPnl.Name = "GameOverPnl";
            GameOverPnl.Size = new Size(435, 562);
            GameOverPnl.TabIndex = 10;
            // 
            // playerHighScoreLbl
            // 
            playerHighScoreLbl.AutoSize = true;
            playerHighScoreLbl.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            playerHighScoreLbl.ForeColor = Color.White;
            playerHighScoreLbl.Location = new Point(212, 307);
            playerHighScoreLbl.Name = "playerHighScoreLbl";
            playerHighScoreLbl.Size = new Size(19, 18);
            playerHighScoreLbl.TabIndex = 11;
            playerHighScoreLbl.Text = "0";
            playerHighScoreLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // playerScoreLbl
            // 
            playerScoreLbl.AutoSize = true;
            playerScoreLbl.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            playerScoreLbl.ForeColor = Color.White;
            playerScoreLbl.Location = new Point(212, 248);
            playerScoreLbl.Name = "playerScoreLbl";
            playerScoreLbl.Size = new Size(19, 18);
            playerScoreLbl.TabIndex = 10;
            playerScoreLbl.Text = "0";
            playerScoreLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ConfirmExitPnl
            // 
            ConfirmExitPnl.Controls.Add(denyExitBtn);
            ConfirmExitPnl.Controls.Add(confirmExitLbl);
            ConfirmExitPnl.Controls.Add(confirmExitBtn);
            ConfirmExitPnl.Location = new Point(0, 0);
            ConfirmExitPnl.Name = "ConfirmExitPnl";
            ConfirmExitPnl.Size = new Size(438, 562);
            ConfirmExitPnl.TabIndex = 12;
            ConfirmExitPnl.Visible = false;
            // 
            // denyExitBtn
            // 
            denyExitBtn.BackColor = Color.FromArgb(106, 149, 148);
            denyExitBtn.FlatAppearance.BorderSize = 0;
            denyExitBtn.FlatStyle = FlatStyle.Flat;
            denyExitBtn.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            denyExitBtn.ForeColor = Color.White;
            denyExitBtn.Location = new Point(132, 278);
            denyExitBtn.Name = "denyExitBtn";
            denyExitBtn.Size = new Size(180, 39);
            denyExitBtn.TabIndex = 9;
            denyExitBtn.Text = "NO";
            denyExitBtn.UseVisualStyleBackColor = false;
            denyExitBtn.Click += confirmExitBtns_Click;
            denyExitBtn.MouseLeave += allBtn_MouseLeave;
            denyExitBtn.MouseHover += allBtn_MouseHover;
            // 
            // confirmExitLbl
            // 
            confirmExitLbl.AutoSize = true;
            confirmExitLbl.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            confirmExitLbl.ForeColor = Color.White;
            confirmExitLbl.Location = new Point(70, 155);
            confirmExitLbl.Name = "confirmExitLbl";
            confirmExitLbl.Size = new Size(308, 50);
            confirmExitLbl.TabIndex = 8;
            confirmExitLbl.Text = "Are you sure you want to\r\nquit the game?\r\n";
            confirmExitLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // confirmExitBtn
            // 
            confirmExitBtn.BackColor = Color.FromArgb(106, 149, 148);
            confirmExitBtn.FlatAppearance.BorderSize = 0;
            confirmExitBtn.FlatStyle = FlatStyle.Flat;
            confirmExitBtn.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            confirmExitBtn.ForeColor = Color.White;
            confirmExitBtn.Location = new Point(132, 227);
            confirmExitBtn.Name = "confirmExitBtn";
            confirmExitBtn.Size = new Size(180, 39);
            confirmExitBtn.TabIndex = 7;
            confirmExitBtn.Text = "YES";
            confirmExitBtn.UseVisualStyleBackColor = false;
            confirmExitBtn.Click += confirmExitBtns_Click;
            confirmExitBtn.MouseLeave += allBtn_MouseLeave;
            confirmExitBtn.MouseHover += allBtn_MouseHover;
            // 
            // GameOverScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(91, 105, 128);
            ClientSize = new Size(436, 563);
            Controls.Add(ConfirmExitPnl);
            Controls.Add(GameOverPnl);
            Name = "GameOverScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hangman";
            FormClosed += GameOverScreen_FormClosed;
            Load += GameOverScreen_Load;
            ((System.ComponentModel.ISupportInitialize)linePbx).EndInit();
            GameOverPnl.ResumeLayout(false);
            GameOverPnl.PerformLayout();
            ConfirmExitPnl.ResumeLayout(false);
            ConfirmExitPnl.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label gameOverLbl;
        private Label label1;
        private PictureBox linePbx;
        private Label correctWordLbl;
        private Label scoreLbl;
        private Label highScoreLbl;
        private CustomButton playAgainBtn;
        private CustomButton mainMenuBtn;
        private CustomButton leaderboardsBtn2;
        private CustomButton exitBtn;
        private Panel GameOverPnl;
        private Panel ConfirmExitPnl;
        private CustomButton denyExitBtn;
        private Label confirmExitLbl;
        private CustomButton confirmExitBtn;
        private Label playerScoreLbl;
        private Label playerHighScoreLbl;
    }
}