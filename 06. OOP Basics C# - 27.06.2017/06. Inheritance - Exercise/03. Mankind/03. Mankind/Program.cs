

using System;
using System.Linq;

namespace _03.Mankind
{
    public class Program
    {
        public static void Main()
        {
            try
            {
                string[] studentValues = Console.ReadLine().Split().ToArray();
                string[] workerValues = Console.ReadLine().Split().ToArray();
                Student student = new Student(studentValues[0], studentValues[1], studentValues[2]);
                Worker worker = new Worker(workerValues[0], workerValues[1], decimal.Parse(workerValues[2]), decimal.Parse(workerValues[3]));
                
                Console.WriteLine(student.ToString());
                Console.WriteLine();
                Console.WriteLine(worker.ToString());
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);               
            }                     
        }       
    }
}
