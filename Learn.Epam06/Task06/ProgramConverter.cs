using System;

namespace Task06
{
    public class ProgramConverter : IConvertible
    {
        public string ConvertToCSharp(string strToConvert)
        {
            return $"String \"{strToConvert}\" converting to CSharp";
        }

        public string ConvertToVB(string strToConvert)
        {
            return $"String \"{strToConvert}\" converting to VB";
        }
    }
}
