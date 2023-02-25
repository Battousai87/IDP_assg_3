using System.Xml.Linq;
using git_objects;

namespace git_objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Instansiera tre grundämnen syre, järn och guld och deras data med:
            syre 8 ickemetall 54.36 90.188
            järn 26 metall 1811 3134
            guld 79 metall 1337.33 3243*/

            Element oxygen = new Element();
            oxygen.name = "oxygen";
            oxygen.z = "8";
            oxygen.type = "non-metal";
            oxygen.meltingPoint = 54.36;
            oxygen.boilingPoint = 90.188;

            Element iron = new Element();
            iron.name = "iron";
            iron.z = "26";
            iron.type = "metal";
            iron.meltingPoint = 1811;
            iron.boilingPoint = 3134;

            Element gold = new Element();
            gold.name = "gold";
            gold.z = "79";
            gold.type = "metal";
            gold.meltingPoint = 1337.33;
            gold.boilingPoint = 3243;

            oxygen.Print();
            iron.Print();
            gold.Print();

            //skapa arrayen:
            Element[] elements = new Element[6]
            {
                oxygen, 
                iron, 
                gold,
                new Element()
                {
                    name = "hydrogen",
                    z = "1",
                    type = "non-metal",
                    meltingPoint = 13.99,
                    boilingPoint = 20.271,
                },
                new Element()
                {
                    name = "bromine",
                    z = "35",
                    type = "non-metal",
                    meltingPoint = 265.8,
                    boilingPoint = 332.0,
                },
                new Element()
                {
                    name = "mercury",
                    z = "80",
                    type = "metal",
                    meltingPoint = 234.310,
                    boilingPoint = 629.88,
                },
            };

            Console.WriteLine(); //Create blankrow for better readability in terminal.

            foreach (Element elem in elements)
            {
                Console.WriteLine(elem.name);
            }

            Console.WriteLine("\nOnly metal types:");

            foreach (Element elem in elements)
            {
                if (elem.type == "metal") {
                    Console.WriteLine(elem.name);
                }
                
            }

            Console.WriteLine("\nOnly elements melting bellow 273.16k(0°C) and boiling point above 273.16k.");

            foreach (Element elem in elements)
            {
                if (elem.meltingPoint < 273.16 && elem.boilingPoint > 273.16)
                {
                    Console.WriteLine(elem.name);
                }

            }


        }
    }

    class Element
    {
        //namn, Z (atomnummer), typ, smältpunkt, kokpunkt
        public string name;
        public string z;
        public string type;
        public double meltingPoint;
        public double boilingPoint;

        public void Print() {
            Console.WriteLine($"Element: {name}");
            Console.WriteLine($"  Type: {type}");
            Console.WriteLine($"  Melting point: {meltingPoint}");
            Console.WriteLine($"  Boiling point: {boilingPoint}");
        }


    }

}