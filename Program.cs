using System;
using System.IO;

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
                // create data file

                 // ask a question
                Console.WriteLine("How many weeks of data is needed?");
                // input the response (convert to int)
                int weeks = int.Parse(Console.ReadLine());

                 // determine start and end date
                DateTime today = DateTime.Now;
                // we want full weeks sunday - saturday
                DateTime dataEndDate = today.AddDays(-(int)today.DayOfWeek);
                // subtract # of weeks from endDate to get startDate
                DateTime dataDate = dataEndDate.AddDays(-(weeks * 7));
                
                // random number generator
                Random rnd = new Random();
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
