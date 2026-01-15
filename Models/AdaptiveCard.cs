using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using AdaptiveCards;
using Newtonsoft.Json;
using TokenFlow_API_MS.Services;

// 
namespace TokenFlow_API_MS.Models
{
    public class AdaptiveCard
    {
        [JsonPropertyName("type")]
        public string Type { get; set; } = "AdaptiveCard";

        [JsonPropertyName("version")]
        public string version { get; set; } = "v.1.0";





    }
}