using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Text;

namespace ARDefBuilderDataManager.DataObjects
{
    /// <summary>
    /// Represents the basic data for any hero.
    /// </summary>
    public class HeroData
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("shortName", NullValueHandling = NullValueHandling.Ignore)]
        public string ShortName { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("releaseDate")]
        public string ReleaseDate { get; set; }

        [JsonProperty("colorType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ColorType ColorType { get; set; }

        [JsonProperty("weaponType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public WeaponType WeaponType { get; set; }

        [JsonProperty("moveType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public MoveType MoveType { get; set; }

        [JsonProperty("skills")]
        public List<HeroDataSkill> Skills { get; set; }

        [JsonProperty("stats")]
        public HeroDataStats Stats { get; set; }

        [JsonProperty("limited", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Limited { get; set; }

        [JsonProperty("ttReward", NullValueHandling = NullValueHandling.Ignore)]
        public bool? TtReward { get; set; }

        [JsonProperty("ghb", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ghb { get; set; }
    }

    /// <summary>
    /// Represents a skill for a hero's data.
    /// </summary>
    public class HeroDataSkill
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("rarity")]
        public int Rarity { get; set; }
    }

    /// <summary>
    /// Represents the different stats available for a hero.
    /// </summary>
    public class HeroDataStats
    {
        [JsonProperty("level1")]
        public HeroDataLvl1Stats Level1 { get; set; }

        [JsonProperty("level40")]
        public HeroDataLvl40Stats Level40 { get; set; }

        [JsonProperty("level1_4", NullValueHandling = NullValueHandling.Ignore)]
        public HeroDataLvl1Stats Level1_4 { get; set; }

        [JsonProperty("level40_4", NullValueHandling = NullValueHandling.Ignore)]
        public HeroDataLvl40Stats Level40_4 { get; set; }
    }

    public class HeroDataLvl1Stats
    {
        [JsonProperty("hp")]
        public int Hp { get; set; }

        [JsonProperty("atk")]
        public int Atk { get; set; }

        [JsonProperty("spd")]
        public int Spd { get; set; }

        [JsonProperty("def")]
        public int Def { get; set; }

        [JsonProperty("res")]
        public int Res { get; set; }
    }

    public class HeroDataLvl40Stats
    {
        [JsonProperty("hp")]
        public int[] Hp { get; set; }

        [JsonProperty("atk")]
        public int[] Atk { get; set; }

        [JsonProperty("spd")]
        public int[] Spd { get; set; }

        [JsonProperty("def")]
        public int[] Def { get; set; }

        [JsonProperty("res")]
        public int[] Res { get; set; }
    }
}
