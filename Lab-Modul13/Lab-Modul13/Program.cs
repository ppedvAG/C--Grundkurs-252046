using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text.Json;

namespace M012;

static class Program
{
	static void Main(string[] args)
	{
		#region File lesen
		string readJson = File.ReadAllText(@"..\..\..\Personen.json");
		List<Person> personen = JsonSerializer.Deserialize<List<Person>>(readJson)!;
		#endregion

		//Hier eigenen Code schreiben

		// Personen die älter als 60 sind
		personen.Where(p => p.Alter >= 60).ToList();

		// Personen die mehr als 5000€ verdienen
		personen.Where(p => p.Job.Gehalt > 5000).ToList();
		
		// Sortieren Personen nach Jobtitel alphabetisch danach nach Gehalt
		personen.OrderBy(p => p.Job.Titel).ThenBy(p=> p.Job.Gehalt).ToList();

		// Personen mit mehr als 10 Buchstaben im Vornamen
		personen.Count(p => p.Vorname.Length > 10);

		// Durchschnittsgehalt der Softwareentwickler
		Math.Round(personen.Where(p => p.Job.Titel == "Softwareentwickler").Average(p => p.Job.Gehalt), 2);

		// Wie viele Personen haben genau zwei Hobbies?
		personen.Count(p => p.Hobbies.Count == 2);

		// Verdienen alle Personen über 50 mehr als 25000 in 12 Monaten
		personen.Where(p => p.Alter > 50).All(p => p.Job.Gehalt * 12 > 25000);

		//Finde alle Personen, die Radfahren und Laufen als Hobbies haben.
		personen.Where(p => p.Hobbies.Contains("Radfahren") && p.Hobbies.Contains("Laufen")).ToList();
		personen.Where(p => p.Hobbies.Contains("Radfahren")).Where(p => p.Hobbies.Contains("Laufen")).ToList();

		// Alle Personen deren Vorname mit M und Nachname mit S beginnt
		personen.Where(p=> p.Vorname.StartsWith('M') && p.Nachname.StartsWith("S")).ToList();

		// Alle Personen bei denen Vor und Nachname mit dem gleichen Buchstaben beginnen
		personen.Where(p=> p.Vorname.StartsWith(p.Nachname[0])).ToList();
		personen.Where(p => p.Vorname.StartsWith(p.Nachname.First())).ToList();

		//Finde alle Personen, die überdurchschnittlich alt sind in Relation zu allen Personen.
		personen.Where(p=> p.Alter > personen.Average(p => p.Alter)).ToList();


		// Personen über 60 die Sport machen
		personen.Where(p => p.Alter > 60 && (p.Hobbies.Contains("Laufen") || p.Hobbies.Contains("Radfahren") || p.Hobbies.Contains("Ballsport") || p.Hobbies.Contains("Fitness"))).ToList();

		// Wie viele Jobs gibt es
		personen.Select(p => p.Job.Titel).Distinct().Count();

		// Tischler maximales Gehalt
		int maxTischlerGehalt = personen.Where(p => p.Job.Titel == "Tischler").MaxBy(p => p.Job.Gehalt).Job.Gehalt;

		// Personen die 1977 geboren wurden
		personen.Where(p=>p.Geburtsdatum.Year == 1977).ToList();

		// Alle möglichen Vor und Nachnamen Kombis
		personen.Select(p=>p.Vorname+" "+p.Nachname).OrderBy(vn=> vn.Length).ToList();

		// Top 5 Verdiener
		personen.OrderByDescending(p=>p.Job.Gehalt).Take(5).ToList();

		// Personen die länger als 20 Jahre im Unternehmen sind (2023)
		personen.Where(p => p.Job.Einstellungsdatum.Year <= 2003).ToList();

		// Am häufgsten vorkommenden Vornamen
		personen.GroupBy(p => p.Vorname).ToDictionary(p => p.Key, p => p.Count()).OrderByDescending(p=>p.Value).ToDictionary();

		// Finde pro Beruf das höchste Gehalt, sortiert nach Jobtitel.
		personen.GroupBy(p=>p.Job.Titel).ToDictionary(p=>p.Key, p=> p.Max(x => x.Job.Gehalt)).OrderBy(p=>p.Key).ToDictionary();

		personen.SelectMany(p=>p.Hobbies).GroupBy(h=>h).ToDictionary(h=>h.Key, h=>h.Count()).OrderByDescending(h=>h.Value).ToDictionary();

		personen.GroupBy(p => p.Job.Titel).ToDictionary(p => p.Key, p => p.OrderByDescending(x => x.Job.Gehalt).Take(3).ToArray());

		personen.Take(5).ToList().PersonenListSchoenDarstellen();
	}

	public static void PersonenListSchoenDarstellen(this List<Person> personen)
	{
		foreach (var person in personen)
		{
			Console.Write($"Person: ID: {person.ID}, Vorname: {person.Vorname}, JobTiltel: {person.Job.Titel}, Hobbies: [");
			foreach (var hobby in person.Hobbies)
			{
				Console.Write($"{hobby}, ");
			}
			Console.WriteLine("]");
		}
	}
}

///////////////////////////////////////////////////////////////////////////////

[DebuggerDisplay("Person - ID: {ID}, Vorname: {Vorname}, Nachname: {Nachname}, GebDat: {Geburtsdatum.ToString(\"yyyy.MM.dd\")}, Alter: {Alter}, " +
	"Jobtitel: {Job.Titel}, Gehalt: {Job.Gehalt}, Einstellungsdatum: {Job.Einstellungsdatum.ToString(\"yyyy.MM.dd\")}")]
public record Person(int ID, string Vorname, string Nachname, DateTime Geburtsdatum, int Alter, Beruf Job, List<string> Hobbies);

public record Beruf(string Titel, int Gehalt, DateTime Einstellungsdatum);

///////////////////////////////////////////////////////////////////////////////