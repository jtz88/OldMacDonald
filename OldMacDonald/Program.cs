using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldMacDonald
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IAnimals> animals = new List<IAnimals>();

            IAnimals dog = new Dog();

            dog.Name = "Dog";

            dog.Sound = "Woof";

            animals.Add(dog);

            IAnimals cat = new Cat();

            cat.Name = "Cat";

            cat.Sound = "Meoow";

            animals.Add(cat);

            IAnimals pig = new Pig();

            pig.Name = "Pig";

            pig.Sound = "Oink";

            animals.Add(pig);

            IAnimals bird = new Bird();

            bird.Name = "Bird";

            bird.Sound = "Chirp";

            animals.Add(bird);

            IAnimals wolf = new Wolf();

            wolf.Name = "Wolf";

            wolf.Sound = "Howl";

            animals.Add(wolf);

            foreach (var animal in animals) { Console.WriteLine($"Old McDonald had a farm, E-I-E-I-O,\nAnd on his farm he had a { animal.Name }, E-I-E-I-O.\nWith a { animal.Sound } { animal.Sound } here and a { animal.Sound } { animal.Sound } there,\nHere a { animal.Sound }, there a { animal.Sound } everywhere a { animal.Sound } { animal.Sound }.\nOld MacDonald had a farm, E-I-E-I-O.\n"); }

            Console.WriteLine("Press any key to exit.");

            Console.ReadKey();

        }
    }
}
