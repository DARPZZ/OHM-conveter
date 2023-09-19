namespace Farve_til_tal
{
    public class FarveTal
    {

        public  string FarveTilTal(string farve1, string farve2, string farve3)
        {

            var colorToNumberMap = new Dictionary<string, int>
            {
                { "black", 0 },
                { "brown", 1 },
                { "red", 2 },
                { "orange", 3 },
                { "yellow", 4 },
                { "green", 5 },
                { "blue", 6 },
                { "violet", 7 },
                { "gray", 8 },
                { "white", 9 }
            };

            int digit1 = colorToNumberMap[farve1.ToLower()];
            int digit2 = colorToNumberMap[farve2.ToLower()];
            int multiplier = (int)Math.Pow(10, colorToNumberMap[farve3.ToLower()]);

            int resistanceValue = (digit1 * 10 + digit2) * multiplier;


            return resistanceValue.ToString();
        }
        public void FarveTilTalTest(string[] colors)
        {
            string resistanceValue = FarveTilTal(colors[0], colors[1], colors[2]);
            Console.WriteLine("Resistance value: " + resistanceValue + " ohms");

            if (FarveTilTal("red", "green", "blue") == "25000000")
            {
                Console.WriteLine("Pass: red green blue");
            }

            if (FarveTilTal("green", "blue", "red") == "5600")
            {
                Console.WriteLine("pass: greeen blue red");
            }
            if (FarveTilTal("green", "green", "violet") == "550000000")
            {
                Console.WriteLine("pass: \"green\", \"green\", \"violet\" ");
            }
            if (FarveTilTal("gray", "green", "brown") == "850")
            {
                Console.WriteLine("pass: \"gray\", \"green\", \"brown\"");
            }

        }
    }
}
