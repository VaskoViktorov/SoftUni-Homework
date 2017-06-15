using System;
using System.IO;

class CopyingImage
{    
    static void Main()
    {
        Console.Write("Choose input file path: ");
        string ImagePath = Console.ReadLine();

        // Don't forget to give the output a name and format
        Console.Write("Choose output file path: ");
        string DestinationPath = Console.ReadLine();

        using (var source = new FileStream(ImagePath, FileMode.Open))
        {
            using (var destination = new FileStream(DestinationPath, FileMode.Create))
            {
                double fileLength = source.Length;
                byte[] buffer = new byte[4096];
                while (true)
                {
                    int readBytes = source.Read(buffer, 0, buffer.Length);

                    if (readBytes == 0)
                    {
                        break;
                    }
                    destination.Write(buffer, 0, readBytes);                  
                }
                Console.WriteLine("Finished");
            }
        }
    }
}
