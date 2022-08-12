// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to guessing game");
Console.WriteLine("question master's time , enter the word which you want others to guess");
string qn = Console.ReadLine().ToLower();
Console.WriteLine("Enter 1st clue for the guesser :");
string clue1 = Console.ReadLine().ToUpper();
Console.WriteLine("Enter 2nd clue :");
string clue2 = Console.ReadLine().ToUpper();
string guess = "";
int n = 5;
Console.Clear();
Console.WriteLine("Now its the time to guess");


do
{
    if (guess == "i give up" || n == 0)
    {
        Console.WriteLine("\nSorry out of chances");
        Console.WriteLine("Oops SORRY :(  \nYou tried hard, it was : {0} ", qn);
        break;

    }
    switch (n)
    {
        case 2:
            Console.WriteLine("\n\nOk clue granted, First clue be: {0}",clue1);
            break;
        case 1:
            Console.WriteLine("\n\nThis is the final clue : {0}", clue2);
            break;

    }
    Console.WriteLine("\nREMEMBER YOU HAVE {0} CHANCES LEFT ", n);
    Console.WriteLine("Enter your guess");
    Console.WriteLine("Enter : I give up, to give up");
    guess = Console.ReadLine().ToLower();

    n--;

} while (guess != qn );
    if (guess == qn)
{
    Console.WriteLine("\nYou guessed it right,HURRAY!");
}
