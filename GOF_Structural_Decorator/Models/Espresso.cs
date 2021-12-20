using GOF_Structural_Decorator.Models.Interfaces;

namespace GOF_Structural_Decorator.Models
{
    class Espresso : IBeverage
    {
        public string Description { get; set; }
        private int CupSize { get; set; }

        public Espresso()
        {
            CupSize = 1;
            Description = "Good quality Espresso";
        }
        public string GetDescription()
        {
            return Description;
        }

        public decimal Cost()
        {
            return 1.99M + (CupSize * 0.05M);
        }

        public int GetCupSize()
        {
            return CupSize;
        }

        public void SetCupSize(int cupSize)
        {
            CupSize = cupSize;
        }
    }
}
