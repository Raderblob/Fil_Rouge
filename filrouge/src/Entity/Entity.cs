using FilRouge.src.physics;
using FilRouge.src.shape;
using System;
namespace FilRouge.src.Entity
{
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
		protected Shape shape { get; set; }
		protected string name { get; set; }
		protected Body body { get; set; }
	}
}