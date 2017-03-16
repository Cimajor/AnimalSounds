using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Animals[] animals = new Animals[20];

            for (int i = 0; i < 20; i++)
            {
                int random = 0;
                random = rnd.Next(0, 10);
                if (random > 5)
                {
                    Cat a = new Cat();
                    animals[i] = a;
                }
                else
                {
                    Dog a = new Dog();
                    animals[i] = a;
                }     
            }
            for (int i = 0; i < 20; i++)
            {
                if(animals[i].GetType() == typeof(Cat)) {
                    ((Cat)animals[i]).Sounds();
                }else if(animals[i].GetType() == typeof(Dog))
                {
                    ((Dog)animals[i]).Sounds();
                }
            }
                Console.ReadLine();
        }
    }
}
