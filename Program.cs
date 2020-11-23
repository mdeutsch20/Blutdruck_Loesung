using System;
using System.Collections.Generic;

namespace Blutdruck_Loesung
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Messung> messungen = new List<Messung>();

            messungen.Add(new Messung(70, 130));
            messungen.Add(new Messung(80, 135));

            Messung m = new Messung(75, 140);
            messungen.Add(m);

            Console.WriteLine("Durchschnittliche Werte:");

            double sumObererWert = 0;
            double sumUntererWert = 0;

            foreach (var messung in messungen)
            {
                sumObererWert = sumObererWert + messung.ObererWert;
                sumUntererWert = sumUntererWert + messung.UntererWert;
            }

            double durchschnittObererWert = sumObererWert / messungen.Count;
            double durchschnittUntererWert = sumUntererWert / messungen.Count;

            Console.WriteLine($"unterer Wert: {durchschnittUntererWert}");
            Console.WriteLine($"oberer Wert: {durchschnittObererWert}");
        }
    }
}
