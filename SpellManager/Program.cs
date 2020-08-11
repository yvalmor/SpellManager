using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace SpellManager
{
    static class Program
    {
        public static string[] elements;
        public static string[] classes;

        public static string default_element,
            default_class;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Load();
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        private static void Load()
        {
            string JsonString = File.ReadAllText("../../ressources.json");
            var Ressources = JObject.Parse(JsonString);

            List<string> elementList = Ressources.SelectToken("elements")?.Values<string>().ToList();
            List<string> classesList = Ressources.SelectToken("classes")?.Values<string>().ToList();

            elementList.Sort();
            classesList.Sort();

            elements = elementList.ToArray();
            classes = classesList.ToArray();

            elementList = null;
            classesList = null;

            default_element = elements?[0];
            default_class = classes?[0];
        }
    }
}