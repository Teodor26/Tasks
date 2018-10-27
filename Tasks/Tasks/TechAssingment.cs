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
        public double Calc()
        {
            for (int i = 0; i < 30; i++)
            {

                Sub = -Time();

            }
            return Sub;
        }

        internal void Name(string v)
        {
            throw new NotImplementedException();
        }
    }
}
