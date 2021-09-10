using System;

namespace ElSoldado
{
    public class Soldado
    {
        private Arma _arma;
        private int _mano;

        public Soldado()
        {
            _mano = 0;
        }

        public void RecogerArma(Arma arma)
        {
            if (_mano == 0)
            { 
                Console.WriteLine("Arma en mano! 🤩");
                Console.WriteLine(arma.GetNombre());
                _arma = arma;
                _mano = 1;
            }
            else
            {
                Console.WriteLine("El soldado ya tiene un arma en mano: " + _arma.GetNombre());
                Console.WriteLine("Primero debe dejarla. 😠");
            }
        }

        public void DejarArma()
        {
            if (_mano == 1)
            {
                Console.WriteLine("🥱 Se soltó el arma: " + _arma.GetNombre());
                _mano = 0;
            }
            else
            {
                Console.WriteLine("😡 No hay nada para soltar.");
            }
        }

        public void Gatillar()
        {
            if (_mano == 0)
            {
                Console.WriteLine("🤬 No hay nada que disparar!!");
            }
            else
            {
                Console.WriteLine("👉 Se disparó: " + _arma.GetNombre() + "!!!");
                _arma.Disparar();
            }
        }

        public void IdentificarArma()
        {
            if (_mano == 0)
            {
                Console.WriteLine("🤯 El soldado no tiene arma equipada.");
            }
            else
            {
                Console.WriteLine("👀 Arma actual: ");
                Console.WriteLine(_arma.GetNombre());
            }
        }
        
    }
}