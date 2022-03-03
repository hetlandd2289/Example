using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeSimulator
{
    public partial class TicTacToe : Form
    {
        const int ROWS = 3;
        const int COLS = 3;
        bool xTurn = true;

        int[,] game = new int[ROWS, COLS];
        int[] results = new int[5] { 0, 0, 0, 0, 0 }; //{ O wins, O losses, X wins, X losses, Draws }

        public TicTacToe()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            clearGame();
            
            Random rand = new Random();
            
            int goesFirst = rand.Next(0, 2); 
            if (goesFirst == 1)
                xTurn = true;
            else
                xTurn = false;

            int row = 0;
            int col = 0;
            int count = 0;
            while (count < 9)
            {
                if (xTurn) // X Turn
                {
                    while (xTurn)
                    {
                        row = rand.Next(0, 3);
                        col = rand.Next(0, 3);

                        if (game[row, col] == -1)
                        {
                            game[row, col] = 1;
                            count++;
                            xTurn = false;
                        }
                    }
                }
                else // O Turn
                {
                    while (!xTurn)
                    {
                        row = rand.Next(0, 3);
                        col = rand.Next(0, 3);

                        if (game[row, col] == -1)
                        {
                            game[row, col] = 0;
                            count++;
                            xTurn = true;
                        }
                    }
                }
            }

            fillSpaces();

            checkVictory();
        }

        private void clearGame()
        {
            for (int r = 0; r < ROWS; r++)
            {
                for (int c = 0; c < COLS; c++)
                {
                    game[r, c] = -1;
                }
            }
        }

        private void fillSpaces()
        {
            if (game[0, 0] == 0)
                space00Label.Text = "O";
            else
                space00Label.Text = "X";
            
            if (game[0, 1] == 0)
                space01Label.Text = "O";
            else
                space01Label.Text = "X";
            
            if (game[0, 2] == 0)
                space02Label.Text = "O";
            else
                space02Label.Text = "X";

            if (game[1, 0] == 0)
                space10Label.Text = "O";
            else
                space10Label.Text = "X";

            if (game[1, 1] == 0)
                space11Label.Text = "O";
            else
                space11Label.Text = "X";

            if (game[1, 2] == 0)
                space12Label.Text = "O";
            else
                space12Label.Text = "X";

            if (game[2, 0] == 0)
                space20Label.Text = "O";
            else
                space20Label.Text = "X";

            if (game[2, 1] == 0)
                space21Label.Text = "O";
            else
                space21Label.Text = "X";

            if (game[2, 2] == 0)
                space22Label.Text = "O";
            else
                space22Label.Text = "X";
        }

        private void checkVictory()
        {
            int xWins = 0;
            int oWins = 0;

            // Rows
            if (game[0,0] == game[0,1] && game[0,0] == game[0,2])
            {
                if (game[0, 0] == 0)
                    oWins += 1;
                else
                    xWins += 1;
            }
            if (game[1, 0] == game[1, 1] && game[1, 0] == game[1, 2])
            {
                if (game[1, 0] == 0)
                    oWins += 1;
                else
                    xWins += 1;
            }
            if (game[2, 0] == game[2, 1] && game[2, 0] == game[2, 2])
            {
                if (game[2, 0] == 0)
                    oWins += 1;
                else
                    xWins += 1;
            }

            // Columns
            if (game[0, 0] == game[1, 0] && game[0, 0] == game[2, 0])
            {
                if (game[2, 0] == 0)
                    oWins += 1;
                else
                    xWins += 1;
            }
            if (game[0, 1] == game[1, 1] && game[0, 1] == game[2, 1])
            {
                if (game[2, 1] == 0)
                    oWins += 1;
                else
                    xWins += 1;
            }
            if (game[0, 2] == game[1, 2] && game[0, 2] == game[2, 2])
            {
                if (game[2, 2] == 0)
                    oWins += 1;
                else
                    xWins += 1;
            }

            // Diagonals
            if (game[0, 0] == game[1, 1] && game[0, 0] == game[2, 2])
            {
                if (game[2, 2] == 0)
                    oWins += 1;
                else
                    xWins += 1;
            }
            if (game[0, 2] == game[1, 1] && game[0, 2] == game[2, 0])
            {
                if (game[2, 0] == 0)
                    oWins += 1;
                else
                    xWins += 1;
            }

            if (xWins < oWins)
            {
                results[0] += 1; // O wins
                results[3] += 1; // X losses
                displayResults();
            }
            else if (xWins > oWins)
            {
                results[2] += 1; // X wins
                results[1] += 1; // O losses
                displayResults();
            }
            else
            {
                results[4] += 1;
                displayResults();
            }
        }

        private void displayResults()
        {
            resultLabel.Text = "O Wins: " + results[0] + "    O Losses: " + results[1] +
                               "\nX Wins: " + results[2] + "    X Losses: " + results[3] +
                               "\nDraws: " + results[4];
        }
    }
}
