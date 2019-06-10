
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
        string[] WaterHouse = {"", "One", "Two", "Three","Four","Five",
        "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve",
        "Thirteen", "Fourteen", "Fiveteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
        string[] WaterHouse20 = { "", "Ten", "Twenty", "Thirty", "Fouty", "Fifty",
        "Sixty", "Seventy", "Eighty", "Ninety"};
        string Hundred = "hundred";
        string Thousand = "thousand";
        string Million = "million";


        public string Chance(int data)
        {
            string UnionData = "";
            int DataMoment;
            if (data == 0)
                return "Cero";
            while (data != 0 || data > 0)
            {
                if (data > 19 && data < 100)
                {
                    DataMoment = data / 10;
                    UnionData += WaterHouse20[DataMoment] + " ";
                    data = data % 10;
                }
                if (data < 20)
                {
                    UnionData += WaterHouse[data] + " ";
                    data -= data;
                }
                if (data > 99 && data < 1000)
                {
                    DataMoment = data / 100;
                    UnionData += WaterHouse[DataMoment] + " " + Hundred + " ";
                    data = data % 100;
                }
                if(data > 999 && data < 1000000)
                {
                    DataMoment = data / 1000;
                    int TMP = DataMoment = data / 1000;
                    while (TMP != 0 || TMP > 0)
                    {
                        if (TMP > 19 && TMP < 100)
                        {
                            DataMoment = TMP / 10;
                            UnionData += WaterHouse20[DataMoment] + " ";
                            TMP = data % 10;
                        }
                        if (TMP < 20)
                        {
                            UnionData += WaterHouse[TMP] + " ";
                            TMP -= TMP;
                        }
                        if (TMP > 99 && TMP < 1000)
                        {
                            DataMoment = TMP / 100;
                            UnionData += WaterHouse[DataMoment] + " " + Hundred + " ";
                            TMP = TMP % 100;
                        }
                    }
                    UnionData += Thousand + " ";
                    data = data % 1000;
                }
            }
            return UnionData;
        }

    }
}
