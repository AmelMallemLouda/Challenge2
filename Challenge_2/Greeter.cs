using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2
{
    class Greeter
    {
        static void Main(string[] args)
        {
            Name();
            Farewell();
            SwitchCases();






           void Name()
            {
                string name = "Amel";
                string hello = "Hello";
                Console.WriteLine($"{hello} {name}");

            }



            void Farewell()
            {
                string name = "Amel";
                string somethingelse = ("Good bye");

                Console.WriteLine(somethingelse + " " + name);
            }




            void SwitchCases()
            {
                Console.WriteLine($"Choose an option:\n"+
                    "1.time(12am-11:59pm)\n"+
                    "2.time(12:00pm-5:00pm)\n"+
                    "3.time(5:01pm-6:00pm)\n"+
                    "4.time(6:01pm-12:00pm)\n");
                string time = Console.ReadLine();

                switch (time)
                {
                    case ("1"):
                        Console.WriteLine("Good morning");

                        break;

                    case "2":
                        Console.WriteLine("Good afternoon");
                        break;
                    case "3":
                        Console.WriteLine("Good evening");
                        break;
                    case "4":
                        Console.WriteLine("Good night");
                        break;


                }



            }

        
        }
    }

}

