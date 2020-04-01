using System;
using System.Collections.Generic;

namespace FilRouge
{
	public class Chunk
	{
		//contructeur par défaut
		public Chunk()
		{

		}

		//constructeur qui prend une liste d'élément et une taille
		public Chunk(Rectangle shapeChunk, List<Decor> ornement)
		{
			formeChunk = shapeChunk;
			elements = ornement;
		}

		//ajoute un élément de décor au chunk
		public void Add_Environnement(Decor element)
		{
			elements.Add(element);
		}

		public Rectangle GetFormeChunk()
		{
			return formeChunk;
		}

		public List<Decor> GetElements()
		{
			return elements;
		}

		public void AfficherChunk()
		{
			Console.WriteLine();
			formeChunk.AfficherForme();
			foreach (Decor decoration in elements)
			{
				decoration.AfficherDecor();
			}
			return;
		}

		//attributs
		protected Rectangle formeChunk { get; set; }
		protected List<Decor> elements { get; set; }
	}
}