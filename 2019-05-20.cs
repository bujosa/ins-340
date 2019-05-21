using System;

namespace RomanoNumeralPart1
{
    class Program
    {

        public static int N;
        public static string rom;
        public static int Sum;
        public static string s;

        static void Main(string[] args)
        {
            Console.WriteLine("Digite un numero entre 1 y 3000:");
            N = Convert.ToInt32(Console.ReadLine());
            NumberToLetter(N);
            Console.WriteLine("Digite un numero en romano: ");
            s = Console.ReadLine();
            LetterToNumber(s);
            Console.ReadKey();
        }

        public static void NumberToLetter(int n)
        {
            if (n == 0 || n > 3000)
            {
                Console.WriteLine("Solamente se permite los numeros entre 1 y 3000");
                return;
            }
            if (n > 999 && n < 3001)
            {
                switch(n / 1000)
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
                n -= (n / 1000) * 1000; // Funcion que resta la unidad de MIl al numero
            }

            if(n > 99 && n < 1000)
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

                n -= 100 * (n / 100);// Asi eliminamos la centena;
            }

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

            if( n > 0 && n < 10)
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

         
            Console.WriteLine("El numero N en romano es {0}",rom);
        }

        public static void LetterToNumber(string S)
        {
            // I, V, X, L, D, C, M
            // MMXDL
            S.ToUpper();
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
                if (array[i] == 'I')
                {
                    Sum += 1;
                    continue;
                  
                }
                if (array[i] == 'C')
                {
                    Sum += 100;
                    if (i == 0)
                        continue;
                    if (array[i - 1] == 'X')
                        Sum -= 200;
                    continue;
                }
                if(array[i] == 'X')
                {
                    Sum += 10;
                    if (i == 0)
                        continue;
                    if (array[i - 1] == 'I')
                        Sum -= 2;
                    continue;
                }

                Console.WriteLine("No se aceptan caracteres no valido solo : I,V,X,L,C,D,M");
                return;
            }

            Console.WriteLine("El numero romano {0} en numero normal es: {1}", s, Sum);

        }
        
    }
}
