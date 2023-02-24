namespace git_objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    class Element
    {
        //namn, Z (atomnummer), typ, smältpunkt, kokpunkt
        public string Name;
        public string Z;
        public string type;
        public double meltingPoint;
        public double boilingPoint;
    }

}