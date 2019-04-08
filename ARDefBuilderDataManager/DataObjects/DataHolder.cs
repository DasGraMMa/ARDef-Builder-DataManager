using System;
using System.Collections.Generic;
using System.Text;

namespace ARDefBuilderDataManager.DataObjects
{
    public class DataHolder
    {
        public List<HeroData> Heroes { get; set; } = new List<HeroData>();

        public List<SkillData> Weapons { get; set; } = new List<SkillData>();

        public List<SkillData> Assists { get; set; } = new List<SkillData>();

        public List<SkillData> Specials { get; set; } = new List<SkillData>();

        public List<SkillData> ASkills { get; set; } = new List<SkillData>();

        public List<SkillData> BSkills { get; set; } = new List<SkillData>();

        public List<SkillData> CSkills { get; set; } = new List<SkillData>();

        public List<SkillSealData> Seals { get; set; } = new List<SkillSealData>();

        public StructureData Structures { get; set; } = new StructureData();
    }
}
