using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using FizzWare.NBuilder;
using Newtonsoft.Json;
using WebApi.Models;

public static class JsonHelper
{
    public static void ExecOnStartup()
    {
        //Comment this line bellow to exec anything on statup
        return;
        
        CreateJsonFiles();
    }

    public static void CreateJsonFiles()
    {
        var smallJson = GenerateSerializedFooList(3, 2);
        var bigJson = GenerateSerializedFooList(5000, 50);
        var hugeJson = GenerateSerializedFooList(50000, 100);

        File.WriteAllText(@"Container\smallFooData.json", smallJson);
        File.WriteAllText(@"Container\bigFooData.json", bigJson);
        File.WriteAllText(@"Container\hugeFooData.json", hugeJson);
    }

    public static IEnumerable<FooItem> GenerateFooList(int listSize = 100, int subListsSize = 100)
    {
        Random rdn = new Random();

        return Builder<FooItem>.CreateListOfSize(listSize)
            .All()
            .Do(x => 
            {
                var rndInt = rdn.Next(0, subListsSize);
                if (rndInt == 0) return;
                x.FooSubItems = Builder<FooSubItem>.CreateListOfSize(rndInt).Build();
            })
            .Build();
    }

    public static string GenerateSerializedFooList(int listSize = 100, int subListsSize = 100)
    {
        return JsonConvert.SerializeObject(GenerateFooList(listSize, subListsSize));
    }
}