namespace Ejercicio
{
    public class Batman
    {
        protected List<Tecnología> batiriñonera;
        protected int vitalidad;
        protected int estres;

        public Batman(List<Tecnología> batiriñonera)
        {
            this.batiriñonera = batiriñonera;
            this.vitalidad = 800;
            this.estres = 8;
        }

        public int Fuerza ()
        {
            return vitalidad + batiriñonera.Sum(tecno => tecno.Poder());
        }
        public void CombatirElCrimen()
        {

        }

        public void LlorarASusPadres()
        {
            estres -= 10;
            batiriñonera.RemoveAt(0);
        }
    }
}