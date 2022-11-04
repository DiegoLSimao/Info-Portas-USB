using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace InfoDispositivoUSB
{
    internal class USBDeviceInfo
    {
        public USBDeviceInfo(string name, string manufacturer, string serialPort)
        {
            this.Name = name;
            this.Manufacturer = manufacturer;
            this.SerialPort = serialPort;
        }
        public string Name { get; private set; }
        public string Manufacturer { get; private set; }
        public string SerialPort { get; private set; }




        public static List<USBDeviceInfo> GetUSBDevices()
        {
            List<USBDeviceInfo> devices = new List<USBDeviceInfo>();

            ManagementObjectCollection collection;
            using (var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity WHERE ClassGuid=\"{4d36e978-e325-11ce-bfc1-08002be10318}\""))
                collection = searcher.Get();

            foreach (var device in collection)
            {
                devices.Add(new USBDeviceInfo(
                (string)device.GetPropertyValue("Name"),
                (string)device.GetPropertyValue("Manufacturer"),
                Regex.Match((string)device.GetPropertyValue("Name"), @"(?<=\().+?(?=\))").Value
                ));
            }
            collection.Dispose();
            return devices;
        }

        public static USBDeviceInfo GetDeviceInfo(string com)
        {
            var devices = GetUSBDevices();

            foreach (var device in devices)
            {
                if(device.SerialPort.Contains(com))
                {
                    return device;
                }
            }
            return null;
        }


    }
}
