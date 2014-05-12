/*File name: BlackJackWindow.cs
 *Author: Darian Jeptha
 *Created: 05/09/2013
 *
 *This Class has the exception of the Dealer because 
 *he has rules that guards him from folding most of the time.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsProjectBlackJack
{
    public class BlackJackGame
    {
        public BlackJackGame(Player player) { 
            //initializer
            this._player = player;
            this.Dealer = new Dealer("Dealer");
            this.Deck = new Deck();
            
        }

        public Deck Deck { get; set; }
        
        private Player _player { get; set; }
        public Player Player { 
            get 
            { 
                return _player; 
            } 
        }

        public Player Dealer
        {
            get;
            set;
        }

        public void Deal()
        {
            this.Player.AddCard(this.Deck.DrawRandomCard());
            this.Player.AddCard(this.Deck.DrawRandomCard());
            this.Dealer.AddCard(this.Deck.DrawRandomCard());
            this.Dealer.AddCard(this.Deck.DrawRandomCard());
        }

    }
}
