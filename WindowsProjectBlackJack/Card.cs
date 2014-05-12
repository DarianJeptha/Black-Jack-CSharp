/*File name: BlackJackWindow.cs
 *Author: Darian Jeptha
 *Created: 05/09/2013
 *
 *This Class creates a instance of a card by getting its by getting
 *its card number, suit and a picture 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsProjectBlackJack
{
    public enum Suits { Clubs, Diamonds, Hearts, Spades }
    public class Card
    {
        public Card(int number, Suits suit, string picture, string pictureBack) {
            this.Number = number;
            this.Suit = suit;
            this.Picture = picture;
            this.PictureBack = pictureBack;
        }

        public int Number { get; set; }
        public Suits Suit
        {
            get;
            set;
        }
        public string Picture { get; set; }
        public string PictureBack { get; set; }
    }
}
