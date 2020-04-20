namespace E6
{
    public class Matematica
    {

        public static int Factorial(int num)
        {
            int act=1;
            for (int i = 2; i <= num; i++)
            {
                act*=i;
            }
            return(act);
        }

        public static int Mayor (int num, int num1)
        {
            return (num>num1? num:num1);
        }

        public static int Menor (int num, int num1)
        {
            return (num<num1? num:num1);
        }

        public static int Cubo(int num)
        {
            return (num*num*num);
        }
    }
}