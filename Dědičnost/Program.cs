using Dědičnost.C1;
using Dědičnost.C2;

namespace Dědičnost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Clovek clovek = new Clovek("Honza");
            Console.WriteLine(clovek.Lez());

            Politik politik = new Politik("Andrej");
            Console.WriteLine(politik.Lez());

            Svetec svetec = new Svetec("Vaclav");
            Console.WriteLine(svetec.Lez());

            //Bojova arena

            Postava postava = new Postava();
            Console.WriteLine(postava.Body());
        }
    }
}