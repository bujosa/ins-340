
using System.Linq;
using System.Collections.Generic;
using System;

namespace CodeKatas
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        
    }

    public class Anagrams
    {
        public string Find(string Anagram, string words2)
        {
            if (words2 == null)
                return null;

            string TMP;
            string Value = Anagram;
            string[] words = words2.Split(" ");

            for (int i = 0; i < words.Length; i++)
            {
                TMP = words[i];
                if (TMP.Length > Anagram.Length || TMP.Length < Anagram.Length)
                    continue; // Ahorraria el tiempo de entrar  a IsAnagram 
                // y evaluar una palabra con menor tamaño o 
                //  Mayor Tamaño que ese anagrama.

                if (IsAnagram(Anagram, TMP))
                    Value += " " + TMP;
            }
            
            return Value;
        }

        public bool IsAnagram(string a1, string a2)
        {
            string a3 = Sort(a1);
            string a4 = Sort(a2);

            if (a3 == a4)
                return true;
            return false;
        }

        public string Sort(string y)
        {
            int z = y.Length;
            string house = "";
            for (int i = 0; i < z; i++)
            {
                if (y.Substring(i, 1) != " " && y.Substring(i, 1) != "." && y.Substring(i, 1) != ",")
                    house += y.Substring(i, 1);
            }

            string ordenado = new string(house.OrderBy(x => x).ToArray());

            return ordenado;
        }
    }
}
