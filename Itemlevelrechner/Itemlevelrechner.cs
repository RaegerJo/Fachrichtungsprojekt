using Itemlevelrechner;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace Itemlevelrechner
{
	internal class Itemlevelrechner
	{
		ArrayList slots = new ArrayList();
		private ArrayList itemliste = new ArrayList();

		string mainstat;
		string[] spezialisierung;

		public Itemlevelrechner()
		{}
		public void Starte() // Methode die als Aufrufsmethode in der Mainmethode verwendet wird mit einer Willkommensnachricht
		{
			Console.WriteLine("Willkommen im Itemlevelrechner!\nFolgend wirst du nach einigen Angaben gebeten. Bitte beantworte diese um an dein Itemlevel zu kommen ;)");
			string charName = CharakterName();
			string userKlasse = WelcheKlasse();
			string userspezialisierung = WelcheSpezialisierung();
			ErzeugeSlots();
			WelchesIlvl();
			Endcard(charName,userspezialisierung,userKlasse);
		}
		public string CharakterName()
		{
			Console.WriteLine("Bitte geben Sie den Namen Ihres Charakters an.");    // Aufruf zur Eingabe des Namens des "Spielers"
			string charName = Console.ReadLine();
			Console.Clear();
			return charName;
		} // User gibt Name an
		public string WelcheKlasse()
		{
			string[] klassen = {
			"Krieger", "Todesritter", "Paladin", "Magier", "Priester",
			"Hexenmeister", "Rufer", "Jäger", "Schurke", "Schamane",
			"Druide", "Dämonenjäger", "Mönch" };
			int auswahlUser = 0;
			
			ConsoleKey key;

			do
			{
				Console.Clear();
				Console.WriteLine("Bitte gebe deine Klasse an.");
				Console.WriteLine("Dir stehen folgende Klassen zur Verfügung:");
				for (int i = 0; i < klassen.Length; i++)
				{
					if (i == auswahlUser)
					{
						// Markiert die Ausgewählte Klasse mit einem > und in Grün um hervorzuheben was grade ausgewählt ist

						Console.ForegroundColor = ConsoleColor.Red;
						Console.WriteLine($">> {klassen[i]}");
						Console.ResetColor();
					}
					else
					{
						Console.WriteLine($"  {klassen[i]}");
					}
				}

				// Navigation durchs Menü via Pfeiltasten, Enter bestätigt die Eigabe
				key = Console.ReadKey(true).Key;

				// Navigation durch die Optionen
				if (key == ConsoleKey.UpArrow)
				{
					auswahlUser--;
					if (auswahlUser < 0) auswahlUser = klassen.Length - 1;
				}
				else if (key == ConsoleKey.DownArrow)
				{
					auswahlUser++;
					if (auswahlUser >= klassen.Length) auswahlUser = 0;
				}

			} while (key != ConsoleKey.Enter);

			string auswahlKlasse = klassen[auswahlUser];
			
			// je nachdem welche Klasse ausgewählt ist geht es weiter 
			switch (auswahlUser + 1)
			{
				case 1:
					Warri();
					spezialisierung = Warri();
					return auswahlKlasse;
				case 2:
					spezialisierung= DK();
					return auswahlKlasse;
				case 3:
					Paladin();
					spezialisierung = Paladin();
					return auswahlKlasse;
				case 4:
					Magier();
					spezialisierung = Magier();
					return auswahlKlasse;
				case 5:
					Priester();
					spezialisierung = Priester();
					return auswahlKlasse;
				case 6:
					WL();
					spezialisierung = WL();
					return auswahlKlasse;
				case 7:
					Rufer();
					spezialisierung = Rufer();
					return auswahlKlasse;
				case 8:
					Jäger();
					spezialisierung = Jäger();
					return auswahlKlasse;
				case 9:
					Schurke();
					spezialisierung = Schurke();
					return auswahlKlasse;
				case 10:
					Schamane();
					spezialisierung = Schamane();
					return auswahlKlasse;
				case 11:
					Druide();
					spezialisierung = Druide();
					return auswahlKlasse;
				case 12:
					Dh();
					spezialisierung = Dh();
					return auswahlKlasse;
				case 13:
					Mönch();
					spezialisierung = Mönch();
					return auswahlKlasse;
					
				default:
					Console.WriteLine("Ungültige Auswahl.");
					return auswahlKlasse;





			}
		} // User wird nach Klasse gefragt
		public string WelcheSpezialisierung() // Folgend sind alle Klassen mit ihren Spezialisierungen die man auswählen kann wodurch sich der Mainstat verändert
		{
			string userSpezialisierung = "";
			int auswahlUser = 0;


			ConsoleKey key;

			do
			{
				Console.Clear();
				Console.WriteLine("Welche Spezialisierung hast du?");


				for (int i = 0; i < spezialisierung.Length; i++)
				{
					if (i == auswahlUser)
					{
						Console.ForegroundColor = ConsoleColor.Red;
						Console.WriteLine($">> {spezialisierung[i]}");
						Console.ResetColor();
					}
					else
					{
						Console.WriteLine($"  {spezialisierung[i]}");
					}
				}


				key = Console.ReadKey(true).Key;


				if (key == ConsoleKey.UpArrow)
				{
					auswahlUser--;
					if (auswahlUser < 0)
					{
						auswahlUser = spezialisierung.Length - 1;
					}
				}
				else if (key == ConsoleKey.DownArrow)
				{
					auswahlUser++;
					if (auswahlUser >= spezialisierung.Length)
					{
						auswahlUser = 0;
					}
				}

			} while (key != ConsoleKey.Enter);

			userSpezialisierung = spezialisierung[auswahlUser];

			return userSpezialisierung;
		}
		public string[] Warri()
		{
			string[] krieger = { "Furor", "Waffen", "Schutz" };
			mainstat = "Stärke";
			return krieger;
		}
		public string[] DK()
		{
			string[] dk = { "Unheilig", "Frost", "Blut" };
			mainstat = "Stärke";
			return dk;
		}
		public string[] Magier()
		{
			string[] mage = { "Feuer", "Frost", "Arkan" };
			mainstat = "Intelligenz";
			return mage;

		}
		public string[] Priester()
		{
			string[] priest = { "Heilig", "Disziplin", "Schatten" };
			mainstat = "Intelligenz";
			return priest;
		}
		public string[] Rufer()
		{
			string[] evoker = { "Verstärkung", "Verheerung", "Bewahrung" };
			mainstat = "Intelligenz";
			return evoker;
		}
		public string[] WL()
		{
			string[] wl = { "Zerstörung", "Gebrechen", "Dämonologie" };
			mainstat = "Intelligenz";
			return wl;
		}
		public string[] Jäger()
		{
			string[] hunter = { "Treffsicherheit", "Tierherrschaft", "Überleben" };
			mainstat = "Beweglichkeit";
			return hunter;
		}
		public string[] Schurke()
		{
			string[] rogue = { "Täuschung", "Kampf", "Meucheln" };
			mainstat = "Beweglichkeit";
			return rogue;
		}
		public string[] Schamane()
		{
			string[] shaman = { "Elementar", "Verstärker", "Wiederherstellung" };
			mainstat = "Intelligenz/Beweglichkeit";
			return shaman;
		}
		public string[] Druide()
		{
			string[] druid = { "Feral", "Wächter", "Wiederherstellung" };
			mainstat = "Intelligenz/Beweglichkeit";
			return druid;
		}
		public string[] Dh()
		{
			string[] dh = { "Verwüstung", "Rachsucht" };
			mainstat = "Beweglichkeit";
			return dh;
		}
		public string[] Paladin()
		{
			string[] shaman = { "Schutz", "Vergeltung", "Heilig" };
			mainstat = "Intelligenz/Stärke";
			return shaman;

		}
		public string[] Mönch()
		{
			string[] monk = { "Windläufer", "Braumeister", "Nebelwirker" };
			mainstat = "Intelligenz/Beweglichkeit";
			return monk;
			
		}	
		public void WelchesIlvl()
		{
			Console.Clear();
			foreach (Slot slot in slots)
			{
				Console.WriteLine("Nun Berechnen wir Ihr Itemlevel!");
				Console.WriteLine($"Bitte geben Sie das Ilvl für {slot.Name} ein.");
				double.TryParse(Console.ReadLine(), out double ilvl);
				slot.SetIlvlundMainstat(ilvl);
				Console.Clear();


			}

		} // User wird nach Itemleveln seiner Slots gefragt
		public void ErzeugeSlots()
		{
			slots.Clear();
			Slot helm = new Slot("Helm", 1);
			Slot halskette = new Slot("Halskette", 2);
			Slot schulter = new Slot("Schulter", 3);
			Slot brust = new Slot("Brust", 4);
			Slot rücken = new Slot("Rücken", 5);
			Slot armschienen = new Slot("Armschienen", 6);
			Slot hände = new Slot("Hände", 7);
			Slot gürtel = new Slot("Gürtel", 8);
			Slot hosen = new Slot("Hosen", 9);
			Slot füße = new Slot("Füße", 10);
			Slot ring1 = new Slot("Ring1", 11);
			Slot ring2 = new Slot("Ring2", 12);
			Slot trinket1 = new Slot("Trinket1", 13);
			Slot trinket2 = new Slot("Trinket2", 14);
			Slot mainhand = new Slot("Mainhand", 15);
			Slot offhand = new Slot("Offhand", 16);
			slots.Add(helm);
			slots.Add(halskette);
			slots.Add(schulter);
			slots.Add(brust);
			slots.Add(rücken);
			slots.Add(armschienen);
			slots.Add(hände);
			slots.Add(gürtel);
			slots.Add(hosen);
			slots.Add(füße);
			slots.Add(ring1);
			slots.Add(ring2);
			slots.Add(trinket1);
			slots.Add(trinket2);
			slots.Add(mainhand);
			slots.Add(offhand);
		} // Slots werden erzeugt
		public void Endcard(string charName, string userSpezialisierung, string userKlasse)
		{
			Console.WriteLine("Sie haben nun alle Eingaben getan! Bitte Drücken Sie eine beliebige Taste um Ihre Ergebnisse anzuzeigen!:)");
			Console.ReadKey();
			Console.Clear();
			Console.WriteLine($"Dein {userKlasse} mit dem Namen {charName},welcher die Spezialisierung {userSpezialisierung} benutzt,");
			double averageIlvl = slots.OfType<Slot>().Average(slot => slot.Ilvl);
			Console.WriteLine($"hat ein durchschnittliches Itemlevel von {averageIlvl}.");
			double totalMainstat = slots.OfType<Slot>().Sum(slot => slot.Mainstat);
			Console.WriteLine($"Daraus resultiert ein Gesammtwert von {totalMainstat} {mainstat}.");
			Console.WriteLine("\n\n\nUm sich Ihre einzelnen Eingaben anzuschauen drücken Sie bitte eine beliebige Taste");
			Console.ReadKey();
            Console.WriteLine($"Dein Charaktername: {charName}");
            Console.WriteLine($"Deine Klasse: {userKlasse}");
            Console.WriteLine($"Deine Spezialisierung {userSpezialisierung}");
			Console.WriteLine("\n\nMöchten Sie die einzelnen Itemlevel die Sie eingegeben haben nochmals ansehen?");
			Console.WriteLine("Bitte Antworten sie mit \"Ja\",\"ja\" oder \"1\" zum bestätigenoder \"Nein\" zum Beenden des Programms ");
			string janein = Console.ReadLine();
			if (janein == "Ja" || janein == "ja" || janein == "1")
			{
				Console.WriteLine("Die folgenden Itemlevel waren deine Eingabe:");
				foreach (Slot slot in slots)
				{
					Console.WriteLine($"Dein/e {slot.Name} hat ein Itemlevel von {slot.Ilvl} und einen {slot.Mainstat} {mainstat}.");
				}
			}
			else
			{
				Console.WriteLine("Goodbye!");
			}
		} // Darstellung von Userdaten leider ohne Grafik :(
	}
}
