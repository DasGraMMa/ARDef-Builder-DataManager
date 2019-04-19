using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ARDefBuilderDataManager.DataObjects
{
    public class DataHolder
    {
        public ObservableCollection<HeroData> Heroes { get; set; } = new ObservableCollection<HeroData>();

        public ObservableCollection<SkillData> Weapons { get; set; } = new ObservableCollection<SkillData>();

        public ObservableCollection<SkillData> Assists { get; set; } = new ObservableCollection<SkillData>();

        public ObservableCollection<SkillData> Specials { get; set; } = new ObservableCollection<SkillData>();

        public ObservableCollection<SkillData> ASkills { get; set; } = new ObservableCollection<SkillData>();

        public ObservableCollection<SkillData> BSkills { get; set; } = new ObservableCollection<SkillData>();

        public ObservableCollection<SkillData> CSkills { get; set; } = new ObservableCollection<SkillData>();

        public ObservableCollection<SkillSealData> Seals { get; set; } = new ObservableCollection<SkillSealData>();

        public StructureData Structures { get; set; } = new StructureData();
    }
}
