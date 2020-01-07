using System;

namespace CLI_Doge
{
    public class Program
    {
        static void Main(string[] args) 
            

        {
            while (true)
            {

                Console.WriteLine("Which is your favorite animal. Write s for shark, l for lion, y for yoda.");
                string Species = Console.ReadLine();
                Console.WriteLine("What is your age?");
                int Age = int.Parse(Console.ReadLine());




                Console.WriteLine("What would you like to name your pet?");
                string Name = Console.ReadLine();
                
                Console.WriteLine("You may now pet your new pet.");


                IAnimal ChosenAnimal = Animal.CreateAnimal(Name, Species);

                ChosenAnimal.Pet();







            }

            
           
        }
    }
}
