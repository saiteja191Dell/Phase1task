using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileText = @"C:\Users\gajula_sai_teja\Desktop\Phase1task\Phase1Task\TeacherRegistername.txt";

            List<string> listOfRegisters = new List<string>();
            listOfRegisters = File.ReadAllLines(fileText).ToList();
            if (listOfRegisters != null)
            {
                //Storing and updated teacher data in to text file.
                Console.WriteLine("Updating teacher data in Raindow school : ");
                Console.WriteLine("Enter teacher Id : ");
                var Id = Console.ReadLine();
                Console.WriteLine("Enter teacher Name : ");
                var Name = Console.ReadLine();
                Console.WriteLine("Enter teacher Class : ");
                var Class = Console.ReadLine();
                Console.WriteLine("Enter teacher Section : ");
                var Section = Console.ReadLine();
                listOfRegisters.Add(@"Id : " +Id.ToString()+", Name : "+ Name+", Class : "+Class+ ", Section : " + Section);
                File.WriteAllLines(fileText, listOfRegisters);

                //retrieving teacher data from text file.
                Console.WriteLine("-------------------------");
                Console.WriteLine("Existing teacher data in Raindow school : ");
                foreach (var line in listOfRegisters)
                    Console.WriteLine(line);
            }

            Console.ReadLine();
        }
    }
}
