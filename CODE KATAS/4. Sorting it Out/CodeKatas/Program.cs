using System;
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
        public int[] Sorted(int[] B)
        {

            if (B.Length == 1)
                return B;

            for(int i = 0; i < B.Length - 1;i++)
            {
                bool Swat = false;
                for(int j = 0; j < B.Length - 1; j++)
                {
                    if(B[j] > B[j + 1] )
                    {
                        int x = B[j];
                        int Y = B[j + 1];
                        B[j] = Y;
                        B[j + 1] = x;
                        Swat = true;
                    }  
                }
                if (!Swat)
                    break;
            }
            return B;
        }
    }
}
