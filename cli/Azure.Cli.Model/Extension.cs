﻿using System;
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

    public class CloudConfig
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("source")]
        public string Source { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }
    }

    public class CoreConfig
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("source")]
        public string Source { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }
    }

    public class ExtensionConfig
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("source")]
        public string Source { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }
    }

    public class Config
    {
        [JsonPropertyName("cloud")]
        public List<CloudConfig> Cloud { get; set; }

        [JsonPropertyName("core")]
        public List<CoreConfig> Core { get; set; }

        [JsonPropertyName("extension")]
        public List<ExtensionConfig> Extension { get; set; }
    }
}
