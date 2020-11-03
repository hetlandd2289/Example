/* Title: Penny Project
Author: Drake Hetland
Date: 10/7/2020
Description: Creating a program that takes the inputs for the amount 
of coins and puts out the money it is worth in cents to see if the value
is equal to $1.00*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PennyProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Clear button.
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clear button.
            penniesInput.Text = "";
            nickelsInput.Text = "";
            dimeInput.Text = "";
            quartersInput.Text = "";
            totalOutput.Text = "";
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            
            {
                //Setting variables.
                int pennies = 0;
                int nickels = 0;
                int dimes = 0;
                int quarters = 0;
                double total = 0;

                //Parses the string into a decimal.
                int.TryParse(penniesInput.Text, out pennies);
                int.TryParse(nickelsInput.Text, out nickels);
                int.TryParse(dimeInput.Text, out dimes);
                int.TryParse(quartersInput.Text, out quarters);

                //Input validation
                if (pennies < 1000 && nickels < 600 && dimes < 800 && quarters < 1000 &&
                    pennies >= 0 && nickels >= 0 && dimes >= 0 && quarters >= 0)
                {
                    //Add together appropriate values for the coins.
                    total = (pennies + (nickels * 5) + (dimes * 10) + (quarters * 25)) / 100.0;

                    //Compare total to see if user won or lost.
                    if (total == 100.0)
                    {
                        totalOutput.Text = "Your total: $1.00 \nYou Win!";
                    }
                    else if (total < 100.0)
                    {
                        totalOutput.Text = "Your total: " + total.ToString("C") + "\nYou entered a value less than $1.00";
                    }
                    else
                    {
                        totalOutput.Text = "Your total: " + total.ToString("C") + "\nYou entered a value greater than $1.00";
                    }

                }

                else { totalOutput.Text = "Result: Invalid input. \nPlease enter a valid value."; }
                
            }
            
        }
    }
}
