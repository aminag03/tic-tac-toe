namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Player 1 is X and Player 2 is O. Good luck!");
        }

        private int counter = 0;
        private string startSign = "X";
        private string followingSign = "O";
        private int player1Wins = 0;
        private int player2Wins = 0;
        private int ties = 0;
        private int gameCounter = 0;

        private void button_Reset(bool enabled = true, bool reset_Text = true, bool reset_Color = true)
        {
            foreach (var item in this.Controls)
            {
                if (item is Button)
                {
                    if ((item as Button) != buttonNewGame)
                        (item as Button).Enabled = enabled;
                }
            }

            foreach (var item in this.Controls)
            {
                if (item is Button)
                {
                    if ((item as Button) != buttonNewGame)
                    {
                        (item as Button).Enabled = enabled;
                        if (reset_Color)
                            (item as Button).BackColor = Color.White;
                        if (reset_Text)
                            (item as Button).Text = "";
                    }
                }
            }
        }

        private void select_Button(Button btn)
        {
            if (btn.Text == "")
            {
                btn.Text = counter % 2 == 0 ? startSign : followingSign;
                counter++;
            }

            if (end_Game())
            {
                var temp = startSign;
                startSign = followingSign;
                followingSign = temp;
                counter = 0;
                button_Reset(false, false, false);
                return;
            }

            if (gameCounter % 2 == 0)
            {
                if (counter % 2 == 0)
                    lblTurn.Text = "Player 1 turn";
                else
                    lblTurn.Text = "Player 2 turn";
            }
            else
            {
                if (counter % 2 == 0)
                    lblTurn.Text = "Player 2 turn";
                else
                    lblTurn.Text = "Player 1 turn";
            }
        }

        private bool check_Win(Button btn1, Button btn2, Button btn3)
        {
            if (btn1.Text != "" && btn1.Text == btn2.Text && btn2.Text == btn3.Text)
            {
                btn1.BackColor = Color.Red;
                btn2.BackColor = Color.Red;
                btn3.BackColor = Color.Red;

                if (btn1.Text == "X")
                {
                    MessageBox.Show("Player 1 won!");
                    player1Wins++;
                    lblPlayer1.Text = player1Wins.ToString();
                }
                else
                {
                    MessageBox.Show("Player 2 won!");
                    player2Wins++;
                    lblPlayer2.Text = player2Wins.ToString();
                }

                return true;
            }
            return false;
        }

        private bool end_Game()
        {
            if (check_Win(button1, button2, button3) ||
                check_Win(button4, button5, button6) ||
                check_Win(button7, button8, button9) ||
                check_Win(button1, button4, button7) ||
                check_Win(button2, button5, button8) ||
                check_Win(button3, button6, button9) ||
                check_Win(button1, button5, button9) ||
                check_Win(button3, button5, button7))
            {
                gameCounter++;
                return true;
            }

            if (button1.Text != "" &&
               button2.Text != "" &&
               button3.Text != "" &&
               button4.Text != "" &&
               button5.Text != "" &&
               button6.Text != "" &&
               button7.Text != "" &&
               button8.Text != "" &&
               button9.Text != "")
            {
                MessageBox.Show("It's a draw!");
                ties++;
                lblTies.Text = ties.ToString();
                gameCounter++;
                return true;
            }

            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            select_Button(button1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            select_Button(button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            select_Button(button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            select_Button(button4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            select_Button(button5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            select_Button(button6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            select_Button(button7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            select_Button(button8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            select_Button(button9);
        }

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            button_Reset();

            if (gameCounter % 2 == 0)
                lblTurn.Text = "Player 1 turn";
            else
                lblTurn.Text = "Player 2 turn";
        }
    }
}