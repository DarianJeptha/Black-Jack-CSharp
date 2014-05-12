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
    public class Dealer: Player
    {
        public Dealer(string name): base(name) {
            
        }

        public override bool CanHit
        {
            get
            {
                if (this.HandValue >= 17)
                {
                    return false;
                }
                return base.CanHit;
            }
        }

        public override void AddCard(Card card)
        {
            base.AddCard(card);
        }

        public override void Hit(Card c)
        {
            if (this.CanHit) {
                AddCard(c);
            }
        }
    }
}
