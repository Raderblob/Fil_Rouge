using System;
using System.Collections.Generic;
using System.Drawing;

public class Monde
{
	public Monde()
	{
		nbSalles = 0;
		clear = false;
		adjMat = new int[nbSalles, nbSalles];
		floor = new List<Salle> { };
		floor.Add(new Salle());
	}

	public Monde(int size,List<Salle> list)
	{
		clear = false;
		nbSalles = size;
		foreach(Salle s in list)
		{
			floor.Add(s);
		}

	}

	public void ImageRead(string name)
	{
		Bitmap bitmap = new Bitmap(name);
		int sizeW = bitmap.Width;
		int sizeH = bitmap.Height;
		for(int i = 0; i < sizeW; i++)
		{
			for(int j = 0; j < sizeH; j++)
			{
				Color clr = bitmap.GetPixel(j, i);
				byte R = clr.R;
				byte G = clr.G;
				byte B = clr.B;
				byte A = clr.A;
				Console.WriteLine(i+j+" -> R: " + R + " G: " + G + " B: " + B + " A: " + A);
			}
		
		}
		
	}
	
	
	int nbSalles;
	int[,] adjMat;
	List<Salle> floor;
	bool clear;
}
