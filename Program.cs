namespace ConsoleApp16

{
    internal class Program
    {
        static List<string> Versenyzok;

        static void Main(string[] args)
        {

            Versenyzok = File.ReadAllLines("bin\\Data\\pilotak.csv")
                .Skip(1)
               .Select(sor => sor.Split(';')[1])
               .ToList();

            Console.WriteLine($"3. feladat: Versenyzők száma: {Versenyzok.Count()}");
            
            

            class Versenyzo
        
        {
            string nev;
            DateTime szuletesiDatum;
            string nemzetiseg;
            int? rajtszam;


            public string Nev { get => nev; set => nev = value; }
            public DateTime SzuletesiDatum { get => szuletesiDatum; set => szuletesiDatum = value; }
            public string Nemzetiseg { get => nemzetiseg; set => nemzetiseg = value; }
            public int? Rajtszam { get => rajtszam; set => rajtszam = value; }
            
            public Versenyzo(string nev, DateTime szuletesiDatum, string nemzetiseg, int? rajtszam)
            {
                Nev = nev;
                SzuletesiDatum = szuletesiDatum;
                Nemzetiseg = nemzetiseg;
                Rajtszam = rajtszam;
            }

            public Versenyzo(string adatsor)
            {
                string[] adatok = adatsor.Split(';');

                Nev = adatok[0];
                SzuletesiDatum = DateTime.Parse(adatok[1]);
                Nemzetiseg = adatok[2];
                if (string.IsNullOrEmpty(adatok[3].Trim()))
                {
                    Rajtszam = null;
                }
                else
                {
                    Rajtszam = int.Parse(adatok[3].Trim());
                }
            }
        }
    }
}