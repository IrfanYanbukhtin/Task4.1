namespace Task._4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int r1, r2;
            int tmp;
            bool isDifferenceDigit = true;
            while (number !=0) 
            {
                r1= number % 10;
                number /= 10;
                tmp = number;
                
                while(tmp !=0)
                {
                    r2 = tmp % 10;
                    tmp /= 10;
                    if (r2== r1)
                    {
                        Console.WriteLine("Muxtelif regemli deyil");
                        isDifferenceDigit = false;
                        break;
                    }
                }
                if (!isDifferenceDigit) ;
                    break;
            }
            if (isDifferenceDigit)
             Console.WriteLine("Muxtelif reqemlidir");
        }
    }
}