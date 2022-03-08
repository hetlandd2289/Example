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
    public partial class Bruhtha : Form
    {
        public Bruhtha()
        {
            InitializeComponent();
        }

        private void bruhBtn_Click(object sender, EventArgs e)
        {
            ExampleForm bruh = new ExampleForm();
            this.Hide();
            bruh.ShowDialog();
            this.Show();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ticTacToeBtn_Click(object sender, EventArgs e)
        {
            TicTacToeSimulator.TicTacToe ttt = new TicTacToeSimulator.TicTacToe();
            this.Hide();
            ttt.ShowDialog();
            this.Show();
        }

        private void blindManBluffBtn_Click(object sender, EventArgs e)
        {
            GuessingGame.BlindMansBluff bmb = new GuessingGame.BlindMansBluff();
            this.Hide();
            bmb.ShowDialog();
            this.Show();
        }

        private void rpsBtn_Click(object sender, EventArgs e)
        {
            RPSGame.rps rock = new RPSGame.rps();
            this.Hide();
            rock.ShowDialog();
            this.Show();
        }

        private void brableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.brableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.brableDataSet);

        }

        private void Bruhtha_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'brableDataSet.Brable' table. You can move, or remove it, as needed.
            this.brableTableAdapter.Fill(this.brableDataSet.Brable);

        }
    }
}
