using GOF_Structural_Decorator.Models.Interfaces;

namespace GOF_Structural_Decorator.Models
{
    public class Soy : IBeverageDecorator
    {
        private readonly IBeverage _beverage;

        public Soy(IBeverage beverage)
        {
            Description = ", soy milk";
            _beverage = beverage;
        }
        public string Description { get; set; }
        public string GetDescription()
        {
            return _beverage.GetDescription() + Description;
        }

        public decimal Cost()
        {
            return 0.29M + _beverage.Cost();
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
