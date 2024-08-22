namespace TicTacToe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonNewGame = new Button();
            lblTurn = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button5 = new Button();
            button9 = new Button();
            button8 = new Button();
            button6 = new Button();
            button4 = new Button();
            button7 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblPlayer1 = new Label();
            lblTies = new Label();
            lblPlayer2 = new Label();
            SuspendLayout();
            // 
            // buttonNewGame
            // 
            buttonNewGame.Location = new Point(315, 12);
            buttonNewGame.Name = "buttonNewGame";
            buttonNewGame.Size = new Size(129, 43);
            buttonNewGame.TabIndex = 0;
            buttonNewGame.Text = "NEW GAME";
            buttonNewGame.UseVisualStyleBackColor = true;
            buttonNewGame.Click += buttonNewGame_Click;
            // 
            // lblTurn
            // 
            lblTurn.AutoSize = true;
            lblTurn.Location = new Point(12, 23);
            lblTurn.Name = "lblTurn";
            lblTurn.Size = new Size(91, 20);
            lblTurn.TabIndex = 1;
            lblTurn.Text = "Player 1 turn";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 55F, FontStyle.Bold);
            button1.Location = new Point(12, 72);
            button1.Name = "button1";
            button1.Size = new Size(140, 140);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 55F, FontStyle.Bold);
            button2.Location = new Point(158, 72);
            button2.Name = "button2";
            button2.Size = new Size(140, 140);
            button2.TabIndex = 3;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 55F, FontStyle.Bold);
            button3.Location = new Point(304, 72);
            button3.Name = "button3";
            button3.Size = new Size(140, 140);
            button3.TabIndex = 4;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 55F, FontStyle.Bold);
            button5.Location = new Point(158, 218);
            button5.Name = "button5";
            button5.Size = new Size(140, 140);
            button5.TabIndex = 5;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 55F, FontStyle.Bold);
            button9.Location = new Point(304, 365);
            button9.Name = "button9";
            button9.Size = new Size(140, 140);
            button9.TabIndex = 6;
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 55F, FontStyle.Bold);
            button8.Location = new Point(158, 365);
            button8.Name = "button8";
            button8.Size = new Size(140, 140);
            button8.TabIndex = 7;
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 55F, FontStyle.Bold);
            button6.Location = new Point(304, 218);
            button6.Name = "button6";
            button6.Size = new Size(140, 140);
            button6.TabIndex = 8;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 55F, FontStyle.Bold);
            button4.Location = new Point(12, 218);
            button4.Name = "button4";
            button4.Size = new Size(140, 140);
            button4.TabIndex = 9;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 55F, FontStyle.Bold);
            button7.Location = new Point(12, 365);
            button7.Name = "button7";
            button7.Size = new Size(140, 140);
            button7.TabIndex = 10;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(12, 518);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 11;
            label1.Text = "Player 1 wins:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(304, 518);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 12;
            label2.Text = "Player 2 wins:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(189, 518);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 13;
            label3.Text = "Ties:";
            // 
            // lblPlayer1
            // 
            lblPlayer1.AutoSize = true;
            lblPlayer1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPlayer1.Location = new Point(123, 518);
            lblPlayer1.Name = "lblPlayer1";
            lblPlayer1.Size = new Size(18, 20);
            lblPlayer1.TabIndex = 14;
            lblPlayer1.Text = "0";
            // 
            // lblTies
            // 
            lblTies.AutoSize = true;
            lblTies.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTies.Location = new Point(236, 518);
            lblTies.Name = "lblTies";
            lblTies.Size = new Size(18, 20);
            lblTies.TabIndex = 15;
            lblTies.Text = "0";
            // 
            // lblPlayer2
            // 
            lblPlayer2.AutoSize = true;
            lblPlayer2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPlayer2.Location = new Point(415, 518);
            lblPlayer2.Name = "lblPlayer2";
            lblPlayer2.Size = new Size(18, 20);
            lblPlayer2.TabIndex = 16;
            lblPlayer2.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 553);
            Controls.Add(lblPlayer2);
            Controls.Add(lblTies);
            Controls.Add(lblPlayer1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button7);
            Controls.Add(button4);
            Controls.Add(button6);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lblTurn);
            Controls.Add(buttonNewGame);
            Name = "Form1";
            Text = "Tic Tac Toe";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonNewGame;
        private Label lblTurn;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button5;
        private Button button9;
        private Button button8;
        private Button button6;
        private Button button4;
        private Button button7;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblPlayer1;
        private Label lblTies;
        private Label lblPlayer2;
    }
}
