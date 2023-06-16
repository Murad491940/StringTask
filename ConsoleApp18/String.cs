using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    public class String
    {
        
        public void Trim()
        {
            string word = "    Hello   ".Trim();
            Console.WriteLine(word.Trim());

        }
        public void TrimStart()
        {
            string word = "    Hello".Trim();
            Console.WriteLine(word.Trim());
        }
        public void TrimEnd()
        {
            string word = "Hello   ".Trim();
            Console.WriteLine(word.Trim());
        }
    }
}
