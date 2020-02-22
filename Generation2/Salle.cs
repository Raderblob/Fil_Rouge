using System;
using System.Collections.Generic;

public class Salle
{
	public Salle()
	{
		//environnement.Add(new Point(50, 50), new Decor());
		//peuple.Add(new Point(12, 12), new Personnage());
		contour = new Rectangle(50, 50, new Point(50, 50),0);
		nbSorties = 2;
		clear = false;
	}

	//Dictionary<Point, Decor> environnement; //tester si nb sortie>0 //tester si les objets sont dans la putain de salle
	//Dictionary<Point, Personnage> peuple; nope
	protected Dictionary<Point, Chunk> chunk_list { get; set; } //on divise( division entière) les coordonnées relatives par la taille du chunk et on obtient la clé 
	protected Forme contour { get; set; }
	protected int nbSorties { get; set; }
	protected bool clear { get; set; }
	protected int id_salle{get;set;}
	
	
}
