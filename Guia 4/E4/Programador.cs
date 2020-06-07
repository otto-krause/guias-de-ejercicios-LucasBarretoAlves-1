namespace E4
{
    public class Programador : Empleado
    {
        string titulo;
        int bono;
        public Programador(int cajaBancaria, string titulo) : base(cajaBancaria)
        {
            this.titulo=titulo;
            switch (titulo)
            {
                case "junior":
                    this.bono=10000;
                    break;
                case "semiSenior":
                    this.bono=20000;
                    break;
                case "senior":
                    this.bono=40000;
                    break;
            }
        }

        public override void Deposito()
        {
            cajaBancaria += (20000 + bono);
        }
    }
}