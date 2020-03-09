using System;

public abstract class Entity//classe abstraite entite
{
	//attributs
	public Point AbsoluteCoordinate
	{
		set { absoluteCoordinate = value; }
		get { return absoluteCoordinate; }
	}
	
	protected Point absoluteCoordinate { get; set; }
	protected Point relativeCoordinate { get; set; }
	protected Point speed { get; set; }
	protected bool franchissabilite { get; set; }
	protected Forme shape{ get; set; }
	protected string name { get; set; }
}
