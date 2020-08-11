using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SpellManager
{
    public partial class Form1 : Form
    {
        private string name;
        private string element;
        private string[] classes;
        private int level,
            mana_cost,
            hp_cost,
            magical_dmg, 
            physical_dmg;
        
        public Form1()
        {
            InitializeComponent();

            elementBox.Items.AddRange(Program.elements);
            elementBox.SelectedItem = Program.default_element;
            
            Classes.Items.AddRange(Program.classes);
            
            addButton.Click += AddSpell;
        }

        private void AddSpell(object sender, EventArgs e)
        {
            name = spellNameBox.Text;

            if (name == "")
            {
                AddError("name");
                return;
            }

            name = name.Substring(0, 1).ToUpper() + name.Substring(1).ToLower();
            
            element = elementBox.Text;
            
            if (!Program.elements.Contains(element))
            {
                AddError("element");
                return;
            }
            
            classes = ToStringArray(Classes.SelectedItems);
            
            if (classes.Length == 0 || !CheckClasses())
            {
                AddError("classes");
                return;
            }
            
            level = Convert.ToInt32(levelBox.Text);
            mana_cost = Convert.ToInt32(manaCostBox.Text);
            hp_cost = Convert.ToInt32(hpCostBox.Text);
            magical_dmg = Convert.ToInt32(magicalDmgBox.Text);
            physical_dmg = Convert.ToInt32(physicalDmgBox.Text);

            for (int i = 0; i < spells.Items.Count; i++)
            {
                var spell = (Spell) spells.Items[i];

                int val = string.Compare(spell.Name, name, StringComparison.Ordinal);
                
                switch (val)
                {
                    case 0:
                        spells.Items.Remove(spell);
                        spells.Items.Insert(i,
                            new Spell(
                                name, element, classes, level, mana_cost, hp_cost, magical_dmg, physical_dmg));
                        return;
                    case int n when n > 0:
                        spells.Items.Insert(i,
                            new Spell(
                                name, element, classes, level, mana_cost, hp_cost, magical_dmg, physical_dmg));
                        return;
                }
            }
            
            spells.Items.Add(
                new Spell(name, element, classes, level, mana_cost, hp_cost, magical_dmg, physical_dmg));
            
        }

        private bool CheckClasses() 
            => classes.All(s => Program.classes.Contains(s));

        private void AddError(string e) =>
            MessageBox.Show($"{e} is not correct");

        private string[] ToStringArray(ListBox.SelectedObjectCollection collection)
        {
            string[] array = new string[collection.Count];

            for (int i = 0; i < array.Length; i++)
                array[i] = collection[i].ToString();

            return array;
        }

        private void removeButton_Click(object sender, EventArgs e) =>
            spells.Items.Remove(spells.SelectedItem);

        private void saveButton_Click(object sender, EventArgs e)
        {
            int length = spells.Items.Count;
            JObject toSave = new JObject();

            for (int i = 0; i < length; i++)
            {
                Spell spell = (Spell) spells.Items[i];
                toSave.Add(spell.Name, spell.ToJson());
            }

            SaveFileDialog choofdlog = new SaveFileDialog();
            choofdlog.Filter = "Json Files (*.json)|*.json";
            choofdlog.FilterIndex = 1;

            if (choofdlog.ShowDialog() == DialogResult.OK)    
            {     
                string sFileName = choofdlog.FileName;
                
                System.IO.File.WriteAllText(sFileName, JsonConvert.SerializeObject(toSave, Formatting.Indented));
            }
            else
            {
                MessageBox.Show("Save couldn't be done, please retry");
            }
        }
        
        private void loadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "Json Files (*.json)|*.json";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = false;

            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                string sFileName = choofdlog.FileName;

                string data = File.ReadAllText(sFileName);

                JObject sp = new JObject(JObject.Parse(data));
                
                spells.Items.Clear();

                foreach (var pair in sp)
                {
                    spells.Items.Add(new Spell(pair.Key, (JObject) pair.Value));
                }
            }
            else
            {
                MessageBox.Show("Loading couldn't be done, please retry");
            }
        }

        private void spells_SelectedIndexChanged(object sender, EventArgs e)
        {
            Spell spell = (Spell) spells.SelectedItem;
            
            if (spell == null)
                return;

            spellNameBox.Text = spell.Name;
            elementBox.Text = spell.Element;

            for (int i = 0; i < Classes.Items.Count; i++)
                Classes.SetItemChecked(i, spell.Classes.Contains(Classes.Items[i]));

            levelBox.Text = spell.Level.ToString();
            manaCostBox.Text = spell.Mana_cost.ToString();
            hpCostBox.Text = spell.Hp_cost.ToString();
            magicalDmgBox.Text = spell.Magical_dmg.ToString();
            physicalDmgBox.Text = spell.Physical_dmg.ToString();
        }
    }
}