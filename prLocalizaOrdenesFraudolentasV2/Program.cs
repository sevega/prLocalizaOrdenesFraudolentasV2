using System;

namespace prLocalizaOrdenesFraudolentasV2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ordenesId = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };
            foreach (string ordenId in ordenesId)
            {
                if (ordenId.StartsWith("B"))
                {
                    Console.WriteLine($"Ordenes que inician con B {ordenId}");
                }
            }
        }
    }
}
