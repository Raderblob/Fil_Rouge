using System;

public class Point
{
	public Point()
	{
		abscisse = 0.0f;
		ordonnee = 0.0f;
	}

	public Point(float a, float b)
	{
		abscisse = a;
		ordonnee = b;
	}

	public float GetAbscissePoint()
	{
		return this.abscisse;
	}

	public float GetOrdonneePoint()
	{
		return this.ordonnee;
	}

	

	public void SetAbscissePoint(float changement)
	{
		this.abscisse = changement;
	}

	public void SetOrdonneePoint(float changement)
	{
		this.ordonnee = changement;
	}

	public void AfficherPoint()
	{
		Console.WriteLine("abcisse = "+this.abscisse);
		Console.WriteLine("ordonne = "+this.ordonnee);
	}

	public float DistancePoint(Point a)
	{
		float dist =(float)Math.Pow(a.GetAbscissePoint() - abscisse, 2) + (float)Math.Pow(a.GetOrdonneePoint() - ordonnee,2);
		return dist;
	}

	private float abscisse;
	private float ordonnee;
}
