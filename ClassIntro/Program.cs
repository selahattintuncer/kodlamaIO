using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1= new Kurs();
            kurs1.kursAdi = "C#";
            kurs1.Egitmen = "Engin";
            kurs1.izlenmeOrani = 68;
            
            Kurs kurs2 = new Kurs();
            kurs2.kursAdi = "JAVA";
            kurs2.Egitmen = "Kerem";
            kurs2.izlenmeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.kursAdi = "Pyhton";
            kurs3.Egitmen = "Selo";
            kurs3.izlenmeOrani = 80;

            //Console.WriteLine(kurs1.kursAdi + " : " + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
                Console.WriteLine(kurs.kursAdi + " : " + kurs.Egitmen);
            

        }
    }

    class Kurs
    {
        public string kursAdi { get; set; }
        public string Egitmen { get; set; }
        public int izlenmeOrani { get; set; }

    }
}
