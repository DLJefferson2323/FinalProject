using FinalProject.AbstractDeviceFactory;
using FinalProject.BaseFiles;


namespace FinalProject.AbstractFiles
{
    public class SmallDeviceFactory : AbstractDeviceFactory
    {
        public override IDeviceFrame CreateDeviceFrame()
        {
            return new SmallFrame();
        }
        public override IDeviceScreen CreateDeviceScreen()
        {
            return new SmallScreen();
        }
    } // end class
} // end namespace
