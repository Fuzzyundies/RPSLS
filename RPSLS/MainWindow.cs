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
                        MessageBox.Show("Computer shoots... ROCK.\n Rock covers Paper." );
                        PlayerWins();
                    }

                    else if (computerShoot == Shoot.Lizard)
                    {
                        MessageBox.Show("Computer shoots... LIZARD.\n Lizard eats Paper.");
                        PlayerLoses();
                    }

                    else if (computerShoot == Shoot.Spock)
                    {
                        MessageBox.Show("Computer shoots... SPOCK.\n Paper disproves Spock.");
                        PlayerWins();
                    }

                    else if (computerShoot == Shoot.Scissors)
                    {
                        MessageBox.Show("Computer shoots... SCISSORS.\n Scissors cuts Paper.");
                        PlayerLoses();
                    }

                    else if (computerShoot == Shoot.Paper)
                    {
                        MessageBox.Show("Computer shoots... PAPER.\n Paper gets stapled with Paper.");
                        PlayerDraws();
                    }
                    break;

                case Shoot.Rock:

                    if (computerShoot == Shoot.Rock)
                    {
                        MessageBox.Show("Computer shoots... ROCK.\n Rock does nothing sitting next to another Rock.");
                        PlayerDraws();
                    }

                    else if (computerShoot == Shoot.Lizard)
                    {
                        MessageBox.Show("Computer shoots... LIZARD.\n Rock crushes Lizard.");
                        PlayerWins();
                    }

                    else if (computerShoot == Shoot.Spock)
                    {
                        MessageBox.Show("Computer shoots... SPOCK.\n Spock vaporizes Rock.");
                        PlayerLoses();
                    }

                    else if (computerShoot == Shoot.Scissors)
                    {
                        MessageBox.Show("Computer shoots... SCISSORS.\n Rock crushes Scissors.");
                        PlayerWins();
                    }

                    else if (computerShoot == Shoot.Paper)
                    {
                        MessageBox.Show("Computer shoots... PAPER.\n Rock covers Paper.");
                        PlayerLoses();
                    }
                    break;

                case Shoot.Scissors:

                    if (computerShoot == Shoot.Rock)
                    {
                        MessageBox.Show("Computer shoots... ROCK.\n Rock crushes Scissors.");
                        PlayerLoses();
                    }

                    else if (computerShoot == Shoot.Lizard)
                    {
                        MessageBox.Show("Computer shoots... LIZARD.\n Scissors decapites Lizard.");
                        PlayerWins();
                    }

                    else if (computerShoot == Shoot.Spock)
                    {
                        MessageBox.Show("Computer shoots... SPOCK.\n Spock smashes Scissors.");
                        PlayerLoses();
                    }

                    else if (computerShoot == Shoot.Scissors)
                    {
                        MessageBox.Show("Computer shoots... SCISSORS.\n Scissors spends time scissoring the other Scissor.");
                        PlayerDraws();
                    }

                    else if (computerShoot == Shoot.Paper)
                    {
                        MessageBox.Show("Computer shoots... PAPER.\n Scissors cut Paper.");
                        PlayerWins();
                    }
                    break;

                case Shoot.Lizard:

                    if (computerShoot == Shoot.Rock)
                    {
                        MessageBox.Show("Computer shoots... ROCK.\n Rock crushes Lizard.");
                        PlayerLoses();
                    }

                    else if (computerShoot == Shoot.Lizard)
                    {
                        MessageBox.Show("Computer shoots... LIZARD.\n Lizard procreats with Lizard to form Godzilla.");
                        PlayerDraws();
                    }

                    else if (computerShoot == Shoot.Spock)
                    {
                        MessageBox.Show("Computer shoots... SPOCK.\n Lizard poisons Spock.");
                        PlayerWins();
                    }

                    else if (computerShoot == Shoot.Scissors)
                    {
                        MessageBox.Show("Computer shoots... SCISSORS.\n Scissors decapites Lizard.");
                        PlayerLoses();
                    }

                    else if (computerShoot == Shoot.Paper)
                    {
                        MessageBox.Show("Computer shoots... PAPER.\n Lizard eats Paper.");
                        PlayerWins();
                    }
                    break;

                case Shoot.Spock:

                    if (computerShoot == Shoot.Rock)
                    {
                        MessageBox.Show("Computer shoots... ROCK.\n Spock vaporizes Rock.");
                        PlayerWins();
                    }

                    else if (computerShoot == Shoot.Lizard)
                    {
                        MessageBox.Show("Computer shoots... LIZARD.\n Lizard poisons Spock.");
                        PlayerLoses();
                    }

                    else if (computerShoot == Shoot.Spock)
                    {
                        MessageBox.Show("Computer shoots... SPOCK.\n Spock mindmelds with the other Spock to create an alternate timeline with OK movies.");
                        PlayerDraws();
                    }

                    else if (computerShoot == Shoot.Scissors)
                    {
                        MessageBox.Show("Computer shoots... SCISSORS.\n Spock smashes Scissors.");
                        PlayerWins();
                    }

                    else if (computerShoot == Shoot.Paper)
                    {
                        MessageBox.Show("Computer shoots... PAPER.\n Paper disproves Spock.");
                        PlayerLoses();
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
