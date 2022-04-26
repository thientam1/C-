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

            // hoặc:
            Cat cat1 = new Cat();

            Cow cow = new Cow();

            // Gọi các phương thức
            cat.Eat148();
            cow.Eat148();

            cat.AnimalSound148();
            cow.AnimalSound148();

            cat.Run148();
            cat.Run148();

            Console.ReadKey();
        }
    }

    // Khai báo abstract class
    public abstract class Animal
    {
        // abstract method
        public abstract void AnimalSound148();

        // virtual method
        public virtual void Eat148()
        {
            Console.WriteLine("Động vật ăn cỏ.");
        }

        // normal method
        public void Run148()
        {
            Console.WriteLine("Chạy bằng 4 chân.");
        }
    }

    // Lớp Cat kế thừa lớp Animal
    public class Cat : Animal
    {
        // abstract method: bắt buộc lớp con phải override lại từ lớp cha.
        // Khi override thì phạm vi truy cập phải giống của lớp cha: public
        public override void AnimalSound148()
        {
            Console.WriteLine("Mèo meow meow.");
        }

        // virtual method: việc override thì không bắt buộc.
        // Lớp con có thể dùng luôn định nghĩa từ lớp cha nếu phù hợp,
        // hoặc override (định nghĩa lại) nếu không phù hợp.
        // Khi override thì phạm vi truy cập phải giống của lớp cha: public
        public override void Eat148()
        {
            Console.WriteLine("Mèo ăn cá.");
        }

        // normal method Run1414() thì dùng luôn của lớp cha không phải làm gì.
    }

    // Lớp Cow kế thừa lớp Animal
    public class Cow : Animal
    {
        public override void AnimalSound148()
        {
            Console.WriteLine("Bò kêu ummuu bò.");
        }
    }
}
