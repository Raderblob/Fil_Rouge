using System;

public abstract class Entity
{
	protected Point AbsoluteCoordinate { get; set; }
	protected Point relativeCoordinate { get; set; }
	protected Point speed { get; set; }
	protected bool franchissabilite { get; set; }
	protected Forme shape{ get; set; }
	

}
