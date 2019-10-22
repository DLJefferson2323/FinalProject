using FinalProject.BaseFiles;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.AbstractFiles
{
    public class MediumDeviceFactory : AbstractDeviceFactory
    {
        public override IDeviceFrame CreateDeviceFrame()
        {
            return new MediumFrame();
        } // end method override
        public override IDeviceScreen CreateDeviceScreen()
        {
            return new MediumScreen();
        }
    } // end class
} // end namespace
