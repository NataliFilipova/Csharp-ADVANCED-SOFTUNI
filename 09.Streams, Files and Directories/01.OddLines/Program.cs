using System;
using System.IO;

namespace _09.Streams__Files_and_Directories
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter writer = new StreamWriter("output.txt"))
            {
                using (StreamReader reader = new StreamReader("input.txt"))
                {
                    int index = 0;

                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        if (index % 2 == 1)
                        {
                            writer.WriteLine(line);
                        }
                        index++;
                        line = reader.ReadLine();

                    }
                }
            }
        }
    }
}
