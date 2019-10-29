using FinalProject.AbstractFiles;
using FinalProject.BaseFiles;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.DeviceFacade
{
    public class MyReaderList
    {
        public void MyReaders()
        {
            List<AbstractReaderBase> myList = new List<AbstractReaderBase>();
            myList.Add(new SevenInch());
            myList.Add(new NineInch());
            myList.Add(new TwelveInch());
            myList.Add(new SevenOLED());
            myList.Add(new NineOLED());
            myList.Add(new TwelveOLED());
        } // end method my list example

    } // end class
} // end namespace
