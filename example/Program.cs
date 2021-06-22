using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            studentinfo instances = new studentinfo();
            instances.SetId("S100");
            instances.Setname("tom");
            instances.Setmarks(70);

            string idvalue= instances.GetId();
            string namevalue = instances.GetName();
            int marksvalue = instances.Getmarks();
            System.Console.WriteLine(idvalue);
            System.Console.WriteLine(namevalue);
            System.Console.WriteLine(marksvalue);
        }
    }
}
