using System;
using System.IO;

namespace ConsoleApp25
{

    class StreamReaderEx
    {
        public void stre()
        {
            try
            {

                using (StreamReader sr = new StreamReader("TestFile.txt"))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception e)
            {

                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }
    }
}