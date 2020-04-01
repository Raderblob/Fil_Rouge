using FilRouge;
using System;
using System.Collections.Generic;
using System.Drawing;
using Point = FilRouge.Point;
using Rectangle = FilRouge.Rectangle;

public class Monde
{
	//constructeur par défaut
	public Monde()
	{
		nbSalles = 0;
		clear = false;
		adjMat = new int[nbSalles, nbSalles];
		floor = new List<Salle> { };
		peuple = new List<Personnage> { };
		index = new Dictionary<CodeRGB, string>();
	}

	//cosntructeur qui permet d'initialiser un monde à partir d'un nom de fichier(une image)
	public Monde(string name)
	{
		nbSalles = 0;
		clear = false;
		adjMat = new int[nbSalles, nbSalles];
		floor = new List<Salle> { };
		peuple = new List<Personnage> { };
		index = this.readLibrary(name);
	}
	
	//permet de lire un index d'objets dans un fichier txt
	public Dictionary<CodeRGB, string> readLibrary(string name)
	{
		Dictionary<CodeRGB, string> code = new Dictionary<CodeRGB, string>();
		CodeRGB transition;
		string nom;
		// Example #2
		// Read each line of the file into a string array. Each element
		// of the array is one line of the file.
		Console.WriteLine(name);
		string[] lines = name.Split('\n');

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
	
	//permet de créer un monde à partir d'une liste de salle
	public Monde(int size, List<Salle> list)
	{
		clear = false;
		nbSalles = size;
		foreach (Salle s in list)
		{
			floor.Add(s);
		}

	}

	//permet de lire les pixels d'un image et d'en extraire les composantes rgb
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

	//permet d'ajouter des salles dans un monde à partir d'une image
	public void ImageReadSalle(string name)
	{
		Bitmap bitmap = new Bitmap(name);
		int sizeW = bitmap.Width;
		int sizeH = bitmap.Height;
		CodeRGB id;
		int longueur = 0;
		int largeur = 0;
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
					if (index[id] == "salle beacon")
					{
						xB = j;
						yB = i;
						while (index[id] != "corner")
						{
							j++;
							clr = bitmap.GetPixel(j, i);
							R = clr.R;
							G = clr.G;
							B = clr.B;
							id = new CodeRGB(R, G, B);

						}
						longueur = j;
						i++;
						clr = bitmap.GetPixel(j, i);
						R = clr.R;
						G = clr.G;
						B = clr.B;
						id = new CodeRGB(R, G, B);
						while (index[id] != "corner")
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
						Console.WriteLine("ajout de la salle n° " + nbSalles);
						nbSalles++;
						j = xB;
						i = yB;
					}
				}

			}

		}

	}

	//permet d'ajouter des salles avec leur nombre de portes associées dans un monde à partir d'une image
	public void ImageReadSalle2(Bitmap bitmap)
	{
		int sizeW = bitmap.Width;
		int sizeH = bitmap.Height;
		CodeRGB id;
		int longueur = 0;
		int largeur = 0;
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
				int compteurportes = 0;

				if (index.ContainsKey(id) == true)
				{
					if (index[id] == "salle beacon")
					{
						xB = j;
						yB = i;
						while (index[id] != "corner")
						{
							j++;
							clr = bitmap.GetPixel(j, i);
							R = clr.R;
							G = clr.G;
							B = clr.B;
							id = new CodeRGB(R, G, B);
							if (index[id] == "porte")
							{
								++compteurportes;
							}

						}
						longueur = j;
						i++;
						clr = bitmap.GetPixel(j, i);
						R = clr.R;
						G = clr.G;
						B = clr.B;
						id = new CodeRGB(R, G, B);
						while (index[id] != "corner")
						{
							i++;
							clr = bitmap.GetPixel(j, i);
							R = clr.R;
							G = clr.G;
							B = clr.B;
							id = new CodeRGB(R, G, B);
							if (index[id] == "porte")
							{
								++compteurportes;
							}

						}

						largeur = i;

						j--;
						clr = bitmap.GetPixel(j, i);
						R = clr.R;
						G = clr.G;
						B = clr.B;
						id = new CodeRGB(R, G, B);
						while (index[id] != "corner")
						{
							j--;
							clr = bitmap.GetPixel(j, i);
							R = clr.R;
							G = clr.G;
							B = clr.B;
							id = new CodeRGB(R, G, B);
							if (index[id] == "porte")
							{
								++compteurportes;
							}

						}


						i--;
						clr = bitmap.GetPixel(j, i);
						R = clr.R;
						G = clr.G;
						B = clr.B;
						id = new CodeRGB(R, G, B);
						while (index[id] != "salle beacon")
						{
							i--;
							clr = bitmap.GetPixel(j, i);
							R = clr.R;
							G = clr.G;
							B = clr.B;
							id = new CodeRGB(R, G, B);
							if (index[id] == "porte")
							{
								++compteurportes;
							}

						}


						Point test = new Point(longueur, largeur);
						this.floor.Add(new Salle((nbSalles), new Point(xB, yB), test, compteurportes));
						//Console.WriteLine("ajout de la salle n° " + nbSalles);
						nbSalles++;
						j = xB;
						i = yB;
					}
				}

			}

		}

	}

	//lit une image précedemment utilisée pour initialiser les salles pour remplir les salles d'objets 
	public void fillRoom(Bitmap image)
	{
		int xStart;
		int yStart;
		int width;
		int height;
		Color clr;
		byte R;
		byte G;
		byte B;
		foreach (Salle room in floor)
		{
			//Console.WriteLine("Parcours de la salle n°" + room.getId_salle());
			width = (int)room.getContour().GetLongueurRectangle();
			height = (int)room.getContour().GetLargeurRectangle();
			xStart = (int)room.getContour().getUsefulPoint().getAbscisse();
			yStart = (int)room.getContour().getUsefulPoint().getOrdonnee();
			for (int i = 1; i < height; i++)
			{
				for (int j = 1; j < width; j++)
				{
					clr = image.GetPixel(xStart + j, yStart + i);
					R = clr.R;
					G = clr.G;
					B = clr.B;
					CodeRGB idObject = new CodeRGB(R, G, B);


					if (index.ContainsKey(idObject) && index[idObject] != "vide de gimp")
					{

						//Console.WriteLine("x: " + (xStart + j) + " y: " + (yStart + i) + " l'objet est un : " + index[idObject]);
						float abscisse_rel =  j;
						float ordonnee_rel =  i;
						float abscisse_abs = xStart+ j;
						float ordonnee_abs = yStart+ i;
						int entity_type;
						int shape_type;
						string nom;
						short id;
						bool passThrough;
						Rectangle rec;
						string[] info = index[idObject].Split('|');
						nom = info[0];
						entity_type = Int32.Parse(info[1]);
						id = Int16.Parse(info[2]);
						shape_type = Int32.Parse(info[3]);
						int string_index = 3;
						rec = new Rectangle();
						switch (shape_type)
						{
							case 0:
								rec.setPoint(new Point(abscisse_rel, ordonnee_rel));
								rec.SetLongueurRectangle(Int32.Parse(info[++string_index]));
								rec.SetLargeurRectangle(Int32.Parse(info[++string_index]));
								
								break;
						}
						if (Int32.Parse(info[++string_index]) == 0)
						{
							passThrough = false;
						}
						else
						{
							passThrough = true;
						}
						
						switch (entity_type)
						{
							case 0:

								Decor bob=new Decor(nom, id, rec.GetPointRectangle(), rec.GetLongueurRectangle(), rec.GetLargeurRectangle(), new Point(), passThrough, 0);
								bob.AbsoluteCoordinate = new Point(abscisse_abs, ordonnee_abs);
								//bob.AfficherDecor();
								room.Elements.Add(bob);
								
								break;

						}
						
					}
				}
			}
			room.AfficherContenueSalle();
		}


	}

	//affiche l'index utilisé par le monde
	public void AfficherIndex()
	{
		foreach (KeyValuePair<CodeRGB, string> line in index)
		{
			line.Key.AfficherCodeRGB();
			Console.WriteLine(line.Value);
		}
	}

	//récupère l'index utilisé par le monde
	public Dictionary<CodeRGB, string> GetIndex()
	{
		return index;
	}

	//afficher les caractéristiques des salles d'un monde
	public void AfficherFloor()
	{
		foreach (Salle room in floor)
		{
			room.AfficherSalle();
		}
		Console.WriteLine("nbSalles " + nbSalles);
	}

	//permet de vérifier que les salles ne se rentrent pas dedans
	public bool VerifIntersectionSalles()
	{
		bool intersect = false;
		foreach (Salle room in floor)
		{
			foreach (Salle roomtest in floor)
			{
				if (room.getId_salle() != roomtest.getId_salle())
				{
					intersect = roomtest.getContour().AppartenanceRectangle2(room.getContour());
				}
				if (intersect == true)
				{
					room.AfficherSalle();
					roomtest.AfficherSalle();
					return intersect;
				}
			}
		}


		return intersect;
	}

	//permet de vérifier que les salles ont au moins une issue
	public bool accessSalle()
	{
		bool presenceporte = true;
		foreach (Salle room in floor)
		{
			if (room.getSorties_salle() == 0 || presenceporte == false)
			{
				presenceporte = false;
			}
		}
		return presenceporte;
	}

	//afficher les personnages d'un monde
	public void AfficherPeuple()
	{
		foreach (Personnage johnDoe in peuple)
		{
			johnDoe.AfficherPersonnage();
		}
		return;
	}

	//retourne la liste des personnages d'un monde
	public List<Personnage> GetPeuple()
	{
		return peuple;
	}

	//récupère la salle dans lequel se trouve le personnage si les coordonnées et l'id correspondent, utile pour les coord relatives
	public Salle GetSallePersonnage(Personnage johnDoe,int idsalle)
	{
		foreach (Salle room in floor)
		{
			if(room.getId_salle()==idsalle)
			{
				if (room.getContour().getUsefulPoint().getAbscisse()<=johnDoe.GetAbscissePerso() && room.getContour().getUsefulPoint().getOrdonnee()<=johnDoe.GetOrdonneePerso()&& room.getContour().getUsefulPoint().getAbscisse()+room.getContour().GetLongueurRectangle() >= johnDoe.GetAbscissePerso() && room.getContour().getUsefulPoint().getOrdonnee() + room.getContour().GetLargeurRectangle() >= johnDoe.GetOrdonneePerso())
				{
					Console.WriteLine("Le personnage ");
					johnDoe.AfficherPersonnage();
					Console.WriteLine("se trouve dans la salle");
					room.AfficherSalle();
					return room;
				}
				else
				{
					Console.WriteLine("La salle demandée existe mais le personnage ne peut se trouver à l'intérieur");
					return new Salle();
				}
				
			}
		}
		Console.WriteLine("Il n'y a pas de salle dans l'étage qui possède l'identifiant " + idsalle + " .");
		return new Salle();
	}


	//attributs
	int nbSalles;
	int[,] adjMat;
	List<Salle> floor;
	bool clear;
	Dictionary<CodeRGB, string> index;
	List<Personnage> peuple;

}
