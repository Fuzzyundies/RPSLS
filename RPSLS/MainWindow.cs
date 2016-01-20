using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPSLS
{

    public enum Shoot
    {
        Rock = 1, //Automatically incremetes by 1.
        Paper,
        Scissors,
        Lizard,
        Spock
    };

    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GameButtonClick(object sender, EventArgs e)
        {
            // int v = (int)(sender as Button).Tag;

            int v = Convert.ToInt32((sender as Button).Tag); //Takes the tag, converting to a number.

            Shoot playerShoot = (Shoot)v;

            Random rng = new Random();

            int randomNumber = rng.Next(1, 6);

            Shoot computerShoot = (Shoot)randomNumber;

            // MessageBox.Show(playerShoot.ToString());

            switch(playerShoot)
            {
                case Shoot.Paper:

                    if (computerShoot == Shoot.Rock)
                    {
                        PlayerWins();
                    }

                    else if (computerShoot == Shoot.Lizard)
                    {
                        PlayerLoses();
                    }

                    else if (computerShoot == Shoot.Spock)
                    {
                        PlayerWins();
                    }

                    else if (computerShoot == Shoot.Scissors)
                    {
                        PlayerLoses();
                    }

                    else if (computerShoot == Shoot.Paper)
                    {
                        PlayerDraws();
                    }
                    break;

                default:
                    break;
            }
        }

        private void PlayerWins()
        {
            MessageBox.Show("You Win!");
        }

        private void PlayerLoses()
        {
            MessageBox.Show("You Lose!");
        }

        private void PlayerDraws()
        {
            MessageBox.Show("You Draw!");
        }
    }
}
