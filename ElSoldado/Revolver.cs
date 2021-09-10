using System;

namespace ElSoldado
{
    public class Revolver : Arma
    {
        public Revolver()
        {
            _nombre = "Revolver";
        }

        public override void Disparar()
        {
            Console.WriteLine("💥💀 Púm...");
        }
    }
}