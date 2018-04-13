using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cfun
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Sunny Mubeen ";
            Console.WriteLine("Trim: '{0}'", fullName.Trim());
            Console.WriteLine("Trim: '{0}'", fullName.Trim().ToUpper());
        }
    }
}
