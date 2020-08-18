namespace Ejercicio
{
    public class Sable : Arma
    {
        public Sable(int potencia, int desgaste)
        {
            this.potencia = potencia;
            this.desgaste = desgaste;
        }

        public override int Poder()
        {
            return potencia * desgaste * 2;
        }
    }
}