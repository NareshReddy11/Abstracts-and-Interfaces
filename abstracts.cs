using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    public abstract class abstracts
    {
       public abstract void draw1();
    }
    public class rectangle1:abstracts
    {
        public override void draw1()
        {
            Console.WriteLine("draw rectangle");
        }
    }
    public class squar1 :abstracts
    {
        public override void draw1()
        {
            Console.WriteLine("draw squar");

        }
    }
   public class testAbtract
    {
        static void Main(string[] args)
        { 
            abstracts ab;
            ab = new rectangle1();
            ab.draw1();
            ab = new squar1();
            ab.draw1();

        }

    }

}
