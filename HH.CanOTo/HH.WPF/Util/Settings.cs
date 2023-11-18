using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HH.WPF.Util
{
    public class Settings
    {
        public static int DiffWeight { get; set; } = 0;
        public static int MaxDiffWeight { get; set; } = 1000;

        public static void LoadSettings()
        {
            try
            {
                string jsonFilePath = "Resources/settings.json"; // Replace with your JSON file path
                if (File.Exists(jsonFilePath))
                {
                    string jsonContent = File.ReadAllText(jsonFilePath);

                    // Deserialize JSON content and map it to the Settings class
                    dynamic settings = JsonConvert.DeserializeObject<Settings>(jsonContent);
                    Settings.DiffWeight = settings.DiffWeight;
                    Settings.MaxDiffWeight = settings.MaxDiffWeight;
                }
                else
                {
                    // Handle if the JSON file doesn't exist
                    MessageBox.Show("Json file doesn't exist!");
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions while reading or deserializing JSON
                MessageBox.Show("reading or deserializing JSON fail!");
            }
        }
    }
}
