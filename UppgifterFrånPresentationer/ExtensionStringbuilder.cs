using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UppgifterFrånPresentationer
{
    public static class ExtensionStringbuilder
    {
        public static StringBuilder Substring(this StringBuilder sb1, int index, int length)
        {
            StringBuilder sb2 = new StringBuilder();
            for (int i = index-1; i < length+index-1; i++)
            {
                sb2.Append(sb1[i]);
            }
            return sb2;
        }
    }
}
