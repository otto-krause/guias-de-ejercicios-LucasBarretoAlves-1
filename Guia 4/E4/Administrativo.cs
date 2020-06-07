namespace E4
{
    public class Administrativo : Empleado
    {
        public Administrativo(int cajaBancaria) : base(cajaBancaria)
        {
            
        }

        public override void Deposito()
        {
            cajaBancaria += 35000;
        }
    }
}