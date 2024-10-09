using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kullanicibilgisiödevi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Kullanıcıdan bilgiler alıncak


            Console.WriteLine("""Adınızı yazınız:""");

            string ad = Console.ReadLine();

            Console.WriteLine("Soyadınızı yazınız:");
            
            string soyad = Console.ReadLine();
            
            Console.WriteLine("Öğrenci numaranızı yazınız:");
            
            string ogrenciNo = Console.ReadLine();
            
            Console.WriteLine("Cep numaranızı yazınız:");

            string cepTel = Console.ReadLine();


            // Alınan bilgiler toplu gözüksün.


            Console.WriteLine("KULLANICI BİLGİLERİ:");
            Console.WriteLine("Kullanıcı Adı: " +ad);
            Console.WriteLine("Kullanıcı Soyadı: " +soyad);
            Console.WriteLine("Kullanıcı Öğrenci No: " +ogrenciNo);
            Console.WriteLine("Kullanıcı Cep Telefonu Numarası: " +cepTel);

            //Terminal ekranda kalsın

            Console.ReadLine();


        }
    }
}