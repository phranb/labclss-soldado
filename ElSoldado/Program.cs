using System;

namespace ElSoldado
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Soldado miSoldado = new Soldado();
            Revolver miRevolver = new Revolver();
            Rifle miRifle = new Rifle();
            Escopeta miEscopeta = new Escopeta();
            int opcion = 0;

            Console.WriteLine(".;:👾| Iniciando programa ElSoldado |👾:;.");
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");

            do
            {
                Console.WriteLine("Ingrese el número según corresponda:");
                Console.WriteLine("'1' Para elegir arma. 🤛");
                Console.WriteLine("'2' Para soltar arma. 🤜");
                Console.WriteLine("'3' Para disparar. 😱");
                Console.WriteLine("'4' Ver arma actual. 🤔");
                Console.WriteLine("'5' Salir. 😑");
                try
                {
                    opcion = Convert.ToInt32(Console.ReadLine());
                    switch (opcion)
                    {
                        case 1:
                            int opcionArma;
                            Console.WriteLine("Elija su arma:");
                            Console.WriteLine("'1' Revolver. 😎");
                            Console.WriteLine("'2' Rifle. 🤓");
                            Console.WriteLine("'3' Escopeta. 🧐");
                            Console.WriteLine("'4' Cancelar. 😒");
                            try
                            {
                                opcionArma = Convert.ToInt32(Console.ReadLine());
                                switch (opcionArma)
                                {
                                    case 1:
                                        miSoldado.RecogerArma(miRevolver);
                                        break;
                                    case 2:
                                        miSoldado.RecogerArma(miRifle);
                                        break;
                                    case 3:
                                        miSoldado.RecogerArma(miEscopeta);
                                        break;
                                    case 4:
                                        break;
                                }
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("❌ ERROR: No se reconoce.");
                            }
                            break;
                        case 2:
                            miSoldado.DejarArma();
                            break;
                        case 3:
                            miSoldado.Gatillar();
                            break;
                        case 4:
                            miSoldado.IdentificarArma();
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("❌ ️ERROR: No se reconoce.");
                    
                }
                if (opcion != 5) continue;
                Console.WriteLine("👋 Saliendo...");
                Environment.Exit(0);
            } while (opcion != 5);
        }
    }
}