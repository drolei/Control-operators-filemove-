using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using Control_operators.Mocks;

namespace Control_operators
{
    class Program
    {
        static void Main(string[] args)
        {

            ReadFile readFile = new ReadFile();
            var rename = new ReNameClass();
            var plusname = new PlusNameClass();
            int i = readFile.CountFile();
            for (int z = 0; z <= i; z++)
            {
                rename.ReName(z);
                plusname.PlusName(z);
            }





           Console.ReadKey();
        }
    }
}
