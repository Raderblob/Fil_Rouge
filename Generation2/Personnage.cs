using System;

public class Personnage : Entity
{
	public Personnage()
	{
		position = new Point(0, 0);
		speed = new Point(0, 0);
		franchissabilite = false;
		shape = new Cercle(0, position);
	}
}
