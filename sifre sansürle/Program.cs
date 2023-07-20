using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sifre_sansürle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sifre="";
            ConsoleKeyInfo tus=default(ConsoleKeyInfo);
            do
            {
                tus = Console.ReadKey(true); // kullanıcının girdiği ekranda gözükmesin diye parametresi true
                if ((tus.Key == ConsoleKey.Escape) || (tus.Key == ConsoleKey.Enter))
                {
                    goto cikis;
                }
                else if(tus.Key == ConsoleKey.Backspace)        // backspace basarsa son karakter silinecek
                {
                    sifre = sifre.Remove(sifre.Length-1, 1);  // remove'un ilk parametresi başlangıç indexini, ikinci parametre silinecek 
                                                              // miktarı gösterir
                    Console.Write("\b");
                }
                else
                {
                    sifre += tus.KeyChar;   // tus.KeyChar yazdım çünkü f11 falan girilirse onları saymaz keychar sadece karakterleri gösterir
                    Console.Write("*");
                }
            } while (true);
            cikis:
            Console.Write("\nSifreniz: "+sifre);
            
            Console.ReadKey();
        }
    }       
}
