using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CtoFConverter
{
    public partial class tempConverter : Form
    {
        public tempConverter()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            for (double c = 0.0; c <= 20.0; c++)
            {
                if (c < 10.0)
                    resultListBox.Items.Add("Celsius: " + c.ToString() + "     Fahrenheit: " + ((c * (9.0/5.0)) + 32.0).ToString());
                else
                    resultListBox.Items.Add("Celsius: " + c.ToString() + "   Fahrenheit: " + ((c * (9.0/5.0)) + 32.0).ToString());
            }
        }
    }
}
