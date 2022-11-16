using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasljedivanje_Ponavljanje
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }

    class GeometrijskiLik
    {
        int BrojStranica;
        double[] Stranice = new double[10];

        public void UcitajStranice()
        {
            for (int i = 0; i < BrojStranica; i++)
            {
                Console.WriteLine("Upišite duljinu stranice "+i);
                string s = Console.ReadLine();
                Stranice[i] = Convert.ToDouble(s);
            }

        }

        public double Opseg()
        {
            double Opseg = 0;
            for (int i = 0; i <= BrojStranica; i++)
            Opseg = +Stranice[i]; 
            return Opseg;
        }
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
        public Cetverokut ()
        {
            BrojStranica = 4;   
        }
    }
}
