using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACS_Example_InClass_2022
{
    public partial class ExampleForm : Form
    {
        public ExampleForm()
        {
            InitializeComponent();
        }

        private void checkDigitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Declare Variables
                int index;

                // Parse index textbox for an integer value
                if (!int.TryParse(indexTB.Text, out index))
                {
                    MessageBox.Show("Invalid index entered");
                    indexTB.Clear();
                    indexTB.Focus();
                }
                else
                {
                    // Check if the value at the given index is in fact a digit
                    if (Char.IsDigit(inputTB.Text, index))
                    {
                        // Inform the user of the result
                        MessageBox.Show("The value is in fact a digit.");
                    }
                    else
                    {
                        // Inform the user of the result
                        MessageBox.Show("The value is not a digit.");
                    }
                }
            }
            catch (Exception ex) // Whatever the error is is stored as ex
            {
                // Display the error message automatically drafted by the system
                MessageBox.Show(ex.Message);
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkLetterBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Declare Variables
                int index;

                // Parse index textbox for an integer value
                if (!int.TryParse(indexTB.Text, out index))
                {
                    MessageBox.Show("Invalid index entered");
                    indexTB.Clear();
                    indexTB.Focus();
                }
                else
                {
                    // Check if the value at the given index is in fact a letter
                    if (Char.IsLetter(inputTB.Text, index))
                    {
                        // Inform the user of the result
                        MessageBox.Show("The value is in fact a letter.");
                    }
                    else
                    {
                        // Inform the user of the result
                        MessageBox.Show("The value is not a letter.");
                    }
                }
            }
            catch (Exception ex) // Whatever the error is is stored as ex
            {
                // Display the error message automatically drafted by the system
                MessageBox.Show(ex.Message);
            }
        }

        private void swapFormBtn_Click(object sender, EventArgs e)
        {
            BrotherForm brother = new BrotherForm(); // Creates an instance of the BrotherForm
            brother.ShowDialog(); // displays brother
            this.Hide();
        }
    }
}
