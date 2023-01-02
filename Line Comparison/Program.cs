namespace Line_Comparison
{
    public class Program
    {
        static void Main(string[] args)
        {
            double Line1 = 0;
            double Line2 = 0;
            for(int i = 1; i < 3;i++)
            {
                Console.WriteLine("Co-ordinates of " + i + " Line");
                Console.WriteLine("Enter First point Co-ordinate on X-Axis");
                float x1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter First point  Co-ordinate on Y-Axis");
                float y1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter Second point Co-ordinate on X-Axis");
                float x2 = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter Second point Co-ordinate on Y-Axis");
                float y2 = float.Parse(Console.ReadLine());
                double Length = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
                
                if(i== 1)
                {
                    Line1 = Length;
                }
                else
                {
                    Line2 = Length;
                }
            }
            Console.WriteLine("Length of First Line is " + Line1);
            Console.WriteLine("Length of Second Line is " + Line2);
            
            if(Line1.CompareTo(Line2) < 0)
            {
                Console.WriteLine("First Line is lesser than Second Line");
            }
            else if (Line1.CompareTo(Line2) > 0)
            {
                Console.WriteLine("First Line is greater than Second Line");
            }
            else
            {
                Console.WriteLine("Lines are Equal");
            }
        }
    }
}
