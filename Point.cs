using System;

namespace projetCube
{
    public class Point
    {
        // coordonées
        private double x;
        private double y;
        private double z;

        // constructeur par défaut qui initialise les points à zéro
        public Point()
        {
            x = 0;
            y = 0;
            z = 0;

        }
        // constructeur fixant les valeurs des trois coordonnées à partir des
        //coordonnées données en paramètre d'entrée du constructeur ;

        public Point(double x, double y, double z)
        {

            this.x = x;
            this.y = y;
            this.z = z;

        }

        //constructeur de recopie
        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            z = p.z;
        }




        public String toString()
        {
            return "x = " + x + " " + "y =" + y + " " + "z =" + z;
        }

        //Surdéfinir les opérateurs + et ==
        //addition de deux points donnés en entrée donne un point en sortie

        public static Point operator +(Point c1, Point c2) => new Point(c1.x + c2.x, c1.y + c2.y, c1.z + c2.z);

        //Le test d'égalité entre deux points donnés
        //en entrée donne un booléen en sortie.

        public static bool operator ==(Point p1, Point p2)
        {
            bool statut = false;
            if (p1.x == p2.x && p1.y == p2.y && p1.z == p2.z)
            {
                statut = true;
            }
            return statut;
        }

        public static bool operator !=(Point p1, Point p2)
        {
            bool status = false;

            if (p1.x != p2.x || p1.y != p2.y || p1.z != p2.z)
            {
                status = true;
            }
            return status;
        }

        //afficher nombres complexes
        public override string ToString()
        {
            return $"{this.x} + {this.y} +{this.z} ";
        }

        //La fonction rotation

        public void Rotation(double alpha, double beta, double gamma)
        {

            const double PI = 3.14;

            alpha = alpha * PI / 180.0;
            beta = beta * PI / 180.0;
            gamma = gamma * PI / 180.0;

            // selon x

            y = (short)(Math.Cos(alpha) * y - Math.Sin(alpha) * z);
            z = (short)(Math.Sin(alpha) * y + Math.Cos(alpha) * z);

            // selon y

            x = (short)(Math.Cos(beta) * x + Math.Sin(beta) * z);
            z = (short)(-Math.Sin(beta) * x + Math.Cos(beta) * z);

            // selon z

            x = (short)(Math.Cos(gamma) * x - Math.Sin(gamma) * y);
            y = (short)(Math.Sin(gamma) * x + Math.Cos(gamma) * y);
        }

        //translation d'un point

        //homothétie d'un point


        // Getter et setter

        public double X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;

            }
        }

        public double Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;

            }
        }

        public double Z
        {
            get
            {
                return z;
            }
            set
            {
                z = value;

            }
        }

        //fonctions qui nous retournent respectivement les points voisins




    }
}
