using System;

public class Ellipse : Forme
{
	public Ellipse()
	{
		demiGrandAxe = new Point(0, 0);
		demiPetitAxe = new Point(0, 0);
		centre = new Point(0.0f, 0.0f);
	}

	public Ellipse(Point c,float dga, float dpa, float teta)
	{
		distGa = dga;
		distPa = dpa;
		demiGrandAxe = new Point(dga*(float)Math.Cos((Math.PI/180)*teta),dga*(float)Math.Sin((Math.PI / 180) * teta));
		demiPetitAxe = new Point(dpa*(float)Math.Sin((Math.PI / 180) * teta),-dpa*(float)Math.Cos((Math.PI / 180) * teta));
		centre = c;
	}

	public void Rotate(float teta)
	{
		angle += teta;
		demiGrandAxe = new Point(distGa * (float)Math.Cos((Math.PI / 180) * teta), distGa * (float)Math.Sin((Math.PI / 180) * teta));
		demiPetitAxe = new Point(-distPa * (float)Math.Sin((Math.PI / 180) * teta), distPa * (float)Math.Cos((Math.PI / 180) * teta));
		
	}

	public void AfficherEllipse()
	{
		Console.WriteLine("distGa = " + this.distGa);
		Console.WriteLine("distPa = " + this.distPa);
		Console.WriteLine("le centre a pour coordonnées ");
		Console.WriteLine("Le Rectangle est incliné de " + angle + " degré(s)");
		centre.AfficherPoint();
		demiGrandAxe.AfficherPoint();
		demiPetitAxe.AfficherPoint();
	}

	protected float distGa { get; set; }
	protected float distPa { get; set; }
	protected Point demiGrandAxe { get; set; }
	protected Point demiPetitAxe { get; set; }
	protected Point centre { get; set; }
	protected float angle { get; set; }
}
