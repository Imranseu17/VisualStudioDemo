using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualStudioDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            string message = Message.GetMessage("en");
            Console.WriteLine(message);
            Console.ReadLine();
            
        }
    }
}
