using System;

namespace ElSoldado
{
    public class Rifle : Arma
    {
        public Rifle()
        {
            _nombre = "Rifle";
        }

        public override void Disparar()
        {
            Console.WriteLine("💥✨💥 Púm púm púm!... 💀️");
        }
    }
}