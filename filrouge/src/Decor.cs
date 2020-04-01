using System;

namespace FilRouge
{
	public class Decor : Entity//hérite de la classe entity
	{
		//constructeur par défaut
		public Decor()
		{
			relativeCoordinate = new Point(0, 0);
			speed = new Point(0, 0);
			franchissabilite = false;
			shape = new Rectangle(0, 0, relativeCoordinate, 0);
			name = "test";
		}

		//constructeur qui initialise un décor de forme sphérique
		public Decor(string nom, short type, Point pos, float r, Point vit, bool f)
		{
			relativeCoordinate = pos;
			speed = vit;
			franchissabilite = f;
			id = type;
			shape = new Cercle(r, relativeCoordinate);
			name = nom;
		}

		//constrcteur qui initialise un décor de forme rectangulaire
		public Decor(string nom, short type, Point pos, float longueur, float largeur, Point vit, bool f, float teta)
		{
			relativeCoordinate = pos;
			speed = vit;
			franchissabilite = f;
			id = type;
			shape = new Rectangle(largeur, longueur, relativeCoordinate, teta);
			name = nom;
		}

		//getteur
		public short GetId()
		{
			return id;
		}

		//setteur
		public void SetId(short changement)
		{
			id = changement;
		}

		//permet d'afficher les caractéristiques d'un décor
		public void AfficherDecor()
		{
			Console.WriteLine("--------------------------------");
			Console.WriteLine("Le décor ID : " + id + " : " + name + " .");
			Console.WriteLine("Ses coordonées absolues sont ");
			AbsoluteCoordinate.AfficherPoint();
			Console.WriteLine(" et ses coordonnées relatives sont ");
			relativeCoordinate.AfficherPoint();
			shape.AfficherForme();
			//Console.WriteLine("Sa vitesse est de ");
			//this.speed.AfficherPoint();
			Console.WriteLine(" et sa franchissabilité est de " + franchissabilite + " .");
			Console.WriteLine("--------------------------------");
			return;
		}

		//attributs
		protected short id;
		//protected int id_salle;
	}
}