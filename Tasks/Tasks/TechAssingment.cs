using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    sealed class TechAssingment:Task
    {

        public double Proitaze = 0.5;

        public override double Time()
        {
            if (Difficulty == 1)
                return Proitaze;
            else
                return Proitaze + (Difficulty / 10 + 1);
        }

        public double Sub = 30;
        public void Calc()
        {
            for (int i = 0; i < 30; i++)
            {
                Sub = Sub - Time();
                if (Sub < 0)
                {
                    Console.WriteLine($"{30-i} has been made.");
                    break;
                }
               
               
            }
           
        }

        
    }
}
