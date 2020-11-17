using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingGame
{
    public partial class blindMansBluff : Form
    {
        int aiMoneyTotal = 25;
        int aiBid = 0;
        int playerMoneyTotal = 25;
        int playerBid = 0;
        int playerRollTotal = 0;
        int aiRollTotal1 = 0;
        public blindMansBluff()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bidButton_Click(object sender, EventArgs e)
        {
            int bidAmount = 0;
            int bidTotal = 0;
            int aiTotal = 0;
            int aibBid = 0;

            int.TryParse(bidTextBox.Text, out bidAmount);
            int.TryParse(totalBidsTextBox.Text, out bidTotal);
            int.TryParse(opponentMoneyTextBox.Text, out aiTotal);

            Random rand = new Random();

            if (aiTotal > 10)
                aibBid = rand.Next(1, bidAmount + 1);
            else
                aibBid = rand.Next(1, aiTotal + 1);

            totalBidsTextBox.Text = (bidAmount + aibBid).ToString();

            bidButton.Enabled = false;

        }

        private void rollButton_Click(object sender, EventArgs e)
        {
            int die1, die2, die3, die4;
            Random rand = new Random();
            die1 = rand.Next(1, 7);
            die2 = rand.Next(1, 7);
            die3 = rand.Next(1, 7);
            die4 = rand.Next(1, 7);

            playerRollTotalTextBox.Text = (die1 + die2).ToString();
            opponentRollTotalTextBox.Text = (die3 + die4).ToString();

            die1PictureBox.Image = diceFaces.Images[die1 - 1];
            die2PictureBox.Image = diceFaces.Images[die2 - 1];
            aiDie3.Image = diceFaces.Images[die3 - 1];
            aiDice4.Image = diceFaces.Images[die4 - 1];

            rollButton.Enabled = false;
            bidButton.Enabled = true;
        }

        private void blindMansBluff_Load(object sender, EventArgs e)
        {
            bidButton.Enabled = false;
        }

        private void callButton_Click(object sender, EventArgs e)
        {
            int playerRoll = 0;
            int aiRoll = 0;
            int playerTotal = 0;
            int aiTotal = 0;
            int totalBid = 0;

            int.TryParse(playerRollTotalTextBox.Text, out playerRoll);
            int.TryParse(opponentRollTotalTextBox.Text, out aiRoll);
            int.TryParse(moneyTextBox.Text, out playerTotal);
            int.TryParse(opponentMoneyTextBox.Text, out aiTotal);
            int.TryParse(totalBidsTextBox.Text, out totalBid);

            if (playerRoll > aiRoll)
            {
                playerMoneyTotal += aiBid;
                aiMoneyTotal -= aiBid;
            }
            else if (aiRoll > playerRoll)
            {
                playerMoneyTotal -= playerBid;
                aiMoneyTotal += playerBid;
            }
            else
            {
                MessageBox.Show("Tied Round. Bids Returned.");
            }

            moneyTextBox.Text = playerMoneyTotal.ToString();
            opponentMoneyTextBox.Text = aiMoneyTotal.ToString();

            if (playerMoneyTotal > 0)
                rollButton.Enabled = true;
            else
            {
                MessageBox.Show("You have lost.");
            }

        }
    }
}
