using System;

namespace Roman_Numeral_Part_2
{
    class Program
    {
        public static int N;
        public static string S;
        public static string rom;
        public static int sum;

        static void Main(string[] args)
        {
            Console.WriteLine("Digite un numero entre 1 y 3000:");
            N = Convert.ToInt32(Console.ReadLine());
            NumberToLetter(N);
            Console.WriteLine("Digite un numero en romano: ");
            S = Console.ReadLine();
            LetterToNumber(S);
            Console.ReadKey();
        }

        private static void LetterToNumber(string s)
        {
            s.ToUpper();
            char[] array = s.ToCharArray();
            // I, V, X, L, C, D, M
            for(int i = 0; i <array.Length; i++)
            {
                if(array[i] == 'I')
                {
                    sum += 1;
                    continue;
                }
                if (array[i] == 'C')
                {
                    sum += 100;
                    if (i == 0)
                        continue;
                    if (array[i - 1] == 'X')
                        sum -= 20;
                    continue;

                }
                if (array[i] == 'L')
                {
                    sum += 50;
                    if(i == 0)
                        continue;
                    if (array[i - 1] == 'X')
                        sum -= 20;
                    continue;
                }
                if (array[i] == 'D')
                {
                    sum += 500;
                    if(i == 0)
                        continue;
                    if (array[i - 1] == 'C')
                        sum -= 200;
                    continue;
                }
                if (array[i] == 'M')
                {
                    sum += 1000;
                    if(i == 0)
                        continue;
                    if (array[i - 1] == 'C')
                        sum -= 200;
                    continue;
                }
                if (array[i] == 'X')
                {
                    sum += 10;
                    if (i == 0)
                        continue;
                    if (array[i - 1] == 'I')
                        sum -= 2;
                    continue;
                }
                if (array[i] == 'V')
                {
                    sum += 5;
                    if (i == 0)
                        continue;
                    if (array[i - 1] == 'I')
                        sum -= 2;
                    continue;
                }
            }

            Console.WriteLine("El numero romano {0} en numero normal es: {1}", s, sum);
            
        }

        private static void NumberToLetter(int n)
        {
            // No se pueden numeros mayores que 3000 y menores que 1
            if (n < 1 || n > 3000)
                throw new InvalidOperationException();

            // Separar la unidad de Mil
            if(n > 999 && n < 3001)
            {
                switch (n / 1000)
                {
                    case 1:
                        rom += "M";
                        break;
                    case 2:
                        rom += "MM";
                        break;
                    case 3:
                        rom += "MMM";
                        break;
                }

                n -= 1000 * (n / 1000);
            }
            // Separar la centena
            if (n > 99 && n < 1000)
            {
                switch (n / 100)
                {
                    case 1:
                        rom += "C";
                        break;
                    case 2:
                        rom += "CC";
                        break;
                    case 3:
                        rom += "CCC";
                        break;
                    case 4:
                        rom += "CD";
                        break;
                    case 5:
                        rom += "D";
                        break;
                    case 6:
                        rom += "DC";
                        break;
                    case 7:
                        rom += "DCC";
                        break;
                    case 8:
                        rom += "DCCC";
                        break;
                    case 9:
                        rom += "CM";
                        break;

                }
                n -= 100 * (n / 100);
            }
            // Separar la decena
            if(n > 9 && n < 100)
            {
                switch (n / 10)
                {
                    case 1:
                        rom += "X";
                        break;
                    case 2:
                        rom += "XX";
                        break;
                    case 3:
                        rom += "XXX";
                        break;
                    case 4:
                        rom += "XL";
                        break;
                    case 5:
                        rom += "L";
                        break;
                    case 6:
                        rom += "LX";
                        break;
                    case 7:
                        rom += "LXX";
                        break;
                    case 8:
                        rom += "LXXX";
                        break;
                    case 9:
                        rom += "XC";
                        break;
                }
                n -= 10 * (n / 10);
            }
            // Separar la unidad
            if (n > 0 && n < 10)
            {
                switch (n)
                {
                    case 1:
                        rom += "I";
                        break;
                    case 2:
                        rom += "II";
                        break;
                    case 3:
                        rom += "III";
                        break;
                    case 4:
                        rom += "IV";
                        break;
                    case 5:
                        rom += "V";
                        break;
                    case 6:
                        rom += "VI";
                        break;
                    case 7:
                        rom += "VII";
                        break;
                    case 8:
                        rom += "VIII";
                        break;
                    case 9:
                        rom += "IX";
                        break;
                }
            }

            Console.WriteLine("El numero {0} en romano es: {1}" ,N, rom);
        }
    }
}
