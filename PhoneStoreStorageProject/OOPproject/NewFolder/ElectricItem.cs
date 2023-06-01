
namespace OOPproject.NewFolder
{
    public class ElectricItem : Item
    {
        private string Name { get; set; }
        private string Color { get; set; }

        protected ElectricItem(double newPrice, int newId, string newName, string newColor)
            : base(newPrice, newId)
        {
            GetPrice();
            GetId();
            Color = newColor;
            Name = newName;
        }

        public string GetName()
        {
            return this.Name;
        }
        public string GetColor()
        {
            return this.Color;
        }
        public void SetName(string name)
        {
            Name = name;
        }
        public void SetColor(string color)
        {
            Color = color;
        }
    }
}


