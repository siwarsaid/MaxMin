namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nbminsaisie;
            int nbmaxsaisie;
            int entier;

            Console.WriteLine("Limit1:");
            nbminsaisie = Int32.Parse(Console.ReadLine());


            Console.WriteLine("Limit2:");
            nbmaxsaisie = Int32.Parse(Console.ReadLine());


            Console.WriteLine("Entier:");
            entier = Int32.Parse(Console.ReadLine());
            if (nbmaxsaisie < entier)
            {

                Console.WriteLine("Vous avez saisi " + entier + " qui est supérieur à " + nbmaxsaisie + " qui est le maximum.");
                Console.WriteLine("Nombre entier résultant :" + nbmaxsaisie);
            }
            else if (entier < nbminsaisie)
            {
                Console.WriteLine("Vous avez saisi " + entier + " qui est inférieur à " + nbminsaisie + " qui est le minimum.");
                Console.WriteLine("Nombre entier résultant : " + nbminsaisie);
            }
            else
            {
                Console.WriteLine("Nombre entier résultant : " + entier);
            }
        }
    }
}
