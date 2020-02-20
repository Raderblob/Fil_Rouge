using System;

public class Rectangle : Forme
{
	public Rectangle()
	{
		largeur = 0.0f;
		longueur = 0.0f;
		centre = new Point(0.0f, 0.0f);
	}

	public Rectangle(float a, float b, Point c)
	{
		largeur = a;
		longueur = b;
		centre = c;
	}

	public Rectangle(Point a, Point b)
	{
		float absmax;
		float ordmax;
		if(a.GetAbscissePoint()>b.GetAbscissePoint())
		{
			absmax = a.GetAbscissePoint();
		}
		else
		{
			absmax = b.GetAbscissePoint();
		}

		if (a.GetOrdonneePoint() > b.GetOrdonneePoint())
		{
			ordmax = a.GetOrdonneePoint();
		}
		else
		{
			ordmax = b.GetOrdonneePoint();
		}

		longueur = Math.Abs(a.GetAbscissePoint() - b.GetAbscissePoint());
		largeur = Math.Abs(a.GetOrdonneePoint() - b.GetOrdonneePoint());
		centre = new Point(absmax - (longueur / 2.0f), ordmax - (largeur / 2.0f));

	}

	public float GetLargeurRectangle()
	{
		return this.largeur;
	}

	public float GetLongueurRectangle()
	{
		return this.longueur;
	}

	public Point GetPointRectangle()
	{
		return this.centre;
	}

	public void SetLargeurRectangle(float changement)
	{
		this.largeur = changement;
	}

	public void SetLongueurRectangle(float changement)
	{
		this.longueur = changement;
	}

	public void SetPointAbscisseRectangle(float changement)
	{
		centre.SetAbscissePoint(changement);
	}

	public void SetPointOrdonneeRectangle(float changement)
	{
		centre.SetOrdonneePoint(changement);
	}

	public bool AppartenanceRectangle(Point a)
	{
		bool appart = false;
		float borneMinLargeur=centre.GetOrdonneePoint() - ( largeur /2.0f);
		float borneMaxLargeur = centre.GetOrdonneePoint() + (largeur / 2.0f);
		float borneMinLongueur = centre.GetAbscissePoint() - (longueur / 2.0f);
		float borneMaxLongueur = centre.GetAbscissePoint() + (longueur / 2.0f);
		//Console.WriteLine(borneMaxLargeur+" "+borneMinLargeur+ " " + borneMaxLongueur + " " + borneMinLongueur);
		//a.AfficherPoint();
		if (a.GetAbscissePoint()>=borneMinLongueur && a.GetAbscissePoint()<=borneMaxLongueur && a.GetOrdonneePoint()>=borneMinLargeur && a.GetOrdonneePoint()<=borneMaxLargeur)
		{
			appart = true;
		}

		return appart;
	}
	public bool AppartenanceRectangle(Rectangle a)
	{
		bool appart = false;
		float borneMinLargeur = centre.GetOrdonneePoint() - (largeur / 2.0f);
		float borneMaxLargeur = centre.GetOrdonneePoint() + (largeur / 2.0f);
		float borneMinLongueur = centre.GetAbscissePoint() - (longueur / 2.0f);
		float borneMaxLongueur = centre.GetAbscissePoint() + (longueur / 2.0f);
		float borneMinLargeur2 = a.centre.GetOrdonneePoint() - (largeur / 2.0f);
		float borneMaxLargeur2 = a.centre.GetOrdonneePoint() + (largeur / 2.0f);
		float borneMinLongueur2 = a.centre.GetAbscissePoint() - (longueur / 2.0f);
		float borneMaxLongueur2 = a.centre.GetAbscissePoint() + (longueur / 2.0f);
		if (((borneMaxLongueur2 <= borneMinLongueur) || (borneMaxLongueur <= borneMinLongueur2))
		 || ((borneMaxLargeur2 <= borneMinLargeur) || (borneMaxLargeur <= borneMinLargeur2)))
		{
			
		}
		else
		{
			appart = true;
		}
		return appart;
	}

	public void AfficherRectangle()
	{
		Console.WriteLine("largeur = " + this.largeur);
		Console.WriteLine("longueur = " + this.longueur);
		Console.WriteLine("le centre a pour coordonnées " );
		centre.AfficherPoint();
	}

	private float largeur;
	private float longueur;
	private Point centre;
}
