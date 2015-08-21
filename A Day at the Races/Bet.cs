using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Day_at_the_Races
{
    public class Bet
    {
        public int Amount = 0;
        public int Dog;
        public Guy Better;

        public string GetDescription()
        {
            if (Amount != 0)
            {
                return Better.Name + " bets " + Amount.ToString() + " on dog #" + Dog.ToString();
            }
            else
            {
                return Better.Name + " hasn't placed a bet";

            }
        }

        public int PayOut(int Winner)
        {
            if (Winner == Dog)
            {
                return Amount;
            }
            else
            {
                return -Amount;
            }
        }
    }
}
