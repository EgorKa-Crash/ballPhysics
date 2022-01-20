using System;
using System.Collections.Generic; 
using System.Drawing; 
using System.Windows.Forms;

namespace ballPhysics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        } 

        int razmer, kolvo;
        List<Ball> balls = new List<Ball>();
        Random rand = new Random(DateTime.Now.Millisecond);

        private void startModelingClick(object sender, EventArgs e)
        {
            frameTimer.Enabled = true;
            razmer = Convert.ToInt32(ballRadius.Text);
            kolvo = Convert.ToInt32(ballCount.Text);
            balls.Clear(); // Очищаем список шаров
            for (int i = 0; i < kolvo; i++)
            {
                balls.Add(new Ball(razmer, rand)); // Заполнение списка шаров
            }
        }
         
        private void timerTick(object sender, EventArgs e)
        {
            for (int i = 0; i < balls.Count; i++)
            {
                for (int j = 0; j < balls.Count; j++)
                {
                    if (i != j)
                    {
                        if (collisionsСheckBox.Checked)
                        {
                            balls[i].ballsCollisions(balls[j]);
                        }
                        balls[i].differentForces(balls[j]);
                    }
                }
                if (sequentialMovementСheckBox.Checked)
                {
                    balls[i].ballMoving(pictureBox1.Width, pictureBox1.Height); //скапливаются в кучи и шарахаются по полю
                }
                balls[i].gravitation();
            }

            if (!sequentialMovementСheckBox.Checked)
                foreach (Ball ball in balls)
                    ball.ballMoving(pictureBox1.Width, pictureBox1.Height);

            pictureBox1.Invalidate(); // Перерисовка

            valueReplacing(balls);
        }
         
        private void valueReplacing(List<Ball> balls)
        {
            for (int i = 0; i < balls.Count; i++)
            {
                balls[i].GravityCoef = (double)gravityK.Value / 500;
                balls[i].SystemFrictionCoef = (double)systemFriction.Value / 1000;
                balls[i].ObjectsGravityCoef = (double)objGravCoeffTrackBar.Value;
                balls[i].CubicКepulsionCoef = (double)cubicKepulsionTrackBar.Value * 100;
            }
        }

        private void speedScroll(object sender, EventArgs e)
        {
            frameTimer.Interval = (speed.Maximum + 1 - speed.Value); // (speed.Maximum + 1 - speed.Value)*10; // Скорость
        }

        Pen pen = new Pen(Color.Red);
        private void paint(object sender, PaintEventArgs e)
        {
            Graphics rg = e.Graphics;
            foreach (Ball ball in balls)
                ball.drawBall(rg, pen); 
        }
    }
}
