using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taski
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine();
            Console.WriteLine("enter the number of tasks of the type Bug");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the number of tasks of the type Feature");
            int f = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the number of tasks of the type TechnicalDuty");
            int t = int.Parse(Console.ReadLine());
            Simulation s = new Simulation(FirstLoad(b, f, t));

            Console.WriteLine();
        }
        static Task[] FirstLoad(int b, int f, int t)
        {
            Task[] ta = new Task[b+f+t];
            for(int i =0; i < b;i++)
            {
                ta[i] = new Bug();
                ta[i].NewTask("Bug # "+(i+1));
            }
            for (int i = 0; i < f;i++)
            {
                ta[i+b] = new Feature();
                ta[i+b].NewTask("Feature # " + (i + 1));
            }
            for (int i = 0; i < t;i++)
            {
                ta[i+b+f] = new TechnicalDuty();
                ta[i+b+f].NewTask("TechnicalDuty # " + (i + 1));
            }
            return ta;
        }
    }
}
