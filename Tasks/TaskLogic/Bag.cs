using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskLogic
{
    public sealed class Bag : Task
    {
        public double Proitaze = 2;
        public override double Time()
        {                   
            if (Difficulty == 1)
                return Proitaze;
            else
                return Proitaze + (Difficulty / 10 + 1);
        }

        public double Calc()
        {
            time =30-Time() ;
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

        
        
        //public double Sub = 30;
        //public void Calc()
        //{
        //    for (int i = 0; i < 30; i++)
        //    {
        //        Sub = Sub - Time();
        //        if (Sub < 0)
        //        {
        //            Console.WriteLine($"{30-i} has been made.");
        //            break;
        //        }
               
               
        //    }
           
        //}
    
     }
}
