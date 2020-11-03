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

            while (++count <= hours)
            {
                resultsListBox.Items.Add("After hour " + count.ToString() + " the distance is " + (speed * count).ToString());
                //count++;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
