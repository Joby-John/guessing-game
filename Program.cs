// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to guessing game");
Console.WriteLine("question master's time , enter the word which you want others to guess");
string qn = Console.ReadLine().ToLower();
string guess = "";
int n = 5;
Console.Clear();
Console.WriteLine("Now its the time to guess");


do
{
    if (guess == "i give up" || n == 0)
    {
        Console.WriteLine("\nSorry out of chances");
        Console.WriteLine("Oops sorry, you tried hard, it was : {0} ", qn);
        break;

    }
    Console.WriteLine("\n\nREMEMBER YOU HAVE {0} CHANCES LEFT ", n);
    Console.WriteLine("Enter your guess");
    Console.WriteLine("Enter : I give up, to give up");
    guess = Console.ReadLine().ToLower();

    n--;

} while (guess != qn );
    if (guess == qn)
{
    Console.WriteLine("\nYou guessed it right,HURRAY!");
}
