using System;

public class Rectangle : Forme
{
	public Rectangle()
	{
		largeur = 0.0f;
		longueur = 0.0f;
		centre = new Point(0.0f, 0.0f);
		angle = 0;
	}

	public Rectangle(float a, float b, Point c,float teta)
	{
		largeur = a;
		longueur = b;
		centre = c;
		VectDemiLongueur= new Point(b * (float)Math.Cos((Math.PI / 180) * teta) / 2, b * (float)Math.Sin((Math.PI / 180) * teta) / 2);
		VectDemiLargeur = new Point(-a * (float)Math.Sin((Math.PI / 180) * teta) / 2, a * (float)Math.Cos((Math.PI / 180) * teta) / 2);
		angle = teta;

	}

	public Rectangle(Point a, Point b, float teta)
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
		VectDemiLongueur = new Point(longueur * (float)Math.Cos((Math.PI / 180) * teta) / 2, longueur * (float)Math.Sin((Math.PI / 180) * teta) / 2);
		VectDemiLargeur = new Point(largeur * (float)Math.Sin((Math.PI / 180) * teta) / 2, -largeur * (float)Math.Cos((Math.PI / 180) * teta) / 2);
		angle = teta;

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
	public Point getUsefulPoint()
	{
		return new Point(this.centre.GetAbscissePoint() - longueur / 2, this.centre.GetOrdonneePoint() - largeur / 2);
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
		Point nouvP = new Point((a.GetAbscissePoint() * (float)Math.Cos((Math.PI / 180) * angle)) - (a.GetOrdonneePoint() * (float)Math.Sin((Math.PI / 180) * angle)), (a.GetAbscissePoint() * (float)Math.Sin((Math.PI / 180) * angle))+ (a.GetOrdonneePoint() * (float)Math.Cos((Math.PI / 180) * angle)));
		nouvP.AfficherPoint();
		if (nouvP.GetAbscissePoint()>=borneMinLongueur && nouvP.GetAbscissePoint()<=borneMaxLongueur && nouvP.GetOrdonneePoint()>=borneMinLargeur && nouvP.GetOrdonneePoint()<=borneMaxLargeur)
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
	public void Rotate(float teta)
	{
		angle += teta;
		VectDemiLongueur = new Point((longueur/2) * (float)Math.Cos((Math.PI / 180) * teta), (longueur/2) * (float)Math.Sin((Math.PI / 180) * teta));
		VectDemiLargeur = new Point(-(largeur/2) * (float)Math.Sin((Math.PI / 180) * teta), (largeur/2) * (float)Math.Cos((Math.PI / 180) * teta));
	}

	public void AfficherRectangle()
	{
		new Point(centre.GetAbscissePoint() - longueur / 2, centre.GetOrdonneePoint() - largeur / 2).AfficherPoint();
		
		Console.WriteLine("longueur = " + this.longueur);
		Console.WriteLine("largeur = " + this.largeur);
		//Console.WriteLine("Le Rectangle est incliné de " + angle + " degré(s)");
		//centre.AfficherPoint();
		//VectDemiLongueur.AfficherPoint();
		//VectDemiLargeur.AfficherPoint();
	}

	protected float largeur;
	protected float longueur;
	protected Point centre;
	protected float angle { get; set; }
	protected Point VectDemiLongueur { get; set; }
	protected Point VectDemiLargeur { get; set; }
}
