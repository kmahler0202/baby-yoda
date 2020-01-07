using System;
using System.Collections.Generic;
using System.Text;

namespace CLI_Doge
{
    class Lion : IAnimal 
    {
        public string Name { get; }
        public int Age { get; }
        public Lion(string Name)
        {

        }
        public void Pet()
        {
            Console.WriteLine("ROARRRR!!!!!");
        }
    }
}
