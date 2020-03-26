using System;
using System.Collections.Generic;

public abstract class Forme//cladse abstraite forme
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

}
