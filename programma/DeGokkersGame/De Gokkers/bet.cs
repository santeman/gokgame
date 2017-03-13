using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace De_Gokkers
{
    public class bet
    {
        public int Amount;   // Het bedrag van de weddenschap
        public int animal;   // Het nummer van de dier waarop weddenschap is afgesloten
        public guy Bettor;  // De gokker die gewed heeft

        public string GetDescription()
        {
            if (Amount > 0)

                return Bettor.Name + " bets " + Amount + " euro on #" + animal;

            else
                return Bettor.Name + " hasnt placed a bet";
        }

        
        public int PayOut(int Winner)
        {
            if (Winner == animal)
                return Amount * 2;
            else
                return -1 * Amount;
        }



    }
}
