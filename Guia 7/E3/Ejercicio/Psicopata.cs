namespace Ejercicio
{
    public class Psicopata : Villano
    {
        protected int personasAsesinadas;
        protected int inteligencia;
        public Psicopata(int personasAsesinadas, int inteligencia)
        {
            this.personasAsesinadas = personasAsesinadas;
            this.inteligencia = inteligencia;
        }

        public override void RealizarMaldad(CiudadGotica ciudad)
        {
           5.times(ciudad.RemoveAt(0)); 
           this.personasAsesinadas += 5;
        }

        public override int Fuerza()
        {
            return inteligencia * personasAsesinadas;
        }
    }
}