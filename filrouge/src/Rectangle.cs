﻿using System;

public class Rectangle : Forme//hérite de la classe forme
{
	//constructeur par défaut
	public Rectangle()
	{
		largeur = 0.0f;
		longueur = 0.0f;
		centre = new Point(0.0f, 0.0f);
		angle = 0;
	}

	//constructeur avec le centre du rectangle, la longueur(abscisse), la largeur(ordonnee) et un angle
	public Rectangle(float a, float b, Point c,float teta)
	{
		largeur = a;
		longueur = b;
		centre = c;
		VectDemiLongueur= new Point(b * (float)Math.Cos((Math.PI / 180) * teta) / 2, b * (float)Math.Sin((Math.PI / 180) * teta) / 2);
		VectDemiLargeur = new Point(-a * (float)Math.Sin((Math.PI / 180) * teta) / 2, a * (float)Math.Cos((Math.PI / 180) * teta) / 2);
		angle = teta;

	}

	//constructeur avec deux points (coins supérieur gauche et inférieur droit) et un angle
	public Rectangle(Point a, Point b, float teta)
	{
		float absmax;
		float ordmax;
		if(a.getAbscisse()>b.getAbscisse())
		{
			absmax = a.getAbscisse();
		}
		else
		{
			absmax = b.getAbscisse();
		}

		if (a.getOrdonnee() > b.getOrdonnee())
		{
			ordmax = a.getOrdonnee();
		}
		else
		{
			ordmax = b.getOrdonnee();
		}

		longueur = Math.Abs(a.getAbscisse() - b.getAbscisse());
		largeur = Math.Abs(a.getOrdonnee() - b.getOrdonnee());
		centre = new Point(absmax - (longueur / 2.0f), ordmax - (largeur / 2.0f));
		VectDemiLongueur = new Point(longueur * (float)Math.Cos((Math.PI / 180) * teta) / 2, longueur * (float)Math.Sin((Math.PI / 180) * teta) / 2);
		VectDemiLargeur = new Point(largeur * (float)Math.Sin((Math.PI / 180) * teta) / 2, -largeur * (float)Math.Cos((Math.PI / 180) * teta) / 2);
		angle = teta;

	}

	//getteur
	public float GetLargeurRectangle()
	{
		return this.largeur;
	}

	//getteur
	public float GetLongueurRectangle()
	{
		return this.longueur;
	}

	//getteur
	public Point GetPointRectangle()
	{
		return this.centre;
	}

	//retorune le point supérieur gauche
	public Point getUsefulPoint()
	{
		return new Point(this.centre.getAbscisse() - longueur / 2, this.centre.getOrdonnee() - largeur / 2);
	}

	//setteur
	public void SetLargeurRectangle(float changement)
	{
		this.largeur = changement;
	}

	//setteur
	public void SetLongueurRectangle(float changement)
	{
		this.longueur = changement;
	}

	//setteur
	public void SetPointAbscisseRectangle(float changement)
	{
		centre.setAbscisse(changement);
	}

	//setteur
	public void SetPointOrdonneeRectangle(float changement)
	{
		centre.setOrdonnee(changement);
	}

	public void setPoint(Point p)
	{
		this.centre = p;
	}

	//pertmet de tester l'appartenance d'un point à un rectangle
	public bool AppartenanceRectangle(Point a)
	{
		bool appart = false;
		float borneMinLargeur=centre.getOrdonnee() - ( largeur /2.0f);
		float borneMaxLargeur = centre.getOrdonnee() + (largeur / 2.0f);
		float borneMinLongueur = centre.getAbscisse() - (longueur / 2.0f);
		float borneMaxLongueur = centre.getAbscisse() + (longueur / 2.0f);
		//Console.WriteLine(borneMaxLargeur+" "+borneMinLargeur+ " " + borneMaxLongueur + " " + borneMinLongueur);
		//a.AfficherPoint();
		Point nouvP = new Point((a.getAbscisse() * (float)Math.Cos((Math.PI / 180) * angle)) - (a.getOrdonnee() * (float)Math.Sin((Math.PI / 180) * angle)), (a.getAbscisse() * (float)Math.Sin((Math.PI / 180) * angle))+ (a.getOrdonnee() * (float)Math.Cos((Math.PI / 180) * angle)));
		//nouvP.AfficherPoint();
		if (nouvP.getAbscisse()>=borneMinLongueur && nouvP.getAbscisse()<=borneMaxLongueur && nouvP.getOrdonnee()>=borneMinLargeur && nouvP.getOrdonnee()<=borneMaxLargeur)
		{
			appart = true;
		}

		return appart;
	}


