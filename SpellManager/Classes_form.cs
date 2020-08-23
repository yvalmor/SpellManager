using System;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace SpellManager
{
    public partial class Classes_form : Form
    {
        public Classes_form()
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

            classes.Items.Clear();
            
            Ressource[] ressources = new Ressource[Program.classes.Length];
            for (int i = 0; i < ressources.Length; i++)
                ressources[i] = new Ressource(Program.classes[i]);
            
            classes.Items.AddRange(ressources);
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (classes.SelectedItem != null)
                classes.Items.RemoveAt(classes.SelectedIndex);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Program.classes = getElements();
            Program.default_element = Program.classes[0];
            
            Program.SpellForm.Reload();
            
            int length = classes.Items.Count;
            JArray toSave = new JArray();
            
            for (int i = 0; i < length; i++)
                toSave.Add(classes.Items[i].ToString());
            
            Program.UpdateClasses(toSave);
        }

        private void addElement_Click(object sender, EventArgs e)
        {
            string name = nameBox.Text;
            if (name.Length < 3)
                return;

            name = name.Substring(0, 1).ToUpper() + name.Substring(1);

            for (int i = 0; i < classes.Items.Count; i++)
            {
                string el = classes.Items[i].ToString();

                int val = name.CompareTo(el);
                
                if (val == 0)
                    return;

                if (val > 0) continue;
                
                classes.Items.Insert(i, name);
                return;
            }

            classes.Items.Add(name);
        }

        private void classes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (classes.SelectedItem != null)
                nameBox.Text = classes.SelectedItem.ToString();
        }

        private string[] getElements()
        {
            string[] array = new string[classes.Items.Count];

            for (int i = 0; i < array.Length; i++)
                array[i] = classes.Items[i].ToString();

            return array;
        }
    }
}