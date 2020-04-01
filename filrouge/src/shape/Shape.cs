using System;
using System.Collections.Generic;
using FilRouge.src.physics;

namespace FilRouge.src.shape
{
	public abstract class Shape//cladse abstraite forme
	{
		//méthode dont hérite les afficherforme des classes cercle et rectangle
		public abstract void AfficherForme();

		public /*abstract*/ List<Point> getNormalVertices()
		{
			throw new NotImplementedException();
		}

		public /*abstract*/ float[] projection(Point axe)
		{
			throw new NotImplementedException();
		}

		public /* abstract */ float ComputeMass(float density)
		{
			throw new NotImplementedException();

		}

		public /* */ AABB ComputeAABB()
		{
			throw new NotImplementedException();

		}

	}
}