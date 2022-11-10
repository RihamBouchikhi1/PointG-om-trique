using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointGéométrique
{
    internal class Program
    {
        static void Main(string[] args)
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
             Console.WriteLine("la distance entre ces deux points est :" + Distance(P1, P2));
            //____Egalité____//
            Egale(P1, P2);
            //_____Translation___//
            Translation(P1);
            //____Linéarité____//
             Linearite(P1, P2, P3);


        }


    }
}
