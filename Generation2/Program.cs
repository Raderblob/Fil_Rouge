using System;

namespace Generation
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Hello World!");

            Point a = new Point(1.0f, 1.0f);
            a.AfficherPoint();

            a.SetAbscissePoint(3.0f);
            a.AfficherPoint();

            Rectangle r = new Rectangle(1.0f, 1.0f,a);
            r.AfficherRectangle();

            r.SetLargeurRectangle(1.0f);
            r.SetPointAbscisseRectangle(5.0f);
            r.AfficherRectangle();

            a.AfficherPoint();

            //Point a = new Point(1.0f, 1.0f);

            //Rectangle r = new Rectangle(2.0f, 2.0f, a);
            
            a.AfficherPoint();
            r.AfficherRectangle();

            Point test1 = new Point(1.0f,1.0f);
            Point test2 = new Point(2.0f, 2.0f);
            Point test3 = new Point(3.0f, 3.0f);
            Point test4 = new Point(1.0f, 2.0f);

            Cercle c1 = new Cercle(1, test1);
            Cercle c2 = new Cercle(1, test2);
            Cercle c3 = new Cercle(1, test3);

            Rectangle r1 = new Rectangle(1, 1, test3);
            Rectangle r2 = new Rectangle(4, 3, test1);

            Console.WriteLine("Les Rectangles se touchent : " + r.AppartenanceRectangle(r1) + " " + r.AppartenanceRectangle(r2));

            Console.WriteLine("les cercles se touchent : " + c1.AppartenanceCercle(c1) + " " + c1.AppartenanceCercle(c3));
            Console.WriteLine("Le point appartient au cercle : " + c1.AppartenanceCercle(test1) + c1.AppartenanceCercle(test2));

            Console.WriteLine("dist : " + test1.DistancePoint(test2));

            Console.WriteLine("Le point appartient au rectangle ? " + r.AppartenanceRectangle(test1));
            Console.WriteLine("Le point appartient au rectangle ? " + r.AppartenanceRectangle(test2));
            Console.WriteLine("Le point appartient au rectangle ? " + r.AppartenanceRectangle(test3));
            Console.WriteLine("Le point appartient au rectangle ? " + r.AppartenanceRectangle(test4));

            Point b = new Point(-1.0f, 0.0f);
            Point c = new Point(0.0f, -1.0f);

            Rectangle test = new Rectangle(c, b);

            test.AfficherRectangle();*/

            /*Rectangle samuel = new Rectangle(1, 1, new Point(0, 0), 0);
            samuel.AfficherRectangle();
            Point Aurelien = new Point(0.5f, 0.5f);
            Console.WriteLine("Le point appartient au rectangle ? " + samuel.AppartenanceRectangle(Aurelien));
            samuel.Rotate(45);
            Console.WriteLine("Le point appartient au rectangle ? " + samuel.AppartenanceRectangle(Aurelien));
            samuel.AfficherRectangle();*/


            Monde m = new Monde(@"C:\Users\Samuel GUYETANT\Desktop\INSA 3IF\C#\VisualStudioProject\Generation2\index2.txt"); // full adresse : D:\Program Files (x86)\VisualStudio\Files\Fil_Rouge\Generation2\
            //m.ImageRead(@"D:\Program Files (x86)\VisualStudio\Files\Fil_Rouge\Generation2\chefdeuvre.png");
            //m.readLibrary(@"D:\Program Files (x86)\VisualStudio\Files\Fil_Rouge\Generation2\index2.txt");
            string test = "1 2 3 nous irons au bois";
            CodeRGB chanson = new CodeRGB(test);
            //chanson.AfficherCodeRGB();

            //m.AfficherIndex();

            m.ImageReadSalle(@"C:\Users\Samuel GUYETANT\Desktop\INSA 3IF\C#\VisualStudioProject\Generation2\salle2.png"); // full adresse : D:\Program Files (x86)\VisualStudio\Files\Fil_Rouge\Generation2\
            m.AfficherFloor();
            m.fillRoom(@"C:\Users\Samuel GUYETANT\Desktop\INSA 3IF\C#\VisualStudioProject\Generation2\salle_objet.png");
            //Console.WriteLine(id.CompareTo(id2));
            //Console.WriteLine(m.GetIndex().ContainsKey(new CodeRGB(2, 2, 3)));
            //Console.WriteLine(m.GetIndex().ContainsValue("poubelle"));
            //m.AfficherIndex();
            //Console.WriteLine(m.GetIndex()[id]);

        }
    }
}
