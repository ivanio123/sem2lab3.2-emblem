using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace sem2lab3_2
{
    class CEmblem
    {
        const int DefaultRadius = 50;
        private Graphics graphics;
        private int _radius;
        public bool isNotRotated;
        public int X { get; set; }
        public int Y { get; set; }
        public int Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                _radius = value >= 200 ? 200 : value;
                _radius = value <= 5 ? 5 : value;
            }
        }

        public CEmblem(Graphics graphics, int X, int Y)
        {
            this.graphics = graphics;
            this.X = X;
            this.Y = Y;
            this.Radius = DefaultRadius;
        }

        public CEmblem(Graphics graphics, int X, int Y, int Radius)
        {
            this.graphics = graphics;
            this.X = X;
            this.Y = Y;
            this.Radius = Radius;
        }

        private void Draw(Pen pen)
        {
            isNotRotated = true;
            Rectangle rectangle = new Rectangle(X - Radius, Y - Radius, 2 * Radius, 2 * Radius);
            Rectangle rectangle1 = new Rectangle(X - (Radius*2), Y - (Radius*2), 4 * Radius, 4 * Radius);
            using (GraphicsPath myPath2 = new GraphicsPath())
            {
                myPath2.AddLines(new[]
                {
                    new Point(rectangle.X - (Radius*3/4), rectangle.Y + (rectangle.Height)),
                    new Point(rectangle.X + (rectangle.Width/2), rectangle.Y - (Radius)),
                    new Point(rectangle.X + rectangle.Width + (Radius / 4 * 3), rectangle.Y + (rectangle.Height)),
                    new Point(rectangle.X - (Radius*3/4), rectangle.Y + (rectangle.Height)),
                });
                graphics.DrawPath(pen, myPath2);
            }

            
           
            graphics.DrawEllipse(pen, rectangle);
            graphics.DrawEllipse(pen, rectangle1);
        }

        public void Show()
        {
            Draw(Pens.Red);
        }

        public void Hide()
        {
            Draw(Pens.White);
        }
        public void Expand()
        {
            Hide();
            Radius++;
            Show();
        }
        public void Expand(int dR)
        {
            Hide();
            Radius = Radius + dR;
            Show();
        }
        public void Collapse()
        {
            Hide();
            Radius--;
            Show();
        }

        public void Collapse(int dR)
        {
            Hide();
            Radius = Radius - dR;
            Show();
        }
        public void Move(int dX, int dY)
        {
            Hide();
            if (X + Radius >= 0 && X + Radius <= 520 && Y - 2*Radius >= 0 && Y + Radius <= 400)
            {
                X = X + dX;
                Y = Y + dY;
            }
            else
            {
                MessageBox.Show("End");
            }
            Show();
        }
        public void Rotate(Pen pen)
        {
            isNotRotated = false;
            Rectangle rectangle = new Rectangle(X - Radius, Y - Radius, 2 * Radius, 2 * Radius);
            Rectangle rectangle1 = new Rectangle(X - (Radius * 2), Y - (Radius * 2), 4 * Radius, 4 * Radius);
            using (GraphicsPath myPath2 = new GraphicsPath())
            {
                myPath2.AddLines(new[]
                {
                    new Point(rectangle.X - (Radius*3/4), rectangle.Y + (rectangle.Height)),
                    new Point(rectangle.X + (rectangle.Width/2), rectangle.Y - (Radius)),
                    new Point(rectangle.X + rectangle.Width + (Radius / 4 * 3), rectangle.Y + (rectangle.Height)),
                    new Point(rectangle.X - (Radius*3/4), rectangle.Y + (rectangle.Height)),
                });
                graphics.DrawPath(pen, myPath2);
            }
            graphics.DrawEllipse(pen, rectangle);
            graphics.DrawEllipse(pen, rectangle1);
        }
    }
}