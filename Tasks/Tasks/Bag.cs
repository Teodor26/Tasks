using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
   sealed class Bag:Task
    {
        public double Proitaze=2;

        public override double Time()
        {
            if(Difficulty==1)            
                return Proitaze;            
            else
            return Proitaze +(Difficulty/10+1);
        }
    }
}
