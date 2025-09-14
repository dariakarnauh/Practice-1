class Task3
{
    public static void Main()
    {
        string input = Console.ReadLine();
        string input2 = Console.ReadLine();
        bool isSuccsess = int.TryParse(input, out int numberInput);
        bool isSuccsess2 = int.TryParse(input2, out int numberInput2);
        if ( numberInput > numberInput2 && isSuccsess && isSuccsess2)
        {
            Console.WriteLine("First is greater");
        }
        else if (numberInput < numberInput2 && isSuccsess && isSuccsess2)
        {
            Console.WriteLine("Second is greater");
        }
        else if (numberInput == numberInput2 && isSuccsess && isSuccsess2)
        {
            Console.WriteLine("Numbers are equal");
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    }
}
//Done.