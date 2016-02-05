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

    /*
        Homework for 1/21 :
        Finish up flavor text for each possible shoot.
        Add win counter to each player.

    */

    /*
        Have icons for each action. Rock/Paper/Scissors/Lizard/Spock
        Have the "Versus" screen at the top with what the player shoots.
        Put flavor text beneath versus for who wins.
        Have a counter for which one is winning in a session.
        PVP mode - insert names on both sides.
        PVE mode with computer tallying what the player chooses and then giving weighted RNG toward beating that.
    */
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

        List<Shoot> _playerShoots; //Records every shoot a player does.

        int _playerWins = 0;

        int _computerWins = 0;

        public MainWindow()
        {
            InitializeComponent();
            _playerShoots = new List<Shoot>(); //Adds every shoot recorded to a list.
            UpdateWinCounters();
        }

        private Shoot PredictPlayerShoot()
        {
            double rockShoot = 0;
            double paperShoot = 0;
            double scissorsShoot = 0;
            double lizardShoot = 0;
            double spockShoot = 0;

            foreach (Shoot ps in _playerShoots)
            {
                switch (ps)
                {
                    case Shoot.Rock:
                        rockShoot++;
                        break;

                    case Shoot.Paper:
                        paperShoot++;
                        break;

                    case Shoot.Scissors:
                        scissorsShoot++;
                        break;

                    case Shoot.Lizard:
                        lizardShoot++;
                        break;

                    case Shoot.Spock:
                        spockShoot++;
                        break;

                    default:
                        break;
                }
            }

            double rockPCT = rockShoot / _playerShoots.Count;

            double paperPCT = paperShoot / _playerShoots.Count;

            double scissorsPCT = scissorsShoot / _playerShoots.Count;

            double lizardPCT = lizardShoot / _playerShoots.Count;

            double spockPCT = spockShoot / _playerShoots.Count;

            Shoot projectedShoot;


            Random rng = new Random();

            double randomNumber = rng.NextDouble();

            if (randomNumber < rockPCT)
            {
                projectedShoot = Shoot.Rock;
            }

            else if (randomNumber < rockPCT + paperPCT)
            {
                projectedShoot = Shoot.Paper;
            }

            else if (randomNumber < rockPCT + paperPCT + scissorsPCT)
            {
                projectedShoot = Shoot.Scissors;
            }

            else if (randomNumber < rockPCT + paperPCT + scissorsPCT + lizardPCT)
            {
                projectedShoot = Shoot.Lizard;
            }

            else
            {
                projectedShoot = Shoot.Spock;
            }

            return projectedShoot;

        }

        private Shoot BeatThis(Shoot opposingPlay)
        {
            Random rng = new Random();

            int coinFlip = rng.Next(0, 2);

            switch (opposingPlay)
            {
                case Shoot.Rock:
                    if (coinFlip == 0)
                        return Shoot.Paper;
                    else
                        return Shoot.Spock;
                    break;

                case Shoot.Paper:
                    if (coinFlip == 0)
                        return Shoot.Scissors;
                    else
                        return Shoot.Lizard;
                    break;

                case Shoot.Scissors:
                    if (coinFlip == 0)
                        return Shoot.Rock;
                    else
                        return Shoot.Spock;
                    break;

                case Shoot.Lizard:
                    if (coinFlip == 0)
                        return Shoot.Rock;
                    else
                        return Shoot.Scissors;
                    break;

                case Shoot.Spock:
                    if (coinFlip == 0)
                        return Shoot.Paper;
                    else
                        return Shoot.Lizard;
                    break;

                default:
                    return 0;
                    break;
            }
        }


        private void GameButtonClick(object sender, EventArgs e)
        {
            int v = Convert.ToInt32((sender as Button).Tag); //Takes the tag, converting to a number.

            Shoot playerShoot = (Shoot)v;

            _playerShoots.Add(playerShoot);

            Shoot computerShoot;

            if (_playerShoots.Count < 5)
            {

                Random rng = new Random();

                int randomNumber = rng.Next(1, 6);

                computerShoot = (Shoot)randomNumber;
            }

            else
            {
                computerShoot = BeatThis(PredictPlayerShoot());
            }


            switch (computerShoot)
            {
                case Shoot.Paper:
                    Player2Shoot.BackgroundImage = RPSLS.ResourceRPSLS.Paper_64;
                    break;

                case Shoot.Rock:
                    Player2Shoot.BackgroundImage = RPSLS.ResourceRPSLS.Rock_64;
                    break;

                case Shoot.Scissors:
                    Player2Shoot.BackgroundImage = RPSLS.ResourceRPSLS.Scissors_64;
                    break;

                case Shoot.Lizard:
                    Player2Shoot.BackgroundImage = RPSLS.ResourceRPSLS.Lizard_64;
                    break;

                case Shoot.Spock:
                    Player2Shoot.BackgroundImage = RPSLS.ResourceRPSLS.Spock_64;
                    break;

                default:
                    break;
            }

            switch (playerShoot)
            {
                case Shoot.Paper:
                    Player1Shoot.BackgroundImage = RPSLS.ResourceRPSLS.Paper_64;
                    if (computerShoot == Shoot.Rock)
                    {
                        FlavorText.Text = "Computer shoots... Rock.\n Rock covers Paper.";
                        //MessageBox.Show("Computer shoots... ROCK.\n Rock covers Paper." );
                        PlayerWins();
                    }

                    else if (computerShoot == Shoot.Lizard)
                    {
                        FlavorText.Text = "Computer shoots... Lizard.\n Lizard eats Paper.";
                        //MessageBox.Show("Computer shoots... LIZARD.\n Lizard eats Paper.");
                        PlayerLoses();
                    }

                    else if (computerShoot == Shoot.Spock)
                    {
                        FlavorText.Text = "Computer shoots... Spock.\n Paper disproves Spock.";
                        //MessageBox.Show("Computer shoots... SPOCK.\n Paper disproves Spock.");
                        PlayerWins();
                    }

                    else if (computerShoot == Shoot.Scissors)
                    {
                        FlavorText.Text = "Computer shoots... Paper.\n Scissors cuts Paper.";
                        //MessageBox.Show("Computer shoots... SCISSORS.\n Scissors cuts Paper.");
                        PlayerLoses();
                    }

                    else if (computerShoot == Shoot.Paper)
                    {
                        FlavorText.Text = "Computer shoots... Paper.\n Paper gets stacked with Paper.";
                        //MessageBox.Show("Computer shoots... PAPER.\n Paper gets stapled with Paper.");
                        PlayerDraws();
                    }
                    break;

                case Shoot.Rock:
                    Player1Shoot.BackgroundImage = RPSLS.ResourceRPSLS.Rock_64;
                    if (computerShoot == Shoot.Rock)
                    {
                        FlavorText.Text = "Computer shoots... ROCK.\n Rock does nothing sitting next to another Rock.";
                        PlayerDraws();
                    }

                    else if (computerShoot == Shoot.Lizard)
                    {
                        FlavorText.Text = "Computer shoots... Lizard.\n Rock crushes Lizard.";
                        PlayerWins();
                    }

                    else if (computerShoot == Shoot.Spock)
                    {
                        FlavorText.Text = "Computer shoots... SPOCK.\n Spock vaporizes Rock.";
                        PlayerLoses();
                    }

                    else if (computerShoot == Shoot.Scissors)
                    {
                        FlavorText.Text = "Computer shoots... SCISSORS.\n Rock crushes Scissors.";
                        PlayerWins();
                    }

                    else if (computerShoot == Shoot.Paper)
                    {
                        FlavorText.Text = "Computer shoots... PAPER.\n Rock covers Paper.";
                        PlayerLoses();
                    }
                    break;

                case Shoot.Scissors:
                    Player1Shoot.BackgroundImage = RPSLS.ResourceRPSLS.Scissors_64;
                    if (computerShoot == Shoot.Rock)
                    {
                        FlavorText.Text = "Computer shoots... ROCK.\n Rock crushes Scissors.";
                        PlayerLoses();
                    }

                    else if (computerShoot == Shoot.Lizard)
                    {
                        FlavorText.Text = "Computer shoots... LIZARD.\n Scissors decapites Lizard.";
                        PlayerWins();
                    }

                    else if (computerShoot == Shoot.Spock)
                    {
                        FlavorText.Text = "Computer shoots... SPOCK.\n Spock smashes Scissors.";
                        PlayerLoses();
                    }

                    else if (computerShoot == Shoot.Scissors)
                    {
                        FlavorText.Text = "Computer shoots... SCISSORS.\n Scissors spends time scissoring the other Scissor.";
                        PlayerDraws();
                    }

                    else if (computerShoot == Shoot.Paper)
                    {
                        FlavorText.Text = "Computer shoots... PAPER.\n Scissors cut Paper.";
                        PlayerWins();
                    }
                    break;

                case Shoot.Lizard:
                    Player1Shoot.BackgroundImage = RPSLS.ResourceRPSLS.Lizard_64;
                    if (computerShoot == Shoot.Rock)
                    {
                        FlavorText.Text = "Computer shoots... ROCK.\n Rock crushes Lizard.";
                        PlayerLoses();
                    }

                    else if (computerShoot == Shoot.Lizard)
                    {
                        FlavorText.Text = "Computer shoots... LIZARD.\n Lizard procreates with Lizard to give birth to Godzilla.";
                        PlayerDraws();
                    }

                    else if (computerShoot == Shoot.Spock)
                    {
                        FlavorText.Text = "Computer shoots... SPOCK.\n Lizard poisons Spock.";
                        PlayerWins();
                    }

                    else if (computerShoot == Shoot.Scissors)
                    {
                        FlavorText.Text = "Computer shoots... SCISSORS.\n Scissors decapites Lizard.";
                        PlayerLoses();
                    }

                    else if (computerShoot == Shoot.Paper)
                    {
                        FlavorText.Text = "Computer shoots... PAPER.\n Lizard eats Paper.";
                        PlayerWins();
                    }
                    break;

                case Shoot.Spock:
                    Player1Shoot.BackgroundImage = RPSLS.ResourceRPSLS.Spock_64;
                    if (computerShoot == Shoot.Rock)
                    {
                        FlavorText.Text = "Computer shoots... ROCK.\n Spock vaporizes Rock.";
                        PlayerWins();
                    }

                    else if (computerShoot == Shoot.Lizard)
                    {
                        FlavorText.Text = "Computer shoots... LIZARD.\n Lizard poisons Spock.";
                        PlayerLoses();
                    }

                    else if (computerShoot == Shoot.Spock)
                    {
                        FlavorText.Text = "Computer shoots... SPOCK.\n Spock mindmelds with the other Spock to create an alternate timeline with 'Meh' movies.";
                        PlayerDraws();
                    }

                    else if (computerShoot == Shoot.Scissors)
                    {
                        FlavorText.Text = "Computer shoots... SCISSORS.\n Spock smashes Scissors.";
                        PlayerWins();
                    }

                    else if (computerShoot == Shoot.Paper)
                    {
                        FlavorText.Text = "Computer shoots... PAPER.\n Paper disproves Spock.";
                        PlayerLoses();
                    }
                    break;

                default:
                    break;
            }
        }

        private void UpdateWinCounters()
        {
            PlayerWinCounter.Text = "Wins: " + _playerWins.ToString();
            ComputerWinCounter.Text = "Wins: " + _computerWins.ToString();
        }
     
        private void PlayerWins()
        {
            Player1Shoot.BorderStyle = BorderStyle.FixedSingle;
            Player2Shoot.BorderStyle = BorderStyle.None;
            _playerWins++;
            UpdateWinCounters();
            //MessageBox.Show("You Win!");
        }

        private void PlayerLoses()
        {
            Player2Shoot.BorderStyle = BorderStyle.FixedSingle;
            Player1Shoot.BorderStyle = BorderStyle.None;
            _computerWins++;
            UpdateWinCounters();
            //MessageBox.Show("You Lose!");
        }

        private void PlayerDraws()
        {
            Player1Shoot.BorderStyle = BorderStyle.FixedSingle;
            Player2Shoot.BorderStyle = BorderStyle.FixedSingle;
            //MessageBox.Show("You Draw!");
        }
    }
}

