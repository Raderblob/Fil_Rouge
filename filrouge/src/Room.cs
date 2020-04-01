using FilRouge.src.Entity;
using FilRouge.src.shape;
using System;
using System.Collections.Generic;

namespace FilRouge
{
	public class Room
	{
		//constructeur par défaut
		public Room()
		{
			contour = new Rectangle(50, 50, new Point(50, 50), 0);
			nbSorties = 2;
			clear = false;
			chunk_list = new Dictionary<Point, Chunk> { };
			CreateChunckList();

		}

		//constructeur avec un identifiant, le point supérieur gauche et le point inférieur droit
		public Room(int id, Point beacon, Point corner)
		{
			id_salle = id;
			nbSorties = 1;
			contour = new Rectangle(beacon, corner, 0);
			clear = false;
			chunk_list = new Dictionary<Point, Chunk> { };
			CreateChunckList();

		}

		//constructeur avec un identifiant, le point supérieur gauche, le point inférieur droit et le nb de sorties
		public Room(int id, Point beacon, Point corner, int nbexit)
		{
			id_salle = id;
			nbSorties = nbexit;
			contour = new Rectangle(beacon, corner, 0);
			clear = false;
			chunk_list = new Dictionary<Point, Chunk> { };
			CreateChunckList();

		}

		//affiche les caractéristiques d'une salle
		public void AfficherSalle()
		{
			Console.WriteLine("--------------------------");
			Console.WriteLine("La salle n°" + id_salle + " : ");
			Console.WriteLine("possède " + nbSorties + " sorties");
			contour.AfficherForme();
			Console.WriteLine("et les chunks suivants");
			foreach (KeyValuePair<Point, Chunk> c in chunk_list)
			{
				c.Key.AfficherPoint();
				//Console.WriteLine();
				c.Value.AfficherChunk();
			}
			//Console.WriteLine("id_salle ="+id_salle);
			Console.WriteLine("--------------------------");
		}
		public void AfficherContenueSalle()
		{
			Console.WriteLine("***************************************" + Environment.NewLine + "La salle n°" + id_salle + " contient les élements suivants :");
			foreach (Decor d in elements)
			{
				d.AfficherDecor();
			}
			Console.WriteLine("***************************************");
		}

		//getteur
		public Rectangle getContour()
		{
			return contour;
		}

		//getteur
		public int getId_salle()
		{
			return id_salle;
		}

		//getteur
		public int getSorties_salle()
		{
			return nbSorties;
		}

		//Dictionary<Point, Decor> environnement; //tester si nb sortie>0 //tester si les objets sont dans la putain de salle
		//Dictionary<Point, Personnage> peuple; nope

		//crée la liste des chunck pour la salle en fonction d'un entier multiple de 2
		/*public void CreateChunckList(int subdivision)
		{
			if(subdivision%2!=0)
			{
				Console.WriteLine("Le nombre de subdivision demande n'est pas réalisable car non pair");
				return;
			}
			else
			{
				int nblignes = subdivision / 2;
				int divverticales = nblignes - 1;
				for()
				{
					for()
					{

					}
				}
			}
		}*/

		//subdivise la salle en 4 rectangles égaux
		public void CreateChunckList()
		{
			Point centre = contour.GetPointRectangle();
			float longueur = contour.GetLongueurRectangle() / 2;
			float largeur = contour.GetLargeurRectangle() / 2;

			//initialisation du chunk haut gauche
			Point centreChunk = new Point(centre.getAbscisse() - longueur / 2, centre.getOrdonnee() - largeur / 2);
			Chunk transi = new Chunk(new Rectangle(largeur, longueur, centreChunk, 0), new List<Decor> { });
			Point cle = new Point(0, 0);

			chunk_list.Add(cle, transi);

			//initialisation du chunk haut droit
			centreChunk = new Point(centre.getAbscisse() + longueur / 2, centre.getOrdonnee() - largeur / 2);
			transi = new Chunk(new Rectangle(largeur, longueur, centreChunk, 0), new List<Decor> { });
			cle = new Point(1, 0);

			chunk_list.Add(cle, transi);

			//initialisation du chunk bas gauche
			centreChunk = new Point(centre.getAbscisse() - longueur / 2, centre.getOrdonnee() + largeur / 2);
			transi = new Chunk(new Rectangle(largeur, longueur, centreChunk, 0), new List<Decor> { });
			cle = new Point(0, 1);

			chunk_list.Add(cle, transi);

			//initialisation du chunk bas droit
			centreChunk = new Point(centre.getAbscisse() + longueur / 2, centre.getOrdonnee() + largeur / 2);
			transi = new Chunk(new Rectangle(largeur, longueur, centreChunk, 0), new List<Decor> { });
			cle = new Point(1, 1);

			chunk_list.Add(cle, transi);

			return;
		}


		//attributs
		protected Dictionary<Point, Chunk> chunk_list { get; set; } //on divise( division entière) les coordonnées relatives par la taille du chunk et on obtient la clé 
		protected Rectangle contour { get; set; }
		protected int nbSorties { get; set; }
		protected bool clear { get; set; }
		protected int id_salle { get; set; }
		//TEMPORARY
		protected List<Decor> elements = new List<Decor>();
		public List<Decor> Elements
		{
			set { elements = value; }
			get { return elements; }
		}
	}
}