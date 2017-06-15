using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text.RegularExpressions;

internal class ZippingSlicedFiles
{
    private static List<string> files = new List<string>();
    private static MatchCollection matches;
    private static void Main()
    {
        string inputFile = Console.ReadLine();
        string folderPath = @"../../";
        int NumberOfParts = int.Parse(Console.ReadLine());

        Slice(inputFile, folderPath, NumberOfParts);

        Assemble(files, folderPath, inputFile);
    }

    private static void Assemble(List<string> files, string destinationDirectory, string inputFile)
    {
        // creating the file path for the reconstructed file
        var arr = inputFile.Split('.').ToArray();
        var format = arr[arr.Length - 1];
        string fileOutputPath = destinationDirectory + "assembled" + "." + format;
        var fsSource = new FileStream(fileOutputPath, FileMode.Create);

        fsSource.Close();
        using (fsSource = new FileStream(fileOutputPath, FileMode.Append))
        {
            // reading the file paths of the parts from the files list
            foreach (var filePart in files)
            {
                using (var partSource = new FileStream(filePart, FileMode.Open))
                {
                    using (var compressionStream = new GZipStream(partSource, CompressionMode.Decompress, false))
                    {
                        // Create a byte array of the content of the current file
                        Byte[] bytePart = new byte[4096];
                        while (true)
                        {
                            int readBytes = compressionStream.Read(bytePart, 0, bytePart.Length);
                            if (readBytes == 0)
                            {
                                break;
                            }

                            // Write the bytes to the reconstructed file
                            fsSource.Write(bytePart, 0, readBytes);
                        }
                    }
                }
            }
        }
    }

    private static void Slice(string sourceFile, string destinationDirectory, int parts)
    {
        using (var source = new FileStream(sourceFile, FileMode.Open))
        {
            long partSize = (long)Math.Ceiling((double)source.Length / parts);

            // The offset at which to start reading from the source file
            long fileOffset = 0;
            ;
            string currPartPath;
            FileStream fsPart;
            long sizeRemaining = source.Length;

            // extracting name and extension of the input file
            var arr = sourceFile.Split('.').ToArray();
            var format = arr[arr.Length - 1];
            
            for (int i = 0; i < parts; i++)
            {
                currPartPath = destinationDirectory + "part" + String.Format(@"-{0}", i) + "." + "gz";
                files.Add(currPartPath);

                // reading one part size
                using (fsPart = new FileStream(currPartPath, FileMode.Create))
                {
                    using (var compressionStream = new GZipStream(fsPart, CompressionMode.Compress, false))
                    {
                        long currentPieceSize = 0;
                        byte[] buffer = new byte[4096];
                        while (currentPieceSize < partSize)
                        {
                            int readBytes = source.Read(buffer, 0, buffer.Length);
                            if (readBytes == 0)
                            {
                                break;
                            }

                            // creating one part size file
                            compressionStream.Write(buffer, 0, readBytes);
                            currentPieceSize += readBytes;
                        }
                    }
                }

                // calculating the remaining file size which iis still too be read
                sizeRemaining = (int)source.Length - (i * partSize);
                if (sizeRemaining < partSize)
                {
                    partSize = sizeRemaining;
                }
                fileOffset += partSize;
            }
        }
    }
}

