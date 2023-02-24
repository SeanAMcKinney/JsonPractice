using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace UserInterface.Models
{
    public class Cat
    {
        [JsonProperty("Id", Required = Required.Always)]
        public int Id { get; set; }

        [JsonProperty("Name", Required = Required.Always)]
        public string? Name { get; set; }

        [JsonProperty("WeightInLbs", Required = Required.Always)]
        public double WeightInLbs { get; set; }

        [JsonProperty("Color", Required = Required.Always)]
        public string? Color { get; set; }

        [JsonProperty("Gender", Required = Required.Always)]
        public string? Gender { get; set; }

        [JsonProperty("GoesOutDoors", Required = Required.Default)]
        public bool GoesOutDoors { get; set; }
    }
}
