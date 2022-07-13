using System;

namespace PSeInt
{
	class ejercicio2dejorgeojeda
	{

		

		static void Main(string[] args)
		{
			double ax;
			double by;
			double c;
			double d;
			double e;
			Console.Write("colocar A ");
			ax = Double.Parse(Console.ReadLine());
			Console.Write("colocar B");
			by = Double.Parse(Console.ReadLine());
			Console.Write("colocar C");
			c = Double.Parse(Console.ReadLine());
			Console.Write("colocar D");
			d = Double.Parse(Console.ReadLine());
			Console.Write("colocar E");
			e = Double.Parse(Console.ReadLine());
			
			if (Math.Pow(ax, 2) != 0 || Math.Pow(by, 2) != 0)
			{
				Console.WriteLine("es una parabola");
			}
			else
			{
				if (Math.Pow(ax, 2) != 0 && Math.Pow(by, 2) != 0 && Math.Pow(ax, 2) == Math.Pow(by, 2))
				{
					Console.WriteLine("es una circunferencia");
				}
				else
				{
					if (Math.Pow(ax, 2) != 0 && Math.Pow(by, 2) != 0 && Math.Pow(ax, 2) > 0 && Math.Pow(by, 2) > 0 && Math.Pow(ax, 2) != Math.Pow(by, 2))
					{
						Console.WriteLine("es una elipse");
					}
					else
					{
						if (Math.Pow(ax, 2) != 0 && Math.Pow(by, 2) != 0 && Math.Pow(ax, 2) > 0 && Math.Pow(by, 2) < 0 && Math.Pow(ax, 2) != Math.Pow(by, 2))
						{
							Console.WriteLine("es una hiperbola");
						}
					}
				}
			}
		}

	}

}
