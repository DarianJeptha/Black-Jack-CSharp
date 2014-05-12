namespace WindowsProjectBlackJack
{
    partial class BlackJackWindow
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
            this.Dealergroup = new System.Windows.Forms.GroupBox();
            this.lblCardval = new System.Windows.Forms.Label();
            this.Cardlbl = new System.Windows.Forms.Label();
            this.DealScoreVal = new System.Windows.Forms.Label();
            this.DealerScore = new System.Windows.Forms.Label();
            this.DealerResultBx = new System.Windows.Forms.GroupBox();
            this.lblResultTieD = new System.Windows.Forms.Label();
            this.lblResultLoseD = new System.Windows.Forms.Label();
            this.lblResultWinD = new System.Windows.Forms.Label();
            this.lblDealerTie = new System.Windows.Forms.Label();
            this.lblDealerLose = new System.Windows.Forms.Label();
            this.lblDealerWin = new System.Windows.Forms.Label();
            this.picDeck4 = new System.Windows.Forms.PictureBox();
            this.picDeck3 = new System.Windows.Forms.PictureBox();
            this.picDeck2 = new System.Windows.Forms.PictureBox();
            this.picDeck1 = new System.Windows.Forms.PictureBox();
            this.PlayerGroup = new System.Windows.Forms.GroupBox();
            this.PlayerScoreVal = new System.Windows.Forms.Label();
            this.PlayerScore = new System.Windows.Forms.Label();
            this.lblResultLoseY = new System.Windows.Forms.GroupBox();
            this.lblResultTieY = new System.Windows.Forms.Label();
            this.lblResultLoseYo = new System.Windows.Forms.Label();
            this.lblResultWinY = new System.Windows.Forms.Label();
            this.lblYourTie = new System.Windows.Forms.Label();
            this.lblYourLose = new System.Windows.Forms.Label();
            this.lblYourWin = new System.Windows.Forms.Label();
            this.StandBtn = new System.Windows.Forms.Button();
            this.HitBtn = new System.Windows.Forms.Button();
            this.DealBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instructionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Dealergroup.SuspendLayout();
            this.DealerResultBx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDeck4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDeck3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDeck2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDeck1)).BeginInit();
            this.PlayerGroup.SuspendLayout();
            this.lblResultLoseY.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dealergroup
            // 
            this.Dealergroup.Controls.Add(this.lblCardval);
            this.Dealergroup.Controls.Add(this.Cardlbl);
            this.Dealergroup.Controls.Add(this.DealScoreVal);
            this.Dealergroup.Controls.Add(this.DealerScore);
            this.Dealergroup.Controls.Add(this.DealerResultBx);
            this.Dealergroup.Controls.Add(this.picDeck4);
            this.Dealergroup.Controls.Add(this.picDeck3);
            this.Dealergroup.Controls.Add(this.picDeck2);
            this.Dealergroup.Controls.Add(this.picDeck1);
            this.Dealergroup.Location = new System.Drawing.Point(12, 47);
            this.Dealergroup.Name = "Dealergroup";
            this.Dealergroup.Size = new System.Drawing.Size(857, 179);
            this.Dealergroup.TabIndex = 0;
            this.Dealergroup.TabStop = false;
            this.Dealergroup.Text = "Dealer";
            // 
            // lblCardval
            // 
            this.lblCardval.AutoSize = true;
            this.lblCardval.Location = new System.Drawing.Point(51, 153);
            this.lblCardval.Name = "lblCardval";
            this.lblCardval.Size = new System.Drawing.Size(0, 13);
            this.lblCardval.TabIndex = 13;
            // 
            // Cardlbl
            // 
            this.Cardlbl.AutoSize = true;
            this.Cardlbl.Location = new System.Drawing.Point(9, 153);
            this.Cardlbl.Name = "Cardlbl";
            this.Cardlbl.Size = new System.Drawing.Size(34, 13);
            this.Cardlbl.TabIndex = 12;
            this.Cardlbl.Text = "Cards";
            // 
            // DealScoreVal
            // 
            this.DealScoreVal.AutoSize = true;
            this.DealScoreVal.Location = new System.Drawing.Point(188, 127);
            this.DealScoreVal.Name = "DealScoreVal";
            this.DealScoreVal.Size = new System.Drawing.Size(0, 13);
            this.DealScoreVal.TabIndex = 11;
            // 
            // DealerScore
            // 
            this.DealerScore.AutoSize = true;
            this.DealerScore.Location = new System.Drawing.Point(142, 127);
            this.DealerScore.Name = "DealerScore";
            this.DealerScore.Size = new System.Drawing.Size(38, 13);
            this.DealerScore.TabIndex = 10;
            this.DealerScore.Text = "Score:";
            // 
            // DealerResultBx
            // 
            this.DealerResultBx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.DealerResultBx.Controls.Add(this.lblResultTieD);
            this.DealerResultBx.Controls.Add(this.lblResultLoseD);
            this.DealerResultBx.Controls.Add(this.lblResultWinD);
            this.DealerResultBx.Controls.Add(this.lblDealerTie);
            this.DealerResultBx.Controls.Add(this.lblDealerLose);
            this.DealerResultBx.Controls.Add(this.lblDealerWin);
            this.DealerResultBx.Location = new System.Drawing.Point(142, 19);
            this.DealerResultBx.Name = "DealerResultBx";
            this.DealerResultBx.Size = new System.Drawing.Size(118, 101);
            this.DealerResultBx.TabIndex = 6;
            this.DealerResultBx.TabStop = false;
            this.DealerResultBx.Text = "Dealer\'s Result";
            // 
            // lblResultTieD
            // 
            this.lblResultTieD.AutoSize = true;
            this.lblResultTieD.Location = new System.Drawing.Point(43, 70);
            this.lblResultTieD.Name = "lblResultTieD";
            this.lblResultTieD.Size = new System.Drawing.Size(13, 13);
            this.lblResultTieD.TabIndex = 5;
            this.lblResultTieD.Text = "0";
            // 
            // lblResultLoseD
            // 
            this.lblResultLoseD.AutoSize = true;
            this.lblResultLoseD.Location = new System.Drawing.Point(43, 43);
            this.lblResultLoseD.Name = "lblResultLoseD";
            this.lblResultLoseD.Size = new System.Drawing.Size(13, 13);
            this.lblResultLoseD.TabIndex = 4;
            this.lblResultLoseD.Text = "0";
            // 
            // lblResultWinD
            // 
            this.lblResultWinD.AutoSize = true;
            this.lblResultWinD.Location = new System.Drawing.Point(43, 20);
            this.lblResultWinD.Name = "lblResultWinD";
            this.lblResultWinD.Size = new System.Drawing.Size(13, 13);
            this.lblResultWinD.TabIndex = 3;
            this.lblResultWinD.Text = "0";
            // 
            // lblDealerTie
            // 
            this.lblDealerTie.AutoSize = true;
            this.lblDealerTie.Location = new System.Drawing.Point(6, 70);
            this.lblDealerTie.Name = "lblDealerTie";
            this.lblDealerTie.Size = new System.Drawing.Size(25, 13);
            this.lblDealerTie.TabIndex = 2;
            this.lblDealerTie.Text = "Tie:";
            // 
            // lblDealerLose
            // 
            this.lblDealerLose.AutoSize = true;
            this.lblDealerLose.Location = new System.Drawing.Point(6, 43);
            this.lblDealerLose.Name = "lblDealerLose";
            this.lblDealerLose.Size = new System.Drawing.Size(33, 13);
            this.lblDealerLose.TabIndex = 1;
            this.lblDealerLose.Text = "Lose:";
            // 
            // lblDealerWin
            // 
            this.lblDealerWin.AutoSize = true;
            this.lblDealerWin.Location = new System.Drawing.Point(7, 20);
            this.lblDealerWin.Name = "lblDealerWin";
            this.lblDealerWin.Size = new System.Drawing.Size(29, 13);
            this.lblDealerWin.TabIndex = 0;
            this.lblDealerWin.Text = "Win:";
            // 
            // picDeck4
            // 
            this.picDeck4.Location = new System.Drawing.Point(24, 19);
            this.picDeck4.Name = "picDeck4";
            this.picDeck4.Size = new System.Drawing.Size(100, 127);
            this.picDeck4.TabIndex = 3;
            this.picDeck4.TabStop = false;
            // 
            // picDeck3
            // 
            this.picDeck3.Location = new System.Drawing.Point(18, 19);
            this.picDeck3.Name = "picDeck3";
            this.picDeck3.Size = new System.Drawing.Size(100, 127);
            this.picDeck3.TabIndex = 2;
            this.picDeck3.TabStop = false;
            // 
            // picDeck2
            // 
            this.picDeck2.Location = new System.Drawing.Point(12, 19);
            this.picDeck2.Name = "picDeck2";
            this.picDeck2.Size = new System.Drawing.Size(100, 127);
            this.picDeck2.TabIndex = 1;
            this.picDeck2.TabStop = false;
            // 
            // picDeck1
            // 
            this.picDeck1.Location = new System.Drawing.Point(6, 19);
            this.picDeck1.Name = "picDeck1";
            this.picDeck1.Size = new System.Drawing.Size(100, 127);
            this.picDeck1.TabIndex = 0;
            this.picDeck1.TabStop = false;
            // 
            // PlayerGroup
            // 
            this.PlayerGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.PlayerGroup.Controls.Add(this.PlayerScoreVal);
            this.PlayerGroup.Controls.Add(this.PlayerScore);
            this.PlayerGroup.Controls.Add(this.lblResultLoseY);
            this.PlayerGroup.Controls.Add(this.StandBtn);
            this.PlayerGroup.Controls.Add(this.HitBtn);
            this.PlayerGroup.Controls.Add(this.DealBtn);
            this.PlayerGroup.Location = new System.Drawing.Point(12, 232);
            this.PlayerGroup.Name = "PlayerGroup";
            this.PlayerGroup.Size = new System.Drawing.Size(857, 152);
            this.PlayerGroup.TabIndex = 1;
            this.PlayerGroup.TabStop = false;
            this.PlayerGroup.Text = "You";
            // 
            // PlayerScoreVal
            // 
            this.PlayerScoreVal.AutoSize = true;
            this.PlayerScoreVal.Location = new System.Drawing.Point(191, 126);
            this.PlayerScoreVal.Name = "PlayerScoreVal";
            this.PlayerScoreVal.Size = new System.Drawing.Size(0, 13);
            this.PlayerScoreVal.TabIndex = 11;
            // 
            // PlayerScore
            // 
            this.PlayerScore.AutoSize = true;
            this.PlayerScore.Location = new System.Drawing.Point(145, 127);
            this.PlayerScore.Name = "PlayerScore";
            this.PlayerScore.Size = new System.Drawing.Size(38, 13);
            this.PlayerScore.TabIndex = 10;
            this.PlayerScore.Text = "Score:";
            // 
            // lblResultLoseY
            // 
            this.lblResultLoseY.Controls.Add(this.lblResultTieY);
            this.lblResultLoseY.Controls.Add(this.lblResultLoseYo);
            this.lblResultLoseY.Controls.Add(this.lblResultWinY);
            this.lblResultLoseY.Controls.Add(this.lblYourTie);
            this.lblResultLoseY.Controls.Add(this.lblYourLose);
            this.lblResultLoseY.Controls.Add(this.lblYourWin);
            this.lblResultLoseY.Location = new System.Drawing.Point(142, 19);
            this.lblResultLoseY.Name = "lblResultLoseY";
            this.lblResultLoseY.Size = new System.Drawing.Size(118, 101);
            this.lblResultLoseY.TabIndex = 7;
            this.lblResultLoseY.TabStop = false;
            this.lblResultLoseY.Text = "Your Result";
            // 
            // lblResultTieY
            // 
            this.lblResultTieY.AutoSize = true;
            this.lblResultTieY.Location = new System.Drawing.Point(43, 70);
            this.lblResultTieY.Name = "lblResultTieY";
            this.lblResultTieY.Size = new System.Drawing.Size(13, 13);
            this.lblResultTieY.TabIndex = 5;
            this.lblResultTieY.Text = "0";
            // 
            // lblResultLoseYo
            // 
            this.lblResultLoseYo.AutoSize = true;
            this.lblResultLoseYo.Location = new System.Drawing.Point(43, 43);
            this.lblResultLoseYo.Name = "lblResultLoseYo";
            this.lblResultLoseYo.Size = new System.Drawing.Size(13, 13);
            this.lblResultLoseYo.TabIndex = 4;
            this.lblResultLoseYo.Text = "0";
            // 
            // lblResultWinY
            // 
            this.lblResultWinY.AutoSize = true;
            this.lblResultWinY.Location = new System.Drawing.Point(43, 20);
            this.lblResultWinY.Name = "lblResultWinY";
            this.lblResultWinY.Size = new System.Drawing.Size(13, 13);
            this.lblResultWinY.TabIndex = 3;
            this.lblResultWinY.Text = "0";
            // 
            // lblYourTie
            // 
            this.lblYourTie.AutoSize = true;
            this.lblYourTie.Location = new System.Drawing.Point(6, 70);
            this.lblYourTie.Name = "lblYourTie";
            this.lblYourTie.Size = new System.Drawing.Size(25, 13);
            this.lblYourTie.TabIndex = 2;
            this.lblYourTie.Text = "Tie:";
            // 
            // lblYourLose
            // 
            this.lblYourLose.AutoSize = true;
            this.lblYourLose.Location = new System.Drawing.Point(6, 43);
            this.lblYourLose.Name = "lblYourLose";
            this.lblYourLose.Size = new System.Drawing.Size(33, 13);
            this.lblYourLose.TabIndex = 1;
            this.lblYourLose.Text = "Lose:";
            // 
            // lblYourWin
            // 
            this.lblYourWin.AutoSize = true;
            this.lblYourWin.Location = new System.Drawing.Point(7, 20);
            this.lblYourWin.Name = "lblYourWin";
            this.lblYourWin.Size = new System.Drawing.Size(29, 13);
            this.lblYourWin.TabIndex = 0;
            this.lblYourWin.Text = "Win:";
            // 
            // StandBtn
            // 
            this.StandBtn.Location = new System.Drawing.Point(18, 94);
            this.StandBtn.Name = "StandBtn";
            this.StandBtn.Size = new System.Drawing.Size(75, 23);
            this.StandBtn.TabIndex = 4;
            this.StandBtn.Text = "Stand";
            this.StandBtn.UseVisualStyleBackColor = true;
            this.StandBtn.Click += new System.EventHandler(this.StandBtn_Click);
            // 
            // HitBtn
            // 
            this.HitBtn.Location = new System.Drawing.Point(18, 64);
            this.HitBtn.Name = "HitBtn";
            this.HitBtn.Size = new System.Drawing.Size(75, 23);
            this.HitBtn.TabIndex = 3;
            this.HitBtn.Text = "Hit";
            this.HitBtn.UseVisualStyleBackColor = true;
            this.HitBtn.Click += new System.EventHandler(this.HitBtn_Click);
            // 
            // DealBtn
            // 
            this.DealBtn.Location = new System.Drawing.Point(18, 34);
            this.DealBtn.Name = "DealBtn";
            this.DealBtn.Size = new System.Drawing.Size(75, 23);
            this.DealBtn.TabIndex = 2;
            this.DealBtn.Text = "Deal";
            this.DealBtn.UseVisualStyleBackColor = true;
            this.DealBtn.Click += new System.EventHandler(this.DealBtn_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(881, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.fileToolStripMenuItem.Text = "Game Options";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instructionsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // instructionsToolStripMenuItem
            // 
            this.instructionsToolStripMenuItem.Name = "instructionsToolStripMenuItem";
            this.instructionsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.instructionsToolStripMenuItem.Text = "How to play";
            this.instructionsToolStripMenuItem.Click += new System.EventHandler(this.instructionsToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // BlackJackWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(881, 396);
            this.Controls.Add(this.PlayerGroup);
            this.Controls.Add(this.Dealergroup);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(889, 430);
            this.MinimumSize = new System.Drawing.Size(889, 430);
            this.Name = "BlackJackWindow";
            this.Text = "Black Jack";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Dealergroup.ResumeLayout(false);
            this.Dealergroup.PerformLayout();
            this.DealerResultBx.ResumeLayout(false);
            this.DealerResultBx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDeck4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDeck3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDeck2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDeck1)).EndInit();
            this.PlayerGroup.ResumeLayout(false);
            this.PlayerGroup.PerformLayout();
            this.lblResultLoseY.ResumeLayout(false);
            this.lblResultLoseY.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Dealergroup;
        private System.Windows.Forms.GroupBox PlayerGroup;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.PictureBox picDeck1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instructionsToolStripMenuItem;
        private System.Windows.Forms.PictureBox picDeck4;
        private System.Windows.Forms.PictureBox picDeck3;
        private System.Windows.Forms.PictureBox picDeck2;
        private System.Windows.Forms.Button StandBtn;
        private System.Windows.Forms.Button HitBtn;
        private System.Windows.Forms.Button DealBtn;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.GroupBox DealerResultBx;
        private System.Windows.Forms.Label lblDealerTie;
        private System.Windows.Forms.Label lblDealerLose;
        private System.Windows.Forms.Label lblDealerWin;
        private System.Windows.Forms.GroupBox lblResultLoseY;
        private System.Windows.Forms.Label lblYourTie;
        private System.Windows.Forms.Label lblYourLose;
        private System.Windows.Forms.Label lblYourWin;
        private System.Windows.Forms.Label lblResultTieD;
        private System.Windows.Forms.Label lblResultLoseD;
        private System.Windows.Forms.Label lblResultWinD;
        private System.Windows.Forms.Label lblResultTieY;
        private System.Windows.Forms.Label lblResultLoseYo;
        private System.Windows.Forms.Label lblResultWinY;
        private System.Windows.Forms.Label DealScoreVal;
        private System.Windows.Forms.Label DealerScore;
        private System.Windows.Forms.Label PlayerScoreVal;
        private System.Windows.Forms.Label PlayerScore;
        private System.Windows.Forms.Label lblCardval;
        private System.Windows.Forms.Label Cardlbl;
    }
}

