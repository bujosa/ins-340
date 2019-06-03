using System;

namespace CodeKatas
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        
    }

    public class Calculator
    {
        public Decimal SumGlobal = 0;

        public string StringCalculator(string v)
        {
            if (v == "")
                return "0";
            string[] zxy = v.Split(",");
            foreach(string data in zxy)
            {
                SumGlobal += Convert.ToDecimal(data);
            }
            return Convert.ToString(SumGlobal);
          
        }
    }
}
