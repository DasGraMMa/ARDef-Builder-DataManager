using ARDefBuilderDataManager.DataObjects;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;

namespace ARDefBuilderDataManager
{
    public static class DataReader
    {
        public static DataHolder LoadFolder(string folder)
        {
            Logger.Info($"Reading folder @ {folder}");

            // Loading is ugly, but it works.
            var holder = new DataHolder
            {
                Heroes = Deserialize<ObservableCollection<HeroData>>(LoadType.Heroes.GetFilePath(folder)),
                Weapons = Deserialize<ObservableCollection<SkillData>>(LoadType.Weapons.GetFilePath(folder)),
                Assists = Deserialize<ObservableCollection<SkillData>>(LoadType.Assists.GetFilePath(folder)),
                Specials = Deserialize<ObservableCollection<SkillData>>(LoadType.Specials.GetFilePath(folder)),
                ASkills = Deserialize<ObservableCollection<SkillData>>(LoadType.ASkills.GetFilePath(folder)),
                BSkills = Deserialize<ObservableCollection<SkillData>>(LoadType.BSkills.GetFilePath(folder)),
                CSkills = Deserialize<ObservableCollection<SkillData>>(LoadType.CSkills.GetFilePath(folder)),
                Seals = Deserialize<ObservableCollection<SkillSealData>>(LoadType.Seals.GetFilePath(folder)),
                Structures = Deserialize<StructureData>(LoadType.Structures.GetFilePath(folder))
            };

            Logger.Info($"Loaded each file and created data holder.");

            return holder;
        }

        private static T Deserialize<T>(string file)
        {
            return JsonConvert.DeserializeObject<T>(File.ReadAllText(file));
        }
    }

    enum LoadType
    {
        Heroes,
        Weapons,
        Assists,
        Specials,
        ASkills,
        BSkills,
        CSkills,
        Seals,
        Structures
    }

    static class LoadTypeExtensions
    {
        public static string GetFileName(this LoadType type)
        {
            switch(type)
            {
            case LoadType.Heroes:
                return "heroes.json";

            case LoadType.Weapons:
                return "skills.weapons.json";

            case LoadType.Assists:
                return "skills.assists.json";

            case LoadType.Specials:
                return "skills.specials.json";

            case LoadType.ASkills:
                return "skills.aSkills.json";

            case LoadType.BSkills:
                return "skills.bSkills.json";

            case LoadType.CSkills:
                return "skills.cSkills.json";

            case LoadType.Seals:
                return "skills.seals.json";

            case LoadType.Structures:
                return "structures.json";
            }

            Logger.Error($"This shouldn't have happened - {type} has no file name attached.");

            return null;
        }

        public static string GetFilePath(this LoadType type, string baseFolder)
        {
            return Path.Combine(baseFolder, type.GetFileName());
        }
    }
}
