/*File name: BlackJackWindow.cs
 *Author: Darian Jeptha
 *Created: 05/09/2013
 *
 *This Class is for both players when calling Hit and 
 *calculates their hand values with the Ace cards
 *values in terms of being 1 or 11
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsProjectBlackJack
{
    public class Player
    {
        public Player(string name) 
        {
            this.Name = name;
            this.Hand = new List<Card>();
        }

        public string Name { get; set; }

        public List<Card> Hand
        {
            get;
            set;
        }

        public virtual void AddCard(Card card) {
            this.Hand.Add(card);
        }

        public virtual bool CanHit {
            get
            {
                return true;
            }
        }

        public virtual int HandValue
        {
            get
            {
                var value = 0;
                var ace = 0;
                foreach (Card c in this.Hand)
                {
                    switch (c.Number)
                    {
                        case 1:
                            ace++;
                            break;
                        case 10:
                        case 11:
                        case 12:
                        case 13:
                            value += 10;
                            break;
                        default:
                            value += c.Number;
                            break;
                    }
                }
                if (ace > 0)
                {
                    if (ace > 1)
                    {
                        value = 1;
                    }
                    else
                    {
                        value += 11;
                    }
                }
                return value;
            }
        }

        public virtual void Hit(Card c)
        {
            if (this.CanHit)
            {
                AddCard(c);
                
            }
        }
    }
}
