/*File name: BlackJackWindow.cs
 *Author: Darian Jeptha
 *Created: 05/09/2013
 *
 *This Class contains the rules of the game
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace WindowsProjectBlackJack
{
    public partial class BlackJackWindow : Form
    {
        //Declaration
        private BlackJackGame Game;
        int playerScoreWin;
        int playerScoreLose;
        int tie;
        int Zero = 0;
        int Xcoordintae = 87;

        public BlackJackWindow()
        {
            MessageBox.Show("Welcome to Black Jack. Play responsibly!!!");
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            InitializeGame();
            
            MainMenu myNewMenu = new MainMenu();
            this.Menu = myNewMenu;
            //
            //Shortcuts
            //
            MenuItem myMenuGameOp = new MenuItem("&Game Options");
            MenuItem myMenuHelp = new MenuItem("&Help");
            MenuItem myMenuNewGame = new MenuItem("&New Game");
            MenuItem myMenuQuit = new MenuItem("&Quit");
            HitBtn.Visible = false;
            StandBtn.Visible = false;

            
            

            lblCardval.Text = Game.Deck.Cards.Count.ToString();
            //Visual Deck
            picDeck1.Image = Image.FromFile("../../PicRear/CardBack.png");
            picDeck2.Image = Image.FromFile("../../PicRear/CardBack.png");
            picDeck3.Image = Image.FromFile("../../PicRear/CardBack.png");
            picDeck4.Image = Image.FromFile("../../PicRear/CardBack.png");
        }

        private void InitializeGame() {

            if (Game != null)
            {
                foreach (Card c in Game.Dealer.Hand)
                {
                    Dealergroup.Controls.RemoveByKey("Cards");
                }
                foreach (Card c in Game.Player.Hand)
                {
                    PlayerGroup.Controls.RemoveByKey("Cards");
                }
            }

            var newPlayer = new Player("Player1");
            Game = new BlackJackGame(newPlayer);

            //Setting value to zero
            DealScoreVal.Text = Zero.ToString();
            PlayerScoreVal.Text = Zero.ToString();

            HitBtn.Visible = false;
            StandBtn.Visible = false;
            this.Refresh();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DrawCards(List<Card> cards, int x, int y, bool isDealer) {
            int Xcoordinate = 0;
            for (int i = 0; i < cards.Count; i++)
            {
                PictureBox pic = new PictureBox();
                pic.Name = "Cards";
                pic.Size = new Size(81, 127);
                pic.Location = new Point(x + Xcoordinate, y);
                if (isDealer && i == 0)
                {
                    pic.Image = Image.FromFile(cards[i].PictureBack);
                    Dealergroup.Controls.Add(pic);
                }
                else if (isDealer && i == 1)
                {
                    pic.Image = Image.FromFile(cards[i].Picture);
                    Dealergroup.Controls.Add(pic);
                    DealScoreVal.Text = cards[i].Number.ToString();
                }
                else
                {
                    pic.Image = Image.FromFile(cards[i].Picture);
                    PlayerGroup.Controls.Add(pic);
                }
                Xcoordinate = Xcoordinate + 87;
            }
        }

        private void ShowDealersCard(List<Card> cards, int x, int y, bool isEndOfGame)
        {
            foreach (Card c in Game.Dealer.Hand)
            {
                Dealergroup.Controls.RemoveByKey("Cards");
            }
            int Xcoordinate = 0;
            for (int i = 0; i < cards.Count; i++)
            {
                PictureBox pic = new PictureBox();
                pic.Name = "Cards";
                pic.Size = new Size(81, 127);
                pic.Location = new Point(x + Xcoordinate, y);
                if (isEndOfGame)
                {
                    pic.Image = Image.FromFile(cards[i].Picture);
                    Dealergroup.Controls.Add(pic);
                }
                Xcoordinate = Xcoordinate + 87;
            }
        }
        //
        // Hit Button
        //
        private void HitBtn_Click(object sender, EventArgs e)
        {
            Xcoordintae = Xcoordintae + 87;

            //foreach (Card c in Game.Dealer.Hand)
            //{
            //    Dealergroup.Controls.RemoveByKey("Cards");
            //}
            foreach (Card c in Game.Player.Hand)
            {
                PlayerGroup.Controls.RemoveByKey("Cards");
            }

            Game.Player.Hit(Game.Deck.DrawRandomCard());
            lblCardval.Text = Game.Deck.Cards.Count.ToString();
            DrawCards(Game.Player.Hand, 294, 19, false);
            //
            //Value of cards with in ur hand
            //
            PlayerScoreVal.Text = Game.Player.HandValue.ToString();
            DetermineOutcome();
                
        }

        private void DetermineOutcome()
        {
            if (Game.Dealer.HandValue == 21 && Game.Player.HandValue == 21)
            {
                //Tie
                //Tallying up..
                tie = tie + 1;

                //Writing to label
                lblResultTieY.Text = tie.ToString();
                lblResultTieD.Text = lblResultTieY.Text;

                //Dealer hand value
                DealScoreVal.Text = Game.Dealer.HandValue.ToString();
                ShowDealersCard(Game.Dealer.Hand, 294, 19, true);

                //Display buttons
                MessageBox.Show("Tie");
                DealBtn.Visible = true;
                this.Form1_Load(this, null);

            }
            else if (Game.Dealer.HandValue == 21 && Game.Player.HandValue < 21)
            {
                //dealer won
                playerScoreLose = playerScoreLose + 1;

                //writing to label
                lblResultLoseYo.Text = playerScoreLose.ToString();
                lblResultWinD.Text = lblResultLoseYo.Text;

                //Setting visible
                StandBtn.Visible = false;
                HitBtn.Visible = false;

                //Dealer hand value
                DealScoreVal.Text = Game.Dealer.HandValue.ToString();
                ShowDealersCard(Game.Dealer.Hand, 294, 19, true);

                //Result Message
                MessageBox.Show("You lose");

                //New deal
                DealBtn.Visible = true;
                this.Form1_Load(this, null);

            }
            else if (Game.Dealer.HandValue < 21 && Game.Player.HandValue > 21)
            {
                //dealer won
                playerScoreLose = playerScoreLose + 1;

                //writing to label
                lblResultLoseYo.Text = playerScoreLose.ToString();
                lblResultWinD.Text = lblResultLoseYo.Text;

                //Dealer hand value
                DealScoreVal.Text = Game.Dealer.HandValue.ToString();

                //Setting visible
                StandBtn.Visible = false;
                HitBtn.Visible = false;
                
                ShowDealersCard(Game.Dealer.Hand, 294, 19, true);

                //Result Message
                MessageBox.Show("You lose");

                //New deal
                DealBtn.Visible = true;
                this.Form1_Load(this, null);
            }
            else if (Game.Dealer.HandValue > 21 && Game.Player.HandValue > 21)
            {
                //tallying score
                playerScoreLose = playerScoreLose + 1;

                //writing to label
                lblResultLoseYo.Text = playerScoreLose.ToString();
                lblResultLoseYo.Text = lblResultWinD.Text;

                //Dealer hand value
                DealScoreVal.Text = Game.Dealer.HandValue.ToString();
                PlayerScoreVal.Text = Game.Player.HandValue.ToString();
                
                ShowDealersCard(Game.Dealer.Hand, 294, 19, true);

                MessageBox.Show("You Lose");
                DealBtn.Visible = true;
                this.Form1_Load(this, null);
                
            }
            else if (Game.Player.HandValue == 21)
            {

                //Tallying up Wins
                playerScoreWin = playerScoreWin + 1;

                //Writing to label
                lblResultWinY.Text = playerScoreWin.ToString();
                lblResultLoseD.Text = lblResultWinY.Text;

                //Dealer hand value
                DealScoreVal.Text = Game.Dealer.HandValue.ToString();

                //Button visibilty set
                StandBtn.Visible = false;
                HitBtn.Visible = false;
                
                ShowDealersCard(Game.Dealer.Hand, 294, 19, true);

                //player won
                MessageBox.Show("You hit BlackJack!!");

                //new Deal
                DealBtn.Visible = true;
                this.Form1_Load(this, null);
                
            }
            else if (Game.Dealer.HandValue > 21)
            {
                //tallying score
                playerScoreWin = playerScoreWin + 1;

                //writing to label
                lblResultWinY.Text = playerScoreWin.ToString();
                lblResultLoseD.Text = lblResultWinY.Text;

                //Dealer hand value
                DealScoreVal.Text = Game.Dealer.HandValue.ToString();
                
                ShowDealersCard(Game.Dealer.Hand, 294, 19, true);

                MessageBox.Show("You win");
                DealBtn.Visible = true;
                this.Form1_Load(this, null);
                
                //Game is done
            }
            
        }
        public void DetermineOutcomeStand(){
            if (Game.Dealer.HandValue == Game.Player.HandValue
                && Game.Dealer.HandValue <= 21 && Game.Player.HandValue <= 21)
            {
                //Tallying score
                tie = tie + 1;

                //writing to label
                lblResultTieY.Text = tie.ToString();
                lblResultTieD.Text = lblResultTieY.Text;

                ShowDealersCard(Game.Dealer.Hand, 294, 19, true);

                //Dealer hand value
                DealScoreVal.Text = Game.Dealer.HandValue.ToString();

                //Result Message
                MessageBox.Show("Tie");

            }
            else if (Game.Dealer.HandValue > Game.Player.HandValue
                && Game.Dealer.HandValue <= 21)
            {

                //Tallying score
                playerScoreLose = playerScoreLose + 1;

                //writing to label
                lblResultLoseYo.Text = playerScoreLose.ToString();
                lblResultWinD.Text = lblResultLoseYo.Text;
                ShowDealersCard(Game.Dealer.Hand, 294, 19, true);
                //
                //Result Message
                //
                MessageBox.Show("You lose");
            }
            else if (Game.Player.HandValue > Game.Dealer.HandValue
                && Game.Player.HandValue <= 21)
            {
                //tallying up score
                playerScoreWin = playerScoreWin + 1;

                //writing to label
                lblResultWinY.Text = playerScoreWin.ToString();
                lblResultLoseD.Text = lblResultWinY.Text;

                ShowDealersCard(Game.Dealer.Hand, 294, 19, true);

                //Dealer result
                DealScoreVal.Text = Game.Dealer.HandValue.ToString();

                //message
                MessageBox.Show("You won");

            }
            else if (Game.Dealer.HandValue > 21 && Game.Player.HandValue <= 21)
            {
                //tallying up score
                playerScoreWin = playerScoreWin + 1;

                //writing to label
                lblResultWinY.Text = playerScoreWin.ToString();
                lblResultLoseD.Text = lblResultWinY.Text;

                ShowDealersCard(Game.Dealer.Hand, 294, 19, true);

                //Dealer result
                DealScoreVal.Text = Game.Dealer.HandValue.ToString();

                //message
                MessageBox.Show("You won");
            }
        }

        //
        // Deal Button
        //
        private void DealBtn_Click_1(object sender, EventArgs e)
        {
            Game.Deal();
            //
            //Amount of Cards in the Deck
            //
            lblCardval.Text = Game.Deck.Cards.Count.ToString();

            //
            //Visual display of cards
            //
            DrawCards(Game.Player.Hand, 294, 19,false);
            DrawCards(Game.Dealer.Hand, 294, 19, true);

            PlayerScoreVal.Text = Game.Player.HandValue.ToString(); 

            //
            //Visibilty Set
            //
            DealBtn.Visible = false;
            HitBtn.Visible = true;
            StandBtn.Visible = true;

            DetermineOutcome();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //New Game
            Game = null;
            this.Controls.Clear();
            this.InitializeComponent();
            Form1_Load(this, null);
            playerScoreWin = 0;
            playerScoreLose = 0;
            tie = 0;
        }

        private void instructionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            InstructionPopup pop = new InstructionPopup();
            pop.Show();
        }

        //
        // Stand button
        //
        private void StandBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                if (Game.Dealer.CanHit)
                {
                    Game.Dealer.Hit(Game.Deck.DrawRandomCard());

                    ShowDealersCard(Game.Dealer.Hand, 294, 19, true);
                }
            }
            //Dealers hand value
            DealScoreVal.Text = Game.Dealer.HandValue.ToString();

            //Deck cards
            lblCardval.Text = Game.Deck.Cards.Count.ToString();

            

            //Setting visibilty
            DealBtn.Visible = true;
            DetermineOutcomeStand();






            //foreach (Card c in Game.Dealer.Hand)
            //{
            //    Dealergroup.Controls.RemoveByKey("Cards");
            //}
            //foreach (Card c in Game.Player.Hand)
            //{
            //    PlayerGroup.Controls.RemoveByKey("Cards");
            //}
            this.Form1_Load(this, null);

            InitializeGame();
        }

        
    }
}
