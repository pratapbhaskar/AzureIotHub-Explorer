using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AzureIotHub.Explorer.Winforms
{
    internal class AzureConnections
    {
        private const string fileName = "azureconnectionstrings.json";
        public IDictionary<string, string> dictionary = new Dictionary<string, string>();

        public List<string> GetKeys()
        {
            return dictionary.Keys.ToList();
        }

        public string GetConnectionStringForHostName(string hostName)
        {
            return dictionary[hostName];
        }

        public AzureConnections()
        {
            if (!File.Exists(fileName))
            {
                var file = File.Create(fileName);
                file.Close();
            }

            string readAllFromFile = File.ReadAllText(fileName);
            try
            {
                dictionary = JsonConvert.DeserializeObject<IDictionary<string, string>>(readAllFromFile);

            }
            catch (Exception ex)
            {
                //Gobble up
            }
            if (dictionary == null)
                dictionary = new Dictionary<string, string>();
        }

        public void AddConnectionString(string hostName, string connectionString)
        {
            if (!dictionary.ContainsKey(hostName))
                dictionary.Add(hostName, string.Empty);

            dictionary[hostName] = connectionString;
            File.WriteAllText(fileName, JsonConvert.SerializeObject(dictionary));
        }
    }
}
