namespace Line_Comparison
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First point Cordinate on X-Axis");
            float x1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter First point  Cordinate on Y-Axis");
            float y1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second point Cordinate on X-Axis");
            float x2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second point Cordinate on Y-Axis");
            float y2 = float.Parse(Console.ReadLine());
            double Length = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("Length of Line is " + Length);
        }
    }
}
