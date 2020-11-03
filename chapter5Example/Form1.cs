using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chapter5Example
{
    public partial class chapter5Example : Form
    {
        public chapter5Example()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearItemsButton_Click(object sender, EventArgs e)
        {
            dynamicListBox.Items.Clear();
        }

        private void countButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("There are " + (dynamicListBox.Items.Count).ToString() + " items in the ListBox");
        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            if (newItemTextBox.Text != "")
            dynamicListBox.Items.Add(newItemTextBox.Text);
            newItemTextBox.Text = "";
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            int index = 0;
            int value = 0;
            int total = 0;

            //ONLY NEED < BECAUSE COMPUTER SCIENCE BEGINS COUNTING AT 0
            while (index < dynamicListBox.Items.Count)
            {
                int.TryParse(dynamicListBox.Items[index].ToString(), out value);

                total += value;

                index++;
            }

            calculateLabel.Text = "Total: " + total.ToString();
        }
    }
}
