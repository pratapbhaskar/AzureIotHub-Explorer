using Microsoft.Azure.Devices;

namespace AzureIotHub.Explorer
{
    public class DeviceModel
    {
        public DeviceModel(Device device)
        {
            this.Id = device.Id;
            Status = device.Status.ToString();
            LastActivityTime = device.LastActivityTime.ToString();
            CToDMessageCount = device.CloudToDeviceMessageCount;
            ConnectionState = device.ConnectionState.ToString();
        }

        public string Id { get; set; }
        public string Status { get; set; }
        public string LastActivityTime { get; set; }
        public int CToDMessageCount { get; set; }
        public string ConnectionState { get; set; }
    }
}
