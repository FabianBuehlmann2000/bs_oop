using System;

namespace _1_Kreisberechnung
{
    class Program
    {
        static void Main(string[] args)
        {
            String response = "";
            double pi = 3.14159265359;

            //Solange task nicht beendet werden soll...
            while (response != "5")
            {
                Console.WriteLine("1: Umfang berechnen");
                Console.WriteLine("2: Fläche berechnen");
                Console.WriteLine("3: Bogen berechnen");
                Console.WriteLine("4: Segment berechnen");
                Console.WriteLine("5: App beenden");

                response = Console.ReadLine().ToString();

                float a = 0; //float for angle
                float r = 0; //float for radius

                switch (response)
                {
                    case "1": //Umfang
                        r = getFloat("Radius: ");
                        Console.WriteLine((2*r*pi).ToString());
                        break;

                    case "2": //Fläche
                        r = getFloat("Radius: ");
                        Console.WriteLine((r*r*pi).ToString());
                        break;

                    case "3": //Bogen
                        r = getFloat("Radius: ");
                        a = getFloat("Winkel: "); //get angle
                        Console.WriteLine(((r*pi*a) / 180).ToString());
                        break;

                    case "4": //Segment
                        r = getFloat("Radius: ");
                        a = getFloat("Winkel: "); //get angle
                        Console.WriteLine(((r*r*pi*a) / 360).ToString());
                        break;

                    case "5": //quit beenden
                        Console.WriteLine("beenden...");
                        break;

                    default: //invalid user input
                        Console.WriteLine("keine gütige Eingabe");
                        break;
                }
            }
        }

        //returns user input as float
        static float getFloat(String info)
        {
            Console.Write(info);
            try { return float.Parse(Console.ReadLine().ToString()); }
            catch
            {
                Console.WriteLine("Ungültige eingabe");
                return getFloat(info);
            }
        }
    }
}
