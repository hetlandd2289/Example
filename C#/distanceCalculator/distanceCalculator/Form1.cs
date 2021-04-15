using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace distanceCalculator
{
    public partial class distanceCalculator : Form
    {
        public distanceCalculator()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            int speed = 0;
            int hours = 0;
            int count = 0;

            int.TryParse(speedTextBox.Text, out speed);
            int.TryParse(hoursTextBox.Text, out hours);

            resultsListBox.Items.Clear();

            /*while (++count <= hours)
            {
                resultsListBox.Items.Add("After hour " + count.ToString() + " the distance is " + (speed * count).ToString());
                //count++;
            }*/

            do
            {
                resultsListBox.Items.Add("After hour " + count.ToString() + " the distance is " + (speed * count).ToString());
                //count++;
            } while (++count <= hours);
        }

          private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*private void alternateWhile()
        {
            bool cont = true;
            int sum = 0;
            int num = 0;

            while (cont)
            {
                int.TryParse(inputTextBox.Text, out num);
                sum += num;
                contLabel.Text = ("Continue? ");

                if (contTextBox.Text == "no")
                {
                    cont = false;
                }
            }
        }*/
    }
}
