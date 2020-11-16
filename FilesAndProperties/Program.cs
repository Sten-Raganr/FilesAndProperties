using System;
using System.Collections.Generic;
using System.IO;

namespace FilesAndProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootPath = @"C:\Users\opilane\samples";
            string txt = @"C:\Users\opilane\samples\filedata.txt";
            string[] files = Directory.GetFiles(rootPath, "*.*", SearchOption.AllDirectories);
            List<string> lines = new List<string>();
            foreach(string file in files)
            {
                var filedata = new FileInfo(file);
                string filename = filedata.Name;
                string filedirectory = filedata.DirectoryName;
                long filesize = filedata.Length;
                //Console.WriteLine($"file name:{filename}; location:{filedirectory};size: {filesize} bytes");
                string line= $"file name:{filename}; location:{filedirectory};size: {filesize} bytes";
                lines.Add(line);
                File.WriteAllLines(txt, lines);
            }
            Console.WriteLine("written!");
        }
    }
}
