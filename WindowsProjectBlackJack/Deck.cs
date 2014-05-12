/*File name: BlackJackWindow.cs
 *Author: Darian Jeptha
 *Created: 05/09/2013
 *
 *This Class populates a deck which loops through the cards and creates
 *only one of each card to avoid duplication and utilizes the random class
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsProjectBlackJack
{
    public class Deck
    {
        public Deck() {
            _cards = new List<Card>();

            for(var count = 0; count < 4; count++){

                for (var number = 1; number <= 13;number++ )
                {
                    var pic = ((Suits)count).ToString() + number.ToString();
                    var card = new Card(number, (Suits)count,
                        string.Format("../../Pictures/{0}.png", pic),
                        "../../PicRear/CardBack.png");

                    _cards.Add(card);
                }
            }
        }

        private List<Card> _cards;
        public List<Card> Cards {
            get 
            {
                return _cards;
            }
        }

        public Card DrawRandomCard() {
            Random r = new Random();
            var index = r.Next(1, this.Cards.Count) - 1;
            var card = this.Cards[index];
            this.Cards.RemoveAt(index);
            return card;
        }
    }
}
