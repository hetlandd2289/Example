using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace distanceConverter
{
    public partial class distanceConverter : Form
    {
        public distanceConverter()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            //Declare variables
            double measure = 0.0;
            double intermediate = 0.0;

            //Convert user imput into a double
            double.TryParse(entryTextBox.Text, out measure);

            //Start by ensuring that both listboxes have selected items
            if (fromListBox.SelectedIndex != -1 && toListBox.SelectedIndex != -1)
            {
                //Using the selection of the from listbox convert the input into feet
                switch (fromListBox.SelectedIndex) 
                {
                    case 0:
                        intermediate = measure / 12;
                        break;
                    case 1:
                        intermediate = measure;
                        break;
                    case 2:
                        intermediate = measure * 3;
                        break;
                    default: MessageBox.Show("You have broken through my defenses!");
                        this.Close();
                        break;
                }
                switch (toListBox.SelectedIndex)
                {
                    case 0:
                        convertedLabel.Text = (intermediate * 12.0).ToString();
                        break;
                    case 1:
                        convertedLabel.Text = (intermediate).ToString();
                        break;
                    case 2:
                        convertedLabel.Text = (intermediate / 3.0).ToString();
                        break;
                    default:
                        MessageBox.Show("You have broken through my defenses!");
                        this.Close();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Please select a 'from' and 'to' option for the conversion.");
            }
            
        }
    }
}
