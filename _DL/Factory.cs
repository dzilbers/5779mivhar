using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _DL
{
    public static class Factory
    {
        public static IDL getDL(string type)
        {
            switch (type)
            {
                case "data": return DL.Instance;
            }
            return null;
        }
    }
}
