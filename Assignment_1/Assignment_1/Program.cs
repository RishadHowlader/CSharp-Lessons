using System;

namespace Assignment_1
{
	class Program
	{
		static void Main(string[] args)
		{

			/*Exercise5
			 * 
			 * Schreiben Sie ein Programm in dem Sie seite_a und seite_b für die 
			 * Seitenlängen eines Rechteckes definieren und auch mit einem Wert versehen.  
			 * Definieren Sie weitere 2 Variablen für den Umfang und die Fläche. Befüllen Sie diese 
			 * Variablen, indem Sie den Umfang und die Fläche mittels der Variablen seite_a und 
			 * seite_b berechnen. 
			 * Geben Sie Umfang und Fläche auf dem Bildschirm aus.
			 */

			int seite_a, seite_b, umfang, flaeche;
			seite_a = 3;
			seite_b = 4;

			//Rechteck
			umfang = 2 * (seite_a + seite_b);
			flaeche = seite_a * seite_b;

			Console.WriteLine("Umfang: {0} / Fläche {1}", umfang, flaeche);



			Console.ReadLine();
			/*
			 */


			/*Exercise6
			 * 
			 * Lesen Sie „interaktiv“ Ihren Vornamen und Ihren Nachnamen ein (d.h. es soll auf dem 
			 * Bildschirm eine entsprechende Eingabeaufforderung erscheinen und es soll dann die 
			 * Möglichkeiten geben die Namen einzugeben.) 
			 * Verwenden sie sowohl für Vornamen, als auch für Nachnamen eine eigene Variable ! 
			 * Im Anschluss an die Eingabe soll der Vorname und der Nachname wieder auf 
			 * Bildschirm ausgegeben werden
			 */

			string vorname, nachname;

			Console.WriteLine("Bitte geben Sie Ihren Vornamen und Nachnamen ein.");
			Console.Write("Vorname: ");
			vorname = Console.ReadLine();
			Console.Write("Nachname: ");
			nachname = Console.ReadLine();

			Console.WriteLine("Vorname: {0} / Nachname: {1}", vorname, nachname);

		}
	}
}
