using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestManager
{
    internal class Common
    {
        public static string DesktopDirectory { get; internal set; } = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
    }
}