	//méthode qui marche pas à modifier
	public bool AppartenanceRectangle(Rectangle a)
	{
		bool appart = false;
		float borneMinLargeur = centre.getOrdonnee() - (largeur / 2.0f);
		float borneMaxLargeur = centre.getOrdonnee() + (largeur / 2.0f);
		float borneMinLongueur = centre.getAbscisse() - (longueur / 2.0f);
		float borneMaxLongueur = centre.getAbscisse() + (longueur / 2.0f);
		float borneMinLargeur2 = a.centre.getOrdonnee() - (largeur / 2.0f);
		float borneMaxLargeur2 = a.centre.getOrdonnee() + (largeur / 2.0f);
		float borneMinLongueur2 = a.centre.getAbscisse() - (longueur / 2.0f);
		float borneMaxLongueur2 = a.centre.getAbscisse() + (longueur / 2.0f);
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

	//permet de tester l'intersection enntre deux rectangles 
	public bool AppartenanceRectangle2(Rectangle a)
	{
		bool appart = false;

		Point supgauche = a.getUsefulPoint();
		Point supdroit = new Point(supgauche.getAbscisse() + a.GetLongueurRectangle(), supgauche.getOrdonnee());
		Point infgauche = new Point(supgauche.getAbscisse(), supgauche.getOrdonnee()+a.GetLargeurRectangle());
		Point infdroit = new Point(supgauche.getAbscisse() + a.GetLongueurRectangle(), supgauche.getOrdonnee() + a.GetLargeurRectangle());
		//this.AppartenanceRectangle(supgauche);
		//this.AppartenanceRectangle(infgauche);
		//this.AppartenanceRectangle(supdroit);
		//this.AppartenanceRectangle(infdroit);

		appart = this.AppartenanceRectangle(supgauche) || this.AppartenanceRectangle(infgauche)|| this.AppartenanceRectangle(supdroit)|| this.AppartenanceRectangle(infdroit);

		return appart;
	}

	//fait tourner un rectangle d'un angle teta
	public void Rotate(float teta)
	{
		angle += teta;
		VectDemiLongueur = new Point((longueur/2) * (float)Math.Cos((Math.PI / 180) * teta), (longueur/2) * (float)Math.Sin((Math.PI / 180) * teta));
		VectDemiLargeur = new Point(-(largeur/2) * (float)Math.Sin((Math.PI / 180) * teta), (largeur/2) * (float)Math.Cos((Math.PI / 180) * teta));
	}

	//affichage des caractéristiques du rectangle, hérite d'un méthode AfficherForme de Form, peut être syntaxe incorrecte
	public override void AfficherForme()
	{
		Console.WriteLine("C'est un rectangle de centre X : "+this.centre.getAbscisse()+" Y :"+this.centre.getOrdonnee());
		//new Point(centre.GetAbscisse() - longueur / 2, centre.GetOrdonneePoint() - largeur / 2).AfficherPoint();
		
		Console.WriteLine("longueur = " + this.longueur);
		Console.WriteLine("largeur = " + this.largeur);
		//Console.WriteLine("Le Rectangle est incliné de " + angle + " degré(s)");
		//centre.AfficherPoint();
		//VectDemiLongueur.AfficherPoint();
		//VectDemiLargeur.AfficherPoint();
	}


	//attributs
	protected float largeur;
	protected float longueur;
	protected Point centre;
	protected float angle { get; set; }
	protected Point VectDemiLongueur { get; set; }
	protected Point VectDemiLargeur { get; set; }
}
