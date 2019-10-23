using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.BaseFiles
{
    public class IReader
    {
        IWheel GetWheel { get; }
        DeviceColor ColorType { get; }

        decimal Price { get; }
        void Color(DeviceColor color);

        void CleanFrame();
        void CleanScreen();
        void TestOS();
    } // end class
} // end namespace
