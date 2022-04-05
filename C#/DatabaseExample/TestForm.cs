using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace DatabaseExample
{
    public partial class TestForm : Form
    {

        LINQ_ClassesDataContext songsDB = new LINQ_ClassesDataContext();
        SoundPlayer player = new SoundPlayer();
        public TestForm()
        {
            InitializeComponent();
        }

        private void testForm_Load(object sender, EventArgs e)
        {
            
            foreach(Song song in songsDB.Songs)
            {
                songsListBox.Items.Add(song.Name);
            }

        }

        private void backBtn_Click(object sender, EventArgs e)
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

        private void playBtn_Click(object sender, EventArgs e)
        {
            foreach (Song song in songsDB.Songs)
            {
                if (songsListBox.SelectedItem.ToString() == song.Name)
                {
                    player.SoundLocation = song.Location;
                    player.Play();
                }
            }
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            player.Stop();
        }
    }
}
