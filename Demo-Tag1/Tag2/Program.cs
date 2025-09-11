

using Tag2;

public class Program
{
	
	public static void Main()
	{
		//SummeAusgeben(5, 7);
		//SummeAusgeben(15, 27);
		//SummeAusgeben(53, 74);

		//int[] zahlen = { 5, 7, 15, 27, 53, 74 };
		//double zahl1 = 5.5;
		//int zahl2 = 7;

		//// Bei überladenen Methoden wird die Methode mit der passenden Signatur aufgerufen
		//Console.WriteLine("Die Summe des Arrays ist " + MathematischeMethoden.SummeBerechnen(zahlen));
		//Console.WriteLine("Die Summe des Arrays ist " + MathematischeMethoden.SummeBerechnen(1,2,3,4,5,6,76,7,85,3));
		//Console.WriteLine("Die Summe von " + zahl1 + " und " + zahl2 + " ist " + MathematischeMethoden.SummeBerechnen(zahl1, zahl2));
		//Console.WriteLine("2 hoch 4 ist " + MathematischeMethoden.ZahlHochX(2,4));
		//Console.WriteLine("2 hoch 2 ist " + MathematischeMethoden.ZahlHochX(2));

		

		Auto auto1 = new Auto();
		Auto auto2 = new Auto("blau", "Peugeot", 110, 185);
		Console.WriteLine("Auto 1: " + auto1.getMarke() + " " + auto1.Farbe + " " + auto1.Leistung + "PS " + auto1.MaxGeschwindigkeit + "km/h");
		Console.WriteLine("Auto 2: " + auto2.getMarke() + " " + auto2.Farbe + " " + auto2.Leistung + "PS " + auto2.MaxGeschwindigkeit + "km/h");

	    auto1.Beschleunigen(50);
		Console.WriteLine(auto1.AktuelleGeschwindigkeit);
		Console.WriteLine(auto1.Garantie);
		auto1.Beschleunigen(1000);
		Console.WriteLine(auto1.AktuelleGeschwindigkeit);
		Console.WriteLine(auto1.Garantie);
		auto1.Bremsen(1000);
		Console.WriteLine(auto1.AktuelleGeschwindigkeit);

		Console.WriteLine("Erzeugte Autos: " + Auto.anzahlErzeugterAutos);

		auto1.setMarke("Porsche");
		auto1.Farbe = "Rot";
	}

	private static void SummeAusgeben(int zahl1, int zahl2)
	{
		Console.WriteLine("Die Summe von " + zahl1 + " und " + zahl2 + " ist " + MathematischeMethoden.SummeBerechnen(zahl1, zahl2));
	}

	

}