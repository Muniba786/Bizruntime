using System;
using System.IO;
namespace ConsoleApp24
{
    class FileInfoEx
    {
        public void fiin()
        {
            try
            {
                
                string loc = "D:\\abc.txt";
                  
                FileInfo file = new FileInfo(loc);
                  
                StreamWriter sw = file.CreateText();
  
                sw.WriteLine("This text is written to the file by using StreamWriter class.");
                sw.Close();
            }
            catch (IOException e)
            {
                Console.WriteLine("Something went wrong: " + e);
            }
        }
    }
}