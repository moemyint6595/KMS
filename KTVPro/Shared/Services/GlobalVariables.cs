using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Services
{
    public class GlobalVariables
    {
        public string MyString { get; private set; } = "MMZ 1996";
        public string APIEndPoint { get; private set; } = "https://192.168.100.173:2002";
    }
}
