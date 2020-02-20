using System;

public class Cercle : Forme
{
	public Cercle()
	{
		rayon = 0.0f;
		centre = new Point(0.0f, 0.0f);
	}

	public Cercle(float r, Point c)
	{
		rayon = r;
		centre = c;
	}

	public Cercle(Point a, Point b)
	{
	//A completer

	}

	public float GetrayonCercle()
	{
		return this.rayon;
	}

	

	public Point GetPointCercle()
	{
		return this.centre;
	}

	public void SetrayonCercle(float changement)
	{
		this.rayon = changement;
	}

	public void SetPointAbscisseCercle(float changement)
	{
		centre.SetAbscissePoint(changement);
	}

	public void SetPointOrdonneeCercle(float changement)
	{
		centre.SetOrdonneePoint(changement);
	}

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


	public void AfficherCercle()
	{
		Console.WriteLine("rayon = " + this.rayon);
		Console.WriteLine("le centre a pour coordonnées ");
		centre.AfficherPoint();
	}

	private float rayon;
	private Point centre;
}

