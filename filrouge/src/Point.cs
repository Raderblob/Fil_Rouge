using System;

public class Point
{
	//constructeur par défaut
	public Point()
	{
		abscisse = 0.0f;
		ordonnee = 0.0f;
	}

	//constructeur avec une abscisse et une ordonnée
	public Point(float a, float b)
	{
		abscisse = a;
		ordonnee = b;
	}

	//getteur
	public float getAbscisse()
	{
		return this.abscisse;
	}

	//getteur
	public float getOrdonnee()
	{
		return this.ordonnee;
	}

	//setteur
	public void setAbscisse(float changement)
	{
		this.abscisse = changement;
	}

	//setteur
	public void setOrdonnee(float changement)
	{
		this.ordonnee = changement;
	}

	//afficher les caractéristiques d'un point
	public void AfficherPoint()
	{
		Console.WriteLine("abcisse = "+this.abscisse+ " ordonne = "+this.ordonnee);
		
	}

	//calcule la distance euclidienne entre deux points
	public float DistancePoint(Point a)
	{
		float dist =(float)Math.Pow(a.getAbscisse() - abscisse, 2) + (float)Math.Pow(a.getOrdonnee() - ordonnee,2);
		return dist;
	}

	//attributs
	private float abscisse;
	private float ordonnee;
}
