using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new Sbsfinal01();
            foreach(var value in client.Values.Get())
            {
                Console.WriteLine(value.ToString());
            }
            Console.ReadLine();
        }
    }
}
