using System;
using System.IO;
using System.Threading;

namespace IMGSRV
{
    class IMGSRV
    {
        static void Main(string[] args)
        {
            bool isRunning = true;
            File.WriteAllText(@"C:\CS361\image-service.txt", "path");
            Console.WriteLine("Image Service");
            while (isRunning == true)
            {
                Thread.Sleep(500);
                string prng_text = File.ReadAllText(@"C:\CS361\image-service.txt");

                int number;
                bool isSuccess = int.TryParse(prng_text, out number);

                if (isSuccess == true)
                {
                    Thread.Sleep(1000);
                    string path = "C:\\CS361\\img\\img" + number + ".jpg";
                    Console.WriteLine("New path was generated!");
                    Console.WriteLine("Path: " + path);
                    File.WriteAllText(@"C:\CS361\image-service.txt", path);
                    File.WriteAllText(@"C:\CS361\prng-service.txt", "command 0");
                }
                else
                {
                    continue;
                }
            }
        }
    }
}
