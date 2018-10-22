using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
   abstract class clsAbstracts2
    {
        protected  int Eid;
        protected  string Ename;
       
        public abstract void GetEmpDeatails();
        public virtual  void DisplayEmpDetails()
        {
            Console.WriteLine("employee details are");
            Console.WriteLine("Emp id is:" + Eid);
            Console.WriteLine("Emp name is:" + Ename);
           
        }
    }
    class testclsAbstract2:clsAbstracts2
    {
        double ca, bonus;
        public override  void GetEmpDeatails()
        {
            Console.WriteLine("enter employe data like id,name,ca,bonus");
            Eid = Convert.ToInt32(Console.ReadLine());
            Ename = Console.ReadLine();
            ca = Convert.ToDouble(Console.ReadLine());






            bonus = Convert.ToDouble(Console.ReadLine());

        }
        public override  void DisplayEmpDetails()
        {
            Console.WriteLine("manager details are");
            Console.WriteLine("manager id is :" + Eid);
            Console.WriteLine("manager name is:" + Ename);
            Console.WriteLine("manager ca is:" + ca);
            Console.WriteLine("manager bonus is:" + bonus);
        }
    }
    class clsAbstrac2
    {
        static void Main(string[] args)
        {
            testclsAbstract2 obj1 = new testclsAbstract2();
            obj1.GetEmpDeatails();
            obj1.DisplayEmpDetails();
        }
    }
}
