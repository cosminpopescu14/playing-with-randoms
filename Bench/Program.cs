using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Bench
{
    class Program
    {
        private static readonly Random random = new Random();
        static void Main(string[] args)
        {
            //int result = 0;

            var sw = new Stopwatch();
            sw.Start();

            /*for (int i = 1000000000; i != 0; i--)
            {
                result++;
            }
            Console.WriteLine("Value: {0} Took: {1}s", result, sw.ElapsedMilliseconds / 1000F);*/

         

            /*for (int steps = 0; steps < 10000000; ++steps)
            {
                GenerateRandomsPair();
            }*/
            Console.WriteLine("Took: {0}s", sw.ElapsedMilliseconds / 1000F);
            
        }

        /*
         * Buna pt chestii criptografice
         */
        private static void GenerateSecureRandomPair()
        {
            using (RNGCryptoServiceProvider rg = new RNGCryptoServiceProvider())
            {
                byte[] rno = new byte[4];
                byte[] rno1 = new byte[4];
                rg.GetBytes(rno);
                rg.GetBytes(rno1);
                int randomvalue = Math.Abs(BitConverter.ToInt32(rno, 0));
                int randomvalue1 = Math.Abs(BitConverter.ToInt32(rno1, 0));
                //Console.WriteLine("{0}     {1}",randomvalue, randomvalue1);
                //WriteInFile(randomvalue, randomvalue1);
            }            
        }

        private static void GenerateRandomsPair()
        {
            /*lock (random)
            {
                float res = 0f;
                int nb1 = random.Next(0, int.MaxValue);
                int nb2 = random.Next(0, int.MaxValue);
                //res = (float)nb1 / nb2;
                Console.WriteLine("{0},{1}", nb1, nb2);
            }*/

            /*int nb1 = new XorShiftRandom().NextInt32();
            int nb2 = new XorShiftRandom().NextInt32();
            float res = (float)nb1 / nb2;*/

            //WriteInFile();

        }

        private static void WriteInFile(int nb1 = 0, int nb2 = 0, float res = 0)
        {
            var sb = new StringBuilder();
            sb.Append("aaaaaaa");
            File.AppendAllText("WriteTextAsync.txt", sb.ToString());
        }

        private static void Parse()
        {
            var path = @"C:\Users\cosmi\Desktop\random_numbers.txt";

            

    
        }
    }
}
