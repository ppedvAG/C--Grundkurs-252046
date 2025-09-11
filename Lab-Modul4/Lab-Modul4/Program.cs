public class Program
{
	enum Rechenoperation
	{
		Addition = 1,
		Subtraktion,
		Mulitplikation,
		Division
	}
	public static void Main()
	{
		string nochmal = "j";
		do
		{

			int zahl1;
			int zahl2;
			Rechenoperation rechenoperation;
			string eingabe;
			bool hatFunktioniert;
			int rechenoperationZahl;
			double ergebnis;
			
			zahl1 = ZahlEingabe();
			zahl2 = ZahlEingabe();			
			rechenoperation = RechenoperationEingabe();


			Console.WriteLine(rechenoperation + " wurde gewählt");

			ergebnis = Berechne(zahl1, zahl2, rechenoperation);

			Console.WriteLine("Das Ergebnis ist: " + ergebnis);

			switch (rechenoperation)
			{
				case Rechenoperation.Addition:
					Console.WriteLine($"{zahl1} + {zahl2} = {ergebnis}");
					break;
				case Rechenoperation.Subtraktion:
					Console.WriteLine($"{zahl1} - {zahl2} = {ergebnis}");
					break;
				case Rechenoperation.Mulitplikation:
					Console.WriteLine($"{zahl1} * {zahl2} = {ergebnis}");
					break;
				case Rechenoperation.Division:
					if (double.IsNaN(ergebnis))
					{
						Console.WriteLine("Division durch 0 ist nicht erlaubt!");
						continue;
					}
					else
					{
						Console.WriteLine($"{zahl1} / {zahl2} = {ergebnis}");
					}
					break;
				default:
					Console.WriteLine("Unbekannte Rechenoperation!");
					continue;
			}

			Console.WriteLine("Nochmal? (j/n)");
			nochmal = Console.ReadLine();
		} while (nochmal.ToLower() == "j");
	}

	static int ZahlEingabe()
	{
		bool hatFunktioniert;
		int zahl;
		do
		{
			Console.Write("Gib eine Zahl ein: ");
			string eingabe = Console.ReadLine();
			hatFunktioniert = int.TryParse(eingabe, out zahl);
			if (!hatFunktioniert)
			{
				Console.WriteLine("Die Eingabe war keine Zahl!");
			}
		} while (!hatFunktioniert);
		return zahl;
	}

	static Rechenoperation RechenoperationEingabe()
	{
		int zahl;
		do
		{
			Console.WriteLine("Wähle eine Rechenopeariton aus: ");
			Console.WriteLine("1: Addition");
			Console.WriteLine("2: Subtraktion");
			Console.WriteLine("3: Multiplikation");
			Console.WriteLine("4: Division");
			zahl = ZahlEingabe();
			
		} while (!(zahl < 5 && zahl > 0));
		return (Rechenoperation)zahl;
	}

	static double Berechne(double zahl1, double zahl2, Rechenoperation operation)
	{
		switch (operation)
		{
			case Rechenoperation.Addition:
				return zahl1 + zahl2;
			case Rechenoperation.Subtraktion:
				return zahl1 - zahl2;
			case Rechenoperation.Mulitplikation:
				return zahl1 * zahl2;	
			case Rechenoperation.Division:
				if (zahl2 == 0)
				{
					return double.NaN; // Not a Number
				}
				return zahl1 / zahl2;
			default:
				return double.NaN; // Not a Number
		}
	}
}