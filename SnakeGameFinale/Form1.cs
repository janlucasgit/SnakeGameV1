using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGameFinale
{
    public partial class Form1 : Form
    {
        private List<Circle> Snake = new List<Circle>();
        private Circle food = new Circle();
        int maxWidth;
        int maxHeight;

        Random rand = new Random();
        bool GoLeft, GoRight, GoUp, GoDown;



        public Form1()
        {
            InitializeComponent();

            new Settings();
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                GoLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                GoRight = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                GoUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                GoDown = false;
            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && Settings.directions != "right")
            {
                GoLeft = true;
            }
            if (e.KeyCode == Keys.Right && Settings.directions != "left")
            {
                GoRight = true;
            }
            if (e.KeyCode == Keys.Up && Settings.directions != "down")
            {
                GoUp = true;
            }
            if (e.KeyCode == Keys.Down && Settings.directions != "Up")
            {
                GoDown = true;
            }

        }

        private void StartGame(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void CancelGame(object sender, EventArgs e)
        {

        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            if (GoLeft)
            {
                Settings.directions = "left";
            }
            if (GoRight)
            {
                Settings.directions = "right";
            }
            if (GoUp)
            {
                Settings.directions = "up";
            }
            if (GoDown)
            {
                Settings.directions = "down";
            }

            for (int i = Snake.Count - 1; i >= 0; i--) //-1 weil man bei der Programmierung bei 0 anfängt zu zählen, deshalb wird - 1 immer der letzte Teil der Schlange sein
            {
                if (i == 0)
                {
                    switch (Settings.directions)
                    {
                        case "left":
                            Snake[i].X--;
                            break;
                        case "right":
                            Snake[i].X++;
                            break;
                        case "up":
                            Snake[i].Y--;
                            break;
                        case "down":
                            Snake[i].Y++;
                            break;
                    }

                    if (Snake[i].X < 0)
                    {
                        Snake[i].X = maxWidth;
                    }
                    if (Snake[i].X > maxWidth)
                    {
                        Snake[i].X = 0;
                    }
                    if (Snake[i].Y < 0)
                    {
                        Snake[i].Y = maxHeight;
                    }
                    if (Snake[i].Y > maxHeight)
                    {
                        Snake[i].Y = 0;
                    }
                

                //das macht man damit wenn die Schlange an dem Rand ankommt, auf der anderen Seite weiterschlängelt
                
                if(i > 0)
                {
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;
                }
            }

            background.Invalidate();

        }


    } 

        private void UpdatePictureBoxGraph(object sender, PaintEventArgs e)
        {
            Graphics background = e.Graphics;

            Brush snakeColour;

            for(int i = 0; i < Snake.Count; i++)
            {
                if (i == 0)
                {
                    snakeColour = Brushes.Black;
                }
                else
                {
                    snakeColour = Brushes.Green;
                }
                background.FillEllipse(snakeColour, new Rectangle(Snake[i].X * Settings.Width,
                Snake[i].Y * Settings.Height,
                Settings.Width, Settings.Height

                ));
            }

            background.FillEllipse(Brushes.DarkRed, new Rectangle
                (food.X * Settings.Width,
                food.Y * Settings.Height,
                Settings.Width, Settings.Height

                ));

        }

        private void score_Click(object sender, EventArgs e)
        {

        }

        private void RestartGame()
        {
            maxWidth = background.Width / Settings.Width - 1;
            maxHeight = background.Height / Settings.Height - 1;

            Snake.Clear();
            StartButton.Enabled = false;
            CancelButton.Enabled = false;
            score.Text = "0";                 
            Highscore.Text = "Score: 0";

            Circle head = new Circle { X = 10, Y = 5 };
            Snake.Add(head);
            for (int i = 0;  i < 10; i++)
            {
                Circle body = new Circle();
                Snake.Add(body);
            }

            food = new Circle 
            {
                
            X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) 
            
            };

            gametimer.Start();
        }

        private void EatFood()
        {

        }

        private void GameOver()
        {

        }


    }
}
