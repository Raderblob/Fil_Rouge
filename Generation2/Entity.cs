using System;

public abstract class Entity
{
	protected Point position;
	protected Point speed;
	protected bool franchissabilite;
	protected Forme shape;
	public Point getPos()
	{
		return position;
	}
	public Point getSpeed()
	{
		return speed;
	}
	public bool getFranchissabilite()
	{
		return franchissabilite;
	}

}
