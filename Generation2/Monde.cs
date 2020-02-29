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
		index = new Dictionary<CodeRGB, string>();
	}

	public Monde(string name)
	{
		nbSalles = 0;
		clear = false;
		adjMat = new int[nbSalles, nbSalles];
		floor = new List<Salle> { };
	
		index = this.readLibrary(name);
	}

	public Dictionary<CodeRGB, string> readLibrary(string name)
	{
		Dictionary<CodeRGB, string> code = new Dictionary<CodeRGB, string>();
		CodeRGB transition;
		string nom;
		// Example #2
		// Read each line of the file into a string array. Each element
		// of the array is one line of the file.
		string[] lines = System.IO.File.ReadAllLines(name);

		// Display the file contents by using a foreach loop.
		//Console.WriteLine("Contents of WriteLines2.txt = ");
		foreach (string line in lines)
		{
			transition = new CodeRGB(line);
			nom = line;
			int position = nom.IndexOf(" ");
			nom = nom.Substring(position + 1);
			position = nom.IndexOf(" ");
			nom = nom.Substring(position + 1);
			position = nom.IndexOf(" ");
			nom = nom.Substring(position + 1);
			code.Add(transition, nom);
			// Use a tab to indent each line of the file.
			//Console.WriteLine("\t" + nom);
		}


		return code;
	}
	public Monde(int size, List<Salle> list)
	{
		clear = false;
		nbSalles = size;
		foreach (Salle s in list)
		{
			floor.Add(s);
		}

	}

	public void ImageRead(string name)
	{
		Bitmap bitmap = new Bitmap(name);
		int sizeW = bitmap.Width;
		int sizeH = bitmap.Height;
		CodeRGB id;
		for (int i = 0; i < sizeW; i++)
		{
			for (int j = 0; j < sizeH; j++)
			{
				Color clr = bitmap.GetPixel(j, i);
				byte R = clr.R;
				byte G = clr.G;
				byte B = clr.B;
				byte A = clr.A;
				id = new CodeRGB(R, G, B);

				if (index.ContainsKey(id) == true)
				{
					Console.WriteLine("le pixel correspond à " + index[id] + " dans la base de données");
					Console.WriteLine("la ligne du pixel est " + i + " et sa colonne est " + j);
					Console.WriteLine(" -> R: " + R + " G: " + G + " B: " + B + " A: " + A);
				}
				
			}

		}

	}

	public void ImageReadSalle(string name)
	{
		Bitmap bitmap = new Bitmap(name);
		int sizeW = bitmap.Width;
		int sizeH = bitmap.Height;
		CodeRGB id;
		int longueur=0;
		int largeur=0;
		int xB = 0;
		int yB = 0;
		Color clr;
		byte R;
		byte G;
		byte B;
		for (int i = 0; i < sizeW; i++)
		{
			for (int j = 0; j < sizeH; j++)
			{
				clr = bitmap.GetPixel(j, i);
				R = clr.R;
				G = clr.G;
				B = clr.B;
				id = new CodeRGB(R, G, B);
			
				if (index.ContainsKey(id) == true)
				{
					if(index[id]== "salle beacon")
					{
						xB = j;
						yB = i;
							while (index[id]!="corner")
							{
							    j++;
								clr = bitmap.GetPixel(j, i);
								R = clr.R;
								G = clr.G;
								B = clr.B;
								id = new CodeRGB(R, G, B);
								
							}
						longueur = j ;
						i++;
						clr = bitmap.GetPixel(j, i);
						R = clr.R;
						G = clr.G;
						B = clr.B;
						id = new CodeRGB(R, G, B);
						while (index[id]!="corner")
						{
							i++;
							clr = bitmap.GetPixel(j, i);
							R = clr.R;
							G = clr.G;
							B = clr.B;
							id = new CodeRGB(R, G, B);
							
						}
						largeur = i;
						Point test = new Point(longueur, largeur);
						this.floor.Add(new Salle((nbSalles), new Point(xB, yB), test));
						nbSalles++;
						j = xB ;
						i = yB ;
					}
				}

			}

		}

	}


	public void fillRoom(string name)
	{
		Bitmap image = new Bitmap(name);
		int xStart;
		int yStart;
		int width;
		int height;
		Color clr;
		byte R;
		byte G;
		byte B;
		foreach(Salle room in floor)
		{
			Console.WriteLine("Parcours de la salle n°" + room.getId_salle());
			width = (int)room.getContour().GetLongueurRectangle();
			height = (int)room.getContour().GetLargeurRectangle();
			xStart = (int)room.getContour().getUsefulPoint().GetAbscissePoint();
			yStart = (int)room.getContour().getUsefulPoint().GetOrdonneePoint();
			for(int i = 1; i < height; i++)
			{
				for(int j = 1; j < width; j++)
				{
					clr = image.GetPixel(xStart+j,yStart+i);
					R = clr.R;
					G = clr.G;
					B = clr.B;
					CodeRGB idObject = new CodeRGB(R, G, B);
					
					
					if(index.ContainsKey(idObject)&&index[idObject]!="vide de gimp")
					{
						
						Console.WriteLine("x: "+(xStart+j)+ " y: "+(yStart+i)+" l'objet est un : "+index[idObject]) ;
					}
				}
			}
		}
		
	}
	/*public int InDictionary(CodeRGB test)
	{
		int t=0
		foreach (KeyValuePair<CodeRGB, string> line in index)
		{
			test.compareTo
		}

	}*/

	public void AfficherIndex()
	{
		foreach (KeyValuePair<CodeRGB, string> line in index)
		{
			line.Key.AfficherCodeRGB();
			Console.WriteLine(line.Value);
		}
	}

	public Dictionary<CodeRGB, string> GetIndex()
	{
		return index;
	}

	public void AfficherFloor()
	{
		foreach (Salle room in floor)
		{
			room.AfficherSalle();
		}
		Console.WriteLine("nbSalles " + nbSalles);
	}

	int nbSalles;
	int[,] adjMat;
	List<Salle> floor;
	bool clear;
	Dictionary<CodeRGB, string> index;
}
