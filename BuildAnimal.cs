using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace CLI_Doge
{
    public class Animal
    {
        public static IAnimal CreateAnimal(string name, string species)
        {
            if (name == null)
                throw new ArgumentNullException(nameof(name));
            if (species == null)  {
                throw new Exception("Sorry, we don't have that species to give away today. Please select a valid species.");
            }
            if (species == "y")
                return new Yoda(name);
            if (species == "s")
                return new Shark(name);
            if (species == "l")
                return new Lion(name);
            if (name != null)
                Console.WriteLine("Your new pet " + species + " is now named" + name + ".");
            
                throw new ArgumentNullException(nameof(species));

            
            
                
        }

           
              
        
            

        
    }
}
