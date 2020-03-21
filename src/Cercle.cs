using System;

public class Cercle : Forme//hérite de la classe forme
{
	//constructeur par défaut
	public Cercle()
	{
		rayon = 0.0f;
		centre = new Point(0.0f, 0.0f);
	}

	//constructeur avec rayon et centre
	public Cercle(float r, Point c)
	{
		rayon = r;
		centre = c;
	}

	//constructeur avec deux points
	public Cercle(Point a, Point b)
	{
	//A completer

	}

	//getteur
	public float GetrayonCercle()
	{
		
		return this.rayon;
	}

	//getteur
	public Point GetPointCercle()
	{
		return this.centre;
	}

	//setteur
	public void SetrayonCercle(float changement)
	{
		this.rayon = changement;
	}

	//setteur
	public void SetPointAbscisseCercle(float changement)
	{
		centre.SetAbscissePoint(changement);
	}

	//setteur
	public void SetPointOrdonneeCercle(float changement)
	{
		centre.SetOrdonneePoint(changement);
	}

	//teste l'appartenance d'un point à un cercle
	public bool AppartenanceCercle(Point a)
	{
		bool appart = false;
		float distance = centre.DistancePoint(a);
		if (distance <= Math.Pow(rayon, 2))
		{
			appart = true;
		}
		

		return appart;
	}

	//teste l'intersection entre deux cercles
	public bool AppartenanceCercle(Cercle c)
	{
		bool appart = false;
		float dist = centre.DistancePoint(c.centre);
		if (dist <= Math.Pow(rayon + c.rayon, 2))
		{
			appart = true;
		}
		return appart;
	}

	//affichage des caractéristiques du cercle, hérite d'un méthode AfficherForme de Form, peut être syntaxe incorrecte
	public override void AfficherForme()
	{
		Console.WriteLine("rayon = " + this.rayon);
		Console.WriteLine("le centre a pour coordonnées ");
		centre.AfficherPoint();
	}

	//attributs
	private float rayon;
	private Point centre;
}

