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

                float r = getFloat("Radius"); //get radius
                float a = 0; //float for angle

                switch (response)
                {
                    case "1": //Umfang
                        Console.WriteLine((2*r*pi).ToString());
                        break;

                    case "2": //Fläche
                        Console.WriteLine((r*r*pi).ToString());
                        break;

                    case "3": //Bogen
                        a = getFloat("Winkel"); //get angle
                        Console.WriteLine(((r*pi*a) / 180).ToString());
                        break;

                    case "4": //Segment
                        a = getFloat("Winkel"); //get angle
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

        //returns user input as float (no error handling)
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
