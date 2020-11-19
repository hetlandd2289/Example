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
    }
}
