namespace Ejercicio
{
    public class ChicoBestia : Titan
    {
        string color;
        public ChicoBestia()
        {
            this.color = "Verde";
            this.tristeza = 2;
        }

        public void CambiarDeColor(string color)
        {
            this.color = color;
            tristeza += 4;
        }
        public override int Poder()
        {
            return (color.Length)*13;
        }
        public override void LlorarPorRobocop()
        {
            tristeza -= (tristeza >= 8 ? 8 : tristeza);
        }
        public override bool EstaTriste()
        {
            return tristeza > 5;
        }

        public override void ComerPizza()
        {
            color="Amarillo patito fluorescente de las montañas del himalaya amazónico";
        }
    }
}