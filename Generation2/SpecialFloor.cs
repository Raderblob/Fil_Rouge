using System;

public class SpecialFloor : Decor
{
	public SpecialFloor(float changePV, Point changeV, short type, Point pos, float longueur, float largeur, Point vit, bool f) :base(type, pos, longueur, largeur, vit, f)
	{
		changeHP = changePV;
		changeSpeed = changeV;
	}

	public SpecialFloor(float changePV, Point changeV, short type, Point pos, float rayon, Point vit, bool f) : base(type, pos, rayon, vit, f)
	{
		changeHP = changePV;
		changeSpeed = changeV;
	}

	public float GetChangeHP()
	{
		return this.changeHP;
	}

	public void SetChangeHP(float changement)
	{
		this.changeHP = changement;
	}

	public Point GetchangeSpeed()
	{
		return this.changeSpeed;
	}

	public void SetChangeSpeed(Point changement)
	{
		this.changeSpeed = changement;
	}

	protected float changeHP;
	protected Point changeSpeed;
}
