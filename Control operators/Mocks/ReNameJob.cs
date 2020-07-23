using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Control_operators
{
    class ReNameJob : IJob
    {
 
        private PropertiesFileReName propertiesFile { get; }
        public ReNameJob()
        {
       
            propertiesFile = new PropertiesFileReName();
        }
        public void DoJob(int i)
        {
            if (Regex.IsMatch(propertiesFile.FileName[i],propertiesFile.OldName, RegexOptions.IgnoreCase))
            {
                File.Move(propertiesFile.FileName[i], propertiesFile.RegexConvert().Replace(propertiesFile.FileName[i],propertiesFile.NewName));

                Console.WriteLine("ismath " + propertiesFile.FileName[i]);

            }
        }
    }
}
