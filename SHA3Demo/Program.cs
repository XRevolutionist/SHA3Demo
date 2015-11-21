using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SHA3;

namespace SHA3Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] HashArray = new int[4] { 224, 256, 384, 512 };
            string Data = "This is the SHA-3 Demonstration";

            Console.WriteLine("Demonstration of SHA-3\n");

            for (int Index = 0; Index < HashArray.Length; Index++)
            {
                using (var SHA3Provider = new SHA3.SHA3Managed(HashArray[Index]))
                {
                    Console.WriteLine("Hash Length : {0}", HashArray[Index]);
                    Console.WriteLine("Hash : {0}\n", BitConverter.ToString(SHA3Provider.ComputeHash(Encoding.Default.GetBytes(Data))));
                }
            }

            Console.WriteLine("End");
            Console.ReadLine();
        }
    }
}
