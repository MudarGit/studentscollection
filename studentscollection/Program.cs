using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentscollection
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> studs = new List<string>();
            Console.WriteLine("How many students would you like to enter?");
            string counter = Console.ReadLine();
            int counterint = Int32.Parse(counter);
            for(int counters = counterint ; counters > 0; counters--)
            {
                Console.WriteLine("What is the students name?");
                var Name = Console.ReadLine();
                studs.Add(Name);
            }
            foreach (string stud in studs)
            {
                var Nick = new Students(stud);
                Console.WriteLine("How many programs did {0} complete?", Nick.Name);
                var programs = Console.ReadLine();
                Console.WriteLine("How many people did {0} help?", Nick.Name);
                var helps = Console.ReadLine();
                int program = Int32.Parse(programs);
                int help = Int32.Parse(helps);

                if (help >= 1)
                {
                    for (int countered = program; countered > 0; countered--)
                    {
                        Nick.CompleteProgram();
                    }

                }
                Nick.Totals();
                if (help >= 1)
                {
                    for (int countered = help; countered > 0; countered--)
                    {
                        Nick.HelpAPeer();
                    }

                }
                Nick.Totals();
                Console.WriteLine();
                Console.WriteLine("{1}'s current level:{0} out of 5", Nick.studentLevel, Nick.Name);
                Console.WriteLine();
                Console.WriteLine("{1}'s current rank:{0}", Nick.studentRank, Nick.Name);
                Console.WriteLine();
                Console.WriteLine("{1}'s total finished programs:{0}", Nick.TotalProgram, Nick.Name);
                Console.WriteLine();
                Console.WriteLine("{1}'s total helped peers:{0}", Nick.TotalPeer, Nick.Name);
                Console.WriteLine();
            }
           

            

        }
    }
}
