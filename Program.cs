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