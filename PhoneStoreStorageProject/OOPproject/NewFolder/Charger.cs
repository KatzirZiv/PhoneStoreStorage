namespace OOPproject.NewFolder
{
    public class Charger : Item
    {

        private int Wattage { get; set; }
        private double Amperage { get; set; }
        public Charger(int wattage = 20, double amperage = 5.5)

        {
            Wattage = wattage;
            Amperage = amperage;
            switch (wattage)
            {
                case 15:
                    SetPrice(5.25 * 15);
                    SetId(3000 + (wattage * 5));
                    break;
                case 20:
                    SetPrice(5.32 * 20);
                    SetId(3000 + (wattage * 6));
                    break;
                case 30:
                    SetPrice(5.45 * 30);
                    SetId(3000 + (wattage * 7));

                    break;
                default:
                    break;
            }
        }

        public int GetWattage() { return Wattage; }
        public double GetAmperage() { return Amperage; }

        public void SetWattage(int wat) { Wattage = wat; }
        public void SetAmperage(double amper) { Amperage = amper; }

        public override string ToString()
        {
            return $"Charger Details, ID: {GetId()} Price: {GetPrice()} Wattage: {Wattage} Amperage: {Amperage}";
        }

    }
}
