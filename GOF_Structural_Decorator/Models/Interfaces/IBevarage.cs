using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_Structural_Decorator.Models.Interfaces
{
    public interface IBeverage 
    {
        string GetDescription();
        decimal Cost();
        int GetCupSize();
        void SetCupSize(int cupSize);

    }
}
