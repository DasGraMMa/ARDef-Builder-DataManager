using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ARDefBuilderDataManager.DataObjects
{
    public class StructureData
    {
        [JsonProperty("offensive")]
        public List<Structure> Offensive { get; set; }

        [JsonProperty("defensive")]
        public List<Structure> Defensive { get; set; }

        [JsonProperty("traps")]
        public List<Structure> Traps { get; set; }

        [JsonProperty("ornaments")]
        public List<Structure> Ornaments { get; set; }

        [JsonProperty("resources")]
        public List<Structure> Resources { get; set; }
    }

    public class Structure
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("levels", NullValueHandling = NullValueHandling.Ignore)]
        public List<StructureLevel> Levels { get; set; }

        [JsonProperty("removable")]
        public bool Removable { get; set; }

        [JsonProperty("costType", NullValueHandling = NullValueHandling.Ignore)]
        public CostType? CostType { get; set; }

        [JsonProperty("exclusive", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Exclusive { get; set; }

        [JsonProperty("tierLock", NullValueHandling = NullValueHandling.Ignore)]
        public int? TierLock { get; set; }

        [JsonProperty("effect", NullValueHandling = NullValueHandling.Ignore)]
        public string Effect { get; set; }
    }

    public class StructureLevel
    {
        [JsonProperty("level")]
        public int Level { get; set; }

        [JsonProperty("cost")]
        public int Cost { get; set; }

        [JsonProperty("effect")]
        public string Effect { get; set; }
    }
}
