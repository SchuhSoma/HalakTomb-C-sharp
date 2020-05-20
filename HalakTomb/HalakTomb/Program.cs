using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalakTomb
{
    class Program
    {
        static string[] AllatNevek = new string[13];
        static double[] Sebesseg = new double[13];
        static int[] Testhossz = new int[13];
        static void Main(string[] args)
        {
            Feladat1AdatokFeltoltese(); Console.WriteLine("\n-------------------------------\n");
            Feladat2TombHossz(); Console.WriteLine("\n-------------------------------\n");
            Feladat3Atlag(); Console.WriteLine("\n-------------------------------\n");
            Feladat5SzazKm(); Console.WriteLine("\n-------------------------------\n");
            Feladat6MinMax(); Console.WriteLine("\n-------------------------------\n");
            Console.ReadKey();
        }

        private static void Feladat6MinMax()
        {
            Console.WriteLine("A legnagyobb és legkisebb állat és adata");
            string MaxAllat = "cica";
            double MaxSebesseg = 0;
            int MaxTesthoszt = int.MinValue;
            string MinAllat = "kutya";
            double MinSebesseg = 0;
            int MinTestHossz = int.MaxValue;
            for (int i = 0; i < AllatNevek.Length; i++)
            {
                if(MaxTesthoszt<Testhossz[i])
                {
                    MaxTesthoszt = Testhossz[i];
                    MaxAllat = AllatNevek[i];
                    MaxSebesseg = Sebesseg[i];
                }
                if(MinTestHossz>Testhossz[i])
                {
                    MinTestHossz = Testhossz[i];
                    MinAllat = AllatNevek[i];
                    MinSebesseg = Sebesseg[i];

                }
            }
            Console.WriteLine("A legnagyobb állat: {0} -> {1} cm-> {2} km/h", MaxAllat, MaxTesthoszt, MaxSebesseg);
            Console.WriteLine("A legkisebb állat: {0} -> {1} cm-> {2} km/h", MinAllat, MinTestHossz, MinSebesseg);
        }

        private static void Feladat5SzazKm()
        {
            Console.WriteLine("5.Feladat: 100 km megtételéhez szükséges idő");
            double SzuksegesIdo = 0;
            for (int i = 0; i < AllatNevek.Length; i++)
            {
                SzuksegesIdo = 100 / Sebesseg[i];
                Console.WriteLine("\tállat neve:{0,-15} -> szükséges idő 100 km-hez: {1:0.00} óra ", AllatNevek[i], SzuksegesIdo);
            }
        }

        private static void Feladat3Atlag()
        {
            Console.WriteLine("4.Feladat: Vizi állatok testhosszának és sebességének átlaga");
            double SebessegOsszeg = 0;
            double SebessegAtlag = 0;
            double HosszOsszeget = 0;
            double HosszAtlag = 0;
            for (int i = 0; i < AllatNevek.Length; i++)
            {
                SebessegOsszeg += Sebesseg[i];
                HosszOsszeget += Testhossz[i];
            }
            SebessegAtlag = SebessegOsszeg / Sebesseg.Length;
            HosszAtlag = HosszOsszeget / Testhossz.Length;
            Console.WriteLine("\tA vizi állatok átlag sebessége a táblázatban: {0:0.00} km/h", SebessegAtlag);
            Console.WriteLine("\tA vizi állatok átlag testhossza a táblázatban: {0:0.00} cm", HosszAtlag);

        }

        private static void Feladat2TombHossz()
        {
            Console.WriteLine("3.Feladat: a viziállatok tömb hossza");
            int TombHossz = AllatNevek.Length;
            Console.WriteLine("\tA Tömb hossza: {0}", TombHossz);
            for (int i = 0; i < TombHossz; i++)
            {
                Console.WriteLine("\t{0,-15}-> {1,-4} km/h->{2} cm",AllatNevek[i], Sebesseg[i], Testhossz[i]);
            }
        }

        private static void Feladat1AdatokFeltoltese()
        {
            AllatNevek = new string[13] { "pisztráng", "pirosszemű kele", "csuka", "aranykárász", "tőkehal ",
                "ragadozó őn ", "pisztráng", "kék cápa", "bálna", "delfin", "barrakuda", "hering", "tonhal" };
            Sebesseg = new double[13] { 2.3, 4.7, 5.3, 6.1, 7.2, 8.9, 10.0, 18.0, 32.0, 36.0, 44.0, 70.0, 70.1 };
            Testhossz = new int[13] { 40, 220, 200, 130, 550, 200, 290, 1500, 27500, 2000, 1200, 1000, 1000 };
        }
    }
}