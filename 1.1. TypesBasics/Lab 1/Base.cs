using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    interface IInfo
    {
        string GetInfo();
    }
    
    internal struct Base: IInfo
    {
          public string GetInfo()
        {
            return "Base struct";
        }
    }
    internal struct A: IInfo
    {
        public string GetInfo()
        {
            return "A struct";
        }
    }
}
