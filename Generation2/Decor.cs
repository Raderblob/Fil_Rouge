using System;

public class Decor : Entity
{
	public Decor()
	{
		position = new Point(0, 0);
		speed = new Point(0, 0);
		franchissabilite = false;
		shape = new Rectangle(0,0, position);
	}

	public Decor(short type,Point pos,float r,Point vit,bool f)
	{
		position = pos;
		speed = vit;
		franchissabilite = f;
		id = type;
		shape = new Cercle(r, position);
	}

	public Decor(short type, Point pos, float longueur, float largeur,  Point vit, bool f)
	{
		position = pos;
		speed = vit;
		franchissabilite = f;
		id = type;
		shape = new Rectangle(largeur, longueur, position);
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
