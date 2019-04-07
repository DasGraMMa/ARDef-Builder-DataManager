using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Text;

namespace ARDefBuilderDataManager.DataObjects
{
    public class SkillData
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("spCost")]
        public int SpCost { get; set; }

        [JsonProperty("cooldown", NullValueHandling = NullValueHandling.Ignore)]
        public int Cooldown { get; set; }

        [JsonProperty("range", NullValueHandling = NullValueHandling.Ignore)]
        public int Range { get; set; }

        [JsonProperty("icon", NullValueHandling = NullValueHandling.Ignore)]
        public string Icon { get; set; }

        [JsonProperty("stats", NullValueHandling = NullValueHandling.Ignore)]
        public SkillStats Stats { get; set; }

        [JsonProperty("prev")]
        public List<string> Prev { get; set; }

        [JsonProperty("last")]
        public bool? Last { get; set; }

        [JsonProperty("include", NullValueHandling = NullValueHandling.Ignore)]
        public List<SkillRestrictor> Include { get; set; }

        [JsonProperty("exclude", NullValueHandling = NullValueHandling.Ignore)]
        public List<SkillRestrictor> Exclude { get; set; }

        [JsonProperty("effect")]
        public string Effect { get; set; }
    }

    public class SkillSealData
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("icon", NullValueHandling = NullValueHandling.Ignore)]
        public string Icon { get; set; }

        [JsonProperty("stats", NullValueHandling = NullValueHandling.Ignore)]
        public SkillStats Stats { get; set; }

        [JsonProperty("include", NullValueHandling = NullValueHandling.Ignore)]
        public List<SkillRestrictor> Include { get; set; }

        [JsonProperty("exclude", NullValueHandling = NullValueHandling.Ignore)]
        public List<SkillRestrictor> Exclude { get; set; }

        [JsonProperty("effect")]
        public string Effect { get; set; }
    }

    public class SkillRestrictor
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        [JsonProperty("colorType", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public ColorType? ColorType { get; set; }

        [JsonProperty("weaponType", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public WeaponType? WeaponType { get; set; }

        [JsonProperty("moveType", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public MoveType? MoveType { get; set; }
    }

    public class SkillStats
    {
        [JsonProperty("hp", NullValueHandling = NullValueHandling.Ignore)]
        public int Hp { get; set; }

        [JsonProperty("atk", NullValueHandling = NullValueHandling.Ignore)]
        public int Atk { get; set; }

        [JsonProperty("spd", NullValueHandling = NullValueHandling.Ignore)]
        public int Spd { get; set; }

        [JsonProperty("def", NullValueHandling = NullValueHandling.Ignore)]
        public int Def { get; set; }

        [JsonProperty("res", NullValueHandling = NullValueHandling.Ignore)]
        public int Res { get; set; }
    }
}
