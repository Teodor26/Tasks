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
            Int32.TryParse(Console.ReadLine(), out int Opt);
            string a="no" ;
            while (a=="no")
            {
                switch (Opt)
                {
                    case 1:
                        Console.WriteLine("Name your task");
                        bag.NewTask(Console.ReadLine());
                        bag.Calc();
                        Console.WriteLine("You have contin?yes\no");
                        a = Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Name your task");
                        ficha.NewTask(Console.ReadLine());
                        ficha.Calc();
                        Console.WriteLine("You have contin?yes\no");
                        a = Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("Name your task");
                        techAssingment.NewTask(Console.ReadLine());
                        techAssingment.Calc();
                        Console.WriteLine("You have contin?yes\no");
                        a = Console.ReadLine();
                        break;
                }
            }

            for (int i = 0; i < bag.DataBase.Length; i++)
            {
                Console.WriteLine(bag.DataBase[i]);
            }
            for (int i = 0; i < ficha.DataBase.Length; i++)
            {
                Console.WriteLine(ficha.DataBase[i]);
            }
            for (int i = 0; i < techAssingment.DataBase.Length; i++)
            {
                Console.WriteLine(techAssingment.DataBase[i]);
            }

            Console.ReadLine();

        }
    }
}
