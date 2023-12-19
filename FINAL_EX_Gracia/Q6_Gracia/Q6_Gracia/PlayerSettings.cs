using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;


namespace Q6_Gracia
{
    internal class PlayerSettings
    {
        public string PlayerName { get; set; }
        public int Level { get; set; }
        public int Hp { get; set; }
        public string[] Inventory { get; set; }
        public string LicenseKey { get; set; }

        private static PlayerSettings instance;

        private PlayerSettings() { }

        public static PlayerSettings Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PlayerSettings();
                }
                return instance;
            }
        }

        public void LoadSettings(string filePath)
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                instance = JsonConvert.DeserializeObject<PlayerSettings>(json);
                Console.WriteLine("Settings loaded successfully.");
            }
            else
            {
                Console.WriteLine("Settings file not found. Creating new settings.");
                instance = new PlayerSettings();
            }
        }
        public static PlayerSettings DefaultSettings()
        {
            return new PlayerSettings
            {
                PlayerName = "dschuh",
                Level = 4,
                Hp = 99,
                Inventory = new string[]
                {
                "spear", "water bottle", "hammer", "sonic screwdriver", "cannonball",
                "wood", "Scooby snack", "Hydra", "poisonous potato", "dead bush", "repair powder"
                },
                LicenseKey = "DFGU99-1454"
            };
        }
        public void SaveSettings(string filePath)
        {
            string json = JsonConvert.SerializeObject(instance, Formatting.Indented);
            File.WriteAllText(filePath, json);
            Console.WriteLine("Settings saved successfully.");
        }
    }
}
