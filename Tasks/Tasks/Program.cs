using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Opt the tipe of tasks:");
            Console.WriteLine($"{1} - Bag");
            Console.WriteLine($"{2} - Ficha");
            Console.WriteLine($"{3} - Technical assingment");
            Int32.TryParse(Console.ReadLine(),out int Opt);
            switch(Opt)
            {
                case 1:
                    Bag bag = new Bag();
                    Console.WriteLine("Name your task");
                    bag.NewTask(Console.ReadLine());
                    bag.Calc();
                    break;

                case 2:

                    Ficha ficha = new Ficha();
                    Console.WriteLine("Name your task");                    
                    ficha.NewTask(Console.ReadLine());
                    ficha.Calc();
                    break;

                case 3:
                    TechAssingment techAssingment = new TechAssingment();
                    Console.WriteLine("Name your task");
                    techAssingment.NewTask(Console.ReadLine());
                    techAssingment.Calc();
                    break;

            }






            Console.ReadLine();
            
            


        }
    }
}
