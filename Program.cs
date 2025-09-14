class task1
{
    public static void Main()
    {
        Console.WriteLine("Enter the radius of a circle:");
        string radiusInput = Console.ReadLine();
        bool doubleParseSuccess = double.TryParse(radiusInput, out double radius);
        radius = double.Parse(radiusInput);
        double area = Math.Pow(radius, 2);
        Console.WriteLine($"The area of a circle with radius {radiusInput} is {area}pi");
    }
}
//Done

