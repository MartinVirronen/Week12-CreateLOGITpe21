using System;
using System.IO;

namespace CreateLOGITpe21
{
    class Program
    {
        static void Main(string[] args)
        {
            string newDirectory = "LOGITpe21";
            CreateMyDirectory(newDirectory);
        }

        private static void CreateMyDirectory(string MyDirectoryName)
        {
            string rootDirectory = @"C:\Users\opilane\Samples";
            string directoryFullPath = $@"{rootDirectory}\{MyDirectoryName}";
        
            if (Directory.Exists(directoryFullPath))
            {
                Console.WriteLine($"Directory {MyDirectoryName} already exists in {rootDirectory}");

            } 
            else
            {
                Directory.CreateDirectory(directoryFullPath);
                Console.WriteLine($"Directory {MyDirectoryName} has been created.");
            }
        
        
        
        
        
        }





    }
}
