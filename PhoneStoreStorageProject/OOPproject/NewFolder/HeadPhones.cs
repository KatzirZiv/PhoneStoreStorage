using System.Drawing;
using System.Drawing.Text;
using System.Xml.Linq;

namespace OOPproject.NewFolder
{
    public class HeadPhones : ElectricItem
    {
        private string Type {  get;  set; }
        private bool HasMicrophone { get; set; }
        public HeadPhones(string color = "White", string type = "IOS", bool hasMicrophone = true) : base(0, 1000, "", "")
        {
            SetType(type);
            SetMicroPhone(hasMicrophone);
            SetColor(color);
            switch (type)
            {
                case "IOS":
                    SetPrice(159.99);
                    SetId(2067);
                    break;
                case "Android":
                    SetPrice(139.99);
                    SetId(2678);
                    break;
                default:
                    break;
            }
        }

        public string GetType()
        {
            return Type;
        }
        public bool GetMicroPhone()
        {
            return HasMicrophone;
        }
        public void SetType(string type)
        {
            Type = type;
        }
        public void SetMicroPhone(bool micro)
        {
            HasMicrophone = micro;
        }
        public override string ToString()
        {
            return $"HeadPhones Details, ID: {GetId()} Price: {GetPrice()} For: {Type} Color: {GetColor()} Microphone: {HasMicrophone}";
        }
    }
}
