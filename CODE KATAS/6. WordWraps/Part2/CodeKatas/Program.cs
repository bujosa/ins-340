
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

    public class Wrapper
    {
        public string WrapWords(string push, int x)
        {
            char[] data = push.ToCharArray();
            string global = "";
            int count = 0;

            if (push.Length < x)
                return push;

            for(int i = 0; i < data.Length; i++)
            {
                if(data[i] == ' ')
                {
                    count = 0;
                    global += " ";
                    continue;
                }
                if (count < x)
                {
                    global += data[i];
                    count++;
                }
                else
                { global += " " + data[i];
                    count = 1;
                }

            }
            return global;
        }

        public string WrapLines(string push, int x)
        {
            char[] data = push.ToCharArray();
            string global = "";
            int count = 0;

            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == ' ')
                {
                    count++;
                    if(count == x)
                    {
                        count = 0;
                        global += "\n ";

                    }
                    else
                        global += " ";
                    continue;
                }
                global += data[i];
            }
            return global;
        }
    }


}
