/*Chapter 3 Assignment
 * Drake Hetland
 * 10/4/2020*/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_3_Assignment___Drake_Hetland
{
    public partial class stadiumSeating : Form
    {
        public stadiumSeating()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Makes the exit button work.
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Makes the clear button work.
            classARevInput.Text = "";
            classATicketText.Text = "";
            classBRevInput.Text = "";
            classBTicketText.Text = "";
            classCRevInput.Text = "";
            classCTicketText.Text = "";
            totalRevenue.Text = "";

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Sets up the variables for the ticket prices.
                double revA = 15;
                double revB = 12;
                double revC = 9;
                double total = 0;

                //Gets the amount of revenue generated per ticket sold.
                revA = double.Parse(classATicketText.Text);
                revB = double.Parse(classBTicketText.Text);
                revC = double.Parse(classCTicketText.Text);

                //Outputs the number of tickets sold to the revenue generated.
                classARevInput.Text = (revA * 15).ToString("C");
                classBRevInput.Text = (revB * 12).ToString("C");
                classCRevInput.Text = (revC * 9).ToString("C");

                //Calculates the total revenue.
                total = (revA * 15) + (revB * 12) + (revC * 9);
                totalRevenue.Text = total.ToString("C");
            }
            catch 
            {
                //Shows error message.
                MessageBox.Show("Please input valid numbers.");
            }
        }
    }
}
