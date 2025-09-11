
namespace Tag2
{
	public class Auto
	{

		public static int anzahlErzeugterAutos = 0;
		public string Farbe { get; set; }

		private string marke;
		public string getMarke()
		{
			return marke;
		}

		public void setMarke(string marke)
		{
			this.marke = marke;
		}
		public int Leistung { get; set; } // in PS

		public int MaxGeschwindigkeit { get; set; } // in km/h

		public int AktuelleGeschwindigkeit { get; private set; } = 0; // in km/h

		public bool Garantie { get; private set; } = true;


		public Auto()
		{
			anzahlErzeugterAutos++;
			Farbe = "Weiß";
			Marke = "VW";
			Leistung = 100;
			MaxGeschwindigkeit = 180;
		}

		public Auto(string farbe, string marke, int leistung, int maxGeschwindigkeit)
		{
			anzahlErzeugterAutos++;
			Farbe = farbe;
			Marke = marke;
			Leistung = leistung;
			MaxGeschwindigkeit = maxGeschwindigkeit;
		}


		public void Beschleunigen(int geschwindigkeitsZunahme)
		{
			if(AktuelleGeschwindigkeit + geschwindigkeitsZunahme > MaxGeschwindigkeit)
			{
				AktuelleGeschwindigkeit = MaxGeschwindigkeit;
				Garantie = false;
			} else if(geschwindigkeitsZunahme>0)
			{
				AktuelleGeschwindigkeit += geschwindigkeitsZunahme;
			}
		}

		public void Bremsen(int geschwindigkeitsAbnahme)
		{
			if (AktuelleGeschwindigkeit - geschwindigkeitsAbnahme < 0)
			{
				AktuelleGeschwindigkeit = 0;
			}
			else if (geschwindigkeitsAbnahme > 0)
			{
				AktuelleGeschwindigkeit -= geschwindigkeitsAbnahme;
			}
		}
	}
}
