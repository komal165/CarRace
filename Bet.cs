using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRace
{
    class Bet : Car
    {
        public int Amount { get; set; }
        public Bettor bettor { get; set; }
        public int car { get; set; }
        public int multiplier { get; set; }

        public string GetDescription()
        {
            if (Amount == 0)
                return bettor.Name + " hasn't placed a bet";
            else
                return bettor.Name + " has placed $" + Amount + " on car #" + car;
        }

        public int PayOut(int Winner)
        {
            if (Winner == car)
            {
                return Amount * 4;
            }
            else
            {
                return (0 - Amount);
            }
        }
    }
}
