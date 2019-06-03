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
        public double GlobalSum = 0;
        public string Stringcalculator(string v)
        {
            char[] splitdata = { ',', '\n' };
            if (v == "")
                return Convert.ToString(GlobalSum);
            string[] ABC = v.Split(splitdata);
            foreach(string parse in ABC)
            {
                try
                {
                    GlobalSum += Convert.ToDouble(parse);
                }
                catch
                {
                    return "Number expected but EOF found.";
                }
            }
            return Convert.ToString(GlobalSum);
        }

    }
}
