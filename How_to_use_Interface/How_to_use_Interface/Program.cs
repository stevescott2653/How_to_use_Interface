using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace How_to_use_Interface
{
    public interface Drawable
    {
        void Draw();
    }

    public class Rectangle : Drawable
    {
        public void Draw()
        {
            Console.WriteLine("drawing rectangle...");
        }
    }

    public class Circle : Drawable
    {
        public void Draw()
        {
            Console.WriteLine("drawing circle...");
        }
    }

    public class TestInterface
    {
        public static void Main()
        {
            Drawable d;
            d = new Circle();
            d.Draw();
            d = new Circle();
            d.Draw();
        }
    }
}
