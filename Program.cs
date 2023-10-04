using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertiSistemi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool[] b = new bool[32];
            int[] dp = new int[4];

            string bit = "";
            int cnt = 0;

            Console.WriteLine("Inserire il numero in binario (max 32 bit)");
            bit = Console.ReadLine();
            for (int i = 32 - bit.Length; i < b.Length; i++)
            {
                if (bit[cnt] == '1')
                {
                    b[i] = true;
                }
                cnt++;

            }

        bool[] Convert_dp_to_Binario(int[]dp)
        {
                int risultato = 0, potenza = 0;
                for (int i = b.Length - 1; i >= 0; i--)
                {
                    risultato += Convert.ToInt32(b[i]) * (int)Math.Pow(2, potenza);
                    potenza++;
                }
                return risultato;
            }

        static int Convert_dp_to_Intero(int[]dp)
        {

        }

        static int Convert_dp_to_Intero(bool[]bn)
        {

        }
    }
}
    
