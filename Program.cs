using System;

namespace projetCube
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test des constructeurs");
            Console.WriteLine("********************************************************************************");


            Point p1 = new Point();
            Point p2 = new Point(2, 3, 1);
            Point p3 = new Point(p2);

            Console.WriteLine(p1.toString());
            Console.WriteLine(p2.toString());
            Console.WriteLine(p3.toString());


            /*MeshGeometry3D MCube()
            {
                MeshGeometry3D cube = new MeshGeometry3D();

                Point corners =
                    new Point();
                corners.Add(new Point(0.5, 0.5, 0.5));
                corners.Add(new Point3D(-0.5, 0.5, 0.5));
                corners.Add(new Point3D(-0.5, -0.5, 0.5));
                corners.Add(new Point3D(0.5, -0.5, 0.5));
                corners.Add(new Point3D(0.5, 0.5, -0.5));
                corners.Add(new Point3D(-0.5, 0.5, -0.5));
                corners.Add(new Point3D(-0.5, -0.5, -0.5));
                corners.Add(new Point3D(0.5, -0.5, -0.5));

                cube.Positions = corners;*/
            
        }
    }
}
