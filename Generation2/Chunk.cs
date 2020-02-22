using System;
using System.Collections.Generic;

public class Chunk
{
	public Chunk()
	{
	}
	public void Add_Environnement(Decor element)
	{
		elements.Add(element);
	}

	protected int size { get; set; }
	protected List<Decor> elements { get; set; }
}
