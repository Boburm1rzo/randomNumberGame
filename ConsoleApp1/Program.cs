namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sanoq = 0;
            int rand_number = new Random().Next(1, 100);
            Console.Write("Random son kiriting:");
            while (true)
            {
                int n = int.Parse(Console.ReadLine());
                sanoq++;
                if (n == rand_number)
                {
                    Console.WriteLine("\nyashirin son " + sanoq + " ta urinishga topildi \nyashiringan son:" + rand_number + " edi");
                    GameOver();
                    Console.WriteLine();
                    Main(args);
                }
                else
                {
                    if (n > rand_number)
                    {
                        Console.WriteLine("Kiritilgan son random sondan katta \n qaytadan son kiriting ");
                    }
                    else if (n < rand_number)
                    {
                        Console.WriteLine("     Kiritilgan son random sondan kichik \n qaytadan son kiriting ");
                    }
                }
            }
            static void GameOver()
            {
                return;
            }
        }
    }
}