
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
            Wrapper dato = new Wrapper();
            string prueba  = dato.WrapWords("hola", 2);
        }
        
    }

    public class Wrapper
    {
        public string WrapWords(string push, int x)
        {
            if (push.Length <= x)
                return push;
            else
            {
                char[] func = push.ToCharArray();
                string global = "";
                int count = 0;
                for (int i = 0; i < func.Length; i++)
                {
                    if (func[i] == ' ')
                    {
                        global += func[i];
                        count = 0;
                        continue;
                    }
                    if (count < x)
                    { global += func[i];
                        count++;
                    }
                    else
                    {
                        count = 0;
                        global += " " + func[i];
                    }
                    
                }
                return global;
            }
        }
        public string WrapLines(string push, int x)
        {
            char[] func = push.ToCharArray();
            string global = "";
            int count = 0;

            for (int i = 0; i < func.Length; i++)
            {
                if (func[i] == ' ')
                {
                    
                    count++;
                    if (count == x)
                    {
                        global += "\n ";
                        count = 0;
                    }
                    else
                        global += " ";
                    continue;
                }
                global += func[i];
            }
               return global;
        }
        
    }


}
