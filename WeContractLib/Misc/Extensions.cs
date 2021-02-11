using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeContractLib.Misc
{
   public static class Extensions
    {
        public static string SubStringN(this string msg, int length = 499) => !string.IsNullOrEmpty(msg) ? (msg.Length >= length ? msg.Substring(0, length) : msg) : "";
    }
}
