using System;
using System.ComponentModel;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using SpellManager.Classes;

namespace SpellManager.Forms
{
    public partial class Element_form : Form
    {
        public Element_form()
        {
            InitializeComponent();

            this.AcceptButton = addElement;
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Program.SpellForm.Show();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            elements.Items.Clear();
            
            Ressource[] ressources = new Ressource[Program.elements.Length];
            for (int i = 0; i < ressources.Length; i++)
                ressources[i] = new Ressource(Program.elements[i]);
            
            elements.Items.AddRange(ressources);
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (elements.SelectedItem != null)
                elements.Items.RemoveAt(elements.SelectedIndex);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Program.elements = getElements();
            Program.default_element = Program.elements[0];
            
            Program.SpellForm.Reload();
            
            int length = elements.Items.Count;
            JArray toSave = new JArray();
            
            for (int i = 0; i < length; i++)
                toSave.Add(elements.Items[i].ToString());
            
            Program.UpdateElements(toSave);
        }

        private void addElement_Click(object sender, EventArgs e)
        {
            string name = nameBox.Text;
            if (name.Length < 3)
                return;

            name = name.Substring(0, 1).ToUpper() + name.Substring(1);

            for (int i = 0; i < elements.Items.Count; i++)
            {
                string el = elements.Items[i].ToString();

                int val = name.CompareTo(el);
                
                if (val == 0)
                    return;

                if (val > 0) continue;
                
                elements.Items.Insert(i, name);
                return;
            }

            elements.Items.Add(name);
        }

        private void elements_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (elements.SelectedItem != null)
                nameBox.Text = elements.SelectedItem.ToString();
        }

        private string[] getElements()
        {
            string[] array = new string[elements.Items.Count];

            for (int i = 0; i < array.Length; i++)
                array[i] = elements.Items[i].ToString();

            return array;
        }
    }
}