using tyuiu.cources.programming.interfaces.Sprint1;
    namespace Tyuiu.ReshetovaAA.Sprint1.Task4.V26.Lib
{
    public class DataService : ISprint1Task4V26
    {
        public double Calculate(double x, double y)
        {
            double z = 2.243;
            double res = (Math.Atan(x) + y) / Math.Exp(y + z);
            return Math.Round(res, 3);
        }
    }
}
