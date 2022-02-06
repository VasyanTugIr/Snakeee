using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snakeee
{

    public partial class Form1 : Form
    {
        public List<Circle> snake = new List<Circle>();
        public Circle Food = new Circle();
        PictureBox[] walls;


        public Form1()
        {
            InitializeComponent();
            walls = new PictureBox[] { wall1, wall2, wall3, wall4 };
            new Settings();
            timer1.Interval = 1000 / Settings.speeeed;
            timer1.Tick += UpdateScreen;
            timer1.Start();
            StartGame();
            
        }

        public void StartGame()
        {
            lblGameOver.Visible = false;
            new Settings();
            snake.Clear();
            Circle Head = new Circle();
            Head.X = 10;
            Head.Y = 10;
            snake.Add(Head);
            schet.Text = Settings.score.ToString();
            GenerateFood();
        }

        public void GenerateFood()
        {

            int X = pbCanvas.Width / Settings.width;
            int Y = pbCanvas.Height / Settings.heigth;
            Random random = new Random();
            int X2 = random.Next(0, X);
            int Y2 = random.Next(0, Y);
            Circle food = new Circle(X2, Y2);
            while (check_intersections(food))
            {
                food.X = random.Next(0, X);
                food.Y = random.Next(0, Y);

            }
            Food = food;
        }

        public void UpdateScreen(object sender, EventArgs e)
        {
            if (!Settings.GameOver)
            {
                MovePlayer();
            }
            pbCanvas.Invalidate();
            
        }

        public void MovePlayer()
        {
            for (int i = snake.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    switch (Settings.direction)
                    {
                        case Directions.Right:
                            snake[i].X++;
                            break;
                        case Directions.Left:
                            snake[i].X--;
                            break;
                        case Directions.Up:
                            snake[i].Y--;
                            break;
                        case Directions.Down:
                            snake[i].Y++;
                            break;
                    }
                    int X = snake[i].X;
                    int Y = snake[i].Y;
                    int MaxX = pbCanvas.Width / Settings.width;
                    int MaxY = pbCanvas.Height / Settings.heigth;
                    if (X < 0 || X > MaxX || Y < 0 || Y > MaxY)
                    {
                        Die();

                    }
                    for (int j = 1; j < snake.Count; j++)
                    {
                        if (X == snake[j].X && Y == snake[j].Y)
                        {
                            Die();
                        }
                    }
                    if (check_intersections(snake[0]))
                    {
                        Die();

                    }

                    if (X == Food.X && Y == Food.Y)
                    {
                        Eat();
                    }
                }

                else
                {
                    snake[i].X = snake[i - 1].X;
                    snake[i].Y = snake[i - 1].Y;
                }
            }

        }

        public void Die()
        {
            Settings.GameOver = true;
        }

        public void Eat()
        {
            Circle last = snake.Last();
            int X2 = last.X;
            int Y2 = last.Y;
            Circle Tail = new Circle(X2, Y2);
            snake.Add(Tail);
            Settings.score += Settings.points;
            schet.Text = Settings.score.ToString();
            GenerateFood();
        }

        private void pbCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            if (!Settings.GameOver)
            {
                Brush snakeColor;
                for (int i = 0; i < snake.Count; i++)
                {
                    if (i == 0)
                    {
                        snakeColor = Brushes.DarkBlue;
                    }
                    else
                    {
                        snakeColor = Brushes.Goldenrod;
                    }
                    canvas.FillEllipse(snakeColor, new Rectangle(snake[i].X * Settings.width, snake[i].Y * Settings.heigth, Settings.width, Settings.heigth));
                }
                canvas.FillEllipse(Brushes.IndianRed, new Rectangle(Food.X * Settings.width, Food.Y * Settings.heigth, Settings.width, Settings.heigth));
            }
            else
            {
                lblGameOver.Visible = true;
                lblGameOver.Text = $"Ты проиграл! \nТвой счёт {Settings.score}. Нажми Enter чтобы продолжить";
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!Settings.GameOver)
            {
                switch (e.KeyCode)
                {
                    case Keys.Left:
                        if (Settings.direction != Directions.Right)
                        {
                            Settings.direction = Directions.Left;
                        }
                        break;
                    case Keys.Right:
                        if (Settings.direction != Directions.Left)
                        {
                            Settings.direction = Directions.Right;
                        }
                        break;

                    case Keys.Up:
                        if (Settings.direction != Directions.Down)
                        {
                            Settings.direction = Directions.Up;
                        }
                        break;
                    case Keys.Down:
                        if (Settings.direction != Directions.Up)
                        {
                            Settings.direction = Directions.Down;
                        }
                        break;

                }
            }
            else
            {
                if (e.KeyCode == Keys.Enter)
                {
                    StartGame();
                }
            }
        }

        bool check_intersections(Circle circle)
        {
            Rectangle HitBox = new Rectangle(circle.X * Settings.width, circle.Y * Settings.heigth, Settings.width, Settings.heigth);
            HitBox.X += pbCanvas.Location.X;
            HitBox.Y += pbCanvas.Location.Y;
            foreach (var wall in walls)
            {
                if (HitBox.IntersectsWith(wall.Bounds))
                {
                    return true;
                }

            }
            return false;
        }
    }
}
