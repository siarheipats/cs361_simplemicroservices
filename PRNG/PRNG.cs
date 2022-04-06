using System;
using System.IO;
using System.Threading;

namespace PRNG
{
    class PRNG
    {
        static void Main(string[] args)
        {
            File.WriteAllText(@"C:\CS361\prng-service.txt", "command 0");
            bool isRunning = true;
            Console.WriteLine("PRNG Microservice");

            Random rnd = new Random();
            int prev_num1 = -1;
            int prev_num2 = -1;
            while (isRunning == true)
            {
                Thread.Sleep(500);
                string prng_text = File.ReadAllText(@"C:\CS361\prng-service.txt");
                string[] words = prng_text.Split(' ');
                string command = words[0];
                if (command == "run")
                {
                    int num = rnd.Next(0, 5);
                    while(num == prev_num1 || num == prev_num2)
                    {
                        num = rnd.Next(0, 5);
                    }
                    Console.WriteLine("The random number " + num + " was generated and saved in prng-service.txt");
                    Console.WriteLine("Erasing the RUN command");
                    File.WriteAllText(@"C:\CS361\prng-service.txt", num.ToString());
                    prev_num2 = prev_num1;
                    prev_num1 = num;
                    
                }
                else
                {
                    continue;
                }
            }
        }
    }
}

