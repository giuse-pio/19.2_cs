namespace _19._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> nomi = new List<string> ();
            string nome;
            Console.WriteLine("Inserisci un nome (o premi invio per terminare): ");
            do
            {
                nome = Console.ReadLine();
                if (nome != null)
                {
                    nomi.Add(nome.ToLower());
                }
            }
            while (nome != "");
            

            Console.WriteLine("inserisci una lattera per vedere i nomi con quella lettera");
            char lettera;
            if(!char.TryParse(Console.ReadLine(), out lettera))
            {
                Console.WriteLine("carattere non valido");
                return;
            }
            lettera = char.ToLower(lettera);
            foreach (var l in nomi)
            {
                if(l.StartsWith(lettera))
                {
                    Console.WriteLine(l);
                }
            }
        }
    }
}
