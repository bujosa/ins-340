
using System.Linq;
using System.Collections.Generic;
using System;
using System.IO;

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
        // Funcion para encontrar anagramas
        public string Find(string anagram, string words)
        {
            if (words == null || anagram == null) 
              return null;
            string value = anagram;
            string[] Words = words.Split(" ");
     
           for (int i = 0; i < Words.Length; i++)
           {
                string TMP = Words[i];
                if (IsAnagram(anagram, TMP))
                    value += " " + TMP;
            
           }
            return value;
        }
        // Funcion con el mismo nombre
        public string Finder( string anagram, string rout)
        {
          
            if (rout == null || anagram == null)
                return null;
            string value = anagram;
            string[] Words = File.ReadAllLines(rout);

            for (int i = 0; i < Words.Length; i++)
            {
                string TMP = Words[i];
                if (anagram == TMP)
                    continue;
                if (IsAnagram(anagram, TMP))
                    value += " " + TMP;

            }
            return value;
        }
        // Funcion para saber si dos palabras son anagramas
        private bool IsAnagram(string anagram, string tMP)
        {
            string WordsOne = Sort(anagram);
            string wordstwo = Sort(tMP);
            
            if (WordsOne == wordstwo)
                return true;
            return false;
        }

        // Funcion para ordernar palabras like sort
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
