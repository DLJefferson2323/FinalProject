using FinalProject.DeviceBase;


namespace FinalProject.DeviceFacade
{
    public class DeviceFacade
    {
        public void PrepareForSale(IDevice device)
        {
            DeviceRegistration reg = new DeviceRegistration(device);
            reg.AllocateDeviceNumber();

            DeviceDocumentation.PrintBrochure(device);

            //device.CleanFrame();
            //device.CleanScreen();
            //device.TestOS();
        } // end method prepare for sale
    } // end class
} // end namespace
