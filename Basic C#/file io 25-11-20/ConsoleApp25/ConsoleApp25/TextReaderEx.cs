using System;
using System.IO;
namespace ConsoleApp25
{
    public class TextReaderEx
    {
        public void txre()
        {
            using (TextReader tr = File.OpenText("e:\\f.txt"))
            {
                Console.WriteLine(tr.ReadToEnd());
            }
        }
    }
}