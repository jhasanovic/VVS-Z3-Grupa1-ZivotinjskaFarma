using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ZivotinjskaFarma;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPocetni()
        {
            Farma f = new Farma();
            List<string> parametri = new List<string>();
            parametri.Add("naziv");
            parametri.Add("Adresa");
            parametri.Add("Mostar");
            parametri.Add("10001");
            parametri.Add("Bosna i Hercegovina");

            Lokacija l = new Lokacija(parametri, 100);
            List<Zivotinja> zivotinje = new List<Zivotinja>();
            Zivotinja z = new Zivotinja(ZivotinjskaVrsta.Ovca, System.DateTime.Now.AddDays(-500), 100, 120, l);

            for (int i = 0; i < 5000000; i++)
            {

                zivotinje.Add(new Zivotinja(ZivotinjskaVrsta.Krava, System.DateTime.Now.AddDays(-500), 1, 120, l));

            }
            zivotinje.Add(z);

            for (int i = 0; i < 4999999; i++)
            {

                zivotinje.Add(new Zivotinja(ZivotinjskaVrsta.Krava, System.DateTime.Now.AddDays(-500), 1, 120, l));

            }
            f.Zivotinje = zivotinje;


            for (int i = 0; i < 63; i++)
            {
                f.RadSaZivotinjama("Izmjena", z, 10);
            }


            f.Zivotinje = null;

        }
        // code tuning 1 radio Dautović Hamza
        [TestMethod]
        public void TestCodeTuning1()
        {
            Farma f = new Farma();
            List<string> parametri = new List<string>();
            parametri.Add("naziv");
            parametri.Add("Adresa");
            parametri.Add("Mostar");
            parametri.Add("10001");
            parametri.Add("Bosna i Hercegovina");

            Lokacija l = new Lokacija(parametri, 100);
            List<Zivotinja> zivotinje = new List<Zivotinja>();
            Zivotinja z = new Zivotinja(ZivotinjskaVrsta.Ovca, System.DateTime.Now.AddDays(-500), 100, 120, l);

            for (int i = 0; i < 5000000; i++)
            {

                zivotinje.Add(new Zivotinja(ZivotinjskaVrsta.Krava, System.DateTime.Now.AddDays(-500), 1, 120, l));

            }
            zivotinje.Add(z);

            for (int i = 0; i < 4999999; i++)
            {

                zivotinje.Add(new Zivotinja(ZivotinjskaVrsta.Krava, System.DateTime.Now.AddDays(-500), 1, 120, l));

            }
            f.Zivotinje = zivotinje;

            for (int i = 0; i < 136; i++)
            {

                f.RadSaZivotinjamaTuning1("Izmjena", z, 10);

            }
            f.Zivotinje = null;

        }
        // code tuning 2 radila Selma Hadžijusufović
        [TestMethod]
        public void TestCodeTuning2()
        {
            Farma f = new Farma();
            List<string> parametri = new List<string>();
            parametri.Add("naziv");
            parametri.Add("Adresa");
            parametri.Add("Mostar");
            parametri.Add("10001");
            parametri.Add("Bosna i Hercegovina");

            Lokacija l = new Lokacija(parametri, 100);
            List<Zivotinja> zivotinje = new List<Zivotinja>();
            Zivotinja z = new Zivotinja(ZivotinjskaVrsta.Ovca, System.DateTime.Now.AddDays(-500), 100, 120, l);

            for (int i = 0; i < 5000000; i++)
            {

                zivotinje.Add(new Zivotinja(ZivotinjskaVrsta.Krava, System.DateTime.Now.AddDays(-500), 1, 120, l));

            }
            zivotinje.Add(z);

            for (int i = 0; i < 4999999; i++)
            {

                zivotinje.Add(new Zivotinja(ZivotinjskaVrsta.Krava, System.DateTime.Now.AddDays(-500), 1, 120, l));

            }

            f.Zivotinje = zivotinje;
            
            for (int i = 0; i < 136; i++)
            {

                f.RadSaZivotinjamaTuning2("Izmjena", z, 10);

            }
           
            f.Zivotinje = null;

        }

        // code tuning 3 radila Jasmina Hasanović
        [TestMethod]
        public void TestCodeTuning3()
        {
            Farma f = new Farma();
            List<string> parametri = new List<string>();
            parametri.Add("naziv");
            parametri.Add("Adresa");
            parametri.Add("Mostar");
            parametri.Add("10001");
            parametri.Add("Bosna i Hercegovina");

            Lokacija l = new Lokacija(parametri, 100);
            List<Zivotinja> zivotinje = new List<Zivotinja>();
            Zivotinja z = new Zivotinja(ZivotinjskaVrsta.Ovca, System.DateTime.Now.AddDays(-500), 100, 120, l);

            for (int i = 0; i < 5000000; i++)
            {

                zivotinje.Add(new Zivotinja(ZivotinjskaVrsta.Krava, System.DateTime.Now.AddDays(-500), 1, 120, l));

            }
            zivotinje.Add(z);

            for (int i = 0; i < 4999999; i++)
            {

                zivotinje.Add(new Zivotinja(ZivotinjskaVrsta.Krava, System.DateTime.Now.AddDays(-500), 1, 120, l));

            }
            f.Zivotinje = zivotinje;


            for (int i = 0; i < 63; i++) //granica petlje smanjena da bi izvršavanje početnog testa bilo oko 30s
            {

                f.RadSaZivotinjamaTuning3("Izmjena", z, 10);

            }

            f.Zivotinje = null;

        }
    }
}
