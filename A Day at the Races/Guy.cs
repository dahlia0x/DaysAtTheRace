using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_Day_at_the_Races
{
    public class Guy
    {
        public string Name;
        public Bet MyBet;
        public int Cash;
        public RadioButton MyRadioButton;
        public Label MyLabel;

        public Guy()
        {
            MyBet = new Bet();
            UpdateLabels();
        }

        public void UpdateLabels()
        {
            MyLabel.Text = MyBet.Amount.ToString();
            MyRadioButton.Text = Name + " has " + Cash + " bucks";
        }

        public void ClearBet()
        {
            MyBet = null;
        }

        public bool PlaceBet(int BetAmount, int DogToWin)
        {
            if (BetAmount >= Cash)
            {
                MyBet.Amount = BetAmount;
                MyBet.Dog = DogToWin;
                MyBet.Better = this;
                UpdateLabels();
                return true;
            }
            else
                return false;
        }

        public void Collect(int Winner)
        {
            MyBet = null;
            UpdateLabels();
        }

    }
}
