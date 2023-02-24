using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema.Generation;
using System;
using UserInterface.Models;

namespace UserInterface
{
    public class GenerateSchema
    {
        public static void Show()
        {
            Console.Clear();
            Console.WriteLine("*** Json.NET Create Schema Automatically ***");

            //Parse the Json text
            string singleCat = File.ReadAllText("CatSingle.json");
            JObject cat = JObject.Parse(singleCat);

            //Generate the Schema
            JSchemaGenerator? genCatSchema = new JSchemaGenerator();
            JSchema generatedSchema = genCatSchema.Generate(typeof(Cat));
            Console.WriteLine(generatedSchema.ToString());

            //Check the Schema
            bool validateGenerated = cat.IsValid(generatedSchema);
            Console.WriteLine("Cat is valid: " + validateGenerated);

        }
    }
}
