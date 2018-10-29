using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taski
{
    public abstract class Task
    {
        public string Name { get; set; }
        public double Difficulty;
        public bool Solved { get; set; }
        public void NewTask(string n)
        {
            Solved = false;
            Name = n;
            System.Threading.Thread.Sleep(42);
            Random rand = new Random();
            Difficulty = rand.Next(1, 6);
        }
        public abstract double Time();
    }

    internal class Bug : Task
    {
        public override double Time()
        {
            return (Difficulty / 10 + 1)*2;
        }
    }

    internal class Feature : Task
    {
        public override double Time()
        {
            return (Difficulty / 10 + 1);
        }
    }

    internal class TechnicalDuty : Task
    {
        public override double Time()
        {
            return (Difficulty / 10 + 1) * 0.5;
        }
    }
}
