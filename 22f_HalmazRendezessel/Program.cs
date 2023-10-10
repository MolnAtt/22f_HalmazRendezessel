using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22f_HalmazRendezessel
{
	internal class Program
	{
		class Halmaz
		{
			public static int db;
			List<int> t;
			public int Count { get => t.Count; }
			public Halmaz()
			{
				t = new List<int>();
			}

			public Halmaz(List<int> t)
			{
				this.t = t;

				// rendezni kell!
			}



			/// <summary>
			/// indexet ad vissza: az az index, ahol az elem VAN, ha rendezett listának tagja, és a leendő helye, ahol kellene legyen, ha még nem tagja.
			/// Logaritmikus keresés!
			/// </summary>
			/// <param name="elem"></param>
			/// <returns></returns>

			public override string ToString() => "[ " + string.Join(" ", t) + " ]";

			private int Helye(int elem)
			{
				if (t.Count == 0)
					return 0;
				int e = 0;
				int v = t.Count - 1;
				int k;
				do
				{
					k = (e + v) / 2;

					if (elem < t[k])
						v = k - 1;
					else if (t[k] < elem)
						e = k + 1;
				} while (e <= v && t[k] != elem);
				return t[k] == elem ? k : e;
			}

			/// <summary>
			/// Részhalmaza-e a a b-nek.
			/// </summary>
			/// <param name="a"></param>
			/// <param name="b"></param>
			/// <returns></returns>
			public static bool operator <(Halmaz a, Halmaz b)
			{
				// a<b
				return false;
			}

			public static bool operator >(Halmaz a, Halmaz b)
			{
				// a<b
				return false;
			}

			public static bool operator ==(Halmaz a, Halmaz b)
			{
				// a<b
				return false;
			}

			public static bool operator !=(Halmaz a, Halmaz b)
			{
				// a<b
				return false;
			}

			public bool Benne_van(int elem) => t[Helye(elem)] == elem;

			public void Add(int elem)
			{
                Console.Error.WriteLine($"Hozzá fogom adni az {elem} elemet");
				int h = Helye(elem); // ha benne van, az indexét, ha nincs benne, a leendő indexét adja meg!
				Console.Error.WriteLine($"Hozzá fogom adni az {elem} elemet a {h} helyre");

				if (t.Count==h) // a leendő helye a lista végén van!
				{
					t.Add(elem);
				}
				else if (t[h] != elem)
					t.Insert(h, elem);
            }

			public void Remove(int elem)
			{
				int h = Helye(elem);
				if (t[h] == elem)
					t.RemoveAt(h);
			}
			/// <summary>
			/// Rendezett halmazok uniója
			/// </summary>
			/// <param name="a"></param>
			/// <param name="b"></param>
			/// <returns></returns>
			public static Halmaz operator +(Halmaz a, Halmaz b)
			{
				return new Halmaz();
			}

			/// <summary>
			/// Rendezett halmazok metszete
			/// </summary>
			/// <param name="a"></param>
			/// <param name="b"></param>
			/// <returns></returns>
			public static Halmaz operator *(Halmaz a, Halmaz b)
			{
				return new Halmaz();
			}

			/// <summary>
			/// Rendezett halmazok különbsége
			/// </summary>
			/// <param name="a"></param>
			/// <param name="b"></param>
			/// <returns></returns>
			public static Halmaz operator -(Halmaz a, Halmaz b)
			{
				return new Halmaz();
			}

		}

		static void Main(string[] args)
		{
			Halmaz h = new Halmaz();

			h.Add(4);
			h.Add(8);
			h.Add(2);
			h.Add(3);
			h.Add(9);
			h.Add(0);
			h.Add(4);
			h.Add(2);
			h.Add(1);

            Console.WriteLine(h);

        }
	}
}
