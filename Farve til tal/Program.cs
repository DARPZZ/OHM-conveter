namespace Farve_til_tal
{
    public class Program
    {
        static FarveTal farveTal = new FarveTal();
        static TalFarve talFarve = new TalFarve();
        static void Main(string[] args)
        {
            Console.WriteLine("Wich way would you like to convert? 1 for farve til tal  2 for tal til farve");
            string valg = Console.ReadLine();
            if(valg == "1")
            {
                Console.WriteLine("Enter three colors (e.g., red green blue):");
                string[] colors = Console.ReadLine().Split(' ');
                farveTal.FarveTilTalTest(colors);

            }else if (valg == "2") 
            {
                Console.WriteLine("Enter a resistance value in ohms:");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out int resistanceValue) || resistanceValue < 0)
                {
                    Console.WriteLine("  enter  non-negative number.");
                    return;
                }

                talFarve.NumberToColor(resistanceValue);
            }
        }
    }
}



