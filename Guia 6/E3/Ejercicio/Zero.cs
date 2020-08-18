using System.Collections.Generic;
using System.Linq;
namespace Ejercicio
{
    public class Zero
    {
        List<Arma> armas;
        public Zero(List<Arma> armas)
        {
            this.armas = armas;
        }

        public int Poder()
        {
            return armas.Max(arma => arma.Poder());
        }
        public bool LoPuedeVencer(Maverick maverick)
        {
            return this.Poder() > maverick.Fuerza();
        }

        public bool LosPuedeVencer(List<Maverick> mavericks)
        {
            return mavericks.All(enemigo => enemigo.Fuerza() < this.Poder());
        }

        public Arma LaMasPolentosa()
        {
            return armas.OrderBy(arma => arma.Poder()).ToList().Last();
        }
    }
}