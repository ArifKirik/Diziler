namespace Diziler_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] sayilar = new int[5];
            //for (int i = 0; i < 5; i++) {
            //    Console.WriteLine((i + 1).ToString() + ". Sayıyı giriniz");
            //    sayilar[i]=Convert.ToInt32(Console.ReadLine());
            //        }
            //int enbüyük;
            //enbüyük = sayilar[0];
            //for (int i = 1; i < 5; i++)
            //{
            //    if(enbüyük<sayilar[i])
            //    {
            //        enbüyük=sayilar[i];
            //    }


            //}

            //Console.WriteLine(enbüyük);
            //Console.ReadLine();
            string[] isim = new string[3];
            int[] s1 = new int[3];
            int[] s2 = new int[3];
            int[] ort = new int[3];
            for (int i = 0; i < 3; i++)
            {
                Console.Clear();
                Console.WriteLine(i+1+".öğrencinin adı:");
                isim[i] = Console.ReadLine();

                Console.WriteLine(i+1+".sınav1:");
                s1[i]=Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(i + 1+".sınav2:");
                s2[i]=Convert.ToInt32(Console.ReadLine());

                ort[i] = (s1[i] + s2[i]) / 2;
            }
            Console.Write("öğrenci  sınav1  sınav2   ort"   );
            Console.WriteLine();
            for(int i = 0;i < 3;i++)
            {
                Console.WriteLine("  " + isim[i]+ "   " + s1[i]+ "     " + s2[i]+ "      " + ort[i]);
            }
            Console.Read();

        }
    }
}
