using ARDefBuilderDataManager.DataObjects;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace ARDefBuilderDataManager
{
    public static class DataReader
    {
        private static readonly Dictionary<Type, string> FILE_FOR_TYPE = new Dictionary<Type, string>()
        {
            [typeof(HeroData)] = "heroes.json"
        };

        public static List<HeroData> LoadFolder(string folder)
        {
            Console.WriteLine($"Reading folder @ {folder}");

            var readHeroesDb = LoadForType<HeroData>(folder);

            Console.WriteLine($"Read heroes file: {readHeroesDb.Count} heroes found");

            return readHeroesDb;
        }

        private static List<T> LoadForType<T>(string baseFolder)
        {
            var path = Path.Combine(baseFolder, FILE_FOR_TYPE[typeof(T)]);

            return JsonConvert.DeserializeObject<List<T>>(File.ReadAllText(path));
        }
    }
}
