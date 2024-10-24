namespace Itemlevelrechner
{
	internal class Program
	{
		static void Main(string[] args)
		{

			Itemlevelrechner programm = new Itemlevelrechner();
			programm.Starte();
			// * Erster Gedanke * \\
			// * programmiere einen Itemlevelrechner
			// * insgesammt gibt es 14 Itemslots
			// * 14 ilvl ergeben 1 avg. ilvl
			// * die momentane ilvl range = zwischn 540 - 639
			// * Slots sind
			// * Helm, Halskette, Schulter, Brust, Rücken ,Armschienen, Handschuhe, Gürtel, Hosen, Schuhe, Ring1, Ring2, Trinket1,Trinket2, Waffenhand, Offhand
			// * Man soll seine Klasse eintragen können z.b.:
			// * Magier, Krieger, Schurke, Druide, Jäger, Hexenmeister, Schamane, Priester, Mönch, Dämonenjäger, Rufer, Todesritter, Paladin
			// * Verschiedene Klassen haben verschiedene Mainstats:
			// * Magier, Priester, Rufer benutzen ausschließlich Intelligenz
			// * Krieger, Todesritter benutzen ausschließlich Stärke 
			// * Schurke, Jäger benutzen ausschließlich Beweglichkeit
			// *
			// * Es gibt verschiedene Speziallisierungen 
			// * 1-Krieger: Schutz [Str], Furor [Str], Waffen [Str]
			// * 2-Todesritter: Blut [Str], Frost [Str], Unheilig [Str]
			// * 3-Paladin: Schutz [Str], Vergeltung [Str], Heilig [Int]
			// * 4-Jäger: Überleben[Bew], Tierherrschaft[Bew], Treffsicherheit [Bew]
			// * 5-Schamane: Elementar[Int], Verstärker [Bew], Wiederherstellung [Int]
			// * 6-Druide: Wächter [Bew], Feral [Bew], Gleichgewicht [Int], Wiederherstellung [Int]
			// * 7-Priester: Heilig [Int], Disziplin [Int], Schatten [Int]
			// * 8-Hexenmeister: Zerstörung [Int], Gebrechen [Int], Dämonen [Int]
			// * 9-Rufer: Verstärkung [Int], Verheerung [Int], Bewahrung [Int]  
			// * 10-Mönch: Braumeister [Bew], Nebelwirker [Int], Windläufer [Bew]
			// * 11-Dämonenjäger: Rachsucht [Bew], Verwüstung [Bew]
			// * 12-Magier: Arkan [Int], Frost [Int], Feuer [Int] 
			// * Man kann zwischen zwischen 3 Rollen unterscheiden: 
			// *Tank:
			// * -> Schutz-Krieger, Schutz-Paladin, Braumeister-Mönch, Rachsucht-Dämonenjäger, Wächter-Druide, Blut-Todesritter
			// * ->
			// * Heiler:
			// * -> Heilig-Paladin, Heilig-Priester, Disziplin-Priester, Bewahrung-Rufer,Wiederherstellung-Druide, Wiederherstellung-Schamane,Nebelwirker-Mönch
			// * ->
			// * DPS: 
			// * -> Arkan-/ Feuer-/Frost- Magier, Windläufer-Mönch, Furor-/Waffen-Krieger, Frost-/Unheilig-Todesritter
			// * -> Verstärkung-/Verheerung-Rufer, Verwüstung-Dämonenjäger, Überleben-/Tierherrschaft-/Treffsicherheit-Jäger
			// * -> Elementar-/Verstärker-Schamane, Feral-/Gleichgewicht-Druide, Zerstörung-/Gebrechen-/Dämonen-Hexenmeister
			// * -> Schatten-Priester, Vergeltung-Paladin, 
			// *
			// *
			// *
			// * Ziel des Programms: Man soll auswählen können welche Klasse und Spezialisierung man ist.
			// * Man soll in jedem Slot sagen können welches Itemlevel dieses hat.
			// * Das Programm soll dir dein Durchschnittliches Itemlevel ausgeben und wieviel Stärke / Intelligenz / Beweglichkeit man hat
		}
	}
}
