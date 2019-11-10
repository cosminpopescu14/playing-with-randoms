using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Bench
{
    class Program
    {
        private static readonly Random random = new Random();
        static void Main(string[] args)
        {
            var sw = new Stopwatch();
            sw.Start();

            /*for (int steps = 0; steps < 10000000; ++steps)
            {
                GenerateRandomsPair();
            }*/
            Parse() ;
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
            }            
        }

        private static void GenerateRandomsPair()
        {
            lock (random)
            {
                float res = 0f;
                int nb1 = random.Next(0, int.MaxValue);
                int nb2 = random.Next(0, int.MaxValue);
                res = (float)nb1 / nb2;
                WriteInFile(nb1, nb2, res);
            }
        }

        private static void WriteInFile(int nb1 = 0, int nb2 = 0, float res = 0)
        {
            var sb = new StringBuilder();
            sb.Append(nb1);
            sb.Append("\t");
            sb.Append(nb2);
            sb.Append("\t");
            sb.Append(res);
            sb.Append("\n");
            File.AppendAllText("WriteTextAsync.txt", sb.ToString());
        }

        private static void Parse()
        {
            var path = @"C:\Users\cosmi\Desktop\random_numbers.txt";

            using (StreamReader sr = File.OpenText(path))
            {
                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    decimal x = decimal.Parse(line.Split("\t")[0]);
                    decimal y = decimal.Parse(line.Split("\t")[1]);

                    decimal res = x / y;
                }
            }
        }
    }
}
