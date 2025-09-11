using System.IO;
using System.Net.Mail;

public static class ErweiterungsMethoden
{
	// Erweiterungsmethode für eine Liste von Integern um die Summe aller Elemente zu berechnen
	public static int Summe(this List<int> liste)
	{
		int summe = 0;
		foreach (int item in liste)
		{
			summe += item;
		}
		return summe;
	}
}

public static class Program
{
	public static void Main()
	{
		// Dateien Lesen und Schreiben
		// Schreiben und Erstellen mit StreamWriter
		string pfad = "../../../Test.txt";
		string meinText="";
		using (StreamReader streamReader = new StreamReader(pfad)) 
		{ 
			meinText = streamReader.ReadToEnd();
		}

		StreamWriter streamWriter = new StreamWriter(pfad);
		meinText+=("\nErste Textzeile\n");

		Console.WriteLine("Was soll in der Testdatei stehen?");
		meinText+=Console.ReadLine()+"\n";
		streamWriter.Write(meinText);

		streamWriter.Close();

		using (StreamReader streamReader = new StreamReader(pfad))
		{
			Console.WriteLine(streamReader.ReadToEnd());
		}




		//List<int> zahlen = new List<int> { 1, 2, 3, 4, 5 };

		//Console.WriteLine("Summe der Zahlen in der Liste: " + zahlen.Summe());

		//// Listen und deren Funktionen
		//List<int> zahlen = new List<int>();
		//// Add zum hinzufügen von Elementen
		//zahlen.Add(1);
		//zahlen.Add(1);
		//zahlen.Add(2);
		//zahlen.Add(5);

		//// Zugriff auf Element über Index
		//Console.WriteLine(zahlen[0]); // Ausgabe: 1
		//Console.WriteLine(zahlen[2]); // Ausgabe: 2

		//// Entfernen eines Elements mit Remove
		//zahlen.Remove(1); // Entfernt die Zahl 1 aus der Liste allerdings nur das erste Vorkommen
		//				  // Wenn ich alle Elemente entfernen möchte, kann ich eine Schleife verwenden
		//Console.WriteLine(zahlen[0]); // Ausgabe: 2

		//zahlen.Add(1);
		//// Solange eine 1 in der Liste ist, entferne sie
		//while (zahlen.Contains(1))
		//{
		//	zahlen.Remove(1);
		//}
		//Console.WriteLine("Alle Zahlen in der Liste:");
		//// Alle Zahlen von der Liste ausgeben
		//foreach (int zahl in zahlen)
		//{
		//	Console.WriteLine(zahl); // Ausgabe: 2, 5
		//}

		////Neue Liste mit Strings
		//List<string> namen = new List<string>();
		//namen.Add("Max");
		//namen.Add("Moritz");
		//namen.Add("Anna");
		//namen.Add("Lisa");


		//// Count gibt uns die Anzahl der Elemente in der Liste zurück
		//Console.WriteLine("Anzahl der Elemente: " + namen.Count()); // Anzahl der Elemente in der Liste

		//// Sort sortiert die Liste alphabetisch aufsteigend
		//namen.Sort();
		//foreach (string name in namen) // Ausgabe: Anna, Lisa, Max, Moritz
		//{
		//	Console.WriteLine(name);
		//}


	}


}