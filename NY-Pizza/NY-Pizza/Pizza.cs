using System;

namespace NY_Pizza
{
    internal class Pizza
    {
        private string pizzaName;
        private double totalPrice;

        public Pizza(string pizzaName, double totalPrice)
        {
            this.pizzaName = pizzaName;
            this.totalPrice = totalPrice;
        }

        internal double GetPrice(int controlNum)
        {
            throw new NotImplementedException();
        }

        internal object GetName()
        {
            throw new NotImplementedException();
        }
    }
}