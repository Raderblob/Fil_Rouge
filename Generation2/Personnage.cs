using System;

public class Personnage : Entity//hérite de la classe entity
{
	//constructeur par défaut
	public Personnage()
	{
		AbsoluteCoordinate = new Point(0, 0);
		relativeCoordinate = new Point(0, 0);
		speed = new Point(0, 0);
		franchissabilite = false;
		shape = new Cercle(0, relativeCoordinate);
		name = "john/jane doe";
	}

	//constructeur qui prend toutes les informations directement, dont les coordonées relatives sous forme d'un point
	public Personnage(Point abs, Point rel, Point vitesse, bool franch, Rectangle a, string nom, int idr, int idc)
	{
		AbsoluteCoordinate = abs;
		relativeCoordinate = rel;
		speed = vitesse;
		franchissabilite = franch;
		shape = a;
		name = nom;
		id_room = idr;
		id_char = idc;
	}

	//constructeur qui prend toutes les informations directement, dont les coordonées relatives sous forme de float
	public Personnage(Point abs, float abssalle, float ordsalle, Point vitesse, bool franch, Rectangle a, string nom, int idr, int idc)
	{
		AbsoluteCoordinate = abs;
		relativeCoordinate = CalculateRelCoord(abs, abssalle, ordsalle);
		speed = vitesse;
		franchissabilite = franch;
		shape = a;
		name = nom;
		id_room = idr;
		id_char = idc;
	}

	//constructeur qui prend toutes les informations directement sauf les coordonées relatives, à compléter après l'init du personnage
	public Personnage(Point abs, Point vitesse, bool franch, Rectangle a, string nom, int idr, int idc)
	{
		AbsoluteCoordinate = abs;
		relativeCoordinate = new Point();
		speed = vitesse;
		franchissabilite = franch;
		shape = a;
		name = nom;
		id_room = idr;
		id_char = idc;
	}

	//afficher les caractéristiques du personnage, atten tion à bien indiquer les coordonnées relatives sinon erreur
	public void AfficherPersonnage()
	{
		Console.WriteLine("--------------------------");
		Console.WriteLine("Le personnage n°" + id_char + " s'appelle "+name+" .");
		Console.WriteLine("Il se trouve dans la salle "+id_room);
		Console.WriteLine("Ses coordonées absolues sont ");
		this.AbsoluteCoordinate.AfficherPoint();
		Console.WriteLine(" et ses coordonnées relatives sont ");
		this.relativeCoordinate.AfficherPoint();
		Console.WriteLine("Sa forme est :");
		this.shape.AfficherForme();
		Console.WriteLine("Sa vitesse est de ");
		this.speed.AfficherPoint();
		Console.WriteLine(" et sa franchissabilité est de "+franchissabilite+" .");
		Console.WriteLine("--------------------------");
		return;
	}

	//calcul les coordonées relatives d'un personnage en fonction des coordonnées absolu du perso et des coordonnées sous forme de float du point utile de la salle
	public Point CalculateRelCoord(Point absCoord, float abssalle,float ordsalle)
	{
		
		float abscisse = absCoord.GetAbscissePoint();
		float ordonnee = absCoord.GetOrdonneePoint();
		Point relCoord=new Point (abscisse-abssalle, ordonnee-ordsalle);
		return relCoord;
	}

	//calcul les coordonées relatives d'un personnage en fonction des coordonnées absolu du perso et du point utile de la salle
	public void CalculateRelCoord(Point absCoord, Point sommetsupgauche)
	{

		float abscisse = absCoord.GetAbscissePoint();
		float ordonnee = absCoord.GetOrdonneePoint();
		float abssupgauche = sommetsupgauche.GetAbscissePoint();
		float ordsupgauche = sommetsupgauche.GetOrdonneePoint();
		relativeCoordinate = new Point(abscisse - abssupgauche, ordonnee - ordsupgauche);
	}

	
	//getteur
	public float GetAbscissePerso()
	{
		return AbsoluteCoordinate.GetAbscissePoint();
	}
	//getteur
	public float GetOrdonneePerso()
	{
		return AbsoluteCoordinate.GetOrdonneePoint();
	}
	//getteur
	public Point GetAbsCoord()
	{
		return AbsoluteCoordinate;
	}

	//attributs
	protected int id_room { get; set; } // l'id change à chaque changement de salle
	protected int id_char { get; set; }// id unique à la création
}
