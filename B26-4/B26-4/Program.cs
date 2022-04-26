using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B26_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            Animal cat = new Cat();

            
            Cat cat1 = new Cat();

            Cow cow = new Cow();

            
            cat.Eat148();
            cow.Eat148();

            cat.AnimalSound148();
            cow.AnimalSound148();

            cat.Run148();
            cat.Run148();

            Console.ReadKey();
        }
    }

    
    public abstract class Animal
    {
        
        public abstract void AnimalSound148();

        
        public virtual void Eat148()
        {
            Console.WriteLine("Động vật ăn cỏ.");
        }

        
        public void Run148()
        {
            Console.WriteLine("Chạy bằng 4 chân.");
        }
    }

    
    public class Cat : Animal
    {
        
        public override void AnimalSound148()
        {
            Console.WriteLine("Mèo meow meow.");
        }

       
        public override void Eat148()
        {
            Console.WriteLine("Mèo ăn cá.");
        }

       
    }

    
    public class Cow : Animal
    {
        public override void AnimalSound148()
        {
            Console.WriteLine("Bò kêu ummuu bò.");
        }
    }
}
