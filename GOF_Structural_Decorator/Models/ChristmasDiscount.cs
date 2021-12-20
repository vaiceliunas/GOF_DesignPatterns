using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_Structural_Decorator.Models.Interfaces
{
    class ChristmasDiscount : IBeverageDecorator
    {
        private IBeverage _beverage;

        public ChristmasDiscount(IBeverage beverage)
        {
            _beverage = beverage;
        }
        public string Description { get; set; }
        public string GetDescription()
        {
            return _beverage.GetDescription() + ", with christmas discount";
        }

        public decimal Cost()
        {
            return Math.Round(_beverage.Cost() * 0.8M, 2);
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
