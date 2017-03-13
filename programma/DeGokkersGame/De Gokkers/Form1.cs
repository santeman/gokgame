using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace De_Gokkers
{
    public partial class reset : Form
    {
        guy[] bettors;

        bool won = false;
        int winner;

        public reset()
        {
            InitializeComponent();


            pictureBox2.Size = new Size(20, 93);
            pictureBox6.Size = new Size(660, 93);

            coyote.Size = new Size(100, 70);
            coyote.Location = new Point(60, 80);

            roadrunner.Size = new Size(100, 70);
            roadrunner.Location = new Point(60, 173);

            finish.Size = new Size(105, 207);
            finish.Location = new Point(719, 56);

            

            nameTag1.Size = new Size(60, 25);
            nameTag2.Size = new Size(60, 25);
            nameTag3.Size = new Size(60, 25);
            



            bettors = new guy[3];

            bettors[0] = new guy();
            bettors[0].Name = "Sietse";
            bettors[0].Cash = 50;         
            bettors[0].MyLabel = SietseMoneyCounter;
            bettors[0].MyLabelMoney = MoneySietse;
            bettors[0].UpdateLabels();
            bettors[0].ClearBet();
            

            
            

            bettors[1] = new guy();
            bettors[1].Name = "Lidy";
            bettors[1].Cash = 75;         
            bettors[1].MyLabel = LidyMoneyCounter;
            bettors[1].MyLabelMoney = MoneyLidy;
            bettors[0].ClearBet();
            bettors[1].UpdateLabels();

            bettors[2] = new guy();
            bettors[2].Name = "Fer";
            bettors[2].Cash = 45;         
            bettors[2].MyLabel = FerMoneyCounter;
            bettors[2].MyLabelMoney = MoneyFer;
            bettors[2].UpdateLabels();
            bettors[2].ClearBet();


            animals[] racers = new animals[2];

            racers[0] = new animals();
            racers[0].MyPictureBox = coyote;
            racers[0].coyoteName = "Coyote";
            
            
            //racers[1] = new animals();
            //racers[1].MyPictureBox = roadrunner;
            //racers[1].roadrunnerName = "Roadrunner";





            //Random xAs = new Random();
            //int randomNumber = xAs.Next(100, 150);

            //animals[] animal = new animals[1];





           

        }











        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public void tb_coyote(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {

        }

        private void start_Click(object sender, EventArgs e)
        {
            won = false;

            do
            {


                Random xcoyote = new Random();
                int randomNumber1 = xcoyote.Next(2, 7);
                Thread.Sleep(15);
                Random xroadrunner = new Random();
                int randomNumber2 = xroadrunner.Next(2, 7);
                Thread.Sleep(15);


                Point p = coyote.Location;


                if (coyote.Location.X < finish.Location.X)
                {
                    p.X += randomNumber1;
                }

                coyote.Location = p;

                Point p2 = roadrunner.Location;


                if (roadrunner.Location.X < finish.Location.X)
                {
                    p2.X += randomNumber2;
                }
                roadrunner.Location = p2;

                if(coyote.Location.X >= finish.Location.X)
                {
                    won = true;
                    MessageBox.Show("Coyote Won!");
                    winner = 1;
                }
                
                if (roadrunner.Location.X >= finish.Location.X)
                {
                    won = true;
                    MessageBox.Show("RoadRunner Won!");
                    winner = 2;
                }






                Application.DoEvents();

            } while (won == false);

            bettors[0].Collect(winner);
            bettors[1].Collect(winner);
            bettors[2].Collect(winner);

            SietseMoneyCounter.Text = Name + " hasnt placed any bets";
            LidyMoneyCounter.Text = Name + " hasnt placed any bets";
            FerMoneyCounter.Text = Name + " hasnt placed any bets";

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            coyote.Location = new Point(60, 80);
            roadrunner.Location = new Point(60, 173);

            SietseMoneyCounter.Text = Name + " hasnt placed any bets";
            LidyMoneyCounter.Text = Name + " hasnt placed any bets";
            FerMoneyCounter.Text = Name + " hasnt placed any bets";
        }

        private void coyote_Click(object sender, EventArgs e)
        {

        }

        

        private void button1_Click(object sender, EventArgs e)
        {

            int animal = (int)numericUpDown5.Value;
            int amount = (int)BetSietse.Value;
            bettors[0].PlaceBet(amount, animal);

            int cash = (int)numericUpDown5.Value;
            

        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void SietseMoneyCounter_Click(object sender, EventArgs e)
        {
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int animal = (int)numericUpDown3.Value;
            int amount = (int)BetLidy.Value;
            bettors[1].PlaceBet(amount, animal);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int animal = (int)numericUpDown1.Value;
            int amount = (int)BetFer.Value;
            bettors[2].PlaceBet(amount, animal);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            
        }
    }
    
}
