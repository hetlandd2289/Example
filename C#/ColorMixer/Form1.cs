using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorMixer
{
    public partial class colorMixer : Form
    {
        public colorMixer()
        {
            InitializeComponent();
        }

        private void colorMixer_Load(object sender, EventArgs e)
        {

        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mixButton_Click(object sender, EventArgs e)
        {
            if (redRadioButton1.Checked && redRadioButton2.Checked)
            {
                this.BackColor = Color.Red;
            }
            else if (blueRadioButton1.Checked && blueRadioButton2.Checked)
            {
                this.BackColor = Color.Blue;
            }
            else if (redRadioButton1.Checked && blueRadioButton2.Checked)
            {
                this.BackColor = Color.Purple;
            }
            else if (redRadioButton1.Checked && yellowRadioButton2.Checked)
            {
                this.BackColor = Color.Orange;
            }
            else if (blueRadioButton1.Checked && redRadioButton2.Checked)
            {
                this.BackColor = Color.Purple;
            }
            else if (blueRadioButton1.Checked && yellowRadioButton2.Checked)
            {
                this.BackColor = Color.Green;
            }
            else if (yellowRadioButton1.Checked && redRadioButton2.Checked)
            {
                this.BackColor = Color.Orange;

            }
            else if (yellowRadioButton1.Checked && blueRadioButton2.Checked)
            {
                this.BackColor = Color.Green;
            }
            else if (yellowRadioButton1.Checked && yellowRadioButton2.Checked)
            {
                this.BackColor = Color.Yellow;
            }
        }

        private void mixCheckedButton_Click(object sender, EventArgs e)
        {
            if (redCheckBox1.Checked && redCheckBox2.Checked)
            {
                this.BackColor = Color.Red;
            }
            else if (redCheckBox1.Checked && blueCheckBox2.Checked)
            {
                this.BackColor = Color.Purple;
            }
            else if (redCheckBox1.Checked && yellowCheckBox2.Checked)
            {
                this.BackColor = Color.Orange;
            }
            else if (blueCheckBox1.Checked && redCheckBox2.Checked)
            {
                this.BackColor = Color.Purple;
            }
            else if (blueCheckBox1.Checked && blueCheckBox2.Checked)
            {
                this.BackColor = Color.Blue;
            }
            else if (blueCheckBox1.Checked && yellowCheckBox2.Checked)
            {
                this.BackColor = Color.Green;
            }
            else if (yellowCheckBox1.Checked && blueCheckBox2.Checked)
            {
                this.BackColor = Color.Green;
            }
            else if (yellowCheckBox1.Checked && redCheckBox2.Checked)
            {
                this.BackColor = Color.Orange;
            }
            else if (yellowCheckBox1.Checked && yellowCheckBox2.Checked)
            {
                this.BackColor = Color.Yellow;
            }
            else
            {
                this.BackColor = colorMixer.DefaultBackColor;
            }
        }

        private void redRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (redRadioButton1.Checked)
            {
                if (redRadioButton2.Checked)
                {
                    this.BackColor = Color.Red;
                }
                else if (blueRadioButton2.Checked)
                {
                    this.BackColor = Color.Purple;
                }
                else
                {
                    this.BackColor = Color.Orange;
                }
            }
        }

        private void redCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (redCheckBox1.Checked)
            {
                blueCheckBox1.Checked = false;
                yellowCheckBox1.Checked = false;
                if (redCheckBox2.Checked)
                    this.BackColor = Color.Red;
                else if (blueCheckBox2.Checked)
                    this.BackColor = Color.Purple;
                else if (yellowCheckBox2.Checked)
                    this.BackColor = Color.Orange;
                else
                    this.BackColor = colorMixer.DefaultBackColor;
            }
            else 
            {
                if (!redCheckBox1.Checked && !blueCheckBox1.Checked && !yellowCheckBox1.Checked)
                this.BackColor = colorMixer.DefaultBackColor; 
            }
        }
    }
}
       