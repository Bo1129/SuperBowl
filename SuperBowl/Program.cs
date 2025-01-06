namespace SuperBowl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Beolvasás
            List<Donto> dontok = new();
            foreach (var sor in File.ReadAllLines("SuperBowl.txt").Skip(1))
            {
                dontok.Add(new Donto(sor));
            }
        }
    }
}
