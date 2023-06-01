using System;

namespace OOPproject.NewFolder
{
    abstract public class Item
    {
        private double Price { get; set; }
        private int Id { get; set; }

        protected Item()
        {
        }
        protected Item(double newPrice, int newId)
        {
            Price = newPrice;
            Id = newId;
        }
        public double GetPrice()
        {
            return Price;
        }
        public void SetPrice(double newPrice)
        {
            Price = newPrice;
        }
        public int GetId()
        {
            return Id;
        }
        public void SetId(int newId)
        {
                Id = newId;
        }
    }
}


