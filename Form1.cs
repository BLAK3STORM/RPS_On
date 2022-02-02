using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPS_On_
{
    public partial class Form1 : Form
    {

        // Globals
        int rounds = 3;
        int timerPerRound = 6;
        bool gameOver = false;

        string[] botChoiceList = { "rock", "paper", "scissors", "paper", "scissors", "rock", "scissors",
                                   "paper", "rock", "rock", "scissors", "paper", "paper", "rock",
                                   "scissors", "scissors", "paper", "rock" };

        Random random = new Random();
        int randomNumber;

        String playerChoice;
        String botChoice;
        int playerScore;
        int botScore;

        public Form1()
        {
            InitializeComponent();

            // Initially Disabled
            btnScissors.Enabled = false;
            btnRock.Enabled = false;
            btnPaper.Enabled = false;
            btnRestart.Enabled = false;
        }

        // Player Side Configuration for Rock
        private void btnRock_Click(object sender, EventArgs e)
        {
            picPlayer.Image = Properties.Resources.realrock;
            playerChoice = "rock";
        }

        // Player Side Configuration for Paper
        private void btnPaper_Click(object sender, EventArgs e)
        {
            picPlayer.Image = Properties.Resources.paper;
            playerChoice = "paper";
        }

        // Player Side Configuration for Scissors
        private void btnScissors_Click(object sender, EventArgs e)
        {
            picPlayer.Image = Properties.Resources.scissors;
            playerChoice = "scissors";
        }

        // Restart button config (Resets Everything)
        private void btnRestart_Click(object sender, EventArgs e)
        {
            countDownTimer.Stop();
            playerScore = 0;
            botScore = 0;
            rounds = 3;

            scoreLabel.Text = "Player: " + playerScore + " BOT: " + botScore;
            playerChoice = "none";
            countdown.Text = "5";
            timerPerRound = 5;
            countDownTimer.Enabled = true;

            btnScissors.Enabled = true;
            btnRock.Enabled = true;
            btnPaper.Enabled = true;

            picPlayer.Image = Properties.Resources.questionmark;
            picBot.Image = Properties.Resources.questionmark;

            gameOver = false;
        }

        // Will attempt to fire the following events in every 1 second
        private void countDownTimerEvent(object sender, EventArgs e)
        {
            // Keeping the working rounds from 1 to 3
            if (rounds == 0)
            {
                endGame();
                return;
            }
            timerPerRound -= 1; // Decreases the countdown time
            countdown.Text = timerPerRound.ToString();

            // When countdown from 5 to 0 is done, DO:
            if(timerPerRound < 1)
            {
                countDownTimer.Enabled = false; // Disables the timer event
                timerPerRound = 6; // Resets the countdown
                
                // Bot makes a choice
                randomNumber = random.Next(0, botChoiceList.Length);
                botChoice = botChoiceList[randomNumber];

                // Bot choice config
                switch (botChoice)
                {
                    case "rock":
                        picBot.Image = Properties.Resources.realrock;
                        break;
                    case "paper":
                        picBot.Image = Properties.Resources.paper;
                        break;
                    case "scissors":
                        picBot.Image = Properties.Resources.scissors;
                        break;
                }

                // Logic process after each round until the game is over
                if (rounds >= 1)
                {
                    checkGame();
                }
                // End game result
                else
                {
                    if (playerScore > botScore)
                    {
                        MessageBox.Show("You have won the GAME!", "Congratulation");
                    }
                    else if (playerScore < botScore)
                    {
                        MessageBox.Show("The BOT has won the GAME!", "SHAME");
                    }
                    else
                    {
                        MessageBox.Show("The game is a DRAW!", "Info");
                    }
                }

            }

        }

        // Logic Process Function
        // After each round either the bot or the player gets a point & the round count decreases
        private void checkGame()
        {
            if(playerChoice == "rock" && botChoice == "paper")
            {
                botScore += 1;
                rounds -= 1;
                roundLabel.Text = "Rounds Left: " + rounds;
                MessageBox.Show("BOT wins, Paper covers Rock!", "LAME");
                startNextRound();

            }
            else if (playerChoice == "paper" && botChoice == "scissors")
            {
                botScore += 1;
                rounds -= 1;
                roundLabel.Text = "Rounds Left: " + rounds;
                MessageBox.Show("BOT wins, Scissors cut Paper!", "LAME");
                startNextRound();

            }
            else if (playerChoice == "scissors" && botChoice == "rock")
            {
                botScore += 1;
                rounds -= 1;
                roundLabel.Text = "Rounds Left: " + rounds;
                MessageBox.Show("BOT wins, Rock breaks Scissors!", "LAME");
                startNextRound();

            }
            else if (playerChoice == "scissors" && botChoice == "paper")
            {
                playerScore += 1;
                rounds -= 1;
                roundLabel.Text = "Rounds Left: " + rounds;
                MessageBox.Show("You win, Scissors cut Paper!", "COOL");
                startNextRound();

            }
            else if (playerChoice == "paper" && botChoice == "rock")
            {
                playerScore += 1;
                rounds -= 1;
                roundLabel.Text = "Rounds Left: " + rounds;
                MessageBox.Show("You win, Paper covers Rock!", "COOL");
                startNextRound();

            }
            else if (playerChoice == "rock" && botChoice == "scissors")
            {
                playerScore += 1;
                rounds -= 1;
                roundLabel.Text = "Rounds Left: " + rounds;
                MessageBox.Show("You win, Rock breaks Scissors!", "COOL");
                startNextRound();

            }
            // These will cost no round & reward no point
            else if(playerChoice == "none")
            {
                MessageBox.Show("Make a Choice!", "Pick Something");
                startNextRound();

            }
            else
            {
                MessageBox.Show("It is a DRAW!!!", "Both are Worthy");
                startNextRound();

            }
        }
        // This function is called after each round till the game is over
        private void startNextRound()
        {
            if (gameOver == true)
            {
                return;
            }

            scoreLabel.Text = "Player: " + playerScore + " BOT: " + botScore; // Updates the scoreboard
            playerChoice = "none"; // Resets the player choice
            countDownTimer.Enabled = true; // Restarts the timer event

            // Resets the picture boxes
            picPlayer.Image = Properties.Resources.questionmark;
            picBot.Image = Properties.Resources.questionmark;
        }

        // Start Button Configuration
        private void btnStart_Click(object sender, EventArgs e)
        {
            countDownTimer.Enabled = true;
            playerChoice = "none";
            countdown.Text = "5";

            btnRestart.Enabled = true;
            btnPaper.Enabled = true;
            btnRock.Enabled = true;
            btnScissors.Enabled = true;
            btnStart.Enabled = false;
        }

        // Conclusion & Result
        private void endGame()
        {
            countDownTimer.Enabled = false; // Stops the timer event

            // Disables the buttons
            btnPaper.Enabled = false;
            btnRock.Enabled = false;
            btnScissors.Enabled = false;

            // Winning or Losing Message
            if (playerScore > botScore)
            {
                MessageBox.Show("You have won the GAME!", "Congratulation");
            }
            else if (playerScore < botScore)
            {
                MessageBox.Show("The BOT has won the GAME!", "SHAME");
            }
            else
            {
                MessageBox.Show("The game is a DRAW!", "Info");
            }

            MessageBox.Show("Click 'Restart' to immediately start a new game", "Info");
        }

    }
}
