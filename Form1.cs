using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRace
{
    public partial class Form1 : Form
    {

        private Car[] Cars = new Car[5];
        private Bettor[] Bidders = new Bettor[3];
        private Random rand = new Random();
        public int CurrentGambler { get; set; }

        public Form1()
        {
            InitializeComponent();

            int StartRace = Car1.Left;
            int RaceTrackLength = trackLength.Width - Car1.Right;

            Cars[0] = new Car() { carImg = Car1, finishPosition = RaceTrackLength, startPosition = StartRace };
            Cars[1] = new Car() { carImg = Car2, finishPosition = RaceTrackLength, startPosition = StartRace };
            Cars[2] = new Car() { carImg = Car3, finishPosition = RaceTrackLength, startPosition = StartRace };
            Cars[3] = new Car() { carImg = Car4, finishPosition = RaceTrackLength, startPosition = StartRace };
            Cars[4] = new Car() { carImg = Car5, finishPosition = RaceTrackLength, startPosition = StartRace };

            Bidders[0] = new Bettor() { Cash = 45, PlayerActivityIndicator = label2, BettorSelector = radioButton1, Name = "Player 1" };
            Bidders[1] = new Bettor() { Cash = 75, PlayerActivityIndicator = label3, BettorSelector = radioButton2, Name = "Player 2" };
            Bidders[2] = new Bettor() { Cash = 55, PlayerActivityIndicator = label4, BettorSelector = radioButton3, Name = "Player 3" };

            // Sets the default values to the labels
            Bidders[0].UpdateLabels();
            Bidders[1].UpdateLabels();
            Bidders[2].UpdateLabels();
            Bidders[0].Reset();
            Bidders[1].Reset();
            Bidders[2].Reset();
        }

        private void PlaceBid_Click(object sender, EventArgs e)
        {
            Bidders[CurrentGambler].PlaceBid((int)BetAmount.Value, (int)BidOnCar.Value);
            Bidders[CurrentGambler].UpdateLabels();
        }

        private void StartRace_Click(object sender, EventArgs e)
        {
            timer1.Start();
            StartRace.Enabled = false;
        }

        private void DeclareWinner(int Winner)
        {
            MessageBox.Show("Car #" + Winner + " is the Winning Car");
            for (int i = 0; i < Bidders.Length; i++)
            {
                Bidders[i].CollectYouMoney(Winner);
                Bidders[i].UpdateLabels();
                ResetPositions();
                ResetBids();
            }
        }

        private void ResetPositions()
        {
            Cars[0].BackToStart();
            Cars[1].BackToStart();
            Cars[2].BackToStart();
            Cars[3].BackToStart();
            Cars[4].BackToStart();
        }

        private void ResetBids()
        {
            label2.Text = "Player 1 hasn't placed a bet.";
            label2.Text = "Player 2 hasn't placed a bet.";
            label2.Text = "Player 3 hasn't placed a bet.";
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            for(int i = 0; i < Cars.Length; i++)
            {
                Cars[rand.Next(0, 5)].AccelerateCar();
                if (Cars[i].AccelerateCar())
                {
                    timer1.Stop();
                    timer1.Enabled = false;
                    StartRace.Enabled = true;
                    DeclareWinner(i + 1);
                }
            }
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            CurrentGambler = 0;
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            CurrentGambler = 1;
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            CurrentGambler = 2;
        }
    }
}
