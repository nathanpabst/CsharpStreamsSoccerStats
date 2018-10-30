﻿using System;
using System.IO;

namespace SoccerStats
{
    class Program
    {
        static void Main(string[] args)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            DirectoryInfo directory = new DirectoryInfo(currentDirectory);
            var files = directory.GetFiles("*.txt");
            foreach (var file in files)
            {
                Console.WriteLine(file.Name);
            }

        }
    }
}
