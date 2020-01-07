using System;
using System.Collections.Generic;
using System.Text;

namespace CLI_Doge
{
    public class Shark : IAnimal
    {
        public string Name { get; }
        public int Age { get; }
        public Shark(string Name)
        {

        }
        public void Pet()
        {
            Console.WriteLine("chomp chomp chompppp");
        }

    }



}
    

        
    
