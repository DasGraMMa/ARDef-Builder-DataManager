using ARDefBuilderDataManager.DataObjects;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace ARDefBuilderDataManager
{
    public static class DataReader
    {
        public static List<HeroData> Read(string file)
        {
            Console.WriteLine($"Reading file @ {file}");

            var readHeroesDb = JsonConvert.DeserializeObject<List<HeroData>>(File.ReadAllText(file));

            Console.WriteLine($"Read heroes file: {readHeroesDb.Count} heroes found");

            return readHeroesDb;
        }
    }
}
