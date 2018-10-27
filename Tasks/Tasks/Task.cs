using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
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
            System.Threading.Thread.Sleep(4000);
            Random rand = new Random();
            Difficulty = rand.Next(1, 5);
        }

        public abstract double Time();

    }
}
