using System;
using System.Collections.Generic;
using System.IO;

namespace DataFramework
{
  public static class FileOperations
    {
     /// <summary>
     /// List all the files in the current directory
     /// </summary>
     /// <returns>list of files</returns>
        public static List<string> ListAllFiles(string Path)
        {
           // String Path = Application.StartupPath + @"\";
            List<string>Details = new List<string>();
            try
            {
                // loop through the directory and get all the file names with a .txt suffix
                foreach (String file in Directory.GetFiles(Path))
                {
                    FileInfo info = new FileInfo(file);
                    if (info.Extension == ".txt")
                    {
                        Details.Add(info.Name);
                    }
                }
                return Details;
            }
            catch (Exception)
            {//don't allow nulls
                Details.Add("No Spies");
                return Details;
            }

        }
        /// <summary>
        ///  Read in lines from file.
        /// </summary>
        /// <param name="ChosenFileName"></param>
        /// <returns>List of file details</returns>
        public static List<string> ReturnFileData(string filename)
        {
          // string filename = Application.StartupPath + @"\" + ChosenFileName;
            List<string> Details = new List<string>();

            foreach (string line in File.ReadLines(filename))
            {
                Details.Add(line);
            }

            return Details;
        }
        //save the file
        public static void SaveFile(string filename, IEnumerable<string>FileData)
        {
            string newpath = Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory())) + @"\" + filename + ".txt";


            File.WriteAllLines(filename + ".txt", FileData);
            }
    }
}
