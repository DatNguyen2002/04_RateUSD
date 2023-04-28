using System;
namespace RateUSD
{
    class Program
    {
        static void Main(string[] args){
            const int RateUSD = 23000;
            
            Console.Write("Nhap So USD ma ban muon chuyen: ");
            float USD =  float.Parse(Console.ReadLine());

            Console.WriteLine(USD + " USD = " + (USD * RateUSD) + " VND ");

        }
    }
}