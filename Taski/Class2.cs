using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taski
{
    class Simulation
    {
        public static double count = 0;
        public Simulation(Task[] ta)
        {
            foreach (Task t in ta)
            {
                count = count + t.Time();
                t.Solved = count < 30 ? true : false;
                Random rnd = new Random();
                System.Threading.Thread.Sleep(42);
                if ((rnd.Next(0, (int)t.Time()+1) == 0)&&(count < 30))
                {
                    count = count + (int)t.Time();
                    t.Solved = count < 30 ? true : false;
                    Console.WriteLine("{0} required reprocessing ",t.Name);
                }
                Console.WriteLine(t.Name + " used time " + t.Time() + " was solved = " + t.Solved.ToString() + " with count " +count);
            }

        }
    }
}
