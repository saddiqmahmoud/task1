namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int small_carpet; 
            int large_carpet;
            int per_small_carpet = 25;
            int per_large_carpet = 35;
            int cost;
            double tax;
            Console.WriteLine("Estimate for carpet cleaning service : ");
            Console.WriteLine("Number of small carpets:");
            small_carpet = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number of large carpets:");
            large_carpet = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Price per small room:${per_small_carpet}");
            Console.WriteLine($"Price per large room:${per_large_carpet}");
            cost = (small_carpet * per_small_carpet) + (large_carpet * per_large_carpet);
            Console.WriteLine($"the Cost : ${cost}");
            tax = cost * 0.06;
            Console.WriteLine($"Tax: ${tax}");
            Console.WriteLine("====================================================");
            Console.WriteLine($"Total estimate: ${cost+tax}");
            Console.WriteLine("This estimate is valid for 30 days");
        }
    }
}
