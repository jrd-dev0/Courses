namespace Conditional_IfConsistsOfUppercaseLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IfConsistsOfUppercaseLetters("xyz"));
            Console.WriteLine(IfConsistsOfUppercaseLetters("DOG"));
            Console.WriteLine(IfConsistsOfUppercaseLetters("L9#"));
            Console.WriteLine(IfConsistsOfUppercaseLetters("drY"));
            Console.WriteLine(IfConsistsOfUppercaseLetters("LOL"));
            Console.WriteLine(IfConsistsOfUppercaseLetters("N0t"));
            Console.WriteLine(IfConsistsOfUppercaseLetters("$1r"));
        }

        static bool IfConsistsOfUppercaseLetters(string text)
        {
            //solution copied from exercise example, ASCII table has been used.

            return (text[0] >= 65 && text[1] >= 65 && text[2] >= 65)
                && (text[0] <= 90 && text[1] <= 90 && text[2] <= 90);
        }
    }
}