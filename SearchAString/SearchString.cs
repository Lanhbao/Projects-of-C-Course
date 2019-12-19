using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
namespace SearchAString
{ 
    /*
     The application should be able to print how many times it found the string in string.
     */

    /// <summary>
    /// The application search string in file.
    /// </summary>
    /// <remarks>
    /// This class can check for the existence of the file.
    /// </remarks>
    class SearchString
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
        public static int CheckOccurrencesOfSearchString(string input, string searchString)
        {
            // Initial Regex object
            Regex regexOfPattern = new Regex(searchString);

            // Find matches
            MatchCollection matches = regexOfPattern.Matches(input);

            // Report the number of matches found.
            return matches.Count;
        }
        public static int CheckOccurrencesOfSearchStringFromFile(string pathOfFile, string searchString)
        {
            // Open and read file
            FileStream fileTest = new FileStream(pathOfFile, FileMode.Open);
            StreamReader readerFile = new StreamReader(fileTest, Encoding.UTF8);
            String data = readerFile.ReadToEnd();
            readerFile.Close();
            return CheckOccurrencesOfSearchString(data, searchString);
        }

        public void PrintResultOfCheckStringInFile(string pathOfFile, string searchString)
        {
            if (!IsFileExists(pathOfFile))
            {
                Console.WriteLine("File not found!");
            }
            else
            {
                Console.WriteLine("{0} occurrences(s) of the search term \"{1}\" were found.", CheckOccurrencesOfSearchStringFromFile(pathOfFile, searchString), searchString);
            }

        }
    }
}


