/*
 * Created by SharpDevelop.
 * User: schulung
 * Date: 26.04.2022
 * Time: 11:32
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Text.RegularExpressions;
using System.IO;

namespace Zeugnis_Eingabe
{
	class Program
	{
		public static void Main(string[] args)
		{
			string Name;
			string Datum;
			
			StreamWriter sw = new StreamWriter(@"C:\Users\schulung.SCHULUNGNB-03\Documents\SPT-2022-Gruppe-2\Zeugnis.txt");
			//durchschnitt
			string eingabe = "0";
			int anzahl = 10;
			int gesamtwert;
			int aktuelleZahl = 0;
			
			int Deutsch, Englisch, Mathe, Biologie, Geschichte, Sport, Musik, Chemie;
			
			string Lk1;
			string Lk2;
			
			int AnzahlUnterkurse=0;
			
			int Fehltage;
			int EntschuldigteFehltage;
			
			int Lk1Note=0, Lk2Note=0;
			
			double Notendurchschnitt=0;
			
			Console.Write("Name: ");
			Name = Convert.ToString(Console.ReadLine());
			Regex rgx = new Regex("[^a-zA-Z- _]+");
			if (rgx.IsMatch(Name))
			{
				Console.Write("false");
				Console.Clear();
				
				Console.Write("Name: ");
				Name = Convert.ToString(Console.ReadLine());
			}
			
			Console.Write("Datum: ");
			Datum = Convert.ToString(Console.ReadLine());
			
			Console.Write("Deutsch: ");
			Deutsch = Convert.ToInt32(Console.ReadLine());
			
			Console.Write("Englisch: ");
			Englisch = Convert.ToInt32(Console.ReadLine());
			
			Console.Write("Mathe: ");
			Mathe = Convert.ToInt32(Console.ReadLine());
			
			Console.Write("Biologie: ");
			Biologie = Convert.ToInt32(Console.ReadLine());
			
			Console.Write("Geschichte: ");
			Geschichte = Convert.ToInt32(Console.ReadLine());
			
			Console.Write("Sport: ");
			Sport = Convert.ToInt32(Console.ReadLine());
			
			Console.Write("Musik: ");
			Musik = Convert.ToInt32(Console.ReadLine());
			
			Console.Write("Chemie: ");
			Chemie = Convert.ToInt32(Console.ReadLine());
			
			
			
			Console.Write("1.Leistungskurs: ");
			Lk1 = Convert.ToString(Console.ReadLine());
			
			
			Console.Write("2.Leistungskurs: ");
			Lk2 = Convert.ToString(Console.ReadLine());

			
			if (Lk1=="Biologie")
			{
				Lk1Note=Biologie;
			}
			if (Lk2=="Biologie")
			{
				Lk2Note=Biologie;
			}
			if (Lk1=="Mathe")
			{
				Lk1Note=Mathe;
			}
			if (Lk2=="Mathe")
			{
				Lk2Note=Mathe;
			}
			if (Lk1=="Deutsch")
			{
				Lk1Note=Deutsch;
			}
			if (Lk2=="Deutsch")
			{
				Lk2Note=Deutsch;
			}
			if (Lk1=="Englisch")
			{
				Lk1Note=Englisch;
			}
			
			if (Lk2=="Englisch")
			{
				Lk2Note=Englisch;
			}
			if (Lk1=="Chemie")
			{
				Lk1Note=Chemie;
			}
			if (Lk2=="Chemie")
			{
				Lk2Note=Chemie;
			}
			if (Lk1=="Geschichte")
			{
				Lk1Note=Geschichte;
			}
			if (Lk2=="Geschichte")
			{
				Lk2Note=Geschichte;
			}
			if (Lk1=="Sport")
			{
				Lk1Note=Sport;
			}
			if (Lk2=="Sport")
			{
				Lk2Note=Sport;
			}
			if (Lk2=="Musik")
			{
				Lk2Note=Musik;
			}
			if (Lk1=="Musik")
			{
				Lk1Note=Musik;
			}
			
			
			Console.Write("Entschuldigte Fehltage: ");
			EntschuldigteFehltage = Convert.ToInt32(Console.ReadLine());
			
			Console.Write("Unentschuldigte Fehltage: ");
			Fehltage = Convert.ToInt32(Console.ReadLine());
			
			
			
			
			
			//Durschnitt berechnen
			
			gesamtwert = Deutsch+Englisch+Mathe+Biologie+Chemie+Musik+Sport+Geschichte+Lk1Note+Lk2Note;
			
			while(eingabe != "-1")
			{
				Console.WriteLine("Geben Sie -1 ein um den Durchschnitt zu berechnen");
				
				eingabe = Console.ReadLine();
				if(eingabe == "-1")
				{
					Console.WriteLine("--------------------------------------------------------------");
					double durchschnitt = (double)gesamtwert / (double)anzahl;
					durchschnitt = Math.Round(durchschnitt,1);
					Console.WriteLine("Der Durchschnitt ist " + durchschnitt);
					
					Notendurchschnitt = (17-durchschnitt)/3;
					Notendurchschnitt= Math.Round(Notendurchschnitt,1);
					Console.WriteLine("Umgerechnet in Noten ist der Durchschnitt " + Notendurchschnitt);
				}
				
				if(Int32.TryParse(eingabe, out aktuelleZahl) && aktuelleZahl >0 && aktuelleZahl<16){
					gesamtwert=gesamtwert+aktuelleZahl;
				}
				else
				{
					if(!(eingabe=="-1"))
					{
						Console.WriteLine("Bitte geben Sie ganzzahlige Werte zwischen 1 und 15 ein!");
					}
					continue;
				}
				anzahl++;
			}
			
			Console.Clear();
			Console.WriteLine("======================Zeugnis======================");
			Console.WriteLine("Name: "+ Name);
			Console.WriteLine("Datum: "+ Datum);
			Console.WriteLine("===================================================");
			Console.WriteLine("");
			Console.WriteLine("Leistungskurse: " + Lk1 + ", " + Lk2);
			Console.WriteLine("");
			Console.WriteLine("Mathe: "+ Mathe);
			Console.WriteLine("Deutsch: "+ Deutsch);
			Console.WriteLine("Englisch: "+ Englisch);
			Console.WriteLine("Biologie: "+ Biologie);
			Console.WriteLine("Chemie: "+ Chemie);
			Console.WriteLine("Sport: "+ Sport);
			Console.WriteLine("Musik: "+ Musik);
			Console.WriteLine("Geschichte: "+ Geschichte);
			Console.WriteLine("");
			Console.WriteLine("Durchschnittsnote: " + Notendurchschnitt);
			Console.WriteLine("===================================================");
			Console.WriteLine("Fehltage: " + EntschuldigteFehltage);
			Console.WriteLine("Davon Unentschuldigt: "+Fehltage);
			Console.WriteLine("");
			
			
			sw.WriteLine("======================Zeugnis======================");
			sw.WriteLine("Name: "+ Name);
			sw.WriteLine("Datum: "+ Datum);
			sw.WriteLine("===================================================");
			sw.WriteLine("");
			sw.WriteLine("Leistungskurse: " + Lk1 + ", " + Lk2);
			sw.WriteLine("");
			sw.WriteLine("Mathe: "+ Mathe);
			sw.WriteLine("Deutsch: "+ Deutsch);
			sw.WriteLine("Englisch: "+ Englisch);
			sw.WriteLine("Biologie: "+ Biologie);
			sw.WriteLine("Chemie: "+ Chemie);
			sw.WriteLine("Sport: "+ Sport);
			sw.WriteLine("Musik: "+ Musik);
			sw.WriteLine("Geschichte: "+ Geschichte);
			sw.WriteLine("");
			sw.WriteLine("Durchschnittsnote: " + Notendurchschnitt);
			sw.WriteLine("===================================================");
			sw.WriteLine("Fehltage: " + EntschuldigteFehltage);
			sw.WriteLine("Davon Unentschuldigt: "+Fehltage);
			sw.WriteLine("");
			
			if (Sport<5)
			{
				AnzahlUnterkurse= AnzahlUnterkurse +1;
			}
			if (Deutsch<5)
			{
				AnzahlUnterkurse= AnzahlUnterkurse +1;
			}
			if (Mathe<5)
			{
				AnzahlUnterkurse= AnzahlUnterkurse +1;
			}
			if (Englisch<5)
			{
				AnzahlUnterkurse= AnzahlUnterkurse +1;
			}
			if (Biologie<5)
			{
				AnzahlUnterkurse= AnzahlUnterkurse +1;
			}
			if (Chemie<5)
			{
				AnzahlUnterkurse= AnzahlUnterkurse +1;
			}
			if (Geschichte<5)
			{
				AnzahlUnterkurse= AnzahlUnterkurse +1;
			}
			if (Musik<5)
			{
				AnzahlUnterkurse= AnzahlUnterkurse +1;
			}
			if (AnzahlUnterkurse>1)
			{
				Console.Write("Schüler*in wird nicht versetzt.");
				sw.Write("Schüler*in wird nicht versetzt.");
			}
			else
				if (Fehltage>29)
			{
				Console.Write("Schüler*in wird nicht versetzt.");
				sw.Write("Schüler*in wird nicht versetzt.");
			}
			if (AnzahlUnterkurse<2 && Fehltage<30)
			{
				Console.Write("Schüler*in wird versetzt.");
				sw.Write("Schüler*in wird versetzt.");
			}
			
			
			sw.Close();
			Console.ReadKey(true);
		}
	}
	
}