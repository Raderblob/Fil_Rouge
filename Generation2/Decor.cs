using System;

public class Decor : Entity
{
	public Decor()
	{
		relativeCoordinate = new Point(0, 0);
		speed = new Point(0, 0);
		franchissabilite = false;
		shape = new Rectangle(0,0, relativeCoordinate, 0);
	}

	public Decor(short type,Point pos,float r,Point vit,bool f)
	{
		relativeCoordinate = pos;
		speed = vit;
		franchissabilite = f;
		id = type;
		shape = new Cercle(r, relativeCoordinate);
	}

	public Decor(short type, Point pos, float longueur, float largeur,  Point vit, bool f, float teta)
	{
		relativeCoordinate = pos;
		speed = vit;
		franchissabilite = f;
		id = type;
		shape = new Rectangle(largeur, longueur, relativeCoordinate, teta);
	}

	public short GetId()
	{
		return this.id;
	}

	public void SetId(short changement)
	{
		this.id = changement;
	}

	protected short id;
}
