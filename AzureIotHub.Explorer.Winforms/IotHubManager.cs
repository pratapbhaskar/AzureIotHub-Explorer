using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AzureIotHub.Explorer.Winforms;
using Microsoft.Azure.Devices;
using Microsoft.ServiceBus.Messaging;

namespace AzureIotHub.Explorer
{
    public class IotHubManager
    {
        private static IotHubManager _instance;
        private const string iotHubEndPoint = "messages/events";

        private EventHubClient _eventHubClient;
        private string _connectionString;
        private bool _initialized;
        private RegistryManager _registryManager;
        private IEnumerable<string> _partitionIds;

        private IotHubManager()
        {
        }

        public static IotHubManager Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new IotHubManager();
                return _instance;
            }
        }

        public bool HasBeenInitialized { get { return _initialized; } }

        public void Initialize(string connectionString)
        {
            _connectionString = connectionString;
            _registryManager = RegistryManager.CreateFromConnectionString(_connectionString);
            _initialized = true;
            _eventHubClient = EventHubClient.CreateFromConnectionString(_connectionString, iotHubEndPoint);
            _partitionIds = _eventHubClient.GetRuntimeInformation().PartitionIds;
        }

        internal async Task<IEnumerable<DeviceModel>> GetDevicesAsync()
        {
            var devices = await _registryManager.GetDevicesAsync(100);
            return devices.Select(a => new DeviceModel(a));
        }

        internal async Task ReceiveMessageAsync(IConsoleAdapter consoleAdapter,
            CancellationToken cts)
        {
            var tasks = new List<Task>();
            foreach (string partition in _partitionIds)
            {
                tasks.Add(ReceiveMessagesFromDeviceAsync(partition,consoleAdapter, cts));
            }
            await Task.WhenAll(tasks.ToArray());
        }

        private async Task ReceiveMessagesFromDeviceAsync(string partition, IConsoleAdapter adapter, 
            CancellationToken ct)
        {
            var eventHubReceiver = _eventHubClient.GetDefaultConsumerGroup().CreateReceiver(partition, DateTime.UtcNow);
            while (true)
            {
                if (ct.IsCancellationRequested)
                    break;
                EventData eventData = await eventHubReceiver.ReceiveAsync();
                if (eventData == null) continue;

                string data = Encoding.UTF8.GetString(eventData.GetBytes());
                adapter.WriteLine(data);
            }
        }

        internal async Task<string> GetConnectionString(string deviceId)
        {
            var device = await _registryManager.GetDeviceAsync(deviceId);
            var x = IotHubConnectionStringBuilder.Create(_connectionString);
            return string.Format("{0};DeviceId={1};SharedAccessKey={1}", x.HostName, 
                deviceId, device.Authentication.SymmetricKey.PrimaryKey);
        }
    }
}
