using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;
using System.Management;

namespace VictoriApp.Framework.SystemInformation
{
    public class Information
    {
        private String sMACAddress;
        private String sDescription;
        private String sName;
        private String sManufacturer;
        private String sSystemName;
        private String sProcessorId;

        public String MACAddress
        {
            get { return sMACAddress; }
            set { sMACAddress = value; }
        }

        public String ProcessorId
        {
            get { return sProcessorId; }
            set { sProcessorId = value; }
        }

        public String SystemName
        {
            get { return sSystemName; }
            set { sSystemName = value; }
        }

        public String Manufacturer
        {
            get { return sManufacturer; }
            set { sManufacturer = value; }
        }

        public String Name
        {
            get { return sName; }
            set { sName = value; }
        }

        public String Description
        {
            get { return sDescription; }
            set { sDescription = value; }
        }

        public Information()
        {
            sMACAddress = "N/A";
            sDescription = "N/A";
            sName = "N/A";
            sManufacturer = "N/A";
            sSystemName = "N/A";
            sProcessorId = "N/A";

            DeviceInformation("Win32_Processor");
            GetMACAddress();
        }

        private void DeviceInformation(String stringIn)
        {
            StringBuilder StringBuilder1 = new StringBuilder(String.Empty);

            ManagementClass ManagementClass1 = new ManagementClass(stringIn);

            ManagementObjectCollection ManagementObjectCollection1 = ManagementClass1.GetInstances();

            PropertyDataCollection properties = ManagementClass1.Properties;

            foreach (ManagementObject obj in ManagementObjectCollection1)
            {
                foreach (PropertyData property in properties)
                {
                    try
                    {
                        if ("Description" == property.Name)
                            sDescription = obj.Properties[property.Name].Value.ToString();
                        else if ("Name" == property.Name)
                            sName = obj.Properties[property.Name].Value.ToString();
                        else if ("Manufacturer" == property.Name)
                            sManufacturer = obj.Properties[property.Name].Value.ToString();
                        else if ("SystemName" == property.Name)
                            sSystemName = obj.Properties[property.Name].Value.ToString();
                        else if ("ProcessorId" == property.Name)
                            sProcessorId = obj.Properties[property.Name].Value.ToString();
                    }
                    catch { }
                }
            }
        }

        private void GetMACAddress()
        {
            try
            {
                NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
                foreach (NetworkInterface adapter in nics)
                {
                    IPInterfaceProperties properties = adapter.GetIPProperties();
                    sMACAddress = adapter.GetPhysicalAddress().ToString();
                    break;
                }
            }
            catch { }
        }
    }
}
