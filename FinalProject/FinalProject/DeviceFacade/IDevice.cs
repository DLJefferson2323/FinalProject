using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.DeviceBase
{
    public class IDevice
    {
        IDevice GetDevice { get; }
        SurfaceColor ColorType { get; }

        decimal Price { get; }
        //void Color(SurfaceColor color);

       // void CleanFrame();
       // void CleanScreen();
      //  void TestOS();
    } // end class
} // namespace
