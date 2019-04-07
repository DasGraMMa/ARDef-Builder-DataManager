using ARDefBuilderDataManager.DataObjects;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace ARDefBuilderDataManager
{
    public static class DataReader
    {
        private static readonly Dictionary<LoadType, string> FILE_FOR_TYPE = new Dictionary<LoadType, string>()
        {
            [LoadType.Heroes] = "heroes.json",
            [LoadType.Weapons] = "skills.weapons.json",
            [LoadType.Assists] = "skills.assists.json",
            [LoadType.Specials] = "skills.specials.json",
            [LoadType.ASkills] = "skills.aSkills.json",
            [LoadType.BSkills] = "skills.bSkills.json",
            [LoadType.CSkills] = "skills.cSkills.json",
            [LoadType.Seals] = "skills.seals.json",
            [LoadType.Structures] = "structures.json"
        };

        public static DataHolder LoadFolder(string folder)
        {
            Console.WriteLine($"Reading folder @ {folder}");

            var holder = new DataHolder();
            
            // TODO: Load files.
            
            return holder;
        }

        private static List<T> LoadForType<T>(string baseFolder, LoadType type)
        {
            var path = Path.Combine(baseFolder, FILE_FOR_TYPE[type]);

            return JsonConvert.DeserializeObject<List<T>>(File.ReadAllText(path));
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
}
