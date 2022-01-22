using System;
using System.Drawing;

namespace ballPhysics
{
    public partial class Form1
    {
        private class Ball
        {
            private double xBallLocation { get; set; }
            private double yBallLocation { get; set; }
            private double ballRadius { get; set; }
            private double dxSpeed { get; set; }
            private double dySpeed { get; set; }
            public double GravityCoef { get => gravityCoef; set => gravityCoef = value; }
            public double SystemFrictionCoef { get => systemFrictionCoef; set => systemFrictionCoef = value; }
            public double ObjectsGravityCoef { get => objectsGravityCoef; set => objectsGravityCoef = value; }
            public double CubicКepulsionCoef { get => cubicКepulsionCoef; set => cubicКepulsionCoef = value; }

            private const int MAX_SPEED = 50;
            private double gravityCoef = 0.0; // коэффициент гравитации  
            private double systemFrictionCoef = 0.0; // замедления системмы
            private double objectsGravityCoef = 500; // коэффициент гравитации между объектами 
            private double cubicКepulsionCoef = 20000; // коэффициент  отталкивания 
            public Ball(int radius, Random rand)
            {
                ballRadius = radius;
                xBallLocation = rand.Next(200, 400);
                yBallLocation = rand.Next(50, 400);
                dxSpeed = rand.Next(-2, 3);
                dySpeed = rand.Next(-2, 3);
            }
            public Ball(int rad, int X, int Y, int dx, int dy)
            {
                ballRadius = rad;
                xBallLocation = X;
                yBallLocation = Y;
                dxSpeed = dx;
                dySpeed = dy;
            }
             
            public void drawBall(Graphics graphic, Pen pen)
            {
                graphic.DrawEllipse(pen, (float)(xBallLocation - (ballRadius)), (float)(yBallLocation - (ballRadius)), (float)ballRadius * 2, (float)ballRadius * 2);
            }

            //рассчет траектории
            public void ballMoving(int width, int height)
            {
                if ((xBallLocation + ballRadius > width))
                {
                    dxSpeed = -dxSpeed;
                    xBallLocation = width - ballRadius;
                }
                else if ((xBallLocation - ballRadius < 0))
                {
                    dxSpeed = -dxSpeed;
                    xBallLocation = ballRadius;
                }
                if ((yBallLocation - ballRadius < 0))
                {
                    dySpeed = -dySpeed;
                    yBallLocation = ballRadius;
                }
                else if ((yBallLocation + ballRadius > height))
                {
                    dySpeed = -dySpeed;
                    yBallLocation = height - ballRadius;
                }
                xBallLocation += dxSpeed;
                yBallLocation += dySpeed;

            }
            // соударение шаров друг с другом
            public void ballsCollisions(Ball ball2)
            {
                double Dx = xBallLocation - ball2.xBallLocation;
                double Dy = yBallLocation - ball2.yBallLocation;
                double d = Math.Sqrt(Dx * Dx + Dy * Dy); if (d == 0) d = 0.01F;
                double sin = Dx / d;
                double cos = Dy / d;
                if (d < ballRadius + ball2.ballRadius) // если сумма радиусов меньше гипотенузе, то было столкновение
                {
                    double Vn1 = ball2.dxSpeed * sin + ball2.dySpeed * cos;
                    double Vn2 = dxSpeed * sin + dySpeed * cos;
                    double dt = (ball2.ballRadius + ballRadius - d) / (Vn1 - Vn2);
                    if (dt > 0.6) dt = 0.6F;
                    if (dt < -0.6) dt = -0.6F;
                    xBallLocation -= dxSpeed * dt;
                    yBallLocation -= dySpeed * dt;
                    ball2.xBallLocation -= ball2.dxSpeed * dt;
                    ball2.yBallLocation -= ball2.dySpeed * dt;
                    Dx = xBallLocation - ball2.xBallLocation;
                    Dy = yBallLocation - ball2.yBallLocation;
                    d = Math.Sqrt(Dx * Dx + Dy * Dy); if (d == 0) d = 0.01;
                    sin = Dx / d;
                    cos = Dy / d;
                    Vn1 = ball2.dxSpeed * sin + ball2.dySpeed * cos;
                    Vn2 = dxSpeed * sin + dySpeed * cos;
                    double Vt1 = -ball2.dxSpeed * cos + ball2.dySpeed * sin;
                    double Vt2 = -dxSpeed * cos + dySpeed * sin;

                    double o = Vn2;
                    Vn2 = Vn1;
                    Vn1 = o;

                    dxSpeed = (Vn2 * sin - Vt2 * cos);
                    dySpeed = (Vn2 * cos + Vt2 * sin);
                    ball2.dxSpeed = (Vn1 * sin - Vt1 * cos);
                    ball2.dySpeed = (Vn1 * cos + Vt1 * sin);
                    xBallLocation += dxSpeed * dt;
                    yBallLocation += dySpeed * dt;
                    ball2.xBallLocation += ball2.dxSpeed * dt;
                    ball2.yBallLocation += ball2.dySpeed * dt;
                }

            }


            public void differentForces(Ball ball2)
            {
                double Dx = xBallLocation - ball2.xBallLocation;
                double Dy = yBallLocation - ball2.yBallLocation;
                double d = Math.Sqrt(Dx * Dx + Dy * Dy); if (d == 0) d = 0.01F;
                double sin = Dx / d; 
                double cos = Dy / d;

                //double Vn1 = ball2.dxSpeed * s + ball2.dySpeed * e;
                double Vn2 = dxSpeed * sin + dySpeed * cos;
                //double Vt1 =  -ball2.dxSpeed * e + ball2.dySpeed * s;
                double Vt2 = -dxSpeed * cos + dySpeed * sin;
                 

                double dd = d + 20;
                Vn2 = Vn2 - (1 / ((dd * dd) + 1)) * ObjectsGravityCoef;
                //Vn1 = Vn1 + (1 / ((dd * dd) + 1)) * gravityCoefficient;// работающее притяжение

                Vn2 = Vn2 + (1 / (Math.Abs(dd * dd * dd) + 1)) * CubicКepulsionCoef;
                //Vn1 = Vn1 - (1 / (Math.Abs(dd * dd * dd) + 1)) * cubicКepulsion;  // работающее отталкивание

                dxSpeed = (Vn2 * sin - Vt2 * cos);
                dySpeed = (Vn2 * cos + Vt2 * sin);

                ball2.dxSpeed = ball2.dxSpeed - ball2.dxSpeed / (d + 1) * SystemFrictionCoef;
                ball2.dySpeed = ball2.dySpeed - ball2.dySpeed / (d + 1) * SystemFrictionCoef;// трение вблизи друг друга

                if (ball2.dxSpeed > MAX_SPEED)
                    ball2.dxSpeed = MAX_SPEED;
                if (ball2.dxSpeed < -MAX_SPEED)
                    ball2.dxSpeed = -MAX_SPEED;
                if (ball2.dySpeed > MAX_SPEED)
                    ball2.dySpeed = MAX_SPEED;
                if (ball2.dySpeed < -MAX_SPEED)
                    ball2.dySpeed = -MAX_SPEED;
            }
            internal void gravitation()
            {
                dySpeed += 1 * GravityCoef;
            }
        }
    }
}
