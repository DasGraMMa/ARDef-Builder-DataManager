using System;
using System.Collections.Generic;
using System.Text;

namespace ARDefBuilderDataManager.DataObjects
{
    public class DataHolder
    {
        public List<HeroData> Heroes { get; set; }

        public List<SkillData> Weapons { get; set; }

        public List<SkillData> Assists { get; set; }

        public List<SkillData> Specials { get; set; }

        public List<SkillData> ASkills { get; set; }

        public List<SkillData> BSkills { get; set; }

        public List<SkillData> CSkills { get; set; }

        public List<SkillSealData> Seals { get; set; }

        public StructureData Structures { get; set; }
    }
}
