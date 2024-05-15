using System;
using System.Windows.Controls;
using System.Windows.Shapes;
using System.Windows.Media;

namespace Arkanoid_IT2
{
    public class Ball : GameObject
    {
        private double speedX;
        private double speedY;
        private int size;
        private Ellipse ellipse;

        public Ball(double initialX, double initialY, double initialSpeedX, double initialSpeedY, int ballSize)
        {
            Location = new System.Windows.Point(initialX, initialY);
            speedX = initialSpeedX;
            speedY = initialSpeedY;
            size = ballSize;
            ellipse = new Ellipse();
            ellipse.Fill = Brushes.White;
            ellipse.Width = size;
            ellipse.Height = size;
        }

        public override void Draw(Canvas canvas)
        {
            Canvas.SetLeft(ellipse, Location.X - size / 2);
            Canvas.SetTop(ellipse, Location.Y - size / 2);
            canvas.Children.Add(ellipse);
        }

        public void Move()
        {
            Location = new System.Windows.Point(Location.X + speedX, Location.Y + speedY);
        }

        public void ReflectX()
        {
            speedX *= -1;
        }

        public void ReflectY()
        {
            speedY *= -1;
        }
    }
}
