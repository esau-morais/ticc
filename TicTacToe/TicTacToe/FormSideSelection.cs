using System;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class FormSideSelection : Form
    {
        private readonly bool againstComputer;

        public FormSideSelection(bool againstComputer)
        {
            InitializeComponent();
            this.againstComputer = againstComputer;
        }

        private void StartGame(char side)
        {
            char computerSide = (side == 'X') ? 'O' : 'X';
            var formGame = new FormGame(againstComputer, side, computerSide);
            formGame.Show();
            Hide();
        }

        private void buttonX_Click_1(object sender, EventArgs e)
        {
            StartGame('X');
        }

        private void buttonO_Click_1(object sender, EventArgs e)
        {
            StartGame('O');
        }
    }
}
