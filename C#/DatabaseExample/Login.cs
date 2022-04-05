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
    public partial class Login : Form
    {
        public Login()
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
        private void goToAdminLandingPage()
        {
            AdminLandingPage landingPage = new AdminLandingPage();
            this.Hide();
            landingPage.ShowDialog();
            this.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
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

        private void clearButton_Click(object sender, EventArgs e)
        {
            try
            {
                usernameCreateTB.Clear();
                passwordCreateTB.Clear();
                FirstNameCreateTB.Clear();
                lastNameCreateTB.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Createthe context object
                LINQ_ClassesDataContext usersDB = new LINQ_ClassesDataContext();

                //Check username and password
                foreach (User uname in usersDB.Users)
                {
                    if (usernameLoginTB.Text == uname.Username)
                    {
                        if (passwordLoginTB.Text == uname.Password)
                        {
                            //open new form
                            //MessageBox.Show("You have successfully logged in.");
                            if(uname.Admin == true)
                            {
                                goToAdminLandingPage();
                            }
                            else
                            {
                                goToTestingGround();
                            }
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Wrog Passwrb, Punk!");
                            passwordLoginTB.Clear();
                            passwordLoginTB.Focus();
                            passwordLabel.ForeColor = Color.Pink;
                            return;
                        }
                    }
                }
                MessageBox.Show("Wrog Ubernaem, Punk!");
                usernameLoginTB.Clear();
                passwordLoginTB.Clear();
                usernameLoginTB.Focus();
                usernameLabel.ForeColor = Color.Pink;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            try
            {
                //check if textboxes have anyhting in them
                if (usernameCreateTB.Text == "")
                {
                    MessageBox.Show("You must enter a username");
                    usernameCreateTB.Focus();
                    return;
                }
                if (passwordCreateTB.Text == "")
                {
                    MessageBox.Show("You must enter a password");
                    usernameCreateTB.Focus();
                    return;
                }

                LINQ_ClassesDataContext usersTable = new LINQ_ClassesDataContext();

                //check table for username in use
                foreach (User user in usersTable.Users)
                {
                    if (usernameCreateTB.Text == user.Username)
                    {
                        //if username is taken
                        MessageBox.Show("Username is taken.");
                        usernameCreateTB.Clear();
                        usernameCreateTB.Focus();
                        return;
                    }
                }

                //username is available if gotten this far
                User newUser = new User();
                newUser.Username = usernameCreateTB.Text;
                newUser.Password = passwordCreateTB.Text;
                newUser.First = FirstNameCreateTB.Text;
                newUser.Last = lastNameCreateTB.Text;

                usersTable.Users.InsertOnSubmit(newUser);
                usersTable.SubmitChanges();

                MessageBox.Show("You have successfully created your account.");
                goToTestingGround();
                return;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
