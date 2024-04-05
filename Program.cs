using System;
using System.Collections.Generic;
using System.Linq;

class Quiz
{
    static void Main()
    {
        List<Ergebnis> highscore = new List<Ergebnis>();

        while (true)
        {
            List<Frage> fragenSchweiz = new List<Frage>
            {
                new Frage("Was ist die Hauptstadt der Schweiz?", new List<string> {"Aarau", "Bern", "Zürich"}, 2),
                new Frage("Wie viele Kantone hat die Schweiz?", new List<string> {"20", "26", "24"}, 2),
                new Frage("Welcher dieser Getränke kommt aus der Schweiz?", new List<string> {"Rivella", "CocaCola", "MezzoMix"}, 1),
                new Frage("Welcher dieser Schokoladenmarken kommt aus der Schweiz", new List<string> {"Lindt", "Frey", "Beide"}, 3),
                new Frage("In welchen Alpen befindet sich die höchste Erhebung der Schweiz?", new List<string> {"Walliser Alpen", "Berner Alpen", "Glarner Alpen"}, 1),
                new Frage("Welcher Fluss fließt durch die Stadt Zürich?", new List<string> {"Rhein", "Aare", "Limmat"}, 3),
                new Frage("Wie heißt der größte See der Schweiz?", new List<string> {"Lac Léman", "Vierwaldstättersee", "Bodensee"}, 1),
                new Frage("Was ist der offizielle Name der Schweiz?", new List<string> {"Schweizer Republik", "Schweizerische Eidgenossenschaft", "Schweizer Königreich"}, 2),
                new Frage("Welches Wahrzeichen ist auf der Flagge der Schweiz abgebildet?", new List<string> {"Matterhorn", "Eiger", "Monte Rosa"}, 1),
                new Frage("In welchem Jahr wurde die Schweizerische Eidgenossenschaft gegründet?", new List<string> {"1291", "1415", "1848"}, 1),
                new Frage("Welche der folgenden Sprachen ist keine der vier Amtssprachen der Schweiz?", new List<string> {"Deutsch", "Italienisch", "Spanisch"}, 3),
                new Frage("Welche berühmte Messe für zeitgenössische Kunst findet jährlich in Basel statt?", new List<string> {"Art Basel", "Art Geneva", "Art Zurich"}, 1),
                new Frage("Wie nennt man den traditionellen Schweizer Schinken?", new List<string> {"Bündnerfleisch", "Schüblig", "Landjäger"}, 1),
                new Frage("Welche Stadt wird als die Uhrenhauptstadt der Welt bezeichnet?", new List<string> {"Genf", "Bern", "Lausanne"}, 1),
                new Frage("Wie nennt man das Schweizer Nationalgericht, das aus geschmolzenem Käse und Weißwein besteht?", new List<string> {"Fondue", "Raclette", "Älplermagronen"}, 1),
            };

            List<Frage> fragenEuropa = new List<Frage>
            {
                new Frage("Was ist die Hauptstadt von Frankreich?", new List<string> {"London", "Berlin", "Paris"}, 3),
                new Frage("Welches Land hat die Form eines Stiefels?", new List<string> {"Griechenland", "Spanien", "Italien"}, 3),
                new Frage("Wo befindet sich der Eiffelturm?", new List<string> {"Paris", "Rom", "Madrid"}, 1),
                new Frage("Welches Land ist für seine Windmühlen bekannt?", new List<string> {"Niederlande", "Schweden", "Belgien"}, 1),
                new Frage("Welches Land hat die meisten Einwohner in Europa?", new List<string> {"Deutschland", "Russland", "Frankreich"}, 2),
                new Frage("Welches Land grenzt nicht an Deutschland?", new List<string> {"Österreich", "Belgien", "Polen"}, 2),
                new Frage("In welchem Land liegt Athen?", new List<string> {"Griechenland", "Italien", "Spanien"}, 1),
                new Frage("Wie heißt die Hauptstadt von Spanien?", new List<string> {"Lissabon", "Madrid", "Barcelona"}, 2),
                new Frage("Welches Land hat die längste Küstenlinie in Europa?", new List<string> {"Norwegen", "Griechenland", "Portugal"}, 1),
                new Frage("In welchem Land liegt der Vatikan?", new List<string> {"Italien", "Spanien", "Portugal"}, 1),
                new Frage("Welches Land hat die Währung Euro?", new List<string> {"Dänemark", "Schweiz", "Spanien"}, 3),
                new Frage("Wie heißt die Hauptstadt von Ungarn?", new List<string> {"Prag", "Budapest", "Warschau"}, 2),
                new Frage("Welches Land hat die meisten Inseln in Europa?", new List<string> {"Griechenland", "Schweden", "Italien"}, 1),
                new Frage("In welchem Land befindet sich der Vatikan?", new List<string> {"Italien", "Spanien", "Griechenland"}, 1),
                new Frage("Wie heißt die Hauptstadt von Polen?", new List<string> {"Warschau", "Bukarest", "Kiew"}, 1),
            };

            fragenSchweiz = fragenSchweiz.OrderBy(x => Guid.NewGuid()).ToList();
            fragenEuropa = fragenEuropa.OrderBy(x => Guid.NewGuid()).ToList();

            Console.WriteLine("Willkommen beim Quizspiel!");
            Console.WriteLine("Welche Kategorie möchtest du spielen?");
            Console.WriteLine("1. Schweiz");
            Console.WriteLine("2. Europa");
            Console.Write("Deine Auswahl (1 oder 2): ");
            int kategorieAuswahl = Convert.ToInt32(Console.ReadLine());

            List<Frage> fragen;

            if (kategorieAuswahl == 1)
            {
                fragen = fragenSchweiz;
            }
            else if (kategorieAuswahl == 2)
            {
                fragen = fragenEuropa;
            }
            else
            {
                Console.WriteLine("Ungültige Auswahl. Das Spiel wird beendet.");
                return;
            }

            int punkte = 0;

            foreach (Frage frage in fragen)
            {
                Console.WriteLine(frage.Fragetext);

                for (int i = 0; i < frage.Antworten.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {frage.Antworten[i]}");
                }

                Console.Write("Deine Antwort (1, 2, 3): ");
                var benutzerAntwort = Convert.ToInt32(Console.ReadLine());

                if (benutzerAntwort == frage.KorrekteAntwort)
                {
                    Console.WriteLine("Richtig!\n");
                    punkte++;
                }
                else
                {
                    Console.WriteLine($"Falsch! Die richtige Antwort war {frage.KorrekteAntwort}: {frage.Antworten[frage.KorrekteAntwort - 1]}\n");
                }
            }

            Console.Write("Dein Name: ");
            string spielerName = Console.ReadLine();

            Ergebnis ergebnis = new Ergebnis { SpielerName = spielerName, Punkte = punkte, Datum = DateTime.Now };
            highscore.Add(ergebnis);

            Console.WriteLine("\nHighscore:");

            foreach (Ergebnis result in highscore.OrderByDescending(x => x.Punkte))
            {
                Console.WriteLine($"{result.SpielerName}: {result.Punkte} Punkte am {result.Datum}");
            }

            Console.WriteLine($"\nSpiel beendet! Du hast {punkte} von {fragen.Count} Fragen richtig beantwortet.");

            Console.Write("Möchtest du das Spiel neustarten? (ja/nein): ");
            string neustartAntwort = Console.ReadLine().ToLower();

            if (neustartAntwort != "ja")
            {
                break;
            }
        }
    }
}

class Frage
{
    public string Fragetext { get; }
    public List<string> Antworten { get; }
    public int KorrekteAntwort { get; }

    public Frage(string fragetext, List<string> antworten, int korrekteAntwort)
    {
        Fragetext = fragetext;
        Antworten = antworten;
        KorrekteAntwort = korrekteAntwort;
    }
}

class Ergebnis
{
    public string SpielerName { get; set; }
    public int Punkte { get; set; }
    public DateTime Datum { get; set; }
}

