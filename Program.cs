class Task2
{
    public static void Main()
    {
        Console.WriteLine("Enter a Tempterature in Celsius: ");
        string input = Console.ReadLine();
        bool isSuccess = int.TryParse(input, out int numberInput);
        if (numberInput > 0)
        {
            Console.WriteLine("It's above freezing!");
        }
        else if (numberInput < 0)
        {
            Console.WriteLine("Freezing");
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    }
}
//Done.
