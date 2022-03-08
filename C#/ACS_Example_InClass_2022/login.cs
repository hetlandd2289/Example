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
    public partial class Login : Form
    {
        BrinkDataContext brink;

        public Login()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hey, Pimp! This done messed up.\n" +
                    "This is bruhken. Here is the error:\n"
                    + ex.Message + "\nI'll let you Google that yoself!");
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int pass = 0;

                if (!int.TryParse(passwordTB.Text, out pass))
                {
                    MessageBox.Show("Dude, seriously? Try a real password this time!");
                    passwordTB.Clear();
                    passwordTB.Focus();
                    return;
                }

                foreach (Brable bruh in brink.Brables)
                {
                    if (nameTB.Text == bruh.Bruh)
                    {
                        if (pass == bruh.Homebois)
                        {
                            ExampleForm bro = new ExampleForm();
                            this.Hide();
                            bro.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("You a counterfeit, Dude!\n" +
                                "Be gone before I give you stitches, snitch!");
                            passwordTB.Clear();
                            passwordTB.Focus();
                            return;
                        }
                    }
                }
                MessageBox.Show("You ain't a bro of mine, NOT my Dude!\n" +
                                "Be gone before I give you stitches, snitch!");
                nameTB.Clear();
                passwordTB.Clear();
                nameTB.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hey, Pimp! This done messed up.\n" +
                    "This is bruhken. Here is the error:\n"
                    + ex.Message + "\nI'll let you Google that yoself!");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            try
            {
                // Creates the object that allows us to access the database
                brink = new BrinkDataContext();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hey, Pimp! This done messed up.\n" +
                    "This is bruhken. Here is the error:\n" 
                    + ex.Message + "\nI'll let you Google that yoself!");
            }
        }
    }
}
