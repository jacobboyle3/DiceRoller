public class Program
{
    public static Random rnd = new Random();
    static int diceRoller(int s)
    {
        int result = rnd.Next(1, s);
        return result;

    }
    public static void Main(string[] args)
    {
       
        string response = "y";
        string sidesS;
        int sidesI;
        bool isItANum;
        int runagain = 1;

        Console.Write("Welcome to Grand Circus Casino! May the beginner's luck be on your side. Roll the dice, if you dare. Type in (y/n): ");



        response = Console.ReadLine().ToLower();
        while (response == "y")
        {
            
            Console.Write("Enter the amount of sides you would like your die to have ");
            sidesS = Console.ReadLine();
            isItANum = int.TryParse(sidesS, out sidesI);
            while (!isItANum)
            {
                
                Console.Write("Not a valid number. Would you like to try again? (y/n)");
                response = Console.ReadLine().ToLower();
                Console.Write("How many sides should each die have? ");
                sidesS = Console.ReadLine();
                isItANum = int.TryParse(sidesS, out sidesI);

            }
            string input = "y";

            Console.WriteLine("Roll " + runagain);
            Console.WriteLine(diceRoller(sidesI));
            Console.WriteLine(diceRoller(sidesI));
            Console.WriteLine("\nRoll again? (y/n)");
            input = Console.ReadLine().ToLower();
            if (input != "y")
            {
                response = "n";
            }
            static void D6Combos(int dieZero, int dieOne)
            {

                switch (dieZero, dieOne)
                {
                    case (1, 1):
                        Console.WriteLine("Snake Eyes: Two 1s!");
                        break;
                    case (1, 2) or (2, 1):
                        Console.WriteLine("Ace Deuce: A 1 and 2!");
                        break;
                    case (6, 6):
                        Console.WriteLine("Box Cars: Two 6s!");
                        break;
                }
                switch (dieZero + dieOne)
                {
                    case 7 or 11:
                        Console.WriteLine("Win: A total of 7 or 11!");
                        break;
                    case 2 or 3 or 12:
                        Console.WriteLine("Craps: A total of 2, 3, or 12!");
                        break;
                    default:
                        break;
                }
            }
            runagain++;
        }
    }
       
}






                           


           




        
        

