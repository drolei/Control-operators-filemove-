using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Control_operators.Mocks
{
    class PlusNameJob : IJob
    {
        private IPropertiesFile propertiesFile { get; }
        
       public PlusNameJob()
        {
            propertiesFile = new PropertiesFileReName();

            
        }

        public void DoJob(int i)
        {
            if (!Regex.IsMatch(propertiesFile.FileName[i], @"\."))
            {

                File.Move(propertiesFile.FileName[i], propertiesFile.FileName[i] + propertiesFile.NewName);

                Console.WriteLine("without file expansion  " + propertiesFile.FileName[i]);
            }

        }
    }
}
