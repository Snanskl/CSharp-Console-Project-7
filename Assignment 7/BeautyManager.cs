using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7
{
    internal class BeautyManager
    {
        //This class is accessed by Mainform
        #region Fields area
        private List<BeautyAndDate> beautyDate;
        private BeautyAndDate beautyAndDate;

        #endregion

        #region Constructors Area
        public BeautyManager()//Default constructor
        {
            //Everytime BeautyManager class is called, will create a new
            //BeautyAndDate object and call its consttructor
            beautyAndDate = new BeautyAndDate();
            beautyDate = new List<BeautyAndDate>();
        }
        #endregion

        #region Manual Methods
        public bool WriteDataToFile(string fileName)//Done
        { 
            FileManager fileManager = new FileManager();
            return fileManager.SaveListToFile(beautyDate, fileName);
        }
        public bool ReadDataToFile(string fileName)//Done
        {
            FileManager fileManager = new FileManager();
            return fileManager.ReadListFile(beautyDate, fileName);
        }
        public bool AddTask(BeautyAndDate bnd)//Done??
        {
            bool validAdd = false;

            if (bnd != null)
            {
                beautyDate.Add(bnd);
                validAdd = true;
            }
            return validAdd;
        }
        private bool CheckInex(int index)//Done
        {
            //This method is to check if the given index is within
            //the list or out of the list

            //return if index is more than 0 and within the object range
           return index >= 0 && index < beautyDate.Count;
        }
        public bool ChangeTaskAt(BeautyAndDate bnd, int index)//Done?? 
        {
            bool validChange = false;

            if ((CheckInex(index)) && (bnd != null))
            {
                beautyDate[index] = bnd;
                validChange = true;
            }
            return validChange;
        }
        public bool DeleteTaskAt(int index)//Done??
        {
            bool validDelete = false;

            if (CheckInex(index))
            {
                beautyDate.RemoveAt(index);
                validDelete = true;
            }
            return validDelete;
        }
        public BeautyAndDate GetAt(int index)
        {
            if (CheckInex(index))
            {
                //Send an index of the element we want to get to Beauty object
                BeautyAndDate beauty = beautyDate[index];

                //Return a copy of the data instead for original one
                BeautyAndDate copyBeautyAndDate = new BeautyAndDate(beauty);
                return copyBeautyAndDate;
            }
            return null;
        }
        public string[] GetSkincareToString()//Done
        {
            string[] skincareString = Enum.GetNames(typeof(SkincareIngrediens));

            for (int i = 0; i < skincareString.Length; i++)
            {
                skincareString[i] = skincareString[i].Replace("_", " ");
            }
            return skincareString;
        }
        public string[] GetMakeupToString()//Done
        {
            string[] makeupToString = Enum.GetNames(typeof(MakeupIngrediens));

            for (int i = 0; i < makeupToString.Length; i++)
            {
                makeupToString[i] = makeupToString[i].Replace("_", " ");
            }
            return makeupToString;
        }
        public string[] GetInfo()
        {
            //this method is returning a string array of data within beautyDate object
            string[] strOut = new string[beautyDate.Count];

            for (int i = 0; i < strOut.Length; i++)
            {
                strOut[i] = beautyDate[i].ToString();
            }
            return strOut;
        }

        
        #endregion

        #region Property Area
        public BeautyAndDate AccessBeautyDate
        {
            //This property is for accessng BeautyAndDate class
            //Without having to instantiate a class object
            get =>  beautyAndDate; 
        }

        #endregion


    }
}
