// See https://aka.ms/new-console-template for more information
//int alter = 20;
//int doppeltesAlter = alter * 2;
//Console.WriteLine("Doppeltes Alter: " + doppeltesAlter + ".");
//Console.WriteLine($"Doppeltes Alter: {doppeltesAlter}.");

//Console.WriteLine('c');

// Parsen von Zahlen
// fehlerhaftes Parsen
//string zahlAlsText = "1234a";
//int zahl = int.Parse(zahlAlsText);

// fehlerhaftes Parsen mit TryParse
//int zahl2;
//bool erfolgreich = int.TryParse(zahlAlsText, out zahl2);
//if(erfolgreich)
//{
//	Console.WriteLine($"Die Zahl ist {zahl2}.");
//} else {
//	Console.WriteLine($"Die Eingabe '{zahlAlsText}' ist keine gültige Zahl.");
//}


//double zahl3= 12.3445345;
//double gerundeteZahl = Math.Round(zahl3, 2);



//string entfernungEingabe = Console.ReadLine();
//bool hatFunktioniert = int.TryParse(entfernungEingabe, out int entfernung);

//if (hatFunktioniert)
//{

//} else
//{
//	Console.WriteLine("Die Eingabe war keine gültige Zahl.");
//}


//Arrays
//Min Max Sum von String Array?
//string[] strings = { "Hallo", "Welt", "das", "ist", "ein", "Test" };
////int min = strings.Min; Min kann nur bei Int, double , ... angewendet werden
//// das gleiche gilt für Max und Sum

//// Vergleichsoperatoren
//if (1 >= 2) Console.WriteLine("1 ist größer-gleich 2");

//int a = 5;
//int b = 4;
//if (!(a < b && b < 10)) { }


// Schleifen

//// Kopfgesteuert while
//Console.WriteLine("Bitte gib den Namen des Trainers ein:");
//while (Console.ReadLine() != "Dominik")
//{
//	Console.WriteLine("Bitte gib den Namen des Trainers ein:");
//}

//// Kopfgesteuert for

//for (int i = 0; i < 100; i += 3)
//{
//	if (i % 2 == 0)
//	{
//		Console.WriteLine(i);
//	}
//}

//// Fußgesteuert do-while
//do
//{
//	Console.WriteLine("Bitte gib den Namen des Trainers ein:");
//} while (Console.ReadLine() != "Dominik");

//// Array mit for Schleife durchlaufen
//string[] namen = { "Anna", "Berta", "Cäsar", "Dora", "Emil" };
//for (int i = 0; i < namen.Length; i++)
//{
//	Console.WriteLine(namen[i].ToLower());
//}
//// mit foreach Schleife durchlaufen
//foreach (string n in namen)
//{
//	Console.WriteLine(n.ToUpper());

//}


// Enum Beispiel


public class Program
{
	enum Monat { Januar = 1, Februar, März, April, Mai, Juni, Juli, August, September, Oktober, November, Dezember };
	public static void Main()
	{
		Monat aktuellesMonat = Monat.September;
		aktuellesMonat = Monat.Dezember;
		Console.WriteLine(aktuellesMonat+ " aka. Nummer " + (int)aktuellesMonat);


		switch(aktuellesMonat)
		{
			case Monat.Dezember:
				Console.WriteLine("Es ist Weihnachten!");
				break;
			default:
				Console.WriteLine("Es ist nicht Weihnachten");
				break;
		}
	}
}




