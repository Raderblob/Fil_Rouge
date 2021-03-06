﻿using System;

public class SpecialFloor : Decor//hérite de la classe décor
{
	//pas de constructeur par défaut?

	//constructeur pour un sol de forme rectangulaire
	public SpecialFloor(string nom, float changePV, Point changeV, short type, Point pos, float longueur, float largeur, Point vit, bool f, float teta) :base(nom, type, pos, longueur, largeur, vit, f, teta)
	{
		changeHP = changePV;
		changeSpeed = changeV;
	}

	//constructeur pour un sol de forme circulaire
	public SpecialFloor(string nom, float changePV, Point changeV, short type, Point pos, float rayon, Point vit, bool f) : base(nom, type, pos, rayon, vit, f)
	{
		changeHP = changePV;
		changeSpeed = changeV;
	}

	//getteur
	public float GetChangeHP()
	{
		return this.changeHP;
	}

	//setteur
	public void SetChangeHP(float changement)
	{
		this.changeHP = changement;
	}

	//getteur
	public Point GetchangeSpeed()
	{
		return this.changeSpeed;
	}

	//setteur
	public void SetChangeSpeed(Point changement)
	{
		this.changeSpeed = changement;
	}

	//attributs
	protected float changeHP;
	protected Point changeSpeed;
}
