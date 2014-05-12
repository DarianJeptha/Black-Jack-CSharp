/*File name: BlackJackWindow.cs
 *Author: Darian Jeptha
 *Created: 05/09/2013
 *
 *This Class is the pop on how to play the game.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsProjectBlackJack
{
    public partial class InstructionPopup : Form
    {
        public InstructionPopup()
        {
            InitializeComponent();
        }

        private void InstructionPopup_Load(object sender, EventArgs e)
        {
            Ruleslbl.Text = "BLACK JACK RULES";
            Rule1lbl.Text = "No player should have more that 21.";
            Rule2lbl.Text = "If you are dealt 21 you hit BlackJack.";
            Rule3lbl.Text = "If you and the Dealer folds you lose automatically.";
            Rule4lbl.Text = "If you have a high value than the dealer you win.";
            Rule5lbl.Text = "Gaining an Ace from calling a hit and your hand value is 11 or above that ace gains a value of one";
            Rule6lbl.Text = "This is a Player orientated game meaning when a player calls anything those events will occur.";
        }
    }
}
