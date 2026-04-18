using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using exercise_picturebox.Properties;

namespace exercise_picturebox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        enPlayer PlayerTurn = enPlayer.Player1;
        enum enPlayer
        {
            Player1,
            Player2
        }
        enum enWinner
        {
            Player1,
            Player2,
            Draw,
            GameInProgess
        } 
        struct stGameStatus
        {
            public enWinner Winner;
            public bool GameOver;
            public short PlayCount;
        }
        stGameStatus GameStatus;
        void EndGame()
        {
            lblTurn.Text = "Game Over";
            switch(GameStatus.Winner)
            {
                case enWinner.Player1:
                    
                    lblWinner.Text = "Player1";
                    break;

                case enWinner.Player2:
                    lblWinner.Text = "Player2";
                    break;

                default:
                    lblWinner.Text = "Draw";
                    break;
            }
            MessageBox.Show("Game Over","Game Over",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        public bool CheckValue(Button btn1,Button btn2,Button btn3)
        {
            if (btn1.Tag.ToString()!= "?" && btn1.Tag.ToString() == btn2.Tag.ToString() && btn1.Tag.ToString() == btn3.Tag.ToString())
            {
                btn1.BackColor = Color.GreenYellow;
                btn2.BackColor = Color.GreenYellow;
                btn3.BackColor = Color.GreenYellow;

                if (btn1.Tag.ToString() == "X")
                {
                    GameStatus.Winner = enWinner.Player1;
                    GameStatus.GameOver = true;
                    EndGame();
                    return true;
                }
                else
                {
                    GameStatus.Winner = enWinner.Player2;
                    GameStatus.GameOver = true;
                    EndGame();
                    return true;
                }
            }
            GameStatus.GameOver = false;
            return false;

        }
        public void CheckWinner()
        {
            //Row 1
            if (CheckValue(btn1, btn2, btn3))
                return;

            //Row 2
            if (CheckValue(btn4, btn5, btn6))
                return;

            //Row 3
            if (CheckValue(btn7, btn8, btn9))
                return;

            //col 1
            if (CheckValue(btn1, btn4, btn7))
                return;

            //col 2
            if (CheckValue(btn2, btn5, btn8))
                return;

            //col 3
            if (CheckValue(btn3, btn6, btn9))
                return;

            //Diagonal 1
            if (CheckValue(btn1, btn5, btn9))
                return;

            //Diagonal 2
            if (CheckValue(btn3, btn5, btn7))
                return;
        }

        public void ChangeImage(Button btn)
        {

            if (btn.Tag.ToString() == "?")
            {
                switch (PlayerTurn)

                {
                    case enPlayer.Player1:
                        btn.Image = Resources.X;
                        PlayerTurn = enPlayer.Player2;
                        lblTurn.Text = "Player 2";
                        GameStatus.PlayCount++;
                        btn.Tag = "X";
                        CheckWinner();
                        break;

                    case enPlayer.Player2:
                        btn.Image = Resources.O;
                        PlayerTurn = enPlayer.Player1;
                        lblTurn.Text = "Player 1";
                        GameStatus.PlayCount++;
                        btn.Tag = "O";
                        CheckWinner();
                        break;
                }                
            }
            else
            {
                MessageBox.Show("Wrong Choice", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (GameStatus.PlayCount == 9)
            {
                GameStatus.GameOver = true;
                GameStatus.Winner = enWinner.Draw;
                EndGame();
            }

        }
        private void ResetButton(Button btn)
        {
            btn.Image = Resources.question_mark_96;
            btn.BackColor = Color.Transparent;
            btn.Tag = "?";
        }   
        private void RestartGame()
        {
            ResetButton(btn1);
            ResetButton(btn2);
            ResetButton(btn3);
            ResetButton(btn4);
            ResetButton(btn5);
            ResetButton(btn6);
            ResetButton(btn7);
            ResetButton(btn8);
            ResetButton(btn9);

            PlayerTurn = enPlayer.Player1;
            lblTurn.Text = "Player 1";
            GameStatus.PlayCount = 0;
            GameStatus.GameOver = false;
            GameStatus.Winner = enWinner.GameInProgess;
            lblWinner.Text = "In Progress";
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
           

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
           

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
              Color white = Color.FromArgb(255, 255, 255, 255);

            Pen WhitePen = new Pen(white);
            WhitePen.Width = 10;

            // Pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            WhitePen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            WhitePen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
       
            e.Graphics.DrawLine(WhitePen, 350, 90, 350, 320);
            e.Graphics.DrawLine(WhitePen, 500, 90, 500, 320);

            e.Graphics.DrawLine(WhitePen, 250, 150, 600, 150);


            e.Graphics.DrawLine(WhitePen, 250, 250, 600, 250);

            //e.Graphics.DrawRectangle(Pen,200, 200,300,300);
            //e.Graphics.DrawEllipse(Pen, 200, 50, 100, 120);
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
         
        }
        private void btn_Click(object sender, EventArgs e)
        {
            ChangeImage((Button)sender);
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            RestartGame();
        }
    }
}
