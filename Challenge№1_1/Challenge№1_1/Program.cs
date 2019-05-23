using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Challenge_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
       // C:\Users\user\Desktop\4.txt

            string path1 = @"" + Console.ReadLine();
            string path2 = @"" + Console.ReadLine();
            FileInfo file1 = new FileInfo(path1);
            FileInfo file2 = new FileInfo(path1);

            
            if (file1.Exists && file2.Exists)
            {
                string text = File.ReadAllText(path1);
                int i = text.Length;
                string convers=null;
                for (i -= 1; i >= 0; i--)
                {
                     convers+= text[i];
                }
                File.WriteAllText(path2,convers);
            }
            else
            {
                Console.Write("Error");
            }

        }
    }
}
