using System;

namespace ehinnersSleepData
{
    class Program
    {
        static void Main(string[] args)
        {
            // ask for input
            Console.WriteLine("Enter 1 to create data file.");
            Console.WriteLine("Enter 2 to parse data.");
            Console.WriteLine("Enter anything else to quit.");
            // input response
            string resp = Console.ReadLine();

            if (resp == "1")
            {
                // create file
                StreamWriter sw = new StreamWriter("data.txt");

                sw.Close();

            }
            else if(resp=="2")
            {
                StreamReader sr = new StreamReader("data.txt");
            }
                
        }
    }
}
