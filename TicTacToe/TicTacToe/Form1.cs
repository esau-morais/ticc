using System;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAgainstComputer_Click_1(object sender, EventArgs e)
        {
            var formSideSelection = new FormSideSelection(true);
            formSideSelection.ShowDialog();
            Hide();
        }

        private void buttonAgainstFriend_Click_1(object sender, EventArgs e)
        {
            var formSideSelection = new FormSideSelection(false);
            formSideSelection.ShowDialog();
            Hide();
        }
    }
}
