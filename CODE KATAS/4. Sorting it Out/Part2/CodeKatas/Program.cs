using System;
using System.Linq;
namespace CodeKatas
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        
    }

    public class Sorting
    {
        public int[] Sort(int[] push)
        {
            // Sort Bubble Sort
            // Worst Case O(N^2) Average Same
            // Best Case O(N)
            for(int i = 0; i < push.Length - 1; i++)
            {
                bool Swat = false;
                for(int j = 0; j < push.Length - 1; j++)
                {
                    if(push[j] > push[j+1])
                    {
                        int x = push[j];
                        int y = push[j + 1];
                        push[j] = y;
                        push[j + 1] = x;
                        Swat = true;
                    }
                }
                if (!Swat)
                    break;
            }
            return push;
        }

        public string Sort(string y)
        {
            int z = y.Length;
            string house = "";
            for(int i = 0; i < z; i++)
            {
                if (y.Substring(i, 1) != " " && y.Substring(i, 1) != "." && y.Substring(i, 1) != ",")
                    house += y.Substring(i, 1);
            }

            string ordenado = new string(house.OrderBy(x => x).ToArray());

            return ordenado;
        }
    }
}
