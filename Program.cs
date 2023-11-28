namespace ReverseChangeword_Moodle
{
    internal class Program
    {

        /*Lag et enkelt kommandobasert program med følgende meny: 1. RotateText. 2. Change word(Bytt ut alle "e" med "a".   */
        static void Main()
        {

            Console.WriteLine("Velkommen til teksttukling. Nedenfor får du 2 valg:");
            Console.WriteLine("1: Roter teksten");
            Console.WriteLine("2: Bytt ut alle \"e\" med \"a\".");

            var userInput = Console.ReadLine();

            switch(userInput)
            {
                case "1":
                    Console.WriteLine("Skriv inn teksten du vil rotere.");
                    string textToRotate = Console.ReadLine();
                    string rotatedText = Reverse(textToRotate);
                    Console.WriteLine($"Nytt ord er {rotatedText}");
                    break;
                case "2":
                    Console.WriteLine("Skriv inn teksten du vil bytte ut bokstaver med.");
                    string changeLetters = Console.ReadLine();
                    string changedText = Changeword(changeLetters);
                    Console.WriteLine($"Det nye ordet blir {changedText}");
                    break;
                default:
                    Console.WriteLine("Ugyldig valg");
                    break;

            }
        }

        public static string Reverse(string Userinput)
        {
            char[] chars = Userinput.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }


        public static string Changeword(string UserInput)
        {
            return UserInput.Replace("e", "a");
        }
    }
}
