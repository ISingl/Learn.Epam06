using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task06
{
    public class ProgramHelper : IConvertible
    {
        public string ConvertToCSharp(string strToConvert)
        {
            return "Converting the string in to CSharp";
        }

        public string ConvertToVB(string strToConvert)
        {
            return "Converting the string in to VB";
        }
    }
}
