using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModelClassLibrary
{
    class DiskStore
    {
        static string currentDocPath =
    Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) +
    "\\arrayData.txt";
        public static void WriteStringArray(string[,] pArray)
        {
            //writes data from the array parameter to the disk
            StreamWriter fileWriter = new StreamWriter(currentDocPath);
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    fileWriter.WriteLine(pArray[i, j]);
                }
            }
            fileWriter.Close();
        }

        public static string[,] ReadStringArray()
        {
            VerifyFileExist(10, 3);  // creates file if it doesnt exist
            StreamReader fileReader = new StreamReader(currentDocPath);
            string[,] returnArray = new string[10, 3];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    returnArray[i, j] = fileReader.ReadLine();
                }
            }
            fileReader.Close();

            return returnArray;
        }

        //Methods below exist solely for file verification

        public static bool VerifyFileExist(int rows, int columns)
        {
            try
            {
                if (File.Exists(currentDocPath))
                {
                    return true;
                }
                else
                {
                    CreateFile(rows, columns); // this method will create the file

                    return true;
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("We have a problem: " + ex.Message);
            }
            return false; // have to keep the compiler happy

        }

        private static void CreateFile(int rows, int columns)
        {
            StreamWriter arrayCreator = new StreamWriter(currentDocPath);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    arrayCreator.WriteLine("");
                }
            }
            arrayCreator.Close();
        }
    }
}
