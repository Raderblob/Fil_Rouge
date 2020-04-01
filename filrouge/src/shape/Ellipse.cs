using System;

namespace FilRouge.src.shape
{
	public class Ellipse : Shape//hérite de la classe forme
	{
		//constructeur par défaut
		public Ellipse()
		{
			demiGrandAxe = new Point(0, 0);
			demiPetitAxe = new Point(0, 0);
			centre = new Point(0.0f, 0.0f);
		}

		//constructeur le centre des centres, le demi-grand axe, le demi-petit axe et l'inclinaison
		public Ellipse(Point c, float dga, float dpa, float teta)
		{
			distGa = dga;
			distPa = dpa;
			demiGrandAxe = new Point(dga * (float)Math.Cos(Math.PI / 180 * teta), dga * (float)Math.Sin(Math.PI / 180 * teta));
			demiPetitAxe = new Point(dpa * (float)Math.Sin(Math.PI / 180 * teta), -dpa * (float)Math.Cos(Math.PI / 180 * teta));
			centre = c;
		}

		//fait tourner une ellipse d'un angle teta
		public void Rotate(float teta)
		{
			angle += teta;
			demiGrandAxe = new Point(distGa * (float)Math.Cos(Math.PI / 180 * teta), distGa * (float)Math.Sin(Math.PI / 180 * teta));
			demiPetitAxe = new Point(-distPa * (float)Math.Sin(Math.PI / 180 * teta), distPa * (float)Math.Cos(Math.PI / 180 * teta));

		}

		//afficher les caractéristiques d'une ellipse
		public override void AfficherForme()
		{
			Console.WriteLine("distGa = " + distGa);
			Console.WriteLine("distPa = " + distPa);
			Console.WriteLine("le centre a pour coordonnées ");
			Console.WriteLine("Le Rectangle est incliné de " + angle + " degré(s)");
			centre.AfficherPoint();
			demiGrandAxe.AfficherPoint();
			demiPetitAxe.AfficherPoint();
		}


		//attributs
		protected float distGa { get; set; }
		protected float distPa { get; set; }
		protected Point demiGrandAxe { get; set; }
		protected Point demiPetitAxe { get; set; }
		protected Point centre { get; set; }
		protected float angle { get; set; }
	}
}