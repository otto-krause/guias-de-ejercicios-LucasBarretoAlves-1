namespace E7
{
    public class Alfajor
    {
        string nombre;
        int precio;
        public int Precio {get => precio;}
        string empresa;
        public string Empresa {get => empresa;}
        public Alfajor(string nombre, int precio, string empresa)
        {
            this.nombre=nombre;
            this.precio=precio;
            this.empresa=empresa;
        }
        public void Subida(int tipo)
        {
            switch(tipo)
            {
                case 1:
                    precio+=80;
                    break;
                case 2:
                    precio*=2;
                    break;
                case 3:
                    precio+=1000;
                    break;
            }
        }
    }
}