using FinalProject.AbstractFiles;
using FinalProject.DeviceFacade;
using System;
using System.Collections.Generic;

namespace FinalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World! My name is Argos and I am here to assist you.");
            //AbstractReaderDemo();
            //SingletonDeviceDemo();
            //DeviceFacadeDemo();
        }

        public void myOtherList()
        {
            List<MyReaderList> myReadList = new List<MyReaderList>();
            myReadList.Add(new SevenInch());
            myReadList.Add(new NineInch());
            myReadList.Add(new TwelveInch());

            foreach (MyReaderList item in myReadList)
            {
                Console.WriteLine(item.ReaderSize + " , " + ReaderColor);
            } // end method for each

        } // end method my other list
    } // end class
} // end namespace
