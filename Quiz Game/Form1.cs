using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_Game
{
    public partial class Form1 : Form
    {
        int correctAnswer, questionNum = 1;
        int score, percentage, totalQuestions;
        public Form1()
        {
            InitializeComponent();
            askQuestion(questionNum);
            totalQuestions = 5;
        }

        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender; //button pressed
            int buttonTag = Convert.ToInt32(senderObject.Tag); //gets answer
            if (buttonTag == correctAnswer)
            {
                score++;
            }
            if (questionNum == totalQuestions)
            {
                percentage = (int)Math.Round((double)score * 100 / totalQuestions);
                MessageBox.Show(
                    "Quiz Ended!" + Environment.NewLine +
                    "You have answered " + score + " questions correctly!." + Environment.NewLine +
                    "Your total percentage is " + percentage + "%" + Environment.NewLine +
                    "Click OK to play again."
                    );
                score = 0;
                questionNum = 0;
                askQuestion(questionNum);
            }
            questionNum++;
            askQuestion(questionNum);
        }

        private void askQuestion(int qNum)
        {
            switch(qNum)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.q1;
                    lblQuestion.Text = "What is (12+3)^2";
                    button1.Text = "255";
                    button2.Text = "225";
                    button3.Text = "220";
                    button4.Text = "230";
                    correctAnswer = 2; //button 2 tag
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.q2;
                    lblQuestion.Text = "What is the square root of 10000";
                    button1.Text = "10000";
                    button2.Text = "1000";
                    button3.Text = "10";
                    button4.Text = "100";
                    correctAnswer = 4;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.q3;
                    lblQuestion.Text = "What numbers are multiples of 40 and 90";
                    button1.Text = "1, 2, 3, 5, 6, 9, 10, 15, 18, 30, 45, and 90.";
                    button2.Text = "1, 2, 5, and 10";
                    button3.Text = "1, 2, 4, 5, 8, 10, 20, and 40";
                    button4.Text = "1, 2, 3, 4, 5, 6, 8, 9, 10, 15, 18, 20, 30, 40, 45, and 90.";
                    correctAnswer = 2;
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.q4;
                    lblQuestion.Text = "1000 / 0";
                    button1.Text = "undefined";
                    button2.Text = "0";
                    button3.Text = "1000";
                    button4.Text = "1";
                    correctAnswer = 1;
                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources.q4;
                    lblQuestion.Text = "5000/5+17-59";
                    button1.Text = "956";
                    button2.Text = "985";
                    button3.Text = "963";
                    button4.Text = "958";
                    correctAnswer = 4;
                    break;
            }
        }
    }
}
