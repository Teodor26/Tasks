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
        
        public double Calc(double time)
        {
            time = time-Time();
            for (int i = 0; i < DataBase.Length; i++)
            {
                if (DataBase[i]==false)
                {
                    if (time <= 30)
                    {
                        for (int j = 0; j < name.Length; j++)
                        {
                            name[j] = Name;
                            break;
                        }
                        DataBase[i] = true;
                        break;                        
                    }
                    else
                    {
                        DataBase[i] = false;
                        break;
                    }
                }
            }

            return time;
        }
    }
}
