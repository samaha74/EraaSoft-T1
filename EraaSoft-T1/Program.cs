namespace EraaSoft_T1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter the prices for the carpets...");
            Console.Write("Small: ");
            int ps = Convert.ToInt32(Console.ReadLine());
            Console.Write("Large: ");
            int pl = Convert.ToInt32(Console.ReadLine());

            float s, l,sum;
            char ans;
            while (true)
            {
                Console.WriteLine("\n======================================== \n");

                Console.Write("Number of small carpets: ");
                s = Convert.ToInt32(Console.ReadLine());
                Console.Write("Number of Large carpets: ");
                l = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("========================================");
                Console.WriteLine("BILL:");
                sum = ps * s + pl * l;
                Console.WriteLine($"Cost: {sum}");
                Console.WriteLine($"tax: {sum * 0.06}");
                Console.WriteLine("========================================");
                Console.WriteLine("                   =====================");
                Console.WriteLine($"Estimated Total: {sum + sum * 0.06}");
                Console.WriteLine("                   =====================");
                Console.WriteLine("========================================");

                Console.WriteLine("Want to make another request?(Y/N) ");
                ans = Convert.ToChar(Console.ReadLine());
                if (ans == 'Y' || ans == 'y')
                    continue;
                else 
                    break;
            }      
        }
    }
}
