using System;
using Task06;

namespace CodeConeverter_UI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProgramConverter[] programConverters = new ProgramConverter[] 
            {
                new ProgramConverter(), 
                new ProgramHelper(), 
                new ProgramConverter(), 
                new ProgramConverter(), 
                new ProgramHelper()
            };

            string strCheck = "String for check";
            foreach(ProgramConverter programConverter in programConverters)
            {
                if (programConverter is ProgramHelper programHelper)
                {
                    if (programHelper.CheckCodeSyntax(strCheck, "VB"))
                    {
                        Console.WriteLine($"{programHelper.ConvertToCSharp(strCheck)}");
                    }
                    else
                    {
                        Console.WriteLine($"{programHelper.ConvertToVB(strCheck)}");
                    }
                }
                else
                {
                    Console.WriteLine(programConverter.ConvertToCSharp(strCheck));
                    Console.WriteLine(programConverter.ConvertToVB(strCheck));
                }
            }

            Console.ReadLine();
        }
    }
}
