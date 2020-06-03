using System.Collections.Generic;
namespace E2
{
    public class MonstersInc
    {
        private List<Monstruo> personal;

        public MonstersInc ()
        {
            Monstruo mikewazowski = new Amigable (65, "Mike Wazowski");
            Monstruo andysullivan = new Peligroso (69, "Andy Sullivan");
            this.personal = new List<Monstruo> ();
            personal.Add (mikewazowski);
            personal.Add (andysullivan);
        }

        public void NocheDeSustos ()
        {
            foreach (Monstruo empleado in personal)
            {
                empleado.Asustar ();
            }
        }

        public void NocheDeRisas ()
        {
            foreach (Monstruo empleado in personal)
            {
                empleado.HacerReir ();
            }
        }

        public List<Monstruo> MonstruosRespetables ()
        {
            List<Monstruo> respetables = new List<Monstruo>();

            foreach (Monstruo empleado in personal)
            {
                if (empleado.Respeto > 70)
                    respetables.Add (empleado);
            }
            return respetables;
        }

        public int EnergiaTotal ()
        {
            int suma = 0;

            foreach (Monstruo empleado in personal)
            {
                suma += empleado.Respeto;
            }

            return suma;
        }

    }
}