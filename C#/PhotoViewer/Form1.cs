//auth: Drake Hetland
//date: 4/10/2022
//desc: A photo viewer map that implements a database for semi-long term storage.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoViewer
{
    public partial class pictureForm : Form
    {
        
        
        public pictureForm()
        {
            InitializeComponent();
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

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                //create a data context for the database
                PhotosDataContext photosDB = new PhotosDataContext();

                //create the opener of the file dialog
                OpenFileDialog opener = new OpenFileDialog();
                //navigate to the pictures folder automatically when clicked
                opener.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures).ToString();
                opener.RestoreDirectory = true;

                if (opener.ShowDialog() == DialogResult.OK)//<- if the opener works
                {
                    //stuff to clean up the title of the image
                    List<string> lis = new List<string>();
                    foreach (string str in opener.FileName.Split('.')[0].Split('\\'))
                    {
                        lis.Add(str);
                    }
                    string title = lis[lis.Count - 1];
                    if (title.Contains('_'))
                    {
                        title = title.Replace('_', ' ');
                    }
                    
                    //check if the photo is already in the database
                    foreach(PhotosTable pho in photosDB.PhotosTables)
                    {
                        if (pho.Location == opener.FileName)
                        {
                            MessageBox.Show("Photo has already been added to viewer.");
                            return;
                        }
                    }

                    //create new entry to be put into the table and assign values
                    PhotosTable photo = new PhotosTable();
                    photo.Name = title;
                    photo.Location = opener.FileName;
                    //MessageBox.Show(photo.Id.ToString());
                    //MessageBox.Show(photo.Name.ToString());
                    //MessageBox.Show(photo.Location.ToString());

                    //insert new entry into database
                    photosDB.PhotosTables.InsertOnSubmit(photo);
                    photosDB.SubmitChanges();
                    //id+=1;
                    //MessageBox.Show(id.ToString());
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureForm_Load(object sender, EventArgs e)
        {
            //create a data context for database to loop each entry into the listbox to be populated on load
            PhotosDataContext photosDB = new PhotosDataContext();
            foreach (PhotosTable photos in photosDB.PhotosTables)
            {
                photoListBox.Items.Add(photos.Name);
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            //creates a new version of the form, to have the listbox update with newly added items
            pictureForm pictureForm = new pictureForm();
            this.Hide();
            pictureForm.ShowDialog();
            this.Close();
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            //creates a data context so the database can be accessed
            PhotosDataContext photosDB = new PhotosDataContext();

            //checks to make sure that something is selected
            if (photoListBox.SelectedItem != null)
            {
                foreach (PhotosTable photo in photosDB.PhotosTables)
                {
                    if (photoListBox.SelectedItem.ToString() == photo.Name)
                    {
                        //creates a new photo instance and puts it into the picturebox
                        Bitmap bitmap = new Bitmap(photo.Location);
                        pictureBox.Image = (Image)bitmap;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an item from the list before viewing.");
            }
        }
    }
}
