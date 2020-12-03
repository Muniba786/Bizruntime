using System;
using System.IO;
namespace ConsoleApp25
{
    public class StringReaderEx
    {
        public void sire()
        {
            StringWriter str = new StringWriter();
            str.WriteLine("Hello, this message is read by StringReader class");
            str.Close();
            
            StringReader reader = new StringReader(str.ToString());
           
            while (reader.Peek() > -1)
            {
                Console.WriteLine(reader.ReadLine());
            }
        }
    }
}