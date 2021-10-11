using System;
using System.Collections.Generic;
using System.Xml;

namespace KryptoWarZV0._5
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Erster Test mit Git Hub");
            Console.WriteLine("Das hier geschriebene ist die Veränderung im Code");

            #region Willkommen bla bla Namen werden Trainer zugewiesen

            Trainer t1;
            Trainer t2;
            string trainerNameEingabe;

            Console.WriteLine("Willkommen");
            Console.WriteLine("Bitte gib deinen Namen ein: ");
            trainerNameEingabe = Console.ReadLine();

            t1 = new Trainer(trainerNameEingabe);

            Console.WriteLine("\n Trainer 2 gib deinen Namen ein: ");
            trainerNameEingabe = Console.ReadLine();

            t2 = new Trainer(trainerNameEingabe);

            //Schleife für Abfrage nach ernuter KryptoMoon Auswahl
            char jaNeuauswahl;
            int zählerKämpfe = 0;
          
            do
            {
                Console.WriteLine("\n Es treten an {0} vs {1} ", t1.TrainerName, t2.TrainerName);

                #endregion Willkommen bla bla Namen werden Trainer zugewiesen

                #region Random Aufruf (welcher Trainer sucht sich als erster das KryptoMoon aus)

                Console.WriteLine("\n *beeep* ZufallsGenerator wird hochgefahren *beep* ");
                //aufrufr
                int userStart = TrainerStart();
                if (userStart == 1)
                {
                    t1.StartTrainer = true;
                    Console.WriteLine("OhOhOh {0} du darfst mit der Auswahl beginnen, entscheide Weise!", t1.TrainerName);
                }
                else
                {
                    t2.StartTrainer = true;
                    Console.WriteLine("OhOhOh {0} du darfst mit der Auswahl beginnen, entscheide Weise!", t2.TrainerName);
                }

                #endregion Random Aufruf (welcher Trainer sucht sich als erster das KryptoMoon aus)

                #region KrytoMoonListeAufrufTrainer

                List<KryptoMoon> kryptoMoonListe = erstelleKryptoMoonListe();

                Console.WriteLine("************ ************ KRYPTOMOON AUSWAHL ************ ***********");

                foreach (KryptoMoon kryptoMoon in kryptoMoonListe)
                {
                    //Das WriteLine(); ist nur für eine LeerZeile da.
                    Console.WriteLine();
                    Console.WriteLine(kryptoMoon.KryptoMoonName);
                    Console.WriteLine("Lebenspunkte: {0}", kryptoMoon.KryptoMoonLebensPunkte);
                    Console.WriteLine("Attacke 1: {0} mit einem Schaden von: {1} Schadenspunkten", kryptoMoon.Attacke1Name, kryptoMoon.Attacke1Schaden);
                }

                #endregion KrytoMoonListeAufrufTrainer

                #region Trainer der Anfängt sucht sich als erster das Moon aus

                if (t1.StartTrainer == true)
                {
                    int trainerAuswahl;
                    bool trainerAuswahlCheck;

                    Console.WriteLine("Na {0}, für welches KryptoMoon hast du dich entschieden?", t1.TrainerName);
                    trainerAuswahlCheck = Int32.TryParse(Console.ReadLine(), out trainerAuswahl);

                    while (!trainerAuswahlCheck || trainerAuswahl > kryptoMoonListe.Count)

                    {
                        Console.WriteLine("Falsche Eingabe ERROOOOOR");
                        Console.WriteLine();
                        Console.WriteLine("Versuchen Sie es doche einfach erneut");
                        trainerAuswahlCheck = Int32.TryParse(Console.ReadLine(), out trainerAuswahl);
                    }
                    // Auswahl - 1 da Index ab 0 beginnt (Informatik VS User)
                    t1.KryptoMoon = kryptoMoonListe[trainerAuswahl - 1];
                    Console.WriteLine("{0}, Du hast dich also für {1} entschieden. Viel Erfolg!", t1.TrainerName, t1.KryptoMoon.KryptoMoonName);
                }
                else
                {
                    int trainerAuswahl;
                    bool trainerAuswahlCheck;

                    Console.WriteLine("Na {0}, für welches KryptoMoon hast du dich entschieden?", t1.TrainerName);
                    trainerAuswahlCheck = Int32.TryParse(Console.ReadLine(), out trainerAuswahl);

                    while (!trainerAuswahlCheck || trainerAuswahl > kryptoMoonListe.Count)

                    {
                        Console.WriteLine("Falsche Eingabe ERROOOOOR");
                        Console.WriteLine();
                        Console.WriteLine("Versuchen Sie es doche einfach erneut");
                        trainerAuswahlCheck = Int32.TryParse(Console.ReadLine(), out trainerAuswahl);
                    }
                    // Auswahl - 1 da Index ab 0 beginnt (Informatik VS User)
                    t2.KryptoMoon = kryptoMoonListe[trainerAuswahl - 1];
                    Console.WriteLine("{0}, Du hast dich also für {1} entschieden. Viel Erfolg!", t2.TrainerName, t2.KryptoMoon.KryptoMoonName);
                }

                #endregion Trainer der Anfängt sucht sich als erster das Moon aus

                #region Zweiter Trainer sucht sich das Moon aus

                if (t1.StartTrainer != true)
                {
                    int trainerAuswahl;
                    bool trainerAuswahlCheck;

                    Console.WriteLine("Na {0}, für welches KryptoMoon hast du dich entschieden?", t1.TrainerName);
                    trainerAuswahlCheck = Int32.TryParse(Console.ReadLine(), out trainerAuswahl);

                    while (!trainerAuswahlCheck || trainerAuswahl > kryptoMoonListe.Count)

                    {
                        Console.WriteLine("Falsche Eingabe ERROOOOOR");
                        Console.WriteLine();
                        Console.WriteLine("Versuchen Sie es doche einfach erneut");
                        trainerAuswahlCheck = Int32.TryParse(Console.ReadLine(), out trainerAuswahl);
                    }
                    // Auswahl - 1 da Index ab 0 beginnt (Informatik VS User)
                    t1.KryptoMoon = kryptoMoonListe[trainerAuswahl - 1];
                    Console.WriteLine("{0}, Du hast dich also für {1} entschieden. Viel Erfolg!", t1.TrainerName, t1.KryptoMoon.KryptoMoonName);
                }
                else
                {
                    int trainerAuswahl;
                    bool trainerAuswahlCheck;

                    Console.WriteLine("Na {0}, für welches KryptoMoon hast du dich entschieden?", t2.TrainerName);
                    trainerAuswahlCheck = Int32.TryParse(Console.ReadLine(), out trainerAuswahl);

                    while (!trainerAuswahlCheck || trainerAuswahl > kryptoMoonListe.Count)

                    {
                        Console.WriteLine("Falsche Eingabe ERROOOOOR");
                        Console.WriteLine();
                        Console.WriteLine("Versuchen Sie es doche einfach erneut");
                        trainerAuswahlCheck = Int32.TryParse(Console.ReadLine(), out trainerAuswahl);
                    }
                    // Auswahl - 1 da Index ab 0 beginnt (Informatik VS User)
                    t2.KryptoMoon = kryptoMoonListe[trainerAuswahl - 1];
                    Console.WriteLine("{0}, Du hast dich also für {1} entschieden. Viel Erfolg!", t2.TrainerName, t2.KryptoMoon.KryptoMoonName);
                }

                #endregion Zweiter Trainer sucht sich das Moon aus

                #region Kampf Aufruf

                char ja;
                do
                {
                    Kampf(t1, t2);
                    zählerKämpfe ++;
                    Console.WriteLine("Möchtet ihr noch einmal mit den gleichen Moons Kämpfen? Drücke j für ja, zum beenden n drücken");
                    ja = Convert.ToChar(Console.ReadLine());
                }
                 while (ja == 'j');
              
                Console.WriteLine("Möchter ihr zur KryptoMoon Auswahl und erneut Kämpfen?  j für ja, zum beenden n drücken");
                jaNeuauswahl = Convert.ToChar(Console.ReadLine());
                 
            } while (jaNeuauswahl == 'j');

            #endregion Kampf Aufruf

            Console.WriteLine("Anzahl der Kämpfe: " + zählerKämpfe);
        }

        #region Random Funktion  2 Zahlen

        private static int TrainerStart()
        {
            Random rand2 = new Random();
            int startTrainer;

            startTrainer = rand2.Next(1, 2);

            if (startTrainer == 1)
            {
                return startTrainer;
            }
            else
            {
                return startTrainer;
            }
        }

        #endregion Random Funktion  2 Zahlen

        #region KrytoMoonListe aus XML Datei erstellen

        private static List<KryptoMoon> erstelleKryptoMoonListe()
        {
            // Liste enthält Elemente vom Typ "Klasse KrytoMoon" und wird an dieser stelle initialisiert
            List<KryptoMoon> liste = new List<KryptoMoon>();
            //XML-DateiAuslesen umd sich liste.Add zu sparen

            XmlDocument doc = new XmlDocument();
            doc.Load("C:/Users/CC-Student/source/repos/KryptoWarZV0.5/KryptoWarZV0.5/KryotoMoonData.xml");
            // Wurzelelement root
            XmlElement root = doc.DocumentElement;
            XmlNodeList nodes = root.SelectNodes("KryptoMoon");
            int i = 0;
            string name;
            int lebenspunkte;
            string attacke1;
            int attacke1Schaden;
            string attacke2;
            int attacke2Schaden;

            foreach (XmlNode node in nodes)//node = knoten
            {
                Console.WriteLine("******************************************************************************");
                // use node variable here for your beeds
                XmlNodeList childNodes = node.ChildNodes;

                name = childNodes.Item(0).InnerText;
                lebenspunkte = Convert.ToInt32(childNodes.Item(1).InnerText);
                attacke1 = childNodes.Item(2).InnerText;
                attacke1Schaden = Convert.ToInt32(childNodes.Item(3).InnerText);
                attacke2 = childNodes.Item(4).InnerText;
                attacke2Schaden = Convert.ToInt32(childNodes.Item(5).InnerText);

                liste.Add(new KryptoMoon(i, name, lebenspunkte, attacke1, attacke1Schaden, attacke2, attacke2Schaden));

                i++;
            }

            return liste;
        }

        #endregion KrytoMoonListe aus XML Datei erstellen

        #region Kampf Funktion

        public static void Kampf(Trainer t1, Trainer t2)
        {
            int lebensPunkteMoonT1;
            int lebensPunkteMoonT2;
            int angriffEinsT1;
            int angriffZweiT1;
            int angriffEinsT2;
            int angriffZweiT2;

            lebensPunkteMoonT1 = t1.KryptoMoon.KryptoMoonLebensPunkte;
            lebensPunkteMoonT2 = t2.KryptoMoon.KryptoMoonLebensPunkte;

            angriffEinsT1 = t1.KryptoMoon.Attacke1Schaden;
            angriffZweiT1 = t1.KryptoMoon.Attacke2Schaden;

            angriffEinsT2 = t2.KryptoMoon.Attacke1Schaden;
            angriffZweiT2 = t2.KryptoMoon.Attacke2Schaden;

            #region Welcher Trainer fängt an Anzugreifen

            int erster;
            erster = TrainerStart();

            Console.WriteLine("\nLass uns die Kämpfe beginnen");

            if (erster == 1)
            {
                t1.StartTrainer = true;
                t2.StartTrainer = false;
                Console.WriteLine("{0} du darfst mit dem Angriff beginnen!", t1.TrainerName);
            }
            else
            {
                t2.StartTrainer = true;
                t1.StartTrainer = false;
                Console.WriteLine("{0} du darfst mit dem Angriff beginnen!", t2.TrainerName);
            }

            #endregion Welcher Trainer fängt an Anzugreifen

            #region Trainer  Fängt an

            int attackenauswahl;

            Console.WriteLine("*Kurz ein Bauen, wird Spannend*");

            do
            {
                if (t1.StartTrainer == true)
                {
                    Console.WriteLine("Mit Welcher Attacke möchtest Anreifen?");
                    Console.WriteLine("\n1) " + t1.KryptoMoon.Attacke1Name);
                    Console.WriteLine("\n2) " + t1.KryptoMoon.Attacke2Name);
                    attackenauswahl = Convert.ToInt32(Console.ReadLine());

                    switch (attackenauswahl)
                    {
                        case 1:
                            lebensPunkteMoonT2 = lebensPunkteMoonT2 - angriffEinsT1;
                            if (lebensPunkteMoonT2 > 0)
                            {
                                Console.WriteLine("ATTACKE {0} Lädt sich auf BOOOOOOMMM BÄÄÄÄÄÄMMMMMMMMMM", t1.KryptoMoon.Attacke1Name);
                                Console.WriteLine("{0},dein {1} hat noch {2} Lebenspunkte", t2.TrainerName, t2.KryptoMoon.KryptoMoonName, lebensPunkteMoonT2);
                                t1.StartTrainer = false;
                                t2.StartTrainer = true;
                            }
                            else
                            {
                                Console.WriteLine("{0} hat keine Lebenspunkte mehr  Dr.Chain ist Unterwegs.", t2.KryptoMoon.KryptoMoonName);
                                Console.WriteLine("Herzlichen Glückwunsch {0} und {1} habt Gewonnen!", t2.TrainerName, t2.KryptoMoon.KryptoMoonName);
                            }
                            break;

                        case 2:
                            lebensPunkteMoonT2 = lebensPunkteMoonT2 - angriffZweiT1;
                            if (lebensPunkteMoonT2 > 0)
                            {
                                Console.WriteLine("ATTACKE {0} Lädt sich auf BOOOOOOMMM BÄÄÄÄÄÄMMMMMMMMMM", t1.KryptoMoon.Attacke1Name);
                                Console.WriteLine("{0},dein {1} hat noch {2} Lebenspunkte", t2.TrainerName, t2.KryptoMoon.KryptoMoonName, lebensPunkteMoonT2);
                                t1.StartTrainer = false;
                                t2.StartTrainer = true;
                            }
                            else
                            {
                                Console.WriteLine("{0} hat keine Lebenspunkte mehr Dr.Chain ist Unterwegs.", t2.KryptoMoon.KryptoMoonName);
                                Console.WriteLine("Herzlichen Glückwunsch {0} und {1} habt Gewonnen!", t2.TrainerName, t2.KryptoMoon.KryptoMoonName);
                            }
                            break;
                    }
                }
                else if (t2.StartTrainer == true && t1.KryptoMoon.KryptoMoonLebensPunkte > 0)
                {
                    Console.WriteLine("Mit Welcher Attacke möchtest Anreifen?");
                    Console.WriteLine("\n1) " + t2.KryptoMoon.Attacke1Name);
                    Console.WriteLine("\n2) " + t2.KryptoMoon.Attacke2Name);
                    attackenauswahl = Convert.ToInt32(Console.ReadLine());

                    switch (attackenauswahl)
                    {
                        case 1:
                            lebensPunkteMoonT1 = lebensPunkteMoonT1 - angriffEinsT2;
                            if (lebensPunkteMoonT1 > 0)
                            {
                                Console.WriteLine("ATTACKE {0} Lädt sich auf BOOOOOOMMM BÄÄÄÄÄÄMMMMMMMMMM", t1.KryptoMoon.Attacke1Name);
                                Console.WriteLine("{0},dein {1} hat noch {2} Lebenspunkte", t1.TrainerName, t1.KryptoMoon.KryptoMoonName, lebensPunkteMoonT1);
                                t2.StartTrainer = false;
                                t1.StartTrainer = true;
                            }
                            else
                            {
                                Console.WriteLine("{0} hat keine Lebenspunkte mehr  Dr.Chain ist Unterwegs.", t1.KryptoMoon.KryptoMoonName);
                                Console.WriteLine("Herzlichen Glückwunsch {0} und {1} habt Gewonnen!", t1.TrainerName, t1.KryptoMoon.KryptoMoonName);
                            }
                            break;

                        case 2:
                            lebensPunkteMoonT1 = lebensPunkteMoonT1 - angriffZweiT2;
                            if (lebensPunkteMoonT1 > 0)
                            {
                                Console.WriteLine("ATTACKE {0} Lädt sich auf BOOOOOOMMM BÄÄÄÄÄÄMMMMMMMMMM", t1.KryptoMoon.Attacke1Name);
                                Console.WriteLine("{0},dein {1} hat noch {2} Lebenspunkte", t1.TrainerName, t1.KryptoMoon.KryptoMoonName, lebensPunkteMoonT1);
                                t2.StartTrainer = false;
                                t1.StartTrainer = true;
                            }
                            else
                            {
                                Console.WriteLine("{0} hat keine Lebenspunkte mehr Dr.Chain ist Unterwegs.", t1.KryptoMoon.KryptoMoonName);
                                Console.WriteLine("Herzlichen Glückwunsch {0} und {1} habt Gewonnen!", t1.TrainerName, t1.KryptoMoon.KryptoMoonName);
                            }
                            break;
                    }
                }
            }
            while (lebensPunkteMoonT1 >= 0 && lebensPunkteMoonT2 >= 0);

            #endregion Trainer  Fängt an

            Console.WriteLine("Kampf beendet.");
        }

        #endregion Kampf Funktion
    }
}