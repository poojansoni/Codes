using System;
using System.IO;

namespace FileInfoDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //retriving details from d: drive
                DirectoryInfo info = new DirectoryInfo(@"D:\");

                //Get the top Level Directories Starting with A
                DirectoryInfo[] directories = info.GetDirectories("A*", SearchOption.TopDirectoryOnly);

                foreach (DirectoryInfo directory in directories)
                {
                    //retriving the files from the current directory
                    FileInfo[] files = directory.GetFiles();

                    foreach (FileInfo fileInfo in files)
                    {
                        //retriving the extension of the file
                        string extension = Path.GetExtension(fileInfo.FullName);
                        Console.WriteLine(fileInfo.FullName);
                        Console.WriteLine(fileInfo.Name);
                        //Checking for .cs extension
                        if (extension.Equals(".ai"))
                        {
                            Console.WriteLine("{0}=>{1}", directory.Name, fileInfo.Name);
                        }

                    }
                }
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
