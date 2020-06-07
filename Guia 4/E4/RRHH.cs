namespace E4
{
    public class RRHH : Empleado
    {
        int personasReferidas;
        public RRHH(int cajaBancaria) : base(cajaBancaria)
        {
            this.personasReferidas=0;
        }

        public override void Deposito()
        {
            cajaBancaria += (5000 + personasReferidas*5000); 
        }
    }
}