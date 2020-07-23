using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Control_operators
{
    class PropertiesFileReName : IPropertiesFile
    {
        public string[] FileName { get; }

        public string NewName { get; }

        public string NamePath { get; }
        /// <summary>
        /// старое расширение
        /// </summary>
        public string OldName { get; }

        public PropertiesFileReName()
        {
            NamePath = @"";

            FileName= Directory.GetFiles(NamePath);

            OldName = @"\.+\S+";

            NewName = ".jpg";
        }
        /// <summary>
        /// конвертирует старое расширение в Regex
        /// </summary>
        /// <returns>возвращает Regex </returns>       
        public Regex RegexConvert()
        {
            Regex regex = new Regex(OldName);
            return regex;
        }






    }
}
