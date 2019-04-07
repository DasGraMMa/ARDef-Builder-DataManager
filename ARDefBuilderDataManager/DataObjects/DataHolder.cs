using System;
using System.Collections.Generic;
using System.Text;

namespace ARDefBuilderDataManager.DataObjects
{
    public class DataHolder
    {
        public List<HeroData> Heroes { get; set; }

        public List<SkillsData> Weapons { get; set; }

        public List<SkillsData> Assists { get; set; }

        public List<SkillsData> Specials { get; set; }

        public List<SkillsData> ASkills { get; set; }

        public List<SkillsData> BSkills { get; set; }

        public List<SkillsData> CSkills { get; set; }

        public List<SkillsSealsData> Seals { get; set; }
    }
}
