namespace E3
{
    public class Armadura
    {
        private string nombre;
        public string Nombre{get => nombre;}
        private string material;
        public string Material{get => material;}

        public Armadura(string nombre, string material)
        {
            this.nombre=nombre;
            this.material=material;
        }
    }
}