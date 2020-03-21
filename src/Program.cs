using System;

namespace Generation
{
    class Program
    {
        static void Main(string[] args)
        {
            


            Monde m = new Monde(@"C:\Users\Samuel GUYETANT\Desktop\INSA 3IF\C#\VisualStudioProject\FilRouge\index_test_format.txt"); // full adresse : D:\Program Files (x86)\VisualStudio\Files\Fil_Rouge\FilRouge\

            //m.AfficherIndex();

            m.ImageReadSalle2(@"C:\Users\Samuel GUYETANT\Desktop\INSA 3IF\C#\VisualStudioProject\FilRouge\salle_objet_porte.png"); // full adresse : D:\Program Files (x86)\VisualStudio\Files\Fil_Rouge\FilRouge\
            //m.AfficherFloor();
            m.fillRoom(@"C:\Users\Samuel GUYETANT\Desktop\INSA 3IF\C#\VisualStudioProject\FilRouge\salle_objet_porte.png");

            /*Console.WriteLine("les salles de l'étage rentrent  en conflits. It's " + m.VerifIntersectionSalles());

            Console.WriteLine("toutes les salles sont accessibles. It's "+m.accessSalle());

            Personnage DD = new Personnage(new Point(2, 2), new Point(1, 1), new Point(2, 3), true, new Rectangle(0.5f, 0.2f, new Point(0.5f, 0.5f), 0), "DD", 0, 0);

            //m.GetPeuple().Add(new Personnage());
            m.GetPeuple().Add(DD);
            m.AfficherPeuple();

            Personnage DD2 = new Personnage(new Point(12, 16), new Point(0, 0), false, new Rectangle(0.5f, 0.5f, new Point(12, 16), 0), "DD2", 0, 1);
            m.GetSallePersonnage(DD2, 0);
            //DD2.CalculateRelCoord(DD2.GetAbsCoord(), m.GetSallePersonnage(DD2, 0).getContour().getUsefulPoint());
            //DD2.AfficherPersonnage();
            */
            //Rectangle a = new Rectangle(new Point(1, 1), new Point(5, 5), 0);
            //Rectangle b = new Rectangle(new Point(2, 2), new Point(3, 3), 0);

            //a.AppartenanceRectangle(b);


            //Console.WriteLine(id.CompareTo(id2));
            //Console.WriteLine(m.GetIndex().ContainsKey(new CodeRGB(2, 2, 3)));
            //Console.WriteLine(m.GetIndex().ContainsValue("poubelle"));
            //m.AfficherIndex();
            //Console.WriteLine(m.GetIndex()[id]);

        }
    }
}
