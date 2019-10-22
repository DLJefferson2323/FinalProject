using FinalProject.DeviceBase;
using FinalProject.SingletonDevice;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.DeviceFacade
{
    public class DeviceRegistration
    {
        private IDevice _device;

        public DeviceRegistration(IDevice device)
        {
            this._device = device;
        } // end method registration

        public void AllocateBikeNumber()
        {
            Console.WriteLine("Allocating Bike Number " + SerialNumberGenerator.Instance.NextSerial);
        } // end method allocated device number
    } // end class
} // end namespace
