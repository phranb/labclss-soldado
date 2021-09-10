namespace ElSoldado
{
    public abstract class Arma
    {
        protected string _nombre;

        public abstract void Disparar();

        public string GetNombre()
        {
            return _nombre;
        }

    }
}