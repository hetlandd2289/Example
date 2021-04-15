/* Author: Drake Hetland
 * Date: 12-2-2020
 * Description: Practice using concepts covered in Chapter 6 */ 


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chapter6Assignment
{
    public partial class hospitalCharges : Form
    {
        public hospitalCharges()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Exit Button.
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clears all text boxes.
            daysTextBox.Text = "";
            medicationTextBox.Text = "";
            labFeesTextBox.Text = "";
            rehabTextBox.Text = "";

            //Makes the total cost label and text box invisible.
            totalCostLabel.Visible = false;
            totalTextBox.Visible = false;
            kilroy.Visible = false;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //Puts the calculated total into the totalTextBox.
            totalTextBox.Text =  CalcTotalCharges().ToString();

            //Makes the total visible.
            totalCostLabel.Visible = true;
            totalTextBox.Visible = true;
            kilroy.Visible = true;
        }

        private double CalcStayCharges()
        {
            //Sets variable, parses, and does the math to get the cost of staying at the hospital.
            double stay = 0;

            double.TryParse(daysTextBox.Text, out stay);

            return stay * 350;
        }

        private double CalcMiscCharges()
        {
            //Sets variables, parses, and adds together the other costs while at the hospital.
            double medication = 0;
            double labFees = 0;
            double rehab = 0;

            double.TryParse(medicationTextBox.Text, out medication);
            double.TryParse(labFeesTextBox.Text, out labFees);
            double.TryParse(rehabTextBox.Text, out rehab);

            return medication + labFees + rehab;
        }

        private double CalcTotalCharges()
        {
            //Conglomerates the 2 other method's values into one for an easy call.
            return CalcStayCharges() + CalcMiscCharges();
        }
    }
}
