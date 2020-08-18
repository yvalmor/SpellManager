using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SpellManager.Classes;
using SpellManager.Properties;

// ReSharper disable CoVariantArrayConversion

namespace SpellManager.Forms
{
    public partial class Spell_form : Form
    {
        private string name;
        private string element;
        private string[] classes;
        private int level,
            mana_cost,
            hp_cost,
            magical_dmg, 
            physical_dmg;
        
        public Spell_form()
        {
            InitializeComponent();

            this.AcceptButton = addButton;

            elementBox.Items.AddRange(Program.elements);
            elementBox.SelectedItem = Program.default_element;
            
            Classes.Items.AddRange(Program.classes);
            
            addButton.Click += AddSpell;
        }

        public void Reload()
        {
            elementBox.Items.Clear();
            elementBox.Items.AddRange(Program.elements);
            elementBox.SelectedItem = Program.default_element;

            Classes.Items.Clear();
            Classes.Items.AddRange(Program.classes);
        }

        private void AddSpell(object sender, EventArgs e)
        {
            name = spellNameBox.Text;

            if (name == "")
            {
                AddError("Le nom");
                return;
            }

            name = name.Substring(0, 1).ToUpper() + name.Substring(1).ToLower();
            
            element = elementBox.Text;
            
            if (!Program.elements.Contains(element))
            {
                AddError("L'élément");
                return;
            }
            
            classes = ToStringArray(Classes.SelectedItems);
            
            if (classes.Length == 0 || !CheckClasses())
            {
                AddError("Les classes");
                return;
            }
            
            errorLabel.Visible = false;
            
            level = Convert.ToInt32(levelBox.Text);
            mana_cost = Convert.ToInt32(manaCostBox.Text);
            hp_cost = Convert.ToInt32(hpCostBox.Text);
            magical_dmg = Convert.ToInt32(magicalDmgBox.Text);
            physical_dmg = Convert.ToInt32(physicalDmgBox.Text);

            for (int i = 0; i < spells.Items.Count; i++)
            {
                var spell = (Spell) spells.Items[i];

                int val = string.Compare(spell.Name, name, StringComparison.Ordinal);

                if (val == 0)
                {
                    spells.Items.Remove(spell);
                    spells.Items.Insert(i,
                        new Spell(
                            name, element, classes, level, mana_cost, hp_cost, magical_dmg, physical_dmg));
                    return;
                }
                if (val > 0)
                {
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

        private void AddError(string e)
        {
            errorLabel.Text = string.Format(
                e != "Les classes" ? Resources.spell_error : Resources.spell_classes_error, e)
                .ToUpper();
            errorLabel.Visible = true;
        }

        private string[] ToStringArray(ListBox.SelectedObjectCollection collection)
        {
            string[] array = new string[collection.Count];

            for (int i = 0; i < array.Length; i++)
                array[i] = collection[i].ToString();

            return array;
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
            spells.Items.Remove(spells.SelectedItem);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            int length = spells.Items.Count;
            JObject toSave = new JObject();

            for (int i = 0; i < length; i++)
            {
                Spell spell = (Spell) spells.Items[i];
                toSave.Add(spell.Name, spell.ToJson());
            }

            SaveFileDialog choofdlog = new SaveFileDialog {Filter = Resources.file_filter, FilterIndex = 1};

            if (choofdlog.ShowDialog() == DialogResult.OK)    
            {     
                string sFileName = choofdlog.FileName;
                
                File.WriteAllText(sFileName, JsonConvert.SerializeObject(toSave, Formatting.Indented));
            }
            else
            {
                MessageBox.Show(Resources.save_error);
            }
        }
        
        private void loadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog
            {
                Filter = Resources.file_filter, FilterIndex = 1, Multiselect = false
            };

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
                MessageBox.Show(Resources.load_error);
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

        private void élémentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Element_form().Show();
        }

        private void classesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Classes_form().Show();
        }
    }
}