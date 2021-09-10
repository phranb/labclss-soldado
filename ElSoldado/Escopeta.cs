using System;

namespace ElSoldado
{
    public class Escopeta : Arma
    {
        public Escopeta()
        {
            _nombre = "Escopeta";
        }

        public override void Disparar()
        {
            Console.WriteLine("💥💥💥 ¡Pááá!... 💀");
        }
    }
}