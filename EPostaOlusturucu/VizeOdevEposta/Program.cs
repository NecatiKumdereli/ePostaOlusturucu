using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VizeOdevEposta
{
    public class Program
    {
        static void Main(string[] args)
        {
            ePostaOlusturucu ePostaOlusturucu = new BrosurEpostaOlusturucu();
            ePosta ePosta = ePostaOlusturucu.ePostaOlustur();
            Console.WriteLine("Çıkış Haberi :" +ePosta.cıkısHaberi());
            Console.WriteLine("İleti Haberi :" + ePosta.iletmeMesajı());
            Console.WriteLine("Alıcı  :" + ePosta.alici());
            Console.WriteLine("\n");
            ePostaOlusturucu = new HaberEpostaOlusturucu();
            ePosta ePosta1 = ePostaOlusturucu.ePostaOlustur();
            Console.WriteLine("Çıkış Haberi :" + ePosta1.cıkısHaberi());
            Console.WriteLine("İleti Haberi :" + ePosta1.iletmeMesajı());
            Console.WriteLine("Alıcı  :" + ePosta.alici());
            Console.WriteLine("\n");
            ePostaOlusturucu = new KampanyaEpostaOlusturucu();
            ePosta ePosta2 = ePostaOlusturucu.ePostaOlustur();
            Console.WriteLine("Çıkış Haberi :" + ePosta2.cıkısHaberi());
            Console.WriteLine("İleti Haberi :" + ePosta2.iletmeMesajı());
            Console.WriteLine("Alıcı  :" + ePosta2.alici());

            Console.Read();

        }
    }
}
