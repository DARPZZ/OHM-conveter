namespace Farve_til_tal
{
    public class TalFarve
    {
        public void NumberToColor(int resistanceværdi)
        {
            string[] farver = { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "gray", "white" };


            int Antaldig = (int)Math.Floor(Math.Log10(resistanceværdi) + 1);
            int eksponent = Antaldig - 2;

            int firstDigit = (int)(resistanceværdi / Math.Pow(10, eksponent + 1));

            int secondDigit = (int)((resistanceværdi / Math.Pow(10, eksponent)) % 10);

            string multiplierColor = farver[eksponent];
            Console.WriteLine("Digit 1 color: " + farver[firstDigit]);
            Console.WriteLine("Digit 2 color: " + farver[secondDigit]);
            Console.WriteLine("Multiplier color: " + multiplierColor);
        }
    }
}
