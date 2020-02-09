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
            Console.WriteLine();
            string path1 = @"" + Console.ReadLine();
            string path2 = @"" + Console.ReadLine();
            FileInfo file1 = new FileInfo(path1);
            FileInfo file2 = new FileInfo(path1);
            if (file1.Exists && file2.Exists)
            {
                string text = File.ReadAllText(path1);
                int n = text.Length-1;
                char [] chars = text.ToCharArray();
                int i , j;
                for (i = 0,j = n; j > n/2; i++,j--)
                {
                    (chars[i], chars[j]) = (chars[j], chars[i]);
                }
                text = String.Concat<char>(chars) ;
                File.WriteAllText(path2,text);
            }
            else
            {
                Console.Write("Error");
            }
        }
    }
}
