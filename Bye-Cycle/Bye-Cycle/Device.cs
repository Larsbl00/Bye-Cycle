using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bye_Cycle
{
    public class Device
    {
        public int Id { get; private set; }
        public string DeviceId { get; private set; }
        public string Name { get; private set; }
        public string Port { get; private set; }
        public Device(int id, string name)
        {
            if (id < 0)
            {
                throw new ArgumentOutOfRangeException("Id", "Id is smaler then zero");
            }
            if (name == null)
            {
                throw new ArgumentNullException("name", "Name is null");
            }
            if (name == "")
            {
                throw new ArgumentOutOfRangeException("name", "Name is empty");
            }
            Id = id;
            Name = name;
        }
        public Device(int id, string name, string deviceId) : this(id, name)
        {
            if (deviceId == null)
            {
                throw new ArgumentNullException("deviceId", "DeviceId is null");
            }
            if (deviceId == "")
            {
                throw new ArgumentOutOfRangeException("deviceId", "DeviceId is empty");
            }
            DeviceId = deviceId;
        }
        public Device(int id, string name, string deviceId, string port) : this(id, name, deviceId)
        {
            if (port == null)
            {
                throw new ArgumentNullException("port", "Port is null");
            }
            if (port == "")
            {
                throw new ArgumentOutOfRangeException("port", "Port is empty");
            }
            Port = port;
        }

        public override string ToString()
        {
            return String.Format("ID: {0}, Name: {1}, Port: {2}, DeviceId: {3}", Id, Name, Port, DeviceId);
        }
    }
}
