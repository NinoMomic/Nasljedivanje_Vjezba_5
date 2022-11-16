using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nasljedjivanje_ponavljanje
{
    class GeometrijskiLik
    {
        int brojStranica;
        double[] stranice = new double[10];

        public void UcitajStranice()
        {
            for (int i = 0; i < BrojStranica; i++)
            {
                Console.WriteLine("Upišite duljinu {0} stranice: ",
                    i + 1);
                string s = Console.ReadLine();
                stranice[i] = Convert.ToDouble(s);
            }

        }

        public double Opseg()
        {
            double opseg = 0;
            for (int i = 0; i < BrojStranica; i++)
            {
                opseg += stranice[i];
            }
            return opseg;
        }

        public int BrojStranica { get => BrojStranica; set => BrojStranica = value; }
        public double[] Stranice { get => stranice; set => stranice = value; }
    }

    class Trokut : GeometrijskiLik
    {
        public Trokut()
        {
            BrojStranica = 3;
        }
    }

    class Cetverokut : GeometrijskiLik
    {
        public Cetverokut()
        {
            BrojStranica = 4;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Izračunavanje opsega trokuta" +
                "i četverokuta\r\n");
            Trokut trokut = new Trokut();
            Console.WriteLine("Upiši duljine stranica trokuta\r\n");
            trokut.UcitajStranice();
            Console.WriteLine("Opseg trokuta je: {0}",
                trokut.Opseg());

            Cetverokut cetverokut = new Cetverokut();
            Console.WriteLine("Upiši duljine stranica četverokuta\r\n");
            cetverokut.UcitajStranice();
            Console.WriteLine("Opseg četverokuta je: {0}",
                cetverokut.Opseg());

            Console.ReadKey();
        }
    }
}
