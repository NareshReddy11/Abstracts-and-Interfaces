using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    public interface shape
    {
        void draw();
    }
    class rectangle:shape
    {
        public void draw()
        {
            Console.WriteLine("draw rectangle");
        }
    }
    class squar:shape
    {
        public void draw()
        {
            Console.WriteLine("draw squar");
        }
    }
    class interface1
    {
        static void Main(string[] args)
        {
            shape s;
            s = new rectangle();
            s.draw();
            s = new squar();
            s.draw();
        }
    }
}
