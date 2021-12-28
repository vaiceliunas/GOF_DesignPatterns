using System;
using GOF_Structural_Template.Models;

namespace GOF_Structural_Template
{
    class Program
    {
        static void Main(string[] args)
        {
            var tea = new Tea();
            tea.PrepareRecipe();

            Console.ReadLine();
        }
    }
}
