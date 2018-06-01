using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace Bye_Cycle
{
    
        public class DeviceDetector
        {
            public List<Device> Devices;
            public DeviceDetector()
            {
                Devices = new List<Device>();
            }
            public bool DetectArduinos()
            {
                bool arduinofound = false;
                int counter = 0;
                try/* bron:https://forum.arduino.cc/index.php?topic=110464.0 */
                {
                    Devices.Clear();
                    ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_PnPEntity");//(locatie waar gezocht moet worden, wat moet er gezocht worden) 
                    foreach (ManagementObject queryObj in searcher.Get())
                    {
                        if (queryObj["Name"] != null)
                        {
                            string foundDeviceName = queryObj["Name"].ToString();
                            if (foundDeviceName.Contains("Arduino")) //checks if the opbject that is found is a Arduino.
                            {
                                Console.WriteLine(queryObj["Name"]); //Writes the name of the arduino adn the comport it is connected to in the consol.
                                                                     //string arduino = queryObj["Name"].ToString(); // the next code convert the the full string to only the comport.
                                foundDeviceName = foundDeviceName.TrimEnd(')');
                                string[] comport = foundDeviceName.Split('(');
                                Console.WriteLine(comport[1]);
                                string[] id = queryObj["PNPDeviceID"].ToString().Split('\\');
                                Console.WriteLine(id[2]);
                                Device newDevice = new Device(counter, comport[0], id[2], comport[1]);
                                Devices.Add(newDevice); //Add comport to device list
                                counter++;
                                arduinofound = true;
                            }
                        }
                    }
                }
                catch (ManagementException error)
                {
                    Console.WriteLine(error.Message);
                    throw new ManagementException("error", error);
                }
                return arduinofound;
            }
            public void DetectDevice()
            {
                int counter = 0;
                try //bron:https://forum.arduino.cc/index.php?topic=110464.0
                {
                    Devices.Clear();
                    ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2",
                        "SELECT * FROM Win32_PnPEntity");

                    foreach (ManagementObject queryObj in searcher.Get())
                    {
                        if (queryObj.GetPropertyValue("DeviceID") == null)
                        {
                            Console.WriteLine("null object");
                        }
                        if (queryObj["Name"] != null)
                        {
                            string foundDeviceName = queryObj["Name"].ToString();
                            string[] id;
                            Device newDevice;
                            Console.WriteLine(
                                queryObj["Name"]); //Writes the name of the device and the comport it is connected to in the consol.
                                                   // the next code convert the the full string to only the comport.
                            if (foundDeviceName.Contains('(') && foundDeviceName.Contains(')'))
                            {
                                foundDeviceName = foundDeviceName.TrimEnd(')');
                                string[] comport = foundDeviceName.Split('(');
                                Console.WriteLine(comport[1]);
                                id = queryObj["PNPDeviceID"].ToString().Split('\\');
                                newDevice = new Device(counter, comport[0], comport[1], id[2]);
                            }
                            else
                            {
                                id = queryObj["PNPDeviceID"].ToString().Split('\\');
                                newDevice = new Device(counter, foundDeviceName, id[2]);
                            }
                            Devices.Add(newDevice); //Add comport to device list
                            counter++;
                        }
                        else
                        {
                            Console.WriteLine("null object");
                        }

                    }
                }
                catch (ManagementException error)
                {
                    Console.WriteLine(error.Message);
                    throw new ManagementException("error", error);
                }

            }
            public void DetectDevice(string deviceName)
            {
                if (deviceName == null)
                {
                    throw new ArgumentNullException("deviceName", "DiviceName is null");
                }
                if (deviceName == "")
                {
                    throw new ArgumentOutOfRangeException("deviceName", "DeviceName is empty");
                }
                int counter = 0;
                try //bron:https://forum.arduino.cc/index.php?topic=110464.0
                {
                    Devices.Clear();
                    ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2",
                        "SELECT * FROM Win32_PnPEntity");

                    foreach (ManagementObject queryObj in searcher.Get())
                    {
                        if (queryObj["Name"] != null)
                        {
                            string foundDeviceName = queryObj["Name"].ToString();
                            if (foundDeviceName.Contains(deviceName)) //checks if the object that is found is a the same as the devicename that you are searching.
                            {
                                Console.WriteLine(queryObj["Name"]); //Writes the name of the device and the comport it is connected to in the consol.
                                                                     // the next code convert the the full string to only the comport.
                                foundDeviceName = foundDeviceName.TrimEnd(')');
                                string[] comport = foundDeviceName.Split('(');
                                Console.WriteLine(comport[1]);
                                string[] id = queryObj["PNPDeviceID"].ToString().Split('\\');
                                Device newDevice = new Device(counter, comport[0], comport[1], id[2]);
                                Devices.Add(newDevice); //Add comport to device list
                                counter++;
                            }
                        }
                    }
                }
                catch (ManagementException error)
                {
                    Console.WriteLine(error.Message);
                    throw new ManagementException("error", error);
                }

            }
        }
    }

