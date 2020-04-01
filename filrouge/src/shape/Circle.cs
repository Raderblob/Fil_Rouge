using System;

namespace FilRouge.src.shape
{
	public class Circle : Shape//hérite de la classe forme
	{
		//constructeur par défaut
		public Circle()
		{
			radius = 0.0f;
			center = new Point(0.0f, 0.0f);
		}

		//constructeur avec rayon et centre
		public Circle(float r, Point c)
		{
			radius = r;
			center = c;
		}

		//constructeur avec deux points
		public Circle(Point a, Point b)
		{
			//A completer

		}

		//getteur
		public float GetrayonCercle()
		{

			return radius;
		}

		//getteur
		public Point GetPointCercle()
		{
			return center;
		}

		//setteur
		public void SetrayonCercle(float changement)
		{
			radius = changement;
		}

		//setteur
		public void SetPointAbscisseCercle(float changement)
		{
			center.setAbscisse(changement);
		}

		//setteur
		public void SetPointOrdonneeCercle(float changement)
		{
			center.setOrdonnee(changement);
		}

		//teste l'appartenance d'un point à un cercle
		public bool AppartenanceCercle(Point a)
		{
			bool appart = false;
			float distance = center.DistancePoint(a);
			if (distance <= Math.Pow(radius, 2))
			{
				appart = true;
			}


			return appart;
		}

		//teste l'intersection entre deux cercles
		public bool AppartenanceCercle(Circle c)
		{
			bool appart = false;
			float dist = center.DistancePoint(c.center);
			if (dist <= Math.Pow(radius + c.radius, 2))
			{
				appart = true;
			}
			return appart;
		}

		//affichage des caractéristiques du cercle, hérite d'un méthode AfficherForme de Form, peut être syntaxe incorrecte
		public override void AfficherForme()
		{
			Console.WriteLine("rayon = " + radius);
			Console.WriteLine("le centre a pour coordonnées ");
			center.AfficherPoint();
		}

		//attributs
		private float radius;
		private Point center;
	}
}