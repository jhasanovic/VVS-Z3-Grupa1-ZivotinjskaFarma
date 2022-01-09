using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using ZivotinjskaFarma;

namespace Test
{
    /// <summary>
    /// Testovi za potpuni obuhvat odluka
    /// -Jasmina Hasanović
    /// </summary>
    [TestClass]
    public class TestZ3
    {
        List<string> parametri = new List<string>();
        Lokacija l;
        Zivotinja z;
        Proizvod p;

        Farma f;

        [TestInitialize]
        public void Inicijalizacija()
        {
            List<string> parametri = new List<string>();
            parametri.Add("Naziv");
            parametri.Add("Adresa");
            parametri.Add("12");
            parametri.Add("Sarajevo");
            parametri.Add("71000");
            parametri.Add("Bosna i Hercegovina");
            l = new Lokacija(parametri, 100);
            z = new Zivotinja(ZivotinjskaVrsta.Krava, System.DateTime.Now.AddDays(-500), 100, 100, l);
            p = new Proizvod("", "", "Mlijeko", z, System.DateTime.Now.AddDays(-5), System.DateTime.Now.AddDays(5), 100);
            f = new Farma();
        }
        /*
                /// <summary>
                /// if #1 true, return false (1-2-10)
                /// </summary>
                [TestMethod]
                public void TestUslovi1()
                {
                    Assert.IsFalse(f.KupovinaProizvoda(p, System.DateTime.Now.AddDays(5), 60));
                }

                /// <summary>
                /// if #1 false, for petlja, i < kupovine.Count false (0 prolaza), if #5 true, return true (1-3-7-8-10)
                /// </summary>
                [TestMethod]
                public void TestUslovi2()
                {
                    //kupovine.Count=0
                    Assert.IsTrue(f.KupovinaProizvoda(p, System.DateTime.Now.AddDays(5), 10));
                }


                /// <summary>
                /// if #1 false, for petlja, i < kupovine.Count true (barem 1 prolaz), if #2 false, if #5 true, return true (1-3-4-3-7-8-10)
                /// </summary>
                [TestMethod]
                public void TestUslovi3()
                {
                    //kupovine.Count=0
                    f.KupovinaProizvoda(p, System.DateTime.Now.AddDays(5), 10);
                    //kupovine.Count=1
                    Assert.IsTrue(f.KupovinaProizvoda(p, System.DateTime.Now.AddDays(5), 10));
                }

                */
        //Testovi za potpuni obuhvat uslova
        //Selma Hadžijusufović
        [TestMethod]
        public void TestUslovi1()
        {
            //verificiraj kupovinu 
            Assert.IsFalse(f.KupovinaProizvoda(p, System.DateTime.Now.AddDays(5), 55));
}

        [TestMethod]

        public void TestUslovi2()
        {
            //Datumi kupovine različiti
            List<string> parametri = new List<string>();
            parametri.Add("Naziv");
            parametri.Add("Adresa");
            parametri.Add("12");
            parametri.Add("Sarajevo");
            parametri.Add("71000");
            parametri.Add("Bosna i Hercegovina");
            l = new Lokacija(parametri, 100);
            z = new Zivotinja(ZivotinjskaVrsta.Kokoška, System.DateTime.Now.AddDays(-500), 100, 100, l);
            p = new Proizvod("", "", "Jaja", z, System.DateTime.Now.AddDays(-5), System.DateTime.Now.AddDays(5), 100);
            Kupovina kupovina = new Kupovina(1.ToString(), DateTime.Now, DateTime.Now.AddDays(5), p, 10, false);
            f.Kupovine.Add(kupovina);
            Assert.IsTrue(f.KupovinaProizvoda(p, System.DateTime.Now.AddDays(5), 10));
        }
        [TestMethod]

        public void TestUslovi3()
        {
            //Nema zabilježenih kupovina, provjera uslova da je postojecaKupovina == null
            Assert.IsTrue(f.KupovinaProizvoda(p, System.DateTime.Now.AddDays(5), 10));
        }






    }
}
