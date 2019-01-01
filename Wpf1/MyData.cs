using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf1
{
    public class MyData
    {
        public const int MinPassword = 6;
        public static string MinPasswordStr = "" + MinPassword;
        public string User { get; set; }
        public string Password { get; set; }
    }
}
