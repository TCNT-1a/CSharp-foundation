using System;
namespace TestProject
{
    public class PettingZoo
    {
        private string[] pettingZoo;
        private Random random;
        public PettingZoo()
        {
            pettingZoo = new string[] {
                "alpacas", "capybaras", "chickens", "ducks", "emus", "geese",
                "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws",
                "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
            };
            random = new Random();
        }
        public void RandomizeAnimals()
        {
            for (int i = 0; i < this.pettingZoo.Length; i++)
            {
                var r = random.Next(i, pettingZoo.Length);
                
                Console.Write($"{i}:{r},");
                var temp = pettingZoo[i];
                pettingZoo[i] = pettingZoo[r];
                pettingZoo[r] = temp;
            }
            Console.WriteLine("".PadLeft(50, '-'));
        }

        public void print()
        {
             Console.WriteLine("".PadLeft(50,'-'));
            foreach (var i in pettingZoo)
            {
                Console.WriteLine(i);
            }
        }
        public void printArray<T> (T arr) where T : IEnumerable<T>
        {
            foreach(var i in arr)
            {
                Console.WriteLine(i.ToString());
            }
        }

    }
                                                        
}

