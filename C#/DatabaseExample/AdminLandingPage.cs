using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseExample
{
    public partial class AdminLandingPage : Form
    {
        public AdminLandingPage()
        {
            InitializeComponent();
        }

        private void goToTestingGround()
        {
            TestForm testForm = new TestForm();
            this.Hide();
            testForm.ShowDialog();
            this.Show();
        }
        private void goToUsersForm()
        {
            EditUsersForm usersForm = new EditUsersForm();
            this.Hide();
            usersForm.ShowDialog();
            this.Show();
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void testBtn_Click(object sender, EventArgs e)
        {
            goToTestingGround();
        }

        private void usersBtn_Click(object sender, EventArgs e)
        {
            goToUsersForm();
        }

        private void songDBBtn_Click(object sender, EventArgs e)
        {
            SongsDBForm sdb = new SongsDBForm();
            this.Hide();
            sdb.ShowDialog();
            this.Show();
        }
    }
}
