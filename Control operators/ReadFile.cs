using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_operators
{
    /// <summary>
    /// считывает все файлы в папке
    /// </summary>
    class ReadFile
    {
       public int i { get; private set; }

       public IPropertiesFile propertiesFile { get; private set; }

        public DirectoryInfo di { get; private set; }

        public ReadFile()
        {
            i = -1;

            propertiesFile = new PropertiesFileReName();

            di = new DirectoryInfo(propertiesFile.NamePath);
        }
        /// <summary>
        /// считает кол-во файлов
        /// </summary>
        /// <returns></returns>
        public int CountFile()
        {
            foreach (var filecount in di.GetFiles())
            {
                Console.WriteLine(filecount.Name);
                i++;
            }
            return i;
        }

    }
}
