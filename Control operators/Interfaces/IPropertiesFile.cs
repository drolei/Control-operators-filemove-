using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_operators
{
    interface IPropertiesFile
    {
        /// <summary>
        /// получает имя файла
        /// </summary>
        string [] FileName { get; }
        /// <summary>
        /// новое расширение
        /// </summary>
        string NewName { get; }
        /// <summary>
        /// путь
        /// </summary>
        string NamePath { get; }
    }
}
