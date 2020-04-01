using FilRouge.src.shape;
using System;

namespace FilRouge.src.Entity
{
	public class Character : Entity//hérite de la classe entity
	{
		//constructeur par défaut
		public Character()
		{
			AbsoluteCoordinate = new Point(0, 0);
			relativeCoordinate = new Point(0, 0);
			speed = new Point(0, 0);
			franchissabilite = false;
			shape = new Circle(0, relativeCoordinate);
			name = "john/jane doe";
		}

		//constructeur qui prend toutes les informations directement, dont les coordonées relatives sous forme d'un point
		public Character(Point abs, Point rel, Point vitesse, bool franch, Rectangle a, string nom, int idr, int idc)
		{
			AbsoluteCoordinate = abs;
			relativeCoordinate = rel;
			speed = vitesse;
			franchissabilite = franch;
			shape = a;
			name = nom;
			id_room = idr;
			id_char = idc;
		}

		//constructeur qui prend toutes les informations directement, dont les coordonées relatives sous forme de float
		public Character(Point abs, float abssalle, float ordsalle, Point vitesse, bool franch, Rectangle a, string nom, int idr, int idc)
		{
			AbsoluteCoordinate = abs;
			relativeCoordinate = CalculateRelCoord(abs, abssalle, ordsalle);
			speed = vitesse;
			franchissabilite = franch;
			shape = a;
			name = nom;
			id_room = idr;
			id_char = idc;
		}

		//constructeur qui prend toutes les informations directement sauf les coordonées relatives, à compléter après l'init du personnage
		public Character(Point abs, Point vitesse, bool franch, Rectangle a, string nom, int idr, int idc)
		{
			AbsoluteCoordinate = abs;
			relativeCoordinate = new Point();
			speed = vitesse;
			franchissabilite = franch;
			shape = a;
			name = nom;
			id_room = idr;
			id_char = idc;
		}

		//afficher les caractéristiques du personnage, atten tion à bien indiquer les coordonnées relatives sinon erreur
		public void AfficherPersonnage()
		{
			Console.WriteLine("--------------------------");
			Console.WriteLine("Le personnage n°" + id_char + " s'appelle " + name + " .");
			Console.WriteLine("Il se trouve dans la salle " + id_room);
			Console.WriteLine("Ses coordonées absolues sont ");
			AbsoluteCoordinate.AfficherPoint();
			Console.WriteLine(" et ses coordonnées relatives sont ");
			relativeCoordinate.AfficherPoint();
			Console.WriteLine("Sa forme est :");
			shape.AfficherForme();
			Console.WriteLine("Sa vitesse est de ");
			speed.AfficherPoint();
			Console.WriteLine(" et sa franchissabilité est de " + franchissabilite + " .");
			Console.WriteLine("--------------------------");
			return;
		}

		//calcul les coordonées relatives d'un personnage en fonction des coordonnées absolu du perso et des coordonnées sous forme de float du point utile de la salle
		public Point CalculateRelCoord(Point absCoord, float abssalle, float ordsalle)
		{

			float abscisse = absCoord.getAbscisse();
			float ordonnee = absCoord.getOrdonnee();
			Point relCoord = new Point(abscisse - abssalle, ordonnee - ordsalle);
			return relCoord;
		}

		//calcul les coordonées relatives d'un personnage en fonction des coordonnées absolu du perso et du point utile de la salle
		public void CalculateRelCoord(Point absCoord, Point sommetsupgauche)
		{

			float abscisse = absCoord.getAbscisse();
			float ordonnee = absCoord.getOrdonnee();
			float abssupgauche = sommetsupgauche.getAbscisse();
			float ordsupgauche = sommetsupgauche.getOrdonnee();
			relativeCoordinate = new Point(abscisse - abssupgauche, ordonnee - ordsupgauche);
		}


		//getteur
		public float GetAbscissePerso()
		{
			return AbsoluteCoordinate.getAbscisse();
		}
		//getteur
		public float GetOrdonneePerso()
		{
			return AbsoluteCoordinate.getOrdonnee();
		}
		//getteur
		public Point GetAbsCoord()
		{
			return AbsoluteCoordinate;
		}

		//attributs
		protected int id_room { get; set; } // l'id change à chaque changement de salle
		protected int id_char { get; set; }// id unique à la création
	}
}