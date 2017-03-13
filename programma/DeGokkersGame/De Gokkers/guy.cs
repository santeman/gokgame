using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace De_Gokkers
{
    public class guy
    {
        public string Name;   // De naam van de gokker
        public bet MyBet;    // Een instantie van Bet()
        public int Cash;    // Het saldo van de gokker
        // Deze twee velden zijn de gokkers GUI controls op het formulier
        public RadioButton MyRadiobutton;
        public Label MyLabel;
        public Label MyLabelMoney;
        public NumericUpDown MyUpDown;
        

        public void UpdateLabels()
        {
            MyLabelMoney.Text = "you have " + Cash.ToString() + " money";
            //1. Verander mijn label in de omschrijving van mijn weddenschap
            if (MyBet == null)
            {  
                MyLabel.Text = Name + " hasnt placed any bets";
            }
            else
            { 
                
                MyLabel.Text = MyBet.GetDescription();
            }
            //2. Verander de label op mijn radioknop zodat deze mijn saldo laat zien (bijv. "Lidy heeft 43 euro")
            //MyRadiobutton.Text = Name + " has" + Cash + " euro";
        }

        

        

        public void ClearBet()
        {
            MyBet = null;
        }

        
        public bool PlaceBet(int Amount, int animal)
        {
            this.MyBet = new bet();

            if (Cash >= Amount)
            {
                Cash -= Amount;
                MyBet.Amount = Amount;
                MyBet.animal = animal;
                MyBet.Bettor = this;
               
                UpdateLabels();
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Collect(int winner)
        {
            if (MyBet != null && MyBet.animal == winner)
            {
                this.Cash += 2 * MyBet.Amount;
                UpdateLabels();
            }
        }
    }
}
