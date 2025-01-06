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
            //4.
            Console.WriteLine($"4.feladat: Döntők száma: {dontok.Count}");
            //5.
            int pontkulonbseg = 0;
            foreach (var d in dontok)
            {
                string[] e = d.Eredmeny.Split('-');
                pontkulonbseg += Math.Abs(int.Parse(e[0]) - int.Parse(e[1]));
   
            }
            double atlag = (double)pontkulonbseg / dontok.Count;
            Console.WriteLine($"5. feladat: Átlagos pontkülönbség: {atlag:0.0}");
           
            RomaiSorszam r = new(dontok[20].SSz);
            Console.WriteLine(r.ArabSsz);

        }
    }
}
