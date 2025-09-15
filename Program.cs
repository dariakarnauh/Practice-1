class Task4
{
    public static void Main()
    {
        Console.WriteLine("put a,b and x");
        string a = Console.ReadLine();
        string b = Console.ReadLine();
        string x = Console.ReadLine();
        bool isNumber = int.TryParse(a, out int a1);
        bool isNumber2 = int.TryParse(b, out int b1);
        bool isNumber3 = int.TryParse(x, out int x1);
        if (a1 == b1)
        {
            Console.WriteLine("invalid Input");
        }
        else if (x1 > b1)
        {
            Console.WriteLine("Outside");
        }
        else if (x1 <= b1 && x1 >= a1)
        {
            Console.WriteLine("Inside");
        }
    }
}
//Done.