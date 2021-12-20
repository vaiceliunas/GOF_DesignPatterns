using System;
using GOF_Structural_Decorator.Models.Interfaces;

namespace GOF_Structural_Decorator.Models
{
    public class SteamedMilk : IBeverageDecorator
    {
        private IBeverage _beverage;
        public SteamedMilk(IBeverage beverage)
        {
            _beverage = beverage;
        }

        public string GetDescription()
        {
            return _beverage.GetDescription();
        }

        public decimal Cost()
        {
            return 0.59M + _beverage.Cost();
        }

        public int GetCupSize()
        {
            return _beverage.GetCupSize();
        }

        public void SetCupSize(int cupSize)
        {
            _beverage.SetCupSize(cupSize);
        }
    }
}
