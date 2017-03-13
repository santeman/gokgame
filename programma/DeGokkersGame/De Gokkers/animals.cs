using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Drawing;
using System.Windows.Forms;

namespace De_Gokkers
{
    

    public class animals
    {
        public int RaceTrackLength;  // De lengte van de renbaan
        public PictureBox MyPictureBox = null;  // Mijn PictureBox object
        public Random Randomizer;   // Een instantie van Random (= Willekeurig)
        public int StartingPosition; // Waar mijn PictureBox start
        public int Location; //  Locatie van coyote op de renbaan
        public int theLocation; // locatie van roadrunner op de renbaan
        public string coyoteName;
        public string roadrunnerName;
        

        

        public bool Run() 
        {
            //1. Ga willekeurig 1,2 posities naar voren
            int moveforward = Randomizer.Next(1, 2);

            //2. Werk de positie van PictureBox bij op het formulier
            Point p = MyPictureBox.Location;
            p.X += moveforward;
            MyPictureBox.Location = p;

            //3. Geef de waarde 'true' terug als ik de race win
            if (p.X >= RaceTrackLength)
                return true;
            else
                return false;
        }

        public void TakeStartingPosition()
        {
            // Wijzig mijn locatie naar de startlijn

            StartingPosition = 0;
        }


    }
}
