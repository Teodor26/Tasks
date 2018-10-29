using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskLogic
{
    public sealed class Fitch : Task
    {
        public double Proitaze = 1;
        public override double Time()
        {       
            if (Difficulty == 1)
                return Proitaze;
            else
                return Proitaze + (Difficulty / 10 + 1);
        }
        
        public double Calc()
        {
            time = time-Time();
            for (int i = 0; i < DataBase.Length; i++)
            {
                if (time <= 30)
                {
                    DataBase[i] = true;
                    break;
                }
                else
                {
                    DataBase[i] = false;
                    break;
                }
            }

            return time;
        }
    }
}
