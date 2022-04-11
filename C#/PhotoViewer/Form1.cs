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
                //int id = 0;
                PhotosDataContext photosDB = new PhotosDataContext();
                OpenFileDialog opener = new OpenFileDialog();
                opener.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures).ToString();
                opener.RestoreDirectory = true;

                if (opener.ShowDialog() == DialogResult.OK)
                {
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
                    
                    foreach(PhotosTable pho in photosDB.PhotosTables)
                    {
                        if (pho.Location == opener.FileName)
                        {
                            MessageBox.Show("Photo has already been added to viewer.");
                            return;
                        }
                    }
                    PhotosTable photo = new PhotosTable();
                    photo.Name = title;
                    photo.Location = opener.FileName;
                    MessageBox.Show(photo.Id.ToString());
                    MessageBox.Show(photo.Name.ToString());
                    MessageBox.Show(photo.Location.ToString());

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
            PhotosDataContext photosDB = new PhotosDataContext();
            foreach (PhotosTable photos in photosDB.PhotosTables)
            {
                photoListBox.Items.Add(photos.Name);
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            pictureForm pictureForm = new pictureForm();
            this.Hide();
            pictureForm.ShowDialog();
            this.Close();
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            PhotosDataContext photosDB = new PhotosDataContext();
            if (photoListBox.SelectedItem != null)
            {
                foreach (PhotosTable photo in photosDB.PhotosTables)
                {
                    if (photoListBox.SelectedItem.ToString() == photo.Name)
                    {

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
