using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    interface interfaces2
    {
        void GetManagerDetails();
        void DisplayManagerDetails();
    }
    public class derived : interfaces2
    {
        int Eid;
        string Ename;
        double ca, bonus;
        public  void GetManagerDetails()
        {
            Console.WriteLine("enter manager details");
             Eid = Convert.ToInt32(Console.ReadLine());
             Ename = Console.ReadLine();
             ca =Convert.ToDouble( Console.ReadLine());
             bonus =Convert.ToDouble(Console.ReadLine());
        }
        public void DisplayManagerDetails()
        {
            Console.WriteLine("manager details are");
            Console.WriteLine("manager id is:" + Eid);
            Console.WriteLine("manager name is:" + Ename);
            Console.WriteLine("manager ca is: " + ca );
            Console.WriteLine("manager bonus is:" +bonus );
        }
    }
    class testInterface2
    {
        static void Main(string[] args)
        {
            derived obj1 = new derived();
            obj1.GetManagerDetails();
            obj1.DisplayManagerDetails();
        }
    }
}
