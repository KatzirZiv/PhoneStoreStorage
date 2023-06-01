namespace OOPproject.NewFolder
{
    public class PhoneCase : Item
    {
        private string Color { get; set; }
        private string PhoneBrand { get; set; }
        public PhoneCase(string color = "White", string phoneBrand = "IOS")
        {
            SetColor(color);
            SetPhoneBrand(phoneBrand);
            switch (phoneBrand)
            {
                case "IOS":
                    SetPrice (127.55);
                    SetId (4069);
                    break;
                case "Android":
                    SetPrice(115.25);
                    SetId(489);
                    break;
                default:
                    break;
            }
        }
        public string GetColor() { return Color; }
        public string GetPhoneBrand() { return PhoneBrand; }

        public void SetColor(string color) { Color = color; }
        public void SetPhoneBrand(string phonebrand) { PhoneBrand = phonebrand; }

        public override string ToString()
        {
            return $"Case Details, ID: {GetId()} Price: {GetPrice()} Color: {Color} For: {PhoneBrand}";
        }
    }
}
