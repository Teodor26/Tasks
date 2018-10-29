using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskLogic;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Bag bag = new Bag();
            Fitch ficha = new Fitch();
            TechAssingment techAssingment = new TechAssingment();
            Console.WriteLine("Input type of task");
            Console.WriteLine($" 1- Bag");
            Console.WriteLine($" 2- Ficha");
            Console.WriteLine($" 3- Technical assingment");
            double time=0;
            string a="yes" ;
            while (a=="yes")
            {
                Int32.TryParse(Console.ReadLine(), out int Opt);
                switch (Opt)
                {
                    case 1:
                        Console.WriteLine("Name your task");
                        bag.NewTask(Console.ReadLine());
                        time=bag.Calc(time);
                        Console.WriteLine("You have add new task ?yes/no");
                        a = Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Name your task");
                        ficha.NewTask(Console.ReadLine());
                        time=ficha.Calc(time);
                        Console.WriteLine("You have add new task ?yes/no");
                        a = Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("Name your task");
                        techAssingment.NewTask(Console.ReadLine());
                        time=techAssingment.Calc(time);
                        Console.WriteLine("You have add new task ?yes/no");
                        a = Console.ReadLine();
                        break;
                }
            }
            int sum=0;
            for (int i = 0; i < bag.DataBase.Length; i++)
            {
                for (int j = 0; j < bag.name.Length; j++)
                {
                    if (bag.DataBase[i] == true)
                    {
                        Console.WriteLine($"{sum} {bag.name[j]}");
                        sum = sum + 1;
                        break;
                    }
                    
                }               
            }
            for (int i = 0; i < ficha.DataBase.Length; i++)
            { 
                for (int j = 0; j < ficha.name.Length; j++)
                {
                    if (bag.DataBase[i] == true)
                    {
                        Console.WriteLine($"{sum} {ficha.name[j]}");
                        sum = sum + 1;
                        break;
                    }
                }
            }
            for (int i = 0; i < techAssingment.DataBase.Length; i++)
            {
                for (int j = 0; j < techAssingment.name.Length; j++)
                {
                    if (bag.DataBase[i] == true)
                    {
                        Console.WriteLine($"{sum} {techAssingment.name[j]}");
                        sum = sum + 1;
                        break;
                    }
                }
            }

            Console.ReadLine();

        }
    }
}
