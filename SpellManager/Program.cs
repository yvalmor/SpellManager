using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SpellManager.Forms;

// ReSharper disable CoVariantArrayConversion

namespace SpellManager
{
    static class Program
    {
        public static string[] elements;
        public static string[] classes;

        public static string default_element,
            default_class;

        public static Spell_form SpellForm;
        public static Element_form ElementForm;
        public static Classes_form ClassesForm;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Load();
            
            SpellForm = new Spell_form();
            
            Application.Run(SpellForm);
        }

        private static void Load()
        {
            string JsonString = File.ReadAllText("ressources.json");
            var Ressources = JObject.Parse(JsonString);

            List<string> elementList = Ressources.SelectToken("elements").Values<string>().ToList();
            List<string> classesList = Ressources.SelectToken("classes").Values<string>().ToList();

            elementList.Sort();
            classesList.Sort();

            elements = elementList?.ToArray();
            classes = classesList?.ToArray();

            elementList = null;
            classesList = null;

            default_element = elements?[0];
            default_class = classes?[0];
        }

        public static void UpdateClasses(JArray jClasses)
        {
            JArray jElements = new JArray(elements);
            
            JObject toSave = new JObject();
            
            toSave.Add("classes", jClasses);
            toSave.Add("elements", jElements);
            
            UpdateRessources(toSave);
        }

        public static void UpdateElements(JArray jElements)
        {
            JArray jClasses = new JArray(classes);
            
            JObject toSave = new JObject();
            
            toSave.Add("classes", jClasses);
            toSave.Add("elements", jElements);
            
            UpdateRessources(toSave);
        }
        
        private static void UpdateRessources(JObject toSave) =>
            File.WriteAllText(
                "ressources.json", JsonConvert.SerializeObject(toSave, Formatting.Indented));
    }
}