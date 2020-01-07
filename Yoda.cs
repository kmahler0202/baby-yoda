using System;
using System.Collections.Generic;
using System.Text;

namespace CLI_Doge
{
    class Yoda : IAnimal
    {
        public string Name { get; }
        public int Age { get; }
        public Yoda(string Name) { }

        public void Pet()
        {
            Console.WriteLine("hmmmmmmm strong with the force, you are. Much anger I feel in you.");




        }
    }
}
