using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    abstract class myLife5
    {
        internal  string  first;
        protected string  second;
        protected string  third;
        public abstract void naresh();
        public abstract void bujji();
    }
    class tirupathi :myLife5
    {
        public override void naresh()
        {
            
            first = "mca 1st year not good and not bad just done only";
            second = "mca 2nd year fully happy bcoz iam in love";
            third = "3rd year i feel completed 2,3 monts.completed very fastly";
        }
        public override void bujji()
        {
            Console.WriteLine("my past days experience is");
            Console.WriteLine("mca first year:" + first);
            Console.WriteLine("mca 2 year is:" + second);
            Console.WriteLine("mca 3rd year is :" + third);
            string afterMCA = "i dont like my life bcoz my love is gone";
            Console.WriteLine("after mca is:" + afterMCA);
        }      
    }
    class myMCALife
    {
        static void Main(string[] args)
        {
            tirupathi obj1 = new tirupathi();
            obj1.naresh();
            obj1.bujji();
        }
    }
}
