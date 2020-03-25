using System;

public class CodeRGB: IComparable
{
	//constructeur par défaut
	public CodeRGB()
	{
		red = 0;
		green = 0;
		blue = 0;
	}

	//constructeur avec un nom de fichier
	public CodeRGB(string name)
	{
		//Console.WriteLine(name);
		string transi;
		int t;
		int position = name.IndexOf(" ");
		transi=name.Substring(0, position);
		
		bool success = int.TryParse(transi, out t);
		red = t;

		name = name.Substring(position+1);

		//Console.WriteLine(name);

		position = name.IndexOf(" ");
		transi = name.Substring(0, position);

		success = int.TryParse(transi, out t);
		green = t;

		name = name.Substring(position+1);

		//Console.WriteLine(name);

		position = name.IndexOf(" ");
		transi = name.Substring(0, position);

		success = int.TryParse(transi, out t);
		blue = t;

	}

	//constructeur avec les valeurs des intensités de rouge, vert et bleu
	public CodeRGB(int r, int g, int b)
	{
		red = r;
		green = g;
		blue = b;
	}

	//permet d'implémenter la comparaison entre deux objets rbg
	public int CompareTo(object obj)
	{
		if (obj == null) return 1;

		CodeRGB otherCode = obj as CodeRGB;
		if (otherCode != null)
			if(this.red!=otherCode.red)
			{
				return this.red.CompareTo(otherCode.red);
			}else if(this.green!=otherCode.green)
			{
				return this.green.CompareTo(otherCode.green);
			}
			else
			{
				return this.blue.CompareTo(otherCode.blue);
			}
			
		else
			throw new ArgumentException("Object is not a CodeRGB");
	}

	//permet d'implémenter la comparaison entre deux objets rbg
	public override int GetHashCode()
	{
		int codePasPropre = red + green * 1000 + blue * 1000000;
		if (codePasPropre == 0) return 0;
		return codePasPropre.GetHashCode();
	}

	//permet d'implémenter la comparaison entre deux objets rbg
	public override bool Equals(object obj)
	{
		CodeRGB other = obj as CodeRGB;
		return other != null && other.red == this.red && other.green == this.green && other.blue == this.blue;
	}

	//affiche les caractéristiques d'un objet rgb
	public void AfficherCodeRGB()
	{
		Console.WriteLine("R: " + red + " G: " + green + " B: " + blue);
		return;
	}


	//attributs
	private int red { get; set; }
	private int green { get; set; }
	private int blue { get; set; }
}
