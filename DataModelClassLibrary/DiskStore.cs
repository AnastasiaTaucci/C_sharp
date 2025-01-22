using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DataModelClassLibrary
{
    internal static class DiskStore
    {
        static string currentDocPath =
        Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) +
        "\\arrayData.txt";

        public static void WriteStringArray(string[,] pArrayIn)
        {
            StreamWriter fileWriter = new StreamWriter(currentDocPath);

            for (int i = 0; i < pArrayIn.GetLength(0); i++) 
            {
                for (int j = 0; j < pArrayIn.GetLength(1); j++)
                {
                    fileWriter.WriteLine(pArrayIn[i, j]);
                }
            }
            fileWriter.Close();
        }


        public static string[,] ReadStringArray()
        {
            VerifyFileExists(10, 3);

            string [,] readArray = new string[10, 3];

            StreamReader fileReader = new StreamReader(currentDocPath);

            for (int i = 0; i <  readArray.GetLength(0); i++)
            {
                for(int j = 0;j < readArray.GetLength(1);j++)
                {
                    readArray[i, j] = fileReader.ReadLine();
                }
            }

            fileReader.Close();
            return readArray;
            
        }


        public static bool VerifyFileExists(int rows, int columns)
        {
            try
            {
                if (File.Exists(currentDocPath))
                {
                    return true;
                }
                else
                {
                    CreateFile(rows, columns);
                    return true;
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine("We have a problem: " + ex.Message);
            }
            return false;
        }




        public static void CreateFile(int rows, int columns)
        {
            StreamWriter arrayCreator = new StreamWriter(currentDocPath);
            for (int i = 0; i < rows; i++)
            {
                arrayCreator.WriteLine("");
            }
            arrayCreator.Close();
        }
    }
}
