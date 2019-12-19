using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace SearchStringInFile
{
    /*
     The application should be able to print how many times it found the string in that file. The application can also handle the situation where the file is not found.
     */

    /// <summary>
    /// The application search string in file.
    /// </summary>
    /// <remarks>
    /// This class can check for the existence of the file.
    /// </remarks>
    class Program
    {
        public Boolean IsFileExists(string pathOfFile)
        {
            return File.Exists(pathOfFile);
        }

        public void PrintDataOfFile(string pathOfFile)
        {
            FileStream fileTest = new FileStream(pathOfFile, FileMode.Open);
            StreamReader readerFile = new StreamReader(fileTest, Encoding.UTF8);
            String data = readerFile.ReadToEnd();
            Console.WriteLine(data);
            readerFile.Close();

        }

        public int CheckOccurrencesOfSearchString(string pathOfFile, string searchString)
        {
            // Open and read file
            FileStream fileTest = new FileStream(pathOfFile, FileMode.Open);
            StreamReader readerFile = new StreamReader(fileTest, Encoding.UTF8);
            String data = readerFile.ReadToEnd();
            readerFile.Close();

            // Initial Regex object
            Regex regexOfPattern = new Regex(searchString);

            // Find matches
            MatchCollection matches = regexOfPattern.Matches(data);

            // Report the number of matches found.
            return matches.Count;


        }

        public void PrintResultOfCheckStringInFile(string pathOfFile, string searchString)
        {
            if (!IsFileExists(pathOfFile))
            {
                Console.WriteLine("File not found!");
            }
            else
            {
                Console.WriteLine("{0} occurrences(s) of the search term \"{1}\" were found.", CheckOccurrencesOfSearchString(pathOfFile, searchString), searchString);
            }

        }
        static void Main(string[] args)
        {
            var program = new Program();
            string pathOfFile = @"C:\Users\vietn\OneDrive\Desktop\testSample.txt";
            Console.WriteLine("Enter your search string: ");
            string searchString = Console.ReadLine();

            program.PrintResultOfCheckStringInFile(pathOfFile, searchString);
        }
    }
}

