using System;

namespace Task06
{
    public class ProgramHelper : ProgramConverter, ICodeChecker
    {
        public bool CheckCodeSyntax(string strChecked, string language)
        {
            switch(language)
            {
                case "CSharp": 
                    Console.WriteLine($"Checking to string \"{strChecked}\" for CSharp");
                    return true;
                case "VB": 
                    Console.WriteLine($"Checking to string \"{strChecked}\" for VB");
                    return true;
                default:
                    return false;
            }
        }
    }
}
