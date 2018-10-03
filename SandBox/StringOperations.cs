using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandBox
{
    public class StringOperations
    {
        public string Concatenate(string leadString, string trailingString)
        {
            return leadString + trailingString;
        }

        public string ConcatenateWithSpace(string leadString, string trailingString)
        {
            return leadString + " " + trailingString;
        }
    }
}

