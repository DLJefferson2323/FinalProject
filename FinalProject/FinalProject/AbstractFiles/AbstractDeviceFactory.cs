using FinalProject.AbstractDeviceFactory;
using FinalProject.BaseFiles;


namespace FinalProject.AbstractFiles
{
    public abstract class AbstractDeviceFactory
    {
        public abstract IDeviceFrame CreateDeviceFrame();
        public abstract IDeviceScreen CreateDeviceScreen();
    } // end class
} // end namespace
