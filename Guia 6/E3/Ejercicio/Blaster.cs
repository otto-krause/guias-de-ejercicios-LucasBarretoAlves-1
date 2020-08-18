namespace Ejercicio
{
    public class Blaster : Arma
    {
        public Blaster(int potencia, int desgaste)
        {
            this.potencia = potencia;
            this.desgaste = desgaste;
        }

        public override int Poder()
        {
            return potencia > desgaste ? potencia-desgaste : 1;
        }
    }
}