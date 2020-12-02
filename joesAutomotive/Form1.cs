using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace joesAutomotive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearOilLube() //Clears the checkboxes for oil change and lube job
        {
            oilChangeCheckBox.Checked = false;
            lubeJobCheckBox.Checked = false;
        }

        private void ClearFlushes()
        {
            radiatorFlushCheckBox.Checked = false;
            transmissionFlushCheckBox.Checked = false;
        }

        private void ClearMisc()
        {
            inspectionCheckBox.Checked = false;
            replaceMufflerCheckBox.Checked = false;
            tireRotationCheckBox.Checked = false;
        }

        private void ClearOther()
        {
            partsTextBox.Text = "";
            laborTextBox.Text = "";
        }

        private void ClearFees()
        {
            serviceTextBox.Text = "";
            partsSummaryTextBox.Text = "";
            taxTextBox.Text = "";
            totalTextBox.Text = "";
        }


        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearOilLube();
            ClearFlushes();
            ClearMisc();
            ClearOther();
            ClearFees();
        }

        private double oilLubeCharges()
        {
            double total = 0;
            if (oilChangeCheckBox.Checked == true)
                total += 26.00;
            if (lubeJobCheckBox.Checked == true)
                total += 18.00;

            return total; //Value-Returning. If this is not here, an error is thrown
        }

        private double flushCharges()
        {
            double total = 0;
            if (radiatorFlushCheckBox.Checked == true)
                total += 30.00;
            if (transmissionFlushCheckBox.Checked == true)
                total += 80.00;

            return total;
        }

        private double miscCharges()
        {
            double total = 0;
            if (inspectionCheckBox.Checked == true)
                total += 15.00;
            if (replaceMufflerCheckBox.Checked == true)
                total += 100.00;
            if (tireRotationCheckBox.Checked == true)
                total += 20.00;

            return total;
        }

        private double laborCharges()
        {
            
            double labor = 0;
            double.TryParse(laborTextBox.Text, out labor);

            return labor;
        }

        private double partsCharges()
        {
            double parts = 0;

            double.TryParse(partsTextBox.Text, out parts);

            return parts;
        }

        private double taxCharges()
        {
            double parts = 0;

            double.TryParse(partsTextBox.Text, out parts);

            return parts * 0.06;
        }

        private double totalCharges()
        {
            return oilLubeCharges() + flushCharges() + miscCharges() + laborCharges() + partsCharges() + taxCharges();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            serviceTextBox.Text = (oilLubeCharges() + flushCharges() + miscCharges() + laborCharges()).ToString();
            partsSummaryTextBox.Text = (partsCharges()).ToString();
            taxTextBox.Text = (taxCharges()).ToString();
            totalTextBox.Text = totalCharges().ToString();
        }
    }
}
