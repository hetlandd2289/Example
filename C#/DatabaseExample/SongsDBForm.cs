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
    public partial class SongsDBForm : Form
    {
        public SongsDBForm()
        {
            InitializeComponent();
        }

        private void songsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.songsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.songsDataSet);

        }

        private void SongsDBForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'songsDataSet.Songs' table. You can move, or remove it, as needed.
            this.songsTableAdapter.Fill(this.songsDataSet.Songs);

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addSong_Click(object sender, EventArgs e)
        {
            try
            {
                //Set dialog to open the users music directory
                opener.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic).ToString();
                //Filter rhe contents to .wav files

                opener.RestoreDirectory = true;

                //get the file to add
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

                    LINQ_ClassesDataContext songsDB = new LINQ_ClassesDataContext();
                    foreach (Song sog in songsDB.Songs)
                    {
                        if (sog.Location == opener.FileName)
                        {
                            MessageBox.Show("Song is already in the database.");
                            return;
                        }
                    }
                    Song song = new Song();
                    song.Name = title;
                    song.Location = opener.FileName;

                    songsDB.Songs.InsertOnSubmit(song);
                    songsDB.SubmitChanges();
                    //MessageBox.Show("Title: " + title);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
