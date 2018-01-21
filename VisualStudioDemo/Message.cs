using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualStudioDemo
{
   public class Message
    {
        public static string GetMessage(string lang)
        {
            if (lang.Equals("sp"))
            {
                return "Hello mudo";
            }

            else  if (lang.Equals("fr"))
            {
                return "Hello Imran";
            }
            else
                return "Hello World";
        }
    }
}
