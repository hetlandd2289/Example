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
    public partial class BrotherForm : Form
    {
        public BrotherForm()
        {
            InitializeComponent();
        }

        private void bruhBtn_Click(object sender, EventArgs e)
        {
            ExampleForm bruh = new ExampleForm(); // creates an instance of the BruhForm
            bruh.Show(); // Display the form for the user to see/interact with
            this.Hide();
        }
    }
}
