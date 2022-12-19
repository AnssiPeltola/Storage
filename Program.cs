namespace Storage
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main(string[] args)
        {
            StorageFacility facility = new StorageFacility();
            facility.Add("A1", "Maito");
            facility.Add("A1", "Juusto");
            facility.Add("A1", "Jugurtti");
 
            facility.Add("F42", "Rullaluistimet");
            facility.Add("F42", "Rullaluistimet");
 
            facility.Add("G12", "Vasara");
            facility.Add("G12", "Kirves");
 
            // Printtaa kaikki hyllyt
            foreach (string unit in facility.StorageUnits())
            {
            Console.WriteLine(unit);
            }

            Console.WriteLine("");
 
            // Printtaa mitä hylly A1 sisältää
            foreach (string item in facility.Contents("A1"))
            {
            Console.WriteLine(item);
            }
 
            Console.WriteLine("");

            // Printtaa mitä hylly F42 sisältää 
            foreach (string item in facility.Contents("F42"))
            {
            Console.WriteLine(item);
            }

            // Poistetaan hyllyltä F42 Rullaluistimet, jolloin sinne jää vain yhdet
            facility.Remove("F42", "Rullaluistimet");

            Console.WriteLine("");
 
            // Printtaa mitä hylly F42 sisältää 
            foreach (string item in facility.Contents("F42"))
            {
            Console.WriteLine(item);
            }

            Console.WriteLine("");

            // Poistetaan hyllyltä F42 Rullaluistimet, jolloin rullaluistimia ei enää ole yhtään. Hylly pitäisi poistua myös.
            facility.Remove("F42", "Rullaluistimet");
 
            // Printataan hyllyt, josta näemme, että hylly F42 on poistunut.
            foreach (string unit in facility.StorageUnits())
            {
            Console.WriteLine(unit);
            }
        }
    }
}