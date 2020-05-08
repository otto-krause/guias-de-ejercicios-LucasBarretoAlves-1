using System;

namespace E1
{
    class Program
    {
        static void Main(string[] args)
        {
            Homero homero = new Homero();
            Lenny lenny = new Lenny();
            PatoBalancin pato = new PatoBalancin();
            MrBurns burns = new MrBurns();
            Planta planta = new Planta(homero, burns);

            string opcion = "";
            int ingreso;
            do
            {
                Console.WriteLine(
                "1)Ver si la planta esta en peligro\n" +
                "2)Homero come dona\n" +
                "3)Homero compra donas\n" +
                "4)Lenny toma cerveza\n" +
                "5)Cambiar empleado por Homero\n" +
                "6)Cambiar empleado por Lenny\n" +
                "7)Cambiar empleado por el Pato\n" +
                "8)Despojar a burns de sus riquezas\n"+
                "9)Llegada de cargamento de uranio");

                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine(planta.estaEnPeligro());
                        break;
                    case "2":
                        homero.comerDona();
                        break;
                    case "3":
                        homero.comprarDonas();
                        break;
                    case "4":
                        lenny.tomarCerveza();
                        break;
                    case "5":
                        planta.cambiarEmpleado(homero);
                        break;
                    case "6":
                        planta.cambiarEmpleado(lenny);
                        break;
                    case "7":
                        planta.cambiarEmpleado(pato);
                        break;
                    case "8":
                        burns.despojarRiquezas();
                        break;
                    case "9":
                        Console.Write("Ingrese cantidad de barras de uranio en el cargamento: ");
                        ingreso=Int32.Parse(Console.ReadLine());
                        planta.recibirCargamento(ingreso);
                        break;
                    default:
                        opcion = "salir";
                        break;
                }
            }
            while (opcion != "salir");
        }
    }
}
