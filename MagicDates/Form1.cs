/* author: Drake Hetland
 * date: 10/6/20
 * description: This takes in a day, month, and year and then displays if the date is magical.*/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagicDates
{
    public partial class magicDates : Form
    {
        public magicDates()
        {
            InitializeComponent();
        }

        private void monthLabel_Click(object sender, EventArgs e)
        {

        }
        //this method takes input and displays the result
        private void submitButton_Click(object sender, EventArgs e)
        {
            try
            {
                //converts the entered text into integers and stores as vaariables
                int month = int.Parse(monthTextBox.Text),
                    day = int.Parse(dayTextBox.Text),
                    year = int.Parse(yearTextBox.Text);

                //check to see if the date is magical
                if ((month * day) == year)
                {
                    resultLabel.Text = "Result: This date is magic!";
                }
                else
                {
                    resultLabel.Text = "Result: This date is not magic.";
                }

            }
            //any invalid entries will be sent here
            catch
            {
                MessageBox.Show("Invalid entry \nPlease enter a valid date.");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //this method clears the text boxes
            monthTextBox.Text = "";
            dayTextBox.Text = "";
            yearTextBox.Text = "";
            resultLabel.Text = "Result:";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //this method closes the app
            this.Close();
        }
    }
}
