using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Azure.Cli.Model
{ 
    public class Extension
    {
        [JsonPropertyName("experimental")]
        public bool Experimental { get; set; }

        [JsonPropertyName("extensionType")]
        public string ExtensionType { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("path")]
        public string Path { get; set; }

        [JsonPropertyName("preview")]
        public bool Preview { get; set; }

        [JsonPropertyName("version")]
        public string Version { get; set; }
    }
}
