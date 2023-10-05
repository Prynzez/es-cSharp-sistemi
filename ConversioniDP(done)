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
            //Dichiariamo e inizializzaziamo un array di interi 'dp' di lunghezza 4
            int[] dp = new int[4];

            //Ciclo per chiedere all'utente di inserire 4 cifre
            for (int i = 0; i < dp.Length; i++)
            {
                Console.WriteLine($"Inserisci cifra {i + 1}");
                dp[i] = Convert.ToInt32(Console.ReadLine());
            }

            //Convertiamo l'array di interi 'dp' in un array di booleani 'bn' rappresentante la forma binaria
            bool[] bn = ConvertDpToBin(dp);

            //Stampiamo la rappresentazione binaria
            for (int i = 0; i < bn.Length; i++)
            {
                Console.Write(Convert.ToInt32(bn[i]));
            }
            Console.WriteLine();

            //Stampiamo la conversione dell'array 'dp' in un numero intero
            Console.WriteLine(ConvertDpToIntero(dp));

            //Stampiamo la conversione dell'array binario 'bn' in un numero intero
            Console.WriteLine(ConvertBinToIntero(bn));

            //Stampiamo nuovamente la conversione dell'array binario 'bn' in un numero intero
            Console.WriteLine(ConvertBinToIntero(bn));

            //Attendi l'input dell'utente prima di chiudere
            Console.ReadLine();
        }

        //Metodo per convertire un array di interi in una rappresentazione binaria 
        static bool[] ConvertDpToBin(int[] dp)
        {
            bool[] bn = new bool[32];
            int j = bn.Length - 1;

            //Iterazione attraverso l'array di interi
            for (int i = 0; i < dp.Length; i++)
            {
                int num = dp[i];

                //Iterazione per convertire il numero in binario e memorizzarlo nell'array 'bn'
                for (int y = 0; y < 8; y++)
                {
                    bn[j] = num % 2 == 1;
                    num = num / 2;
                    j--;
                }
            }
            return bn;
        }

        //Metodo per convertire un array di interi in un numero intero
        static int ConvertDpToIntero(int[] dp)
        {
            int decimale = 0;
            int j = 3;

            //Iterazione attraverso l'array di interi
            for (int i = 0; i < dp.Length; i++)
            {
                //Calcoliamo il valore decimale sommando il prodotto di ciascuna cifra per la potenza di 256
                decimale += dp[i] * (int)Math.Pow(256, j--);
            }
            return decimale;
        }

        //Metodo per convertire un array binario in un numero intero
        static int ConvertBinToIntero(bool[] bn)
        {
            int intero = 0;
            int j = bn.Length - 1;

            //Iterazione attraverso l'array binario
            for (int i = 0; i < bn.Length; i++)
            {
                //Calcoliamo il valore intero sommando il prodotto di 2 elevato alla potenza corrispondente
                if (bn[i])
                {
                    intero += (int)Math.Pow(2, j);
                }
                j--;
            }
            return intero;
        }

        //Metodo per convertire un array binario in decimale
        static int ConvertBinToDec(bool[] bn)
        {
            int d = 0;

            for (int i = 0; i < bn.Length; i++)
            {
                if (bn[i])
                    d = (int)Math.Pow(10, 31 - i);
            }
            return d;
        }
    }
}

    
