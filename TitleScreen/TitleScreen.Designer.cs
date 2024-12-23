namespace TitleScreen
{
    partial class TitleScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TitleScreen));
            titleLbl = new Label();
            gameIconPbx = new PictureBox();
            playBtn = new CustomButton();
            howToPlayBtn = new CustomButton();
            settingsBtn = new CustomButton();
            leaderboardsBtn = new CustomButton();
            audioBtn = new CustomButton();
            muteBtn = new CustomButton();
            MenuPnl = new Panel();
            CategoryPnl = new Panel();
            categoryBackBtn = new CustomButton();
            categoryOccupationBtn = new CustomGradientButton();
            categoryCountryBtn = new CustomGradientButton();
            categoryAnimalsBtn = new CustomGradientButton();
            categoryFruitsBtn = new CustomGradientButton();
            categoryBg = new CustomButton();
            Page1Pnl = new Panel();
            howToPlayLbl = new Label();
            backToMenu1Btn = new CustomButton();
            next1Btn = new CustomButton();
            pageLbl = new Label();
            instructionsLbl = new Label();
            page1Pbx = new CustomButton();
            page2Pbx = new CustomButton();
            page2InstructionLbl = new Label();
            page2Lbl = new Label();
            next2Btn = new CustomButton();
            previous2Btn = new CustomButton();
            label1 = new Label();
            Page2Pnl = new Panel();
            Page3Pnl = new Panel();
            page3Lbl = new Label();
            howToPlay3Lbl = new Label();
            previous3Btn = new CustomButton();
            next3Btn = new CustomButton();
            page3InstructionsLbl = new Label();
            page3Pbx = new CustomButton();
            Page4Pnl = new Panel();
            customButton4 = new CustomButton();
            page4Lbl = new Label();
            page4HowToPlayLbl = new Label();
            previous4Btn = new CustomButton();
            next4Btn = new CustomButton();
            page4InstructionsLbl = new Label();
            customButton3 = new CustomButton();
            Page5Pnl = new Panel();
            page5Pbx2 = new CustomButton();
            page5lbl = new Label();
            page5HowToPlayLbl = new Label();
            previous5Btn = new CustomButton();
            backToMenuBtn = new CustomButton();
            page5InstructionsLbl = new Label();
            customButton6 = new CustomButton();
            ((System.ComponentModel.ISupportInitialize)gameIconPbx).BeginInit();
            MenuPnl.SuspendLayout();
            CategoryPnl.SuspendLayout();
            Page1Pnl.SuspendLayout();
            Page2Pnl.SuspendLayout();
            Page3Pnl.SuspendLayout();
            Page4Pnl.SuspendLayout();
            Page5Pnl.SuspendLayout();
            SuspendLayout();
            // 
            // titleLbl
            // 
            titleLbl.AutoSize = true;
            titleLbl.Font = new Font("Baskerville Old Face", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLbl.ForeColor = Color.FromArgb(244, 247, 251);
            titleLbl.Location = new Point(80, 61);
            titleLbl.Name = "titleLbl";
            titleLbl.Size = new Size(286, 54);
            titleLbl.TabIndex = 0;
            titleLbl.Text = "HANGMAN";
            // 
            // gameIconPbx
            // 
            gameIconPbx.Image = (Image)resources.GetObject("gameIconPbx.Image");
            gameIconPbx.Location = new Point(80, 107);
            gameIconPbx.Name = "gameIconPbx";
            gameIconPbx.Size = new Size(277, 266);
            gameIconPbx.SizeMode = PictureBoxSizeMode.CenterImage;
            gameIconPbx.TabIndex = 1;
            gameIconPbx.TabStop = false;
            // 
            // playBtn
            // 
            playBtn.BackColor = Color.FromArgb(106, 149, 148);
            playBtn.FlatAppearance.BorderSize = 0;
            playBtn.FlatStyle = FlatStyle.Flat;
            playBtn.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            playBtn.ForeColor = Color.White;
            playBtn.Location = new Point(129, 379);
            playBtn.Name = "playBtn";
            playBtn.Size = new Size(180, 43);
            playBtn.TabIndex = 2;
            playBtn.Text = "PLAY";
            playBtn.UseVisualStyleBackColor = false;
            playBtn.Click += menuBtns_Click;
            playBtn.MouseLeave += allBtn_MouseLeave;
            playBtn.MouseHover += allBtn_MouseHover;
            // 
            // howToPlayBtn
            // 
            howToPlayBtn.BackColor = Color.FromArgb(106, 149, 148);
            howToPlayBtn.FlatAppearance.BorderSize = 0;
            howToPlayBtn.FlatStyle = FlatStyle.Flat;
            howToPlayBtn.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            howToPlayBtn.ForeColor = Color.White;
            howToPlayBtn.Location = new Point(155, 433);
            howToPlayBtn.Name = "howToPlayBtn";
            howToPlayBtn.Size = new Size(133, 26);
            howToPlayBtn.TabIndex = 3;
            howToPlayBtn.Text = "How To Play";
            howToPlayBtn.UseVisualStyleBackColor = false;
            howToPlayBtn.Click += menuBtns_Click;
            howToPlayBtn.MouseLeave += allBtn_MouseLeave;
            howToPlayBtn.MouseHover += allBtn_MouseHover;
            // 
            // settingsBtn
            // 
            settingsBtn.BackColor = Color.FromArgb(244, 247, 251);
            settingsBtn.BackgroundImage = (Image)resources.GetObject("settingsBtn.BackgroundImage");
            settingsBtn.BackgroundImageLayout = ImageLayout.Center;
            settingsBtn.FlatAppearance.BorderColor = Color.Black;
            settingsBtn.FlatStyle = FlatStyle.Flat;
            settingsBtn.ForeColor = Color.White;
            settingsBtn.Location = new Point(0, 1);
            settingsBtn.Name = "settingsBtn";
            settingsBtn.Size = new Size(35, 32);
            settingsBtn.TabIndex = 4;
            settingsBtn.UseVisualStyleBackColor = false;
            settingsBtn.Click += menuBtns_Click;
            settingsBtn.MouseLeave += allBtn_MouseLeave;
            settingsBtn.MouseHover += allBtn_MouseHover;
            // 
            // leaderboardsBtn
            // 
            leaderboardsBtn.BackColor = Color.FromArgb(244, 247, 251);
            leaderboardsBtn.BackgroundImage = (Image)resources.GetObject("leaderboardsBtn.BackgroundImage");
            leaderboardsBtn.BackgroundImageLayout = ImageLayout.Center;
            leaderboardsBtn.FlatAppearance.BorderColor = Color.Black;
            leaderboardsBtn.FlatStyle = FlatStyle.Flat;
            leaderboardsBtn.ForeColor = Color.White;
            leaderboardsBtn.Location = new Point(34, 0);
            leaderboardsBtn.Name = "leaderboardsBtn";
            leaderboardsBtn.Size = new Size(35, 32);
            leaderboardsBtn.TabIndex = 5;
            leaderboardsBtn.UseVisualStyleBackColor = false;
            leaderboardsBtn.Click += menuBtns_Click;
            leaderboardsBtn.MouseLeave += allBtn_MouseLeave;
            leaderboardsBtn.MouseHover += allBtn_MouseHover;
            // 
            // audioBtn
            // 
            audioBtn.BackColor = Color.FromArgb(244, 247, 251);
            audioBtn.BackgroundImage = (Image)resources.GetObject("audioBtn.BackgroundImage");
            audioBtn.BackgroundImageLayout = ImageLayout.Center;
            audioBtn.FlatAppearance.BorderColor = Color.Black;
            audioBtn.FlatStyle = FlatStyle.Flat;
            audioBtn.ForeColor = Color.White;
            audioBtn.Location = new Point(69, 0);
            audioBtn.Name = "audioBtn";
            audioBtn.Size = new Size(35, 32);
            audioBtn.TabIndex = 6;
            audioBtn.UseVisualStyleBackColor = false;
            audioBtn.Click += menuBtns_Click;
            audioBtn.MouseLeave += allBtn_MouseLeave;
            audioBtn.MouseHover += allBtn_MouseHover;
            // 
            // muteBtn
            // 
            muteBtn.BackColor = Color.FromArgb(244, 247, 251);
            muteBtn.BackgroundImage = (Image)resources.GetObject("muteBtn.BackgroundImage");
            muteBtn.BackgroundImageLayout = ImageLayout.Center;
            muteBtn.FlatAppearance.BorderColor = Color.Black;
            muteBtn.FlatStyle = FlatStyle.Flat;
            muteBtn.ForeColor = Color.White;
            muteBtn.Location = new Point(69, 0);
            muteBtn.Name = "muteBtn";
            muteBtn.Size = new Size(35, 32);
            muteBtn.TabIndex = 7;
            muteBtn.UseVisualStyleBackColor = false;
            muteBtn.Visible = false;
            muteBtn.Click += menuBtns_Click;
            muteBtn.MouseLeave += allBtn_MouseLeave;
            muteBtn.MouseHover += allBtn_MouseHover;
            // 
            // MenuPnl
            // 
            MenuPnl.Controls.Add(howToPlayBtn);
            MenuPnl.Controls.Add(leaderboardsBtn);
            MenuPnl.Controls.Add(playBtn);
            MenuPnl.Controls.Add(settingsBtn);
            MenuPnl.Controls.Add(titleLbl);
            MenuPnl.Controls.Add(gameIconPbx);
            MenuPnl.Controls.Add(audioBtn);
            MenuPnl.Controls.Add(muteBtn);
            MenuPnl.Location = new Point(0, 0);
            MenuPnl.Name = "MenuPnl";
            MenuPnl.Size = new Size(443, 564);
            MenuPnl.TabIndex = 8;
            // 
            // CategoryPnl
            // 
            CategoryPnl.BackColor = Color.White;
            CategoryPnl.Controls.Add(categoryBackBtn);
            CategoryPnl.Controls.Add(categoryOccupationBtn);
            CategoryPnl.Controls.Add(categoryCountryBtn);
            CategoryPnl.Controls.Add(categoryAnimalsBtn);
            CategoryPnl.Controls.Add(categoryFruitsBtn);
            CategoryPnl.Controls.Add(categoryBg);
            CategoryPnl.Location = new Point(1, 1);
            CategoryPnl.Name = "CategoryPnl";
            CategoryPnl.Size = new Size(433, 560);
            CategoryPnl.TabIndex = 9;
            CategoryPnl.Visible = false;
            // 
            // categoryBackBtn
            // 
            categoryBackBtn.BackColor = Color.FromArgb(106, 149, 147);
            categoryBackBtn.BackgroundImage = (Image)resources.GetObject("categoryBackBtn.BackgroundImage");
            categoryBackBtn.BackgroundImageLayout = ImageLayout.Center;
            categoryBackBtn.FlatAppearance.BorderColor = Color.Black;
            categoryBackBtn.FlatStyle = FlatStyle.Flat;
            categoryBackBtn.ForeColor = Color.White;
            categoryBackBtn.Location = new Point(-1, 0);
            categoryBackBtn.Name = "categoryBackBtn";
            categoryBackBtn.Size = new Size(29, 32);
            categoryBackBtn.TabIndex = 17;
            categoryBackBtn.UseVisualStyleBackColor = false;
            categoryBackBtn.Click += categoryBtns_Click;
            categoryBackBtn.MouseLeave += allBtn_MouseLeave;
            categoryBackBtn.MouseHover += allBtn_MouseHover;
            // 
            // categoryOccupationBtn
            // 
            categoryOccupationBtn.FlatAppearance.BorderSize = 0;
            categoryOccupationBtn.FlatStyle = FlatStyle.Flat;
            categoryOccupationBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            categoryOccupationBtn.ForeColor = Color.White;
            categoryOccupationBtn.Location = new Point(16, 459);
            categoryOccupationBtn.Name = "categoryOccupationBtn";
            categoryOccupationBtn.Size = new Size(406, 92);
            categoryOccupationBtn.TabIndex = 16;
            categoryOccupationBtn.Text = "OCUPATION";
            categoryOccupationBtn.UseVisualStyleBackColor = true;
            categoryOccupationBtn.Click += categoryBtns_Click;
            categoryOccupationBtn.MouseLeave += allBtn_MouseLeave;
            categoryOccupationBtn.MouseHover += allBtn_MouseHover;
            // 
            // categoryCountryBtn
            // 
            categoryCountryBtn.FlatAppearance.BorderSize = 0;
            categoryCountryBtn.FlatStyle = FlatStyle.Flat;
            categoryCountryBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            categoryCountryBtn.ForeColor = Color.White;
            categoryCountryBtn.Location = new Point(19, 139);
            categoryCountryBtn.Name = "categoryCountryBtn";
            categoryCountryBtn.Size = new Size(406, 92);
            categoryCountryBtn.TabIndex = 15;
            categoryCountryBtn.Text = "COUNTRY";
            categoryCountryBtn.UseVisualStyleBackColor = true;
            categoryCountryBtn.Click += categoryBtns_Click;
            categoryCountryBtn.MouseLeave += allBtn_MouseLeave;
            categoryCountryBtn.MouseHover += allBtn_MouseHover;
            // 
            // categoryAnimalsBtn
            // 
            categoryAnimalsBtn.FlatAppearance.BorderSize = 0;
            categoryAnimalsBtn.FlatStyle = FlatStyle.Flat;
            categoryAnimalsBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            categoryAnimalsBtn.ForeColor = Color.White;
            categoryAnimalsBtn.Location = new Point(16, 246);
            categoryAnimalsBtn.Name = "categoryAnimalsBtn";
            categoryAnimalsBtn.Size = new Size(406, 92);
            categoryAnimalsBtn.TabIndex = 14;
            categoryAnimalsBtn.Text = "ANIMALS";
            categoryAnimalsBtn.UseVisualStyleBackColor = true;
            categoryAnimalsBtn.Click += categoryBtns_Click;
            categoryAnimalsBtn.MouseLeave += allBtn_MouseLeave;
            categoryAnimalsBtn.MouseHover += allBtn_MouseHover;
            // 
            // categoryFruitsBtn
            // 
            categoryFruitsBtn.FlatAppearance.BorderSize = 0;
            categoryFruitsBtn.FlatStyle = FlatStyle.Flat;
            categoryFruitsBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            categoryFruitsBtn.ForeColor = Color.White;
            categoryFruitsBtn.Location = new Point(16, 351);
            categoryFruitsBtn.Name = "categoryFruitsBtn";
            categoryFruitsBtn.Size = new Size(406, 92);
            categoryFruitsBtn.TabIndex = 13;
            categoryFruitsBtn.Text = "FRUITS AND VEGETABLES";
            categoryFruitsBtn.UseVisualStyleBackColor = true;
            categoryFruitsBtn.Click += categoryBtns_Click;
            categoryFruitsBtn.MouseLeave += allBtn_MouseLeave;
            categoryFruitsBtn.MouseHover += allBtn_MouseHover;
            // 
            // categoryBg
            // 
            categoryBg.BackColor = Color.FromArgb(106, 149, 147);
            categoryBg.Enabled = false;
            categoryBg.FlatAppearance.BorderSize = 0;
            categoryBg.FlatStyle = FlatStyle.Flat;
            categoryBg.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            categoryBg.ForeColor = Color.White;
            categoryBg.Location = new Point(-1, -4);
            categoryBg.Name = "categoryBg";
            categoryBg.Size = new Size(440, 105);
            categoryBg.TabIndex = 12;
            categoryBg.Text = "Category";
            categoryBg.UseVisualStyleBackColor = false;
            // 
            // Page1Pnl
            // 
            Page1Pnl.Controls.Add(howToPlayLbl);
            Page1Pnl.Controls.Add(backToMenu1Btn);
            Page1Pnl.Controls.Add(next1Btn);
            Page1Pnl.Controls.Add(pageLbl);
            Page1Pnl.Controls.Add(instructionsLbl);
            Page1Pnl.Controls.Add(page1Pbx);
            Page1Pnl.Location = new Point(0, 1);
            Page1Pnl.Name = "Page1Pnl";
            Page1Pnl.Size = new Size(440, 563);
            Page1Pnl.TabIndex = 10;
            Page1Pnl.Visible = false;
            // 
            // howToPlayLbl
            // 
            howToPlayLbl.AutoSize = true;
            howToPlayLbl.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            howToPlayLbl.ForeColor = Color.White;
            howToPlayLbl.Location = new Point(64, 23);
            howToPlayLbl.Name = "howToPlayLbl";
            howToPlayLbl.Size = new Size(315, 25);
            howToPlayLbl.TabIndex = 9;
            howToPlayLbl.Text = "HOW TO PLAY: HANGMAN";
            howToPlayLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // backToMenu1Btn
            // 
            backToMenu1Btn.BackColor = Color.FromArgb(106, 149, 148);
            backToMenu1Btn.FlatAppearance.BorderSize = 0;
            backToMenu1Btn.FlatStyle = FlatStyle.Flat;
            backToMenu1Btn.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backToMenu1Btn.ForeColor = Color.White;
            backToMenu1Btn.Location = new Point(48, 374);
            backToMenu1Btn.Name = "backToMenu1Btn";
            backToMenu1Btn.Size = new Size(142, 64);
            backToMenu1Btn.TabIndex = 8;
            backToMenu1Btn.Text = "BACK TO MENU";
            backToMenu1Btn.UseVisualStyleBackColor = false;
            backToMenu1Btn.Click += howToPlayBtns_Click;
            backToMenu1Btn.MouseLeave += allBtn_MouseLeave;
            backToMenu1Btn.MouseHover += allBtn_MouseHover;
            // 
            // next1Btn
            // 
            next1Btn.BackColor = Color.FromArgb(106, 149, 148);
            next1Btn.FlatAppearance.BorderSize = 0;
            next1Btn.FlatStyle = FlatStyle.Flat;
            next1Btn.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            next1Btn.ForeColor = Color.White;
            next1Btn.Location = new Point(256, 387);
            next1Btn.Name = "next1Btn";
            next1Btn.Size = new Size(120, 39);
            next1Btn.TabIndex = 7;
            next1Btn.Text = "NEXT";
            next1Btn.UseVisualStyleBackColor = false;
            next1Btn.Click += howToPlayBtns_Click;
            next1Btn.MouseLeave += allBtn_MouseLeave;
            next1Btn.MouseHover += allBtn_MouseHover;
            // 
            // pageLbl
            // 
            pageLbl.AutoSize = true;
            pageLbl.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pageLbl.ForeColor = Color.White;
            pageLbl.Location = new Point(181, 63);
            pageLbl.Name = "pageLbl";
            pageLbl.Size = new Size(65, 18);
            pageLbl.TabIndex = 5;
            pageLbl.Text = "Page 1";
            pageLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // instructionsLbl
            // 
            instructionsLbl.AutoSize = true;
            instructionsLbl.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            instructionsLbl.ForeColor = Color.White;
            instructionsLbl.Location = new Point(48, 297);
            instructionsLbl.Name = "instructionsLbl";
            instructionsLbl.Size = new Size(338, 46);
            instructionsLbl.TabIndex = 2;
            instructionsLbl.Text = "Depending on the Category,\r\nthe player must guess a word.";
            instructionsLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // page1Pbx
            // 
            page1Pbx.BackColor = Color.MediumSlateBlue;
            page1Pbx.BackgroundImage = (Image)resources.GetObject("page1Pbx.BackgroundImage");
            page1Pbx.BackgroundImageLayout = ImageLayout.Center;
            page1Pbx.FlatAppearance.BorderSize = 0;
            page1Pbx.FlatStyle = FlatStyle.Flat;
            page1Pbx.ForeColor = Color.White;
            page1Pbx.Location = new Point(73, 118);
            page1Pbx.Name = "page1Pbx";
            page1Pbx.Size = new Size(280, 147);
            page1Pbx.TabIndex = 0;
            page1Pbx.UseVisualStyleBackColor = false;
            // 
            // page2Pbx
            // 
            page2Pbx.BackColor = Color.MediumSlateBlue;
            page2Pbx.BackgroundImage = (Image)resources.GetObject("page2Pbx.BackgroundImage");
            page2Pbx.BackgroundImageLayout = ImageLayout.Center;
            page2Pbx.FlatAppearance.BorderSize = 0;
            page2Pbx.FlatStyle = FlatStyle.Flat;
            page2Pbx.ForeColor = Color.White;
            page2Pbx.Location = new Point(112, 118);
            page2Pbx.Name = "page2Pbx";
            page2Pbx.Size = new Size(198, 198);
            page2Pbx.TabIndex = 0;
            page2Pbx.UseVisualStyleBackColor = false;
            // 
            // page2InstructionLbl
            // 
            page2InstructionLbl.AutoSize = true;
            page2InstructionLbl.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            page2InstructionLbl.ForeColor = Color.White;
            page2InstructionLbl.Location = new Point(48, 364);
            page2InstructionLbl.Name = "page2InstructionLbl";
            page2InstructionLbl.Size = new Size(358, 54);
            page2InstructionLbl.TabIndex = 2;
            page2InstructionLbl.Text = "After the player have thought of\r\na word in mind, they could input a single\r\nletter of that word in the blank.\r\n";
            page2InstructionLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // page2Lbl
            // 
            page2Lbl.AutoSize = true;
            page2Lbl.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            page2Lbl.ForeColor = Color.White;
            page2Lbl.Location = new Point(193, 77);
            page2Lbl.Name = "page2Lbl";
            page2Lbl.Size = new Size(65, 18);
            page2Lbl.TabIndex = 5;
            page2Lbl.Text = "Page 2";
            page2Lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // next2Btn
            // 
            next2Btn.BackColor = Color.FromArgb(106, 149, 148);
            next2Btn.FlatAppearance.BorderSize = 0;
            next2Btn.FlatStyle = FlatStyle.Flat;
            next2Btn.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            next2Btn.ForeColor = Color.White;
            next2Btn.Location = new Point(256, 452);
            next2Btn.Name = "next2Btn";
            next2Btn.Size = new Size(120, 39);
            next2Btn.TabIndex = 7;
            next2Btn.Text = "NEXT";
            next2Btn.UseVisualStyleBackColor = false;
            next2Btn.Click += howToPlayBtns_Click;
            next2Btn.MouseLeave += allBtn_MouseLeave;
            next2Btn.MouseHover += allBtn_MouseHover;
            // 
            // previous2Btn
            // 
            previous2Btn.BackColor = Color.FromArgb(106, 149, 148);
            previous2Btn.FlatAppearance.BorderSize = 0;
            previous2Btn.FlatStyle = FlatStyle.Flat;
            previous2Btn.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            previous2Btn.ForeColor = Color.White;
            previous2Btn.Location = new Point(48, 452);
            previous2Btn.Name = "previous2Btn";
            previous2Btn.Size = new Size(142, 39);
            previous2Btn.TabIndex = 8;
            previous2Btn.Text = "PREVIOUS";
            previous2Btn.UseVisualStyleBackColor = false;
            previous2Btn.Click += howToPlayBtns_Click;
            previous2Btn.MouseLeave += allBtn_MouseLeave;
            previous2Btn.MouseHover += allBtn_MouseHover;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(69, 37);
            label1.Name = "label1";
            label1.Size = new Size(315, 25);
            label1.TabIndex = 9;
            label1.Text = "HOW TO PLAY: HANGMAN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Page2Pnl
            // 
            Page2Pnl.Controls.Add(label1);
            Page2Pnl.Controls.Add(previous2Btn);
            Page2Pnl.Controls.Add(next2Btn);
            Page2Pnl.Controls.Add(page2Lbl);
            Page2Pnl.Controls.Add(page2InstructionLbl);
            Page2Pnl.Controls.Add(page2Pbx);
            Page2Pnl.Location = new Point(0, -3);
            Page2Pnl.Name = "Page2Pnl";
            Page2Pnl.Size = new Size(437, 567);
            Page2Pnl.TabIndex = 11;
            Page2Pnl.Visible = false;
            // 
            // Page3Pnl
            // 
            Page3Pnl.Controls.Add(page3Lbl);
            Page3Pnl.Controls.Add(howToPlay3Lbl);
            Page3Pnl.Controls.Add(previous3Btn);
            Page3Pnl.Controls.Add(next3Btn);
            Page3Pnl.Controls.Add(page3InstructionsLbl);
            Page3Pnl.Controls.Add(page3Pbx);
            Page3Pnl.Location = new Point(0, -3);
            Page3Pnl.Name = "Page3Pnl";
            Page3Pnl.Size = new Size(437, 567);
            Page3Pnl.TabIndex = 12;
            Page3Pnl.Visible = false;
            // 
            // page3Lbl
            // 
            page3Lbl.AutoSize = true;
            page3Lbl.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            page3Lbl.ForeColor = Color.White;
            page3Lbl.Location = new Point(193, 80);
            page3Lbl.Name = "page3Lbl";
            page3Lbl.Size = new Size(65, 18);
            page3Lbl.TabIndex = 5;
            page3Lbl.Text = "Page 3";
            page3Lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // howToPlay3Lbl
            // 
            howToPlay3Lbl.AutoSize = true;
            howToPlay3Lbl.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            howToPlay3Lbl.ForeColor = Color.White;
            howToPlay3Lbl.Location = new Point(64, 46);
            howToPlay3Lbl.Name = "howToPlay3Lbl";
            howToPlay3Lbl.Size = new Size(315, 25);
            howToPlay3Lbl.TabIndex = 9;
            howToPlay3Lbl.Text = "HOW TO PLAY: HANGMAN";
            howToPlay3Lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // previous3Btn
            // 
            previous3Btn.BackColor = Color.FromArgb(106, 149, 148);
            previous3Btn.FlatAppearance.BorderSize = 0;
            previous3Btn.FlatStyle = FlatStyle.Flat;
            previous3Btn.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            previous3Btn.ForeColor = Color.White;
            previous3Btn.Location = new Point(48, 452);
            previous3Btn.Name = "previous3Btn";
            previous3Btn.Size = new Size(142, 39);
            previous3Btn.TabIndex = 8;
            previous3Btn.Text = "PREVIOUS";
            previous3Btn.UseVisualStyleBackColor = false;
            previous3Btn.Click += howToPlayBtns_Click;
            previous3Btn.MouseLeave += allBtn_MouseLeave;
            previous3Btn.MouseHover += allBtn_MouseHover;
            // 
            // next3Btn
            // 
            next3Btn.BackColor = Color.FromArgb(106, 149, 148);
            next3Btn.FlatAppearance.BorderSize = 0;
            next3Btn.FlatStyle = FlatStyle.Flat;
            next3Btn.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            next3Btn.ForeColor = Color.White;
            next3Btn.Location = new Point(256, 452);
            next3Btn.Name = "next3Btn";
            next3Btn.Size = new Size(120, 39);
            next3Btn.TabIndex = 7;
            next3Btn.Text = "NEXT";
            next3Btn.UseVisualStyleBackColor = false;
            next3Btn.Click += howToPlayBtns_Click;
            next3Btn.MouseLeave += allBtn_MouseLeave;
            next3Btn.MouseHover += allBtn_MouseHover;
            // 
            // page3InstructionsLbl
            // 
            page3InstructionsLbl.AutoSize = true;
            page3InstructionsLbl.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            page3InstructionsLbl.ForeColor = Color.White;
            page3InstructionsLbl.Location = new Point(11, 361);
            page3InstructionsLbl.Name = "page3InstructionsLbl";
            page3InstructionsLbl.Size = new Size(416, 72);
            page3InstructionsLbl.TabIndex = 2;
            page3InstructionsLbl.Text = "If the letter input is correct,\r\nit will then put it on the correct placement\r\nin the blanks. If wrong, It will draw a little part\r\nof a stickman\r\n";
            page3InstructionsLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // page3Pbx
            // 
            page3Pbx.BackColor = Color.MediumSlateBlue;
            page3Pbx.BackgroundImage = (Image)resources.GetObject("page3Pbx.BackgroundImage");
            page3Pbx.BackgroundImageLayout = ImageLayout.Stretch;
            page3Pbx.FlatAppearance.BorderSize = 0;
            page3Pbx.FlatStyle = FlatStyle.Flat;
            page3Pbx.ForeColor = Color.White;
            page3Pbx.Location = new Point(106, 89);
            page3Pbx.Name = "page3Pbx";
            page3Pbx.Size = new Size(247, 255);
            page3Pbx.TabIndex = 0;
            page3Pbx.UseVisualStyleBackColor = false;
            // 
            // Page4Pnl
            // 
            Page4Pnl.Controls.Add(customButton4);
            Page4Pnl.Controls.Add(page4Lbl);
            Page4Pnl.Controls.Add(page4HowToPlayLbl);
            Page4Pnl.Controls.Add(previous4Btn);
            Page4Pnl.Controls.Add(next4Btn);
            Page4Pnl.Controls.Add(page4InstructionsLbl);
            Page4Pnl.Controls.Add(customButton3);
            Page4Pnl.Location = new Point(0, -3);
            Page4Pnl.Name = "Page4Pnl";
            Page4Pnl.Size = new Size(440, 567);
            Page4Pnl.TabIndex = 13;
            Page4Pnl.Visible = false;
            // 
            // customButton4
            // 
            customButton4.BackColor = Color.MediumSlateBlue;
            customButton4.BackgroundImage = (Image)resources.GetObject("customButton4.BackgroundImage");
            customButton4.BackgroundImageLayout = ImageLayout.Stretch;
            customButton4.FlatAppearance.BorderSize = 0;
            customButton4.FlatStyle = FlatStyle.Flat;
            customButton4.ForeColor = Color.White;
            customButton4.Location = new Point(230, 96);
            customButton4.Name = "customButton4";
            customButton4.Size = new Size(192, 241);
            customButton4.TabIndex = 10;
            customButton4.UseVisualStyleBackColor = false;
            // 
            // page4Lbl
            // 
            page4Lbl.AutoSize = true;
            page4Lbl.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            page4Lbl.ForeColor = Color.White;
            page4Lbl.Location = new Point(181, 62);
            page4Lbl.Name = "page4Lbl";
            page4Lbl.Size = new Size(65, 18);
            page4Lbl.TabIndex = 5;
            page4Lbl.Text = "Page 4";
            page4Lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // page4HowToPlayLbl
            // 
            page4HowToPlayLbl.AutoSize = true;
            page4HowToPlayLbl.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            page4HowToPlayLbl.ForeColor = Color.White;
            page4HowToPlayLbl.Location = new Point(64, 27);
            page4HowToPlayLbl.Name = "page4HowToPlayLbl";
            page4HowToPlayLbl.Size = new Size(315, 25);
            page4HowToPlayLbl.TabIndex = 9;
            page4HowToPlayLbl.Text = "HOW TO PLAY: HANGMAN";
            page4HowToPlayLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // previous4Btn
            // 
            previous4Btn.BackColor = Color.FromArgb(106, 149, 148);
            previous4Btn.FlatAppearance.BorderSize = 0;
            previous4Btn.FlatStyle = FlatStyle.Flat;
            previous4Btn.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            previous4Btn.ForeColor = Color.White;
            previous4Btn.Location = new Point(43, 490);
            previous4Btn.Name = "previous4Btn";
            previous4Btn.Size = new Size(142, 39);
            previous4Btn.TabIndex = 8;
            previous4Btn.Text = "PREVIOUS";
            previous4Btn.UseVisualStyleBackColor = false;
            previous4Btn.Click += howToPlayBtns_Click;
            previous4Btn.MouseLeave += allBtn_MouseLeave;
            previous4Btn.MouseHover += allBtn_MouseHover;
            // 
            // next4Btn
            // 
            next4Btn.BackColor = Color.FromArgb(106, 149, 148);
            next4Btn.FlatAppearance.BorderSize = 0;
            next4Btn.FlatStyle = FlatStyle.Flat;
            next4Btn.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            next4Btn.ForeColor = Color.White;
            next4Btn.Location = new Point(278, 490);
            next4Btn.Name = "next4Btn";
            next4Btn.Size = new Size(120, 39);
            next4Btn.TabIndex = 7;
            next4Btn.Text = "NEXT";
            next4Btn.UseVisualStyleBackColor = false;
            next4Btn.Click += howToPlayBtns_Click;
            next4Btn.MouseLeave += allBtn_MouseLeave;
            next4Btn.MouseHover += allBtn_MouseHover;
            // 
            // page4InstructionsLbl
            // 
            page4InstructionsLbl.AutoSize = true;
            page4InstructionsLbl.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            page4InstructionsLbl.ForeColor = Color.White;
            page4InstructionsLbl.Location = new Point(43, 366);
            page4InstructionsLbl.Name = "page4InstructionsLbl";
            page4InstructionsLbl.Size = new Size(365, 108);
            page4InstructionsLbl.TabIndex = 2;
            page4InstructionsLbl.Text = resources.GetString("page4InstructionsLbl.Text");
            page4InstructionsLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // customButton3
            // 
            customButton3.BackColor = Color.MediumSlateBlue;
            customButton3.BackgroundImage = (Image)resources.GetObject("customButton3.BackgroundImage");
            customButton3.BackgroundImageLayout = ImageLayout.Stretch;
            customButton3.FlatAppearance.BorderSize = 0;
            customButton3.FlatStyle = FlatStyle.Flat;
            customButton3.ForeColor = Color.White;
            customButton3.Location = new Point(19, 96);
            customButton3.Name = "customButton3";
            customButton3.Size = new Size(192, 241);
            customButton3.TabIndex = 0;
            customButton3.UseVisualStyleBackColor = false;
            // 
            // Page5Pnl
            // 
            Page5Pnl.Controls.Add(page5Pbx2);
            Page5Pnl.Controls.Add(page5lbl);
            Page5Pnl.Controls.Add(page5HowToPlayLbl);
            Page5Pnl.Controls.Add(previous5Btn);
            Page5Pnl.Controls.Add(backToMenuBtn);
            Page5Pnl.Controls.Add(page5InstructionsLbl);
            Page5Pnl.Controls.Add(customButton6);
            Page5Pnl.Location = new Point(0, -3);
            Page5Pnl.Name = "Page5Pnl";
            Page5Pnl.Size = new Size(440, 567);
            Page5Pnl.TabIndex = 14;
            Page5Pnl.Visible = false;
            // 
            // page5Pbx2
            // 
            page5Pbx2.BackColor = Color.MediumSlateBlue;
            page5Pbx2.BackgroundImage = (Image)resources.GetObject("page5Pbx2.BackgroundImage");
            page5Pbx2.BackgroundImageLayout = ImageLayout.Stretch;
            page5Pbx2.FlatAppearance.BorderSize = 0;
            page5Pbx2.FlatStyle = FlatStyle.Flat;
            page5Pbx2.ForeColor = Color.White;
            page5Pbx2.Location = new Point(230, 96);
            page5Pbx2.Name = "page5Pbx2";
            page5Pbx2.Size = new Size(192, 241);
            page5Pbx2.TabIndex = 10;
            page5Pbx2.UseVisualStyleBackColor = false;
            // 
            // page5lbl
            // 
            page5lbl.AutoSize = true;
            page5lbl.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            page5lbl.ForeColor = Color.White;
            page5lbl.Location = new Point(181, 62);
            page5lbl.Name = "page5lbl";
            page5lbl.Size = new Size(65, 18);
            page5lbl.TabIndex = 5;
            page5lbl.Text = "Page 5";
            page5lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // page5HowToPlayLbl
            // 
            page5HowToPlayLbl.AutoSize = true;
            page5HowToPlayLbl.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            page5HowToPlayLbl.ForeColor = Color.White;
            page5HowToPlayLbl.Location = new Point(64, 27);
            page5HowToPlayLbl.Name = "page5HowToPlayLbl";
            page5HowToPlayLbl.Size = new Size(315, 25);
            page5HowToPlayLbl.TabIndex = 9;
            page5HowToPlayLbl.Text = "HOW TO PLAY: HANGMAN";
            page5HowToPlayLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // previous5Btn
            // 
            previous5Btn.BackColor = Color.FromArgb(106, 149, 148);
            previous5Btn.FlatAppearance.BorderSize = 0;
            previous5Btn.FlatStyle = FlatStyle.Flat;
            previous5Btn.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            previous5Btn.ForeColor = Color.White;
            previous5Btn.Location = new Point(47, 466);
            previous5Btn.Name = "previous5Btn";
            previous5Btn.Size = new Size(142, 39);
            previous5Btn.TabIndex = 8;
            previous5Btn.Text = "PREVIOUS";
            previous5Btn.UseVisualStyleBackColor = false;
            previous5Btn.Click += howToPlayBtns_Click;
            previous5Btn.MouseLeave += allBtn_MouseLeave;
            previous5Btn.MouseHover += allBtn_MouseHover;
            // 
            // backToMenuBtn
            // 
            backToMenuBtn.BackColor = Color.FromArgb(106, 149, 148);
            backToMenuBtn.FlatAppearance.BorderSize = 0;
            backToMenuBtn.FlatStyle = FlatStyle.Flat;
            backToMenuBtn.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backToMenuBtn.ForeColor = Color.White;
            backToMenuBtn.Location = new Point(245, 455);
            backToMenuBtn.Name = "backToMenuBtn";
            backToMenuBtn.Size = new Size(164, 61);
            backToMenuBtn.TabIndex = 7;
            backToMenuBtn.Text = "BACK TO MENU";
            backToMenuBtn.UseVisualStyleBackColor = false;
            backToMenuBtn.Click += howToPlayBtns_Click;
            backToMenuBtn.MouseLeave += allBtn_MouseLeave;
            backToMenuBtn.MouseHover += allBtn_MouseHover;
            // 
            // page5InstructionsLbl
            // 
            page5InstructionsLbl.AutoSize = true;
            page5InstructionsLbl.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            page5InstructionsLbl.ForeColor = Color.White;
            page5InstructionsLbl.Location = new Point(47, 390);
            page5InstructionsLbl.Name = "page5InstructionsLbl";
            page5InstructionsLbl.Size = new Size(344, 36);
            page5InstructionsLbl.TabIndex = 2;
            page5InstructionsLbl.Text = "After a few errors until a full stickman \r\nfigure is formed, then it's game over.\r\n";
            page5InstructionsLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // customButton6
            // 
            customButton6.BackColor = Color.MediumSlateBlue;
            customButton6.BackgroundImage = (Image)resources.GetObject("customButton6.BackgroundImage");
            customButton6.BackgroundImageLayout = ImageLayout.Stretch;
            customButton6.FlatAppearance.BorderSize = 0;
            customButton6.FlatStyle = FlatStyle.Flat;
            customButton6.ForeColor = Color.White;
            customButton6.Location = new Point(19, 96);
            customButton6.Name = "customButton6";
            customButton6.Size = new Size(192, 241);
            customButton6.TabIndex = 0;
            customButton6.UseVisualStyleBackColor = false;
            // 
            // TitleScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(91, 105, 128);
            ClientSize = new Size(436, 563);
            Controls.Add(MenuPnl);
            Controls.Add(CategoryPnl);
            Controls.Add(Page1Pnl);
            Controls.Add(Page2Pnl);
            Controls.Add(Page3Pnl);
            Controls.Add(Page4Pnl);
            Controls.Add(Page5Pnl);
            Name = "TitleScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hangman";
            FormClosed += TitleScreen_FormClosed;
            Load += TitleScreen_Load;
            ((System.ComponentModel.ISupportInitialize)gameIconPbx).EndInit();
            MenuPnl.ResumeLayout(false);
            MenuPnl.PerformLayout();
            CategoryPnl.ResumeLayout(false);
            Page1Pnl.ResumeLayout(false);
            Page1Pnl.PerformLayout();
            Page2Pnl.ResumeLayout(false);
            Page2Pnl.PerformLayout();
            Page3Pnl.ResumeLayout(false);
            Page3Pnl.PerformLayout();
            Page4Pnl.ResumeLayout(false);
            Page4Pnl.PerformLayout();
            Page5Pnl.ResumeLayout(false);
            Page5Pnl.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label titleLbl;
        private PictureBox gameIconPbx;
        private CustomButton playBtn;
        private CustomButton howToPlayBtn;
        private CustomButton settingsBtn;
        private CustomButton leaderboardsBtn;
        private CustomButton audioBtn;
        private CustomButton muteBtn;
        public Panel MenuPnl;
        public Panel CategoryPnl;
        private CustomButton categoryBackBtn;
        private CustomGradientButton categoryOccupationBtn;
        private CustomGradientButton categoryCountryBtn;
        private CustomGradientButton categoryAnimalsBtn;
        private CustomGradientButton categoryFruitsBtn;
        private CustomButton categoryBg;
        public Panel Page1Pnl;
        private CustomButton page1Pbx;
        private Label instructionsLbl;
        private Label pageLbl;
        private Label howToPlayLbl;
        private CustomButton backToMenu1Btn;
        private CustomButton next1Btn;
        private CustomButton page2Pbx;
        private Label page2InstructionLbl;
        private Label page2Lbl;
        private CustomButton next2Btn;
        private CustomButton previous2Btn;
        private Label label1;
        private Panel Page2Pnl;
        private Panel Page3Pnl;
        private Label howToPlay3Lbl;
        private CustomButton previous3Btn;
        private CustomButton next3Btn;
        private Label page3Lbl;
        private Label page3InstructionsLbl;
        private CustomButton page3Pbx;
        private Panel Page4Pnl;
        private Label page4Lbl;
        private Label page4HowToPlayLbl;
        private CustomButton previous4Btn;
        private CustomButton next4Btn;
        private Label page4InstructionsLbl;
        private CustomButton customButton4;
        private CustomButton customButton3;
        private Panel Page5Pnl;
        private CustomButton page5Pbx2;
        private Label page5lbl;
        private Label page5HowToPlayLbl;
        private CustomButton previous5Btn;
        private CustomButton backToMenuBtn;
        private Label page5InstructionsLbl;
        private CustomButton customButton6;
    }
}
