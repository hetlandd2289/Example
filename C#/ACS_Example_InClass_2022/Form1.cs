﻿using System;
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
        System.Media.SoundPlayer playah = 
            new System.Media.SoundPlayer(ACS_Example_InClass_2022.Properties.Resources.Bruh_Sound_Effect_2);
        System.Media.SoundPlayer fanfare =
            new System.Media.SoundPlayer(ACS_Example_InClass_2022.Properties.Resources.LTTP_ItemFanfare_Stereo);
        System.Media.SoundPlayer deathToMahBoi = 
            new System.Media.SoundPlayer(ACS_Example_InClass_2022.Properties.Resources.LTTP_Link_Dying);
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
                        fanfare.Play();
                        MessageBox.Show("The value is in fact a digit.");
                    }
                    else
                    {
                        // Inform the user of the result
                        deathToMahBoi.Play();
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
                deathToMahBoi.Play();
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
                        fanfare.Play();
                        MessageBox.Show("The value is in fact a letter.");
                    }
                    else
                    {
                        // Inform the user of the result
                        deathToMahBoi.Play();
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

        private void bruhthaBtn_Click(object sender, EventArgs e)
        {
            playah.Play();
            Bruhtha bruhtha = new Bruhtha();
            this.Hide();
            bruhtha.ShowDialog();
            this.Show();
        }

        private void bruhdiaBtn_Click(object sender, EventArgs e)
        {
            playah.Play();
            Bruhdia bruhdia = new Bruhdia();
            this.Hide();
            bruhdia.ShowDialog();
            this.Show();
        }
    }
}
