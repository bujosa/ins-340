using System;

namespace TestRomanos
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 0; // Variable para numero
            string s = "";
            Console.WriteLine("Escriba un numero entre 1 y 3000:");
            N = Convert.ToInt32(Console.ReadLine());
            NumberToLetter(N);
            Console.WriteLine("Escriba un numero en romano entre 1 y 3000:");
            s = Console.ReadLine();
            LetterToNumber(s);

        }

        public static string rom;
        public static int Sum = 0;

        static void LetterToNumber (string S)
        {
            S = S.ToUpper();

            char[] array = S.ToCharArray();
            
            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] == 'M')
                {
                    Sum += 1000;
                    if (i == 0)
                        continue;
                    if (array[i - 1] == 'C')
                        Sum -= 200;
                        continue;
                }
                if (array[i] == 'D')
                {
                    Sum += 500;
                    if (i == 0)
                        continue;
                    if (array[i - 1] == 'C')
                        Sum -= 200;
                        continue;
                }
                if (array[i] == 'X')
                {
                    Sum += 10;
                    if (i == 0)
                        continue;
                    if (array[i - 1] == 'I')
                        Sum -= 2;
                        continue;
                }
                if (array[i] == 'L')
                {
                    Sum += 50;
                    if (i == 0)
                        continue;
                    if (array[i - 1] == 'X')
                        Sum -= 20;
                        continue;
                }
                if (array[i] == 'V')
                {
                    Sum += 5;
                    if (i == 0)
                        continue;
                    if (array[i - 1] == 'I')
                        Sum -= 2;
                        continue;
                }
                if (array[i] == 'C')
                {
                    Sum += 100;
                    if (i == 0)
                        continue;
                    if (array[i - 1] == 'X')
                        Sum -= 20;
                        continue;
                }
                if (array[i] == 'I')
                {
                    Sum += 1;

                        continue;
                }

                Console.WriteLine("No se aceptan caracteres no valido solo : I, V, L, X, C, M, D");
                return;

            }

            Console.WriteLine(Sum);
            Console.ReadKey();
        }

        static void NumberToLetter(int N)
        {
           
            bool Variable = true;

            if (N > 999 && N < 3001)
            {
                switch (N / 1000)
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
                N -= 1000 * (N / 1000); // funcion para reducir la unidad de MIl al numero
            }

            if (N > 99 && N < 1000)
            {
                switch (N / 100)
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
                N -= 100 * (N / 100);
            }

            if (N > 9 && N < 100)
            {
                switch (N / 10)
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

                N -= 10 * (N / 10);
            }

            if (N > 0 && N < 10)
            {
                switch (N)
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

            if (N > 3000 && N < 1)
            {
                Variable = false;
                Console.WriteLine("No se puede escribir a romano el numero que digito {0}", N);
            }

            if (Variable)
                Console.WriteLine("El numero en romano es: {0} ", rom);
            Console.ReadLine();

        }


    }
}
