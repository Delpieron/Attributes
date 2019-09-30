#define OTHER
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            //ObsoleteClass obsoleteClass = new ObsoleteClass();
            //Stopwatch st = new Stopwatch();
            //st.Start();
            //Console.WriteLine(obsoleteClass.NewMethod());
            //st.Stop();
            //Console.WriteLine(st.ElapsedTicks) ;
            ConditionalClass cC = new ConditionalClass();
            cC.Login();
            cC.Login("User","Pass");

            Console.Read();

        }
    }
}
