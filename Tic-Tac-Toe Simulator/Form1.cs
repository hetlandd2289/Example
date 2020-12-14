/* Author: Drake Hetland
 * Date: 11-9-2020
 * Description: Assignment using a 2D array to make a game of tic-tac-toe work(somewhat)*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe_Simulator
{
    public partial class ticTacToeGame : Form
    {
        //Crreates and sets the constants for the size of the 2D array.
        const int ROWS = 3;
        const int COLS = 3;

        //Creates array
        int[,] ticArray = new int[ROWS, COLS];

        bool xTurn = true;

        public ticTacToeGame()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Exit Button
            this.Close();
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            //images(); Method no longer being used
            array(); //Ended up being unnecessary to make a sepatate method, but left it in cause there wasn't a need to change it
            //wins(); Method no longer being used
            fillSpaces();
            checkVictory();
            resultTextBox.Visible = true;
            kilroy.Visible = true;
        }

        //First itteration. Wasn't sure what exactly I was doing.
        //Built this around not even using an array, but couldn't keep it cause I needed to use one.
        /*private void wins()
        {
            if (box1 == 1 && box2 == 1 && box3 == 1)
            {
                resultTextBox.Text = "Player X Wins";
            }
            else if (box1 == 0 && box2 == 0 && box3 == 0)
            {
                resultTextBox.Text = "Player O Wins";
            }
            else if (box1 == 1 && box4 == 1 && box7 == 1)
            {
                resultTextBox.Text = "Player X Wins";
            }
            else if (box1 == 0 && box4 == 0 && box7 == 0)
            {
                resultTextBox.Text = "Player O Wins";
            }
            else if (box1 == 1 && box5 == 1 && box9 == 1)
            {
                resultTextBox.Text = "Player X Wins";
            }
            else if (box1 == 0 && box5 == 0 && box9 == 0)
            {
                resultTextBox.Text = "Player O Wins";
            }
            else if (box2 == 1 && box5 == 1 && box8 == 1)
            {
                resultTextBox.Text = "Player X Wins";
            }
            else if (box2 == 0 && box5 == 0 && box8 == 0)
            {
                resultTextBox.Text = "Player O Wins";
            }
            else if (box3 == 1 && box6 == 1 && box9 == 1)
            {
                resultTextBox.Text = "Player X Wins";
            }
            else if (box3 == 0 && box6 == 0 && box9 == 0)
            {
                resultTextBox.Text = "Player O Wins";
            }
            else if (box3 == 1 && box5 == 1 && box7 == 1)
            {
                resultTextBox.Text = "Player X Wins";
            }
            else if (box3 == 0 && box5 == 0 && box7 == 0)
            {
                resultTextBox.Text = "Player O Wins";
            }
            else if (box4 == 1 && box5 == 1 && box6 == 1)
            {
                resultTextBox.Text = "Player X Wins";
            }
            else if (box4 == 0 && box5 == 0 && box6 == 0)
            {
                resultTextBox.Text = "Player O Wins";
            }
            else if (box7 == 1 && box8 == 1 && box9 == 1)
            {
                resultTextBox.Text = "Player X Wins";
            }
            else if (box7 == 0 && box8 == 0 && box9 == 0)
            {
                resultTextBox.Text = "Player O Wins";
            }
            else
            {
                resultTextBox.Text = "Draw";
            }
        }*/

        //Applied images without using an array. Usewd global variables, but deleted those.
        /*private void images()
        {
            box1 = rand.Next(0, 2);
            box2 = rand.Next(0, 2);
            box3 = rand.Next(0, 2);
            box4 = rand.Next(0, 2);
            box5 = rand.Next(0, 2);
            box6 = rand.Next(0, 2);
            box7 = rand.Next(0, 2);
            box8 = rand.Next(0, 2);
            box9 = rand.Next(0, 2);

            ticTacToe1.Image = x_O.Images[box1];
            ticTacToe2.Image = x_O.Images[box2];
            ticTacToe3.Image = x_O.Images[box3];
            ticTacToe4.Image = x_O.Images[box4];
            ticTacToe5.Image = x_O.Images[box5];
            ticTacToe6.Image = x_O.Images[box6];
            ticTacToe7.Image = x_O.Images[box7];
            ticTacToe8.Image = x_O.Images[box8];
            ticTacToe9.Image = x_O.Images[box9];
        }*/

        private void array()
        {
            //Built this around using a 1D array. Couldn't keep it cause it needed to be 2D
            /*const int SIZE = 9;
            int[] ticArray = new int[SIZE];
            ticArray[0] = rand.Next(0, 2);
            ticArray[1] = rand.Next(0, 2);
            ticArray[2] = rand.Next(0, 2);
            ticArray[3] = rand.Next(0, 2);
            ticArray[4] = rand.Next(0, 2);
            ticArray[5] = rand.Next(0, 2);
            ticArray[6] = rand.Next(0, 2);
            ticArray[7] = rand.Next(0, 2);
            ticArray[8] = rand.Next(0, 2);

            ticTacToe1.Image = x_O.Images[ticArray[0]];
            ticTacToe2.Image = x_O.Images[ticArray[1]];
            ticTacToe3.Image = x_O.Images[ticArray[2]];
            ticTacToe4.Image = x_O.Images[ticArray[3]];
            ticTacToe5.Image = x_O.Images[ticArray[4]];
            ticTacToe6.Image = x_O.Images[ticArray[5]];
            ticTacToe7.Image = x_O.Images[ticArray[6]];
            ticTacToe8.Image = x_O.Images[ticArray[7]];
            ticTacToe9.Image = x_O.Images[ticArray[8]];*/


            //Part that actually works and runs the program.

            
            //Sets up the random
            Random rand = new Random();
            
            //For keeping board even.
            int row = 0;
            int col = 0;
            int count = 0;

            while (count < 9)
            {
                if (xTurn)
                {
                    while (xTurn)
                    {
                        row = rand.Next(0, 3);
                        col = rand.Next(0, 3);
                          
                        if (ticArray[row, col] == -1)
                        {
                            ticArray[row, col] = 1;
                            count++;
                            xTurn = false;
                        }
                    }
                }
                else
                {
                    while (!xTurn)
                    {
                        row = rand.Next(0, 3);
                        col = rand.Next(0, 3);

                        if (ticArray[row, col] == -1)
                        {
                            ticArray[row, col] = 1;
                            count++;
                            xTurn = true;
                        }
                    }
                }
            }
            


            //Moved commands that create array to a global space
            //Creates and sets the constants for the size of the 2D array.
            /*const int ROWS = 3;
            const int COLS = 3;

            //Creates array
            int[,] ticArray = new int[ROWS, COLS];*/
            
            //Loops through array assigning random values between 0 and 1 to every element.
            for (int Row = 0; Row < ROWS; Row++)
            {
                for (int Col = 0; Col < COLS; Col++)
                {
                    ticArray[row, col] = rand.Next(0, 2);
                }
            }

            //Moved to its own method.
            /*ticTacToe1.Image = x_O.Images[ticArray[0, 0]];
            ticTacToe2.Image = x_O.Images[ticArray[0, 1]];
            ticTacToe3.Image = x_O.Images[ticArray[0, 2]];
            ticTacToe4.Image = x_O.Images[ticArray[1, 0]];
            ticTacToe5.Image = x_O.Images[ticArray[1, 1]];
            ticTacToe6.Image = x_O.Images[ticArray[1, 2]];
            ticTacToe7.Image = x_O.Images[ticArray[2, 0]];
            ticTacToe8.Image = x_O.Images[ticArray[2, 1]];
            ticTacToe9.Image = x_O.Images[ticArray[2, 2]];*/

            
            //Moved to its own method.
            /*if (ticArray[0,0] == 0 && ticArray[0,1] == 0 && ticArray[0,2] == 0)
            {
                resultTextBox.Text = "Player Y Wins!";
            }
            else if (ticArray[1, 0] == 0 && ticArray[1, 1] == 0 && ticArray[1, 2] == 0)
            {
                resultTextBox.Text = "Player Y Wins!";
            }
            else if (ticArray[2, 0] == 0 && ticArray[2, 1] == 0 && ticArray[2, 2] == 0)
            {
                resultTextBox.Text = "Player Y Wins!";
            }
            else if (ticArray[0, 0] == 0 && ticArray[1, 0] == 0 && ticArray[2, 0] == 0)
            {
                resultTextBox.Text = "Player Y Wins!";
            }
            else if (ticArray[0, 1] == 0 && ticArray[1, 1] == 0 && ticArray[2, 1] == 0)
            {
                resultTextBox.Text = "Player Y Wins!";
            }
            else if (ticArray[0, 2] == 0 && ticArray[1, 2] == 0 && ticArray[2, 2] == 0)
            {
                resultTextBox.Text = "Player Y Wins!";
            }
            else if (ticArray[0, 0] == 0 && ticArray[1, 1] == 0 && ticArray[2, 2] == 0)
            {
                resultTextBox.Text = "Player Y Wins!";
            }
            else if (ticArray[0, 2] == 0 && ticArray[1, 1] == 0 && ticArray[2, 0] == 0)
            {
                resultTextBox.Text = "Player Y Wins!";
            }
            //Results for X/Player X victory.
            else if (ticArray[0, 0] == 1 && ticArray[0, 1] == 1 && ticArray[0, 2] == 1)
            {
                resultTextBox.Text = "Player X Wins!";
            }
            else if (ticArray[1, 0] == 1 && ticArray[1, 1] == 1 && ticArray[1, 2] == 1)
            {
                resultTextBox.Text = "Player X Wins!";
            }
            else if (ticArray[2, 0] == 1 && ticArray[2, 1] == 1 && ticArray[2, 2] == 1)
            {
                resultTextBox.Text = "Player X Wins!";
            }
            else if (ticArray[0, 0] == 1 && ticArray[1, 0] == 1 && ticArray[2, 0] == 1)
            {
                resultTextBox.Text = "Player X Wins!";
            }
            else if (ticArray[0, 1] == 1 && ticArray[1, 1] == 1 && ticArray[2, 1] == 1)
            {
                resultTextBox.Text = "Player X Wins!";
            }
            else if (ticArray[0, 2] == 1 && ticArray[1, 2] == 1 && ticArray[2, 2] == 1)
            {
                resultTextBox.Text = "Player X Wins!";
            }
            else if (ticArray[0, 0] == 1 && ticArray[1, 1] == 1 && ticArray[2, 2] == 1)
            {
                resultTextBox.Text = "Player X Wins!";
            }
            else if (ticArray[0, 2] == 1 && ticArray[1, 1] == 1 && ticArray[2, 0] == 1)
            {
                resultTextBox.Text = "Player X Wins!";
            }
            //Else statement for draws.
            else
            {
                resultTextBox.Text = "Draw";
            }*/
        }

        private void fillSpaces()
        {
            //Uses the values assigned to each element and uses them to pick either the X or O image from the image list.
            ticTacToe1.Image = x_O.Images[ticArray[0, 0]];
            ticTacToe2.Image = x_O.Images[ticArray[0, 1]];
            ticTacToe3.Image = x_O.Images[ticArray[0, 2]];
            ticTacToe4.Image = x_O.Images[ticArray[1, 0]];
            ticTacToe5.Image = x_O.Images[ticArray[1, 1]];
            ticTacToe6.Image = x_O.Images[ticArray[1, 2]];
            ticTacToe7.Image = x_O.Images[ticArray[2, 0]];
            ticTacToe8.Image = x_O.Images[ticArray[2, 1]];
            ticTacToe9.Image = x_O.Images[ticArray[2, 2]];
        }

        private void checkVictory()
        {
            int oWins = 0;
            int xWins = 0;

            //If else statements to compare values between tic boxes and display who the winner is.
            //Results for O/Player Y victory.
            if (ticArray[0, 0] == 0 && ticArray[0, 1] == 0 && ticArray[0, 2] == 0)
            {
                resultTextBox.Text = "Player Y Wins!";
                oWins += 1;
            }
            else if (ticArray[1, 0] == 0 && ticArray[1, 1] == 0 && ticArray[1, 2] == 0)
            {
                resultTextBox.Text = "Player Y Wins!";
                oWins += 1;
            }
            else if (ticArray[2, 0] == 0 && ticArray[2, 1] == 0 && ticArray[2, 2] == 0)
            {
                resultTextBox.Text = "Player Y Wins!";
                oWins += 1;
            }
            else if (ticArray[0, 0] == 0 && ticArray[1, 0] == 0 && ticArray[2, 0] == 0)
            {
                resultTextBox.Text = "Player Y Wins!";
                oWins += 1;
            }
            else if (ticArray[0, 1] == 0 && ticArray[1, 1] == 0 && ticArray[2, 1] == 0)
            {
                resultTextBox.Text = "Player Y Wins!";
                oWins += 1;
            }
            else if (ticArray[0, 2] == 0 && ticArray[1, 2] == 0 && ticArray[2, 2] == 0)
            {
                resultTextBox.Text = "Player Y Wins!";
                oWins += 1;
            }
            else if (ticArray[0, 0] == 0 && ticArray[1, 1] == 0 && ticArray[2, 2] == 0)
            {
                resultTextBox.Text = "Player Y Wins!";
                oWins += 1;
            }
            else if (ticArray[0, 2] == 0 && ticArray[1, 1] == 0 && ticArray[2, 0] == 0)
            {
                resultTextBox.Text = "Player Y Wins!";
                oWins += 1;
            }
            //Results for X/Player X victory.
            else if (ticArray[0, 0] == 1 && ticArray[0, 1] == 1 && ticArray[0, 2] == 1)
            {
                resultTextBox.Text = "Player X Wins!";
                xWins += 1;
            }
            else if (ticArray[1, 0] == 1 && ticArray[1, 1] == 1 && ticArray[1, 2] == 1)
            {
                resultTextBox.Text = "Player X Wins!";
                xWins += 1;
            }
            else if (ticArray[2, 0] == 1 && ticArray[2, 1] == 1 && ticArray[2, 2] == 1)
            {
                resultTextBox.Text = "Player X Wins!";
                xWins += 1;
            }
            else if (ticArray[0, 0] == 1 && ticArray[1, 0] == 1 && ticArray[2, 0] == 1)
            {
                resultTextBox.Text = "Player X Wins!";
                xWins += 1;
            }
            else if (ticArray[0, 1] == 1 && ticArray[1, 1] == 1 && ticArray[2, 1] == 1)
            {
                resultTextBox.Text = "Player X Wins!";
                xWins += 1;
            }
            else if (ticArray[0, 2] == 1 && ticArray[1, 2] == 1 && ticArray[2, 2] == 1)
            {
                resultTextBox.Text = "Player X Wins!";
                xWins += 1;
            }
            else if (ticArray[0, 0] == 1 && ticArray[1, 1] == 1 && ticArray[2, 2] == 1)
            {
                resultTextBox.Text = "Player X Wins!";
                xWins += 1;
            }
            else if (ticArray[0, 2] == 1 && ticArray[1, 1] == 1 && ticArray[2, 0] == 1)
            {
                resultTextBox.Text = "Player X Wins!";
                xWins += 1;
            }
            //Else statement for draws.
            else
            {
                resultTextBox.Text = "Draw";
            }
        }
    }
}
