using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7
{
    internal class FileManager
    {
        #region Fields area
        private const string fileToken = "HealthyBeauty";
        private const double fileNumber = 1.0;
        #endregion

        #region Manual methods
        public bool ReadListFile(List<BeautyAndDate> list, string fileName)
        {
            bool validRead = true;

            //Using streamReader to read text from a file
            StreamReader reader = null;

            try
            {
                //Clear or renew the list before reading the file
                if (list != null)
                {
                    list.Clear();
                }
                else
                {
                    //if empty then create a new list from BeautyAndDate class and call its constructor
                    list = new List<BeautyAndDate>();
                }

                reader = new StreamReader(fileName);

                //Ensure that it is the correct file
                string versionTest = reader.ReadLine();
                //Ensure that it is the correct version number
                double version = double.Parse(reader.ReadLine());

                //Since we have created and used versionTest and version 
                //to read the file that we want to read, we will now compare it
                //to the data that we called (with global instance variables)
                if ((versionTest == fileToken) && (version == fileNumber))
                {
                    //Read number of items (tasks) to read
                    //Read the input and turned in int and saved in count
                    int count = int.Parse(reader.ReadLine());

                    for (int i = 0; i < count; i++)
                    {
                        //calling beautyDate object so we can read all the data
                        BeautyAndDate beautyName = new BeautyAndDate();
                        //read product name
                        beautyName.ProductName = reader.ReadLine();
                        //read an enum product type
                        beautyName.Product = (ProductType)Enum.Parse(typeof(ProductType), reader.ReadLine());


                        //Read DateTime.Year,Month. these are readonly
                        int year = 0, month = 0, day = 0;
                        int hour = 0, minute = 0, second = 0;

                        year = int.Parse(reader.ReadLine());
                        month = int.Parse(reader.ReadLine());
                        day = int.Parse(reader.ReadLine());
                        hour = int.Parse(reader.ReadLine());
                        minute = int.Parse(reader.ReadLine());
                        second = int.Parse(reader.ReadLine());

                        //added all these read data to property Date
                        beautyName.Date = new DateTime(year, month, day, hour, minute, second);

                        //added the data to list
                        list.Add(beautyName);
                    }
                }
                else
                { validRead = false; }
            }
            catch
            { validRead = false; }
            finally
            {
                if (reader != null)
                {reader.Close();}
            }
            return validRead;
        }

        public bool SaveListToFile(List<BeautyAndDate> list, string fileName)
        {
            bool validSave = false;

            //Using Streamwriter class to write text to a file. 
            //Initialize to null first
            StreamWriter writer = null;

            try
            {
                //initialized and input the filename in it
                writer = new StreamWriter(fileName);
                writer.WriteLine(fileToken);
                writer.WriteLine(fileNumber);
                writer.WriteLine(list.Count);

                for (int i = 0; i < list.Count; i++)
                {
                    writer.WriteLine(list[i].ProductName);
                    writer.WriteLine(list[i].Product.ToString());
                    writer.WriteLine(list[i].Date.Year);
                    writer.WriteLine(list[i].Date.Month);
                    writer.WriteLine(list[i].Date.Day);
                    writer.WriteLine(list[i].Date.Hour);
                    writer.WriteLine(list[i].Date.Minute);
                    writer.WriteLine(list[i].Date.Second);
                }
            }
            catch
            {
                validSave = false;
            }
            finally
            {
                if (writer != null)
                {
                    writer.Close();
                }
            }
            return validSave;
        }

        #endregion  
    }
}
