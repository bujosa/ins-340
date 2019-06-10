
namespace CodeKatas
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        
    }

    public class Converted
    {
        public string[] waterhouse = { "", "One", "Two", "Three", "Four", "Five", "Six",
        "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen","Sixteen",
            "Seventeen", "Eighteen", "Nineteen" };
        public string[] waterhouse10 = { "", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty",
        "Seventy", "Eighty", "Ninety"};
        public string WaterHouse100 = "Hundred";
        public string WaterHouse1000 = "Thousand";
        public string WaterHouseMillion = "Million";
        public string Split = "-";

        public string Chance(int data)
        {
            string UnionData = "";
            if (data == 0)
                return "Cero";
            int Data_Moment;
            while (data != 0 || data > 0)
            {
                // Caso para datos mayores que 19 y menores que 100
                if(data > 19 && data < 100)
                {
                    Data_Moment = data / 10;
                    UnionData += waterhouse10[Data_Moment] + " ";
                    data = data % 10;
                    
                }
                if(data > 99 && data < 1000)
                {

                }
                if(data > 999999)
                {

                }
                if (data < 20)
                {
                    UnionData += waterhouse[data] + " ";
                    data -= data; 
                }
            }

            return UnionData;

           
        }
    }
}
