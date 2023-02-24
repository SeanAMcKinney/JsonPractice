using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Schema.Generation;
namespace UserInterface
{
    public class ManualSchemaCreation
    {
        public static void Show()
        {
            Console.Clear();
            Console.WriteLine("*** Json.NET Create Schema Manually ***");

            //Parse the Json text
            string singleCat = File.ReadAllText("CatSingle.json");
            JObject cat = JObject.Parse(singleCat);

            // Generate the Schema
            JSchema manualSchema = ManuallyCreatedSchema();
            Console.WriteLine(manualSchema.ToString());

            //Check the Schema
            IList<string> whyNotValid;
            bool validateMaual = cat.IsValid(manualSchema, out whyNotValid);
            Console.WriteLine("Cat is valid: " + validateMaual);
        }

        private static JSchema ManuallyCreatedSchema()
        {
            Console.WriteLine("- Manually generate schema");

            JSchema schema = new JSchema
            {
                Type = JSchemaType.Object,
                Properties =
                {
                    { "Id", new JSchema { Type = JSchemaType.Integer } },
                    { "Name", new JSchema { Type = JSchemaType.String } },
                    { "WeightInLbs", new JSchema { Type = JSchemaType.Number } },
                    { "Color", new JSchema{ Type = JSchemaType.String } },
                    { "Gender", new JSchema { Type = JSchemaType.String } },
                    { "GoesOutDoors", new JSchema { Type = JSchemaType.Boolean} },
                }
            };

            return schema;
        }
    }
}
