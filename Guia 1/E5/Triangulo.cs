namespace E5
{
    public class Triangulo
    {
        int lado1;
        int lado2;
        int lado3;
        public Triangulo (int lado1, int lado2, int lado3)
        {
            this.lado1=lado1;
            this.lado2=lado2;
            this.lado3=lado3;
        }
        public bool EsEscaleno()
        {
            return (lado1!=lado2 && lado1!=lado3 && lado2!=lado3);
        }
        public bool EsIsosceles()
        {
            return ((lado1!=lado2 && lado2==lado3)||(lado3!=lado2&&lado1==lado3)||(lado3!=lado1&&lado1==lado2));
        }
        public bool EsEquilatero()
        {
            return (lado1==lado2 && lado1==lado3);
        }
        public bool EsTrianguloRectangulo()
        {
            return (lado1*lado1==lado2*lado2+lado3*lado3);  
        }
    }
}