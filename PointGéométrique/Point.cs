using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointGéométrique
{
    internal class Point
    {
        private  float x,y;
        public Point(float x = 0, float y = 0)
        {
            this.x = x;
            this.y = y;
        }
        public void set_x(float x)
        {
            this.x = x;
        }
        public float get_x()
        {
            return x;
        }
        public void set_y(float y)
        {
            this.y = y;
        }
        public float get_y()
        {
            return y;
        }
        void translation(float N)
        {
            x += N;
            y += N;
        }
        void Egale(Point p)
        {
            if (x == p.x && y == p.y)
                Console.Write("les deux points sont égaux");
            else
                Console.Write("les deux points ne sont pas égaux");
        }
        double distance(Point p)
        {
            return Math.Sqrt(Math.Pow(x - p.x, 2) +Math.Pow(y - p.y, 2));
        }
    }
}
