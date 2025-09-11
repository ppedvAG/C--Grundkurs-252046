int stunden;
int minuten;
int sekunden;
int meter;
string eingabe;
bool erfolgreicheEingabe;

Console.Write("Entfernung (in Meter): ");
eingabe = Console.ReadLine();
erfolgreicheEingabe = int.TryParse(eingabe, out meter);

if (erfolgreicheEingabe && meter > 0)
{
	Console.Write("Stunden: ");
	eingabe = Console.ReadLine();
	erfolgreicheEingabe = int.TryParse(eingabe, out stunden);

	if (erfolgreicheEingabe && stunden >= 0)
	{
		Console.Write("Minuten: ");
		eingabe = Console.ReadLine();
		erfolgreicheEingabe = int.TryParse(eingabe, out minuten);

		if (erfolgreicheEingabe && minuten >= 0)
		{
			Console.Write("Sekunden: ");
			eingabe = Console.ReadLine();
			erfolgreicheEingabe = int.TryParse(eingabe, out sekunden);

			if (erfolgreicheEingabe && sekunden >= 0)
			{
				int gesamtSekunden = sekunden + (minuten * 60) + (stunden * 360);
				double meterProSekunde = (double)meter / gesamtSekunden;
				double kilometerProStunde = (double)meter / 1000 / gesamtSekunden * 3600;
				double meilenProStunde = (double)meter / 1609 / gesamtSekunden * 3600;
				Console.WriteLine($"Meter/Sekunde: {meterProSekunde:F2}");
				Console.WriteLine($"Kilometer/Stunde: {kilometerProStunde:F2}");
				Console.WriteLine($"Meilen/Stunde: {meilenProStunde:F2}");




			} else
			{
				Console.WriteLine("Ungültige Eingabe!");
			}
		} else
		{
			Console.WriteLine("Ungültige Eingabe!");
		}
	} else
	{
		Console.WriteLine("Ungültige Eingabe!");
	}
} else
{
	Console.WriteLine("Ungültige Eingabe!");
}
