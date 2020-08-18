namespace SpellManager.Classes
{
    public class Ressource
    {
        public string Name;

        public Ressource(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}