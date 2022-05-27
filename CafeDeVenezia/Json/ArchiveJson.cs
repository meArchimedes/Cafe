using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace CafeDeVenezia.Json
{
    internal class ArchiveJson: Archive
    {
        public string Path { get; set; }
        public List<ArchivedInfo> JsonObjectsList { get; set; }
        public ArchiveJson(string path = "H:\\Design Patterns\\orders.json")
        {
            Path = path;
        }
        public List<ArchivedInfo> ImportData()
        {
            string json = File.ReadAllText(Path);
            JsonObjectsList = JsonSerializer.Deserialize<List<ArchivedInfo>>(json)!;
            return JsonObjectsList;
        }
      

        public void Save(ArchivedInfo data)
        {
            if (JsonObjectsList == null)
            {
                JsonObjectsList = new();
            }
            JsonObjectsList = ImportData();
            JsonObjectsList.Add(data);
            var opt = new JsonSerializerOptions() { WriteIndented = true };
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            string jsonString = JsonSerializer.Serialize(JsonObjectsList, JsonObjectsList.GetType(), options);
            jsonString = JsonSerializer.Serialize(JsonObjectsList, opt);
            File.WriteAllText(Path, jsonString);
        }
    }
}
