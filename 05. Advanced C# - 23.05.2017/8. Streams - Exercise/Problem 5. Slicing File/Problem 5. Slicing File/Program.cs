using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _05.Slicing_File
{
    public class SlicingFile
    {
        public static void Main()
        {
            Console.Write("Parts amount: ");
            int parts = int.Parse(Console.ReadLine());
            Console.Write("Choose input file path: ");
            var sourceFile = Console.ReadLine();
           
            var destinationDirectory =  @"../../Parts";
            var assembledDirectory =    @"../../Assembled";
            CreateFolder(destinationDirectory);
            CreateFolder(assembledDirectory);

            Slice(sourceFile, destinationDirectory, parts);

            var files = Directory.GetFiles(destinationDirectory).ToList();

            Assemble(files, assembledDirectory);
        }

        private static void CreateFolder(string directory)
        {
            bool exists = Directory.Exists(directory);

            if (!exists)
            {
                Directory.CreateDirectory(directory);
            }
        }

        private static void Assemble(List<string> files, string destinationDirectory)
        {
            var arr = files[0].Split('.').ToArray();
            string format = arr[arr.Length - 1];
            using (FileStream writer = new FileStream(destinationDirectory + "\\" + "assembled." + format, FileMode.Create, FileAccess.Write))
            {
                foreach (var file in files)
                {
                    using (FileStream reader = new FileStream(file, FileMode.Open))
                    {
                        var buffer = new byte[4096];
                        int readBytes = reader.Read(buffer, 0, buffer.Length);

                        while (readBytes != 0)
                        {
                            writer.Write(buffer, 0, readBytes);

                            readBytes = reader.Read(buffer, 0, buffer.Length);
                        }
                    }
                }
            }

            Console.WriteLine("Assembling Done.");
        }

        private static void Slice(string sourcePath, string destinationDirectory, int parts)
        {
            using (FileStream reader = new FileStream(sourcePath, FileMode.Open))
            {
                int partLength = (int)Math.Ceiling((double)reader.Length / parts);
                var buffer = new byte[partLength];
                var arr = sourcePath.Split('.').ToArray();
                string format = "." + arr[arr.Length - 1];
                var i = 0;
                while (true)
                {
                    int readBytes = reader.Read(buffer, 0, buffer.Length);

                    if (readBytes == 0)
                    {
                        break;
                    }

                    using (FileStream outputFile =
                        new FileStream(destinationDirectory + "\\" + "part-" + i.ToString() + format, FileMode.CreateNew, FileAccess.Write))
                    {
                        outputFile.Write(buffer, 0, readBytes);
                        i++;
                    }
                }
            }

            Console.WriteLine("Slicing Done.");
        }
    }
}