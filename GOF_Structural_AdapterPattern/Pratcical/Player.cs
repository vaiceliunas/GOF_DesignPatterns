using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_Structural_AdapterPattern.Pratcical
{
    public class Player : IPlayer
    {
        public int HeightInCm { get; set; }
        public int WeightInKg { get; set; }
        public void DoPresentation()
        {
            Console.WriteLine("Weight: " + WeightInKg + ", height: " + HeightInCm);
        }

        public static IPlayer CreateInstance(int height, int weight)
        {
            return new Player() {WeightInKg = weight, HeightInCm = height};
        }
    }
}
