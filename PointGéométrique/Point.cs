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
        public static void translation(Point P,float N)
        {
            P.x += N;
            P.y += N;
        }
        public static void Egale(Point p1, Point p2)
        {
            if (p1.x == p2.x && p1.y == p2.y)
                Console.Write("les deux points sont égaux");
            else
                Console.Write("les deux points ne sont pas égaux");
        }
        public static double distance(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(p1.x - p2.x, 2) +Math.Pow(p1.y - p2.y, 2));
        }
        public static void Linearite(Point A, Point B, Point C)
        {
            double a, b;
            if (A.x != B.x)
            {
                a = (A.y - B.y) / (A.x - B.x);
                b = A.y + a * A.x;   
                if (a * C.x + b == C.y)
                {
                    Console.WriteLine("les trois points sont lineaire");
                }
                else
                    Console.WriteLine("les trois points ne sont pas lineaire");
            }
        }

        public static void Main(string[] args)
        {
            Point P1 = new Point();
            Point P2 = new Point();
            Point P3 = new Point();


            Console.WriteLine("Entrez l'abscisse de 1ere point");
            float Xp1 = int.Parse(Console.ReadLine());
            P1.set_x(Xp1);

            Console.WriteLine("Entrez l'ordonnee de 1ere point");
            float Yp1 = int.Parse(Console.ReadLine());
            P1.set_y(Yp1);

            Console.WriteLine("Entrez l'abscisse de 2eme point");
            float Xp2 = int.Parse(Console.ReadLine());
            P2.set_x(Xp2);

            Console.WriteLine("Entrez l'ordonnee de 2eme point");
            float Yp2 = int.Parse(Console.ReadLine());
            P2.set_y(Yp2);

            Console.WriteLine("Entrez l'abscisse de 3eme point");
            float Xp3 = int.Parse(Console.ReadLine());
            P3.set_x(Xp3);

            Console.WriteLine("Entrez l'ordonnee de 3eme point");
            float Yp3 = int.Parse(Console.ReadLine());
            P3.set_y(Yp3);
            //______Distance_____//
            Console.WriteLine("la distance entre ces deux points est :" + distance(P1, P2));
            //____Egalité____//
            //Egale(P1, P2);
            //_____Translation___//
            //translation(P3,5);
            //____Linéarité____//
            //Linearite(P1, P2, P3);


        }
    }
}
