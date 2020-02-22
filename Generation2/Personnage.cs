using System;

public class Personnage : Entity
{
	public Personnage()
	{
		relativeCoordinate = new Point(0, 0);
		speed = new Point(0, 0);
		franchissabilite = false;
		shape = new Cercle(0, relativeCoordinate);
	}

	protected int id_room { get; set; } // l'id change à chaque changement de salle
	protected int id_char { get; set; }//id unique à la création
}
