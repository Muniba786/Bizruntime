using System;
using System.IO;
using System.Text;
namespace ConsoleApp25
{
   public class StringWriterEx
    {
        public void siwr()
        {
            string text = "Hello, Welcome to the javatpoint \n" +
                "It is nice site. \n" +
                "It provides technical tutorials";
           
            StringBuilder sb = new StringBuilder();
            
            StringWriter writer = new StringWriter(sb);
            
            writer.WriteLine(text);
            writer.Flush();
            
            writer.Close();
            
            StringReader reader = new StringReader(sb.ToString());
            
            while (reader.Peek() > -1)
            {
                Console.WriteLine(reader.ReadLine());
            }
        }
    }
}