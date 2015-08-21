using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_Day_at_the_Races
{
    public partial class Form1 : Form
    {

        Greyhound[] dogs = new Greyhound[4];
        Guy[] guys = new Guy[3];
        Random MyRandomizer = new Random();


        public Form1()
        {
            InitializeComponent();

            dogs[0] = new Greyhound()
            {
                MyPictureBox = greyHound1,
                StartingPosition = greyHound1.Left,
                RacetrackLength = raceTrack.Width - greyHound1.Width,
                Randomizer = MyRandomizer
            };

            dogs[1] = new Greyhound()
            {
                MyPictureBox = greyHound2,
                StartingPosition = greyHound2.Left,
                RacetrackLength = raceTrack.Width - greyHound2.Width,
                Randomizer = MyRandomizer
            };

            dogs[2] = new Greyhound()
            {
                MyPictureBox = greyHound3,
                StartingPosition = greyHound3.Left,
                RacetrackLength = raceTrack.Width - greyHound3.Width,
                Randomizer = MyRandomizer
            };

            dogs[3] = new Greyhound()
            {
                MyPictureBox = greyHound4,
                StartingPosition = greyHound4.Left,
                RacetrackLength = raceTrack.Width - greyHound4.Width,
                Randomizer = MyRandomizer
            };

            guys[0] = new Guy()
            {
                MyLabel = joeBetLabel,
                Name = "Joe",
                Cash = 50,
                MyBet = new Bet(),
                MyRadioButton = joeRadioButton
            };

            guys[1] = new Guy()
            {
                MyLabel = bobBetLabel,
                Name = "Bob",
                Cash = 75,
                MyBet = new Bet(),
                MyRadioButton = bobRadioButton
            };

            guys[2] = new Guy()
            {
                MyLabel = alBetLabel,
                Name = "Al",
                Cash = 45,
                MyBet = new Bet(),
                MyRadioButton = alRadioButton
            };
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < dogs.Length; i++)
            {
                if (dogs[i].Run())
                {
                    timer1.Stop();
                    MessageBox.Show("Dog " + i.ToString() + " Win!");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

    }
}
