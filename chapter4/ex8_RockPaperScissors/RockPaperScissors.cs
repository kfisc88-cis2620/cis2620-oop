using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex8_RockPaperScissors
{
    public partial class RockPaperScissors : Form
    {
        public RockPaperScissors()
        {
            InitializeComponent();
        }

        enum GameChoice
        {
            ROCK = 1, PAPER, SCISSORS
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            Random ranNumberGenerator = new Random();
            int randomNumber;
            randomNumber = ranNumberGenerator.Next(1, 4);

            string userInput = choiceTextBox.Text;
            int userChoice = 0;

            switch(userInput)
            {
                case "r":
                    userChoice = 1;
                    break;
                case "p":
                    userChoice = 2;
                    break;
                case "s":
                    userChoice = 3;
                    break;
                default:
                    outputLabel.Text = "Invalid choice.";
                    break;
            }


            switch((GameChoice)userChoice)
            {
                case GameChoice.ROCK:
                    switch((GameChoice)randomNumber)
                    {
                        case GameChoice.PAPER:
                            outputLabel.Text = $"You chose {(GameChoice)userChoice} and I chose {(GameChoice)randomNumber}. I WIN!";
                            break;
                        case GameChoice.SCISSORS:
                            outputLabel.Text = $"You chose {(GameChoice)userChoice} and I chose {(GameChoice)randomNumber}. YOU WIN!";
                            break;
                        default:
                            outputLabel.Text = $"You chose {(GameChoice)userChoice} and I chose {(GameChoice)randomNumber}. TIE GAME!";
                            break;
                    }
                    break;  
                case GameChoice.PAPER:
                    switch((GameChoice)randomNumber)
                    {
                        case GameChoice.SCISSORS:
                            outputLabel.Text = $"You chose {(GameChoice)userChoice} and I chose {(GameChoice)randomNumber}. I WIN!";
                            break;
                        case GameChoice.ROCK:
                            outputLabel.Text = $"You chose {(GameChoice)userChoice} and I chose {(GameChoice)randomNumber}. YOU WIN!";
                            break;
                        default:
                            outputLabel.Text = $"You chose {(GameChoice)userChoice} and I chose {(GameChoice)randomNumber}. TIE GAME!";
                            break;
                    }
                    break;  
                case GameChoice.SCISSORS:
                    switch((GameChoice)randomNumber)
                    {
                        case GameChoice.ROCK:
                            outputLabel.Text = $"You chose {(GameChoice)userChoice} and I chose {(GameChoice)randomNumber}. I WIN!";
                            break;
                        case GameChoice.PAPER:
                            outputLabel.Text = $"You chose {(GameChoice)userChoice} and I chose {(GameChoice)randomNumber}. YOU WIN!";
                            break;
                        default:
                            outputLabel.Text = $"You chose {(GameChoice)userChoice} and I chose {(GameChoice)randomNumber}. TIE GAME!";
                            break;
                    }
                    break;
                default:
                    outputLabel.Text = "Invalid Choice";
                    break;                   
            }
        }
    }
}
