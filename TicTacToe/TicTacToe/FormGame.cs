using System;
using System.Linq;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class FormGame : Form
    {
        private char currentPlayer;
        private char[] board;
        private Button[] buttons;
        private bool againstComputer;
        private char playerSide;

        private char computerSide;

        public FormGame(bool againstComputer, char playerSide, char computerSide)
        {
            InitializeComponent();
            this.againstComputer = againstComputer;

            // Update playerSide and computerSide based on selected sides
            this.playerSide = playerSide;
            this.computerSide = computerSide;

            InitializeGame();
        }

        private void InitializeGame()
        {
            currentPlayer = 'X';
            board = new char[9];
            buttons = new Button[9] { button1, button2, button3, button4, button5, button6, button7, button8, button9 };

            // Update labels
            labelPlayer.Text = "You are: " + playerSide;
            labelComputer.Text = "Computer is: " + computerSide;
            labelTurn.Text = "Current Turn: " + currentPlayer;

            for (int i = 0; i < board.Length; i++)
            {
                board[i] = ' ';
                buttons[i].Text = "";
                buttons[i].Enabled = true;
                buttons[i].Click -= Button_Click; // Unsubscribe the event handler if already subscribed
                buttons[i].Click += Button_Click; // Subscribe the event handler
            }

            if (againstComputer && currentPlayer != playerSide)
            {
                MakeComputerMove();
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int index = Array.IndexOf(buttons, button);

            if (board[index] == ' ')
            {
                board[index] = currentPlayer;
                button.Text = currentPlayer.ToString();
                button.Enabled = false;

                if (CheckForWinner()) return;

                currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
                labelTurn.Text = "Current Turn: " + currentPlayer;

                if (againstComputer && currentPlayer == computerSide && !board.All(cell => cell != ' '))
                {
                    MakeComputerMove();
                }
            }
        }

        private void MakeComputerMove()
        {
            if (CheckForWinner() || currentPlayer == playerSide) return;

            int index = FindBestMove();
            if (index != -1)
            {
                board[index] = currentPlayer;
                buttons[index].Text = currentPlayer.ToString();
                buttons[index].Enabled = false;
                if (CheckForWinner()) return;
            }

            currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
            labelTurn.Text = "Current Turn: " + currentPlayer;
        }

        private int FindBestMove()
        {
            int bestScore = int.MinValue;
            int bestMove = -1;

            for (int i = 0; i < board.Length; i++)
            {
                if (board[i] == ' ')
                {
                    board[i] = currentPlayer;
                    int score = Minimax(board, 0, false);
                    board[i] = ' ';

                    if (score > bestScore)
                    {
                        bestScore = score;
                        bestMove = i;
                    }
                }
            }

            return bestMove;
        }

        private int Minimax(char[] board, int depth, bool isMaximizing)
        {
            char opponent = (playerSide == 'X') ? 'O' : 'X';

            int score = Evaluate(board);
            if (score == 10)
            {
                return score - depth;
            }
            if (score == -10)
            {
                return score + depth;
            }
            if (!board.Any(cell => cell == ' '))
            {
                return 0;
            }

            if (isMaximizing)
            {
                int bestScore = int.MinValue;
                for (int i = 0; i < board.Length; i++)
                {
                    if (board[i] == ' ')
                    {
                        board[i] = currentPlayer;
                        int currentScore = Minimax(board, depth + 1, !isMaximizing);
                        board[i] = ' ';
                        bestScore = Math.Max(bestScore, currentScore);
                    }
                }
                return bestScore;
            }
            else
            {
                int bestScore = int.MaxValue;
                for (int i = 0; i < board.Length; i++)
                {
                    if (board[i] == ' ')
                    {
                        board[i] = opponent;
                        int currentScore = Minimax(board, depth + 1, !isMaximizing);
                        board[i] = ' ';
                        bestScore = Math.Min(bestScore, currentScore);
                    }
                }
                return bestScore;
            }
        }

        private int Evaluate(char[] board)
        {
            int[][] winningLines = new int[][]
            {
                new int[] { 0, 1, 2 },
                new int[] { 3, 4, 5 },
                new int[] { 6, 7, 8 },
                new int[] { 0, 3, 6 },
                new int[] { 1, 4, 7 },
                new int[] { 2, 5, 8 },
                new int[] { 0, 4, 8 },
                new int[] { 2, 4, 6 }
            };

            foreach (var line in winningLines)
            {
                if (board[line[0]] == board[line[1]] && board[line[1]] == board[line[2]])
                {
                    if (board[line[0]] == playerSide)
                    {
                        return 10;
                    }
                    else if (board[line[0]] != ' ')
                    {
                        return -10;
                    }
                }
            }

            return 0;
        }

        private bool CheckForWinner()
        {
            if (CheckLine(0, 1, 2) || CheckLine(3, 4, 5) || CheckLine(6, 7, 8) ||
                CheckLine(0, 3, 6) || CheckLine(1, 4, 7) || CheckLine(2, 5, 8) ||
                CheckLine(0, 4, 8) || CheckLine(2, 4, 6))
            {
                string resultMessage = currentPlayer + " wins!";
                ShowGameResult(resultMessage);
                return true;
            }
            else if (!board.Any(cell => cell == ' '))
            {
                string resultMessage = "It's a tie!";
                ShowGameResult(resultMessage);
                return true;
            }
            return false;
        }

        private bool CheckLine(int a, int b, int c)
        {
            return board[a] != ' ' && board[a] == board[b] && board[b] == board[c];
        }

        private void ShowGameResult(string resultMessage)
        {
            MessageBox.Show(resultMessage, "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var dialogResult = MessageBox.Show("Do you want to play again?", "Play Again", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                var formSideSelection = new FormSideSelection(againstComputer);
                formSideSelection.ShowDialog();
                Close();
            }
            else
            {
                Close();
            }
        }

        private void FormGame_Load(object sender, EventArgs e)
        {
            InitializeGame();
        }
    }
}
