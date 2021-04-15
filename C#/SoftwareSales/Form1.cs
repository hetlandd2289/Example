using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareSales
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

        private void enterButton_Click(object sender, EventArgs e)
        {
            int quantity = 0;
            //int discount = 0;

            int.TryParse(quantityTextBox.Text, out quantity);

            if (quantity >= 10 && quantity <= 19)
                discount = 20;
            else if (quantity >= 20 && quantity <= 49)
                discount = 30;
            else if (quantity >= 50 && quantity <= 99)
                discount = 40;
            else if (quantity >= 100)
                discount = 50;
            /*
            switch (discount)
            {
                case 20:
                    resultLabel.Text = "Discount: 20%\nTotal: " + (quantity * 99 * .8).ToString("C");
                    break;
                case 30:
                    resultLabel.Text = "Discount: 30%\nTotal: " + (quantity * 99 * .7).ToString("C");
                    break;
                case 40:
                    resultLabel.Text = "Discount: 40%\nTotal: " + (quantity * 99 * .6).ToString("C");
                    break;
                case 50:
                    resultLabel.Text = "Discount: 50%\nTotal: " + (quantity * 99 * .5).ToString("C");
                    break;
                default:
                    resultLabel.Text = "You do not qualify for a discount. \nTotal: " + (quantity * 99).ToString("C");
                    break;
            }
            */
            

            switch (quantity)
            {
                case int n when n >= 10 && n <= 19:
                    resultLabel.Text = "Discount: 20%\nTotal: " + (quantity * 99 * .8).ToString("C");
                    break;
                case int n when n >= 20 && n <= 49:
                    resultLabel.Text = "Discount: 30%\nTotal: " + (quantity * 99 * .7).ToString("C");
                    break;
                case int n when n >= 50 && n <= 99:
                    resultLabel.Text = "Discount: 40%\nTotal: " + (quantity * 99 * .6).ToString("C");
                    break;
                case int n when n >= 100:
                    resultLabel.Text = "Discount: 50%\nTotal: " + (quantity * 99 * .5).ToString("C");
                    break;

                default:
                    resultLabel.Text = "You do not qualify for a discount. \nTotal: " + (quantity * 99).ToString("C");
                    break;

            }
            resultPannel.Visible = true;
        }   
    }
}
