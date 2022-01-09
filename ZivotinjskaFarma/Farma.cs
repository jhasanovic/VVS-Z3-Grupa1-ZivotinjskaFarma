using System;
using System.Collections.Generic;
using System.Linq;

namespace ZivotinjskaFarma
{
    public class Farma
    {
        #region Atributi

        List<Zivotinja> zivotinje;
        List<Lokacija> lokacije;
        List<Proizvod> proizvodi;
        List<Kupovina> kupovine;

        #endregion

        #region Properties

        public List<Zivotinja> Zivotinje { get => zivotinje; set => zivotinje = value; }
        public List<Lokacija> Lokacije { get => lokacije; }
        public List<Proizvod> Proizvodi { get => proizvodi; set => proizvodi = value; }
        public List<Kupovina> Kupovine { get => kupovine; }

        #endregion

        #region Konstruktor

        public Farma()
        {
            zivotinje = new List<Zivotinja>();
            lokacije = new List<Lokacija>();
            proizvodi = new List<Proizvod>();
            kupovine = new List<Kupovina>();
        }

        #endregion

        #region Metode


        public void RadSaZivotinjama(string opcija, Zivotinja zivotinja, int maxStarost)
        {
            if (zivotinje.Count > 0)
            {
                Zivotinja postojeca = null;
                foreach (Zivotinja z in zivotinje)
                {
                    Zivotinja z2 = null;
                    if (z.ID1 == zivotinja.ID1)
                        z2 = z;
                    if (z2 != null)
                    {
                        if (maxStarost * 365 > z2.Starost.Year)
                            postojeca = z2;
                    }
                }

                if (opcija == "Dodavanje")
                    if (postojeca == null)
                        zivotinje.Add(zivotinja);
                    else
                        throw new ArgumentException("Životinja je već registrovana u bazi!");

                else if (opcija == "Izmjena")
                    if (postojeca != null)
                    {
                        var index = zivotinje.IndexOf(postojeca);
                        zivotinje.RemoveAt(index);
                        zivotinje.Add(zivotinja);
                    }
                    else
                        throw new ArgumentException("Životinja nije registrovana u bazi!");

                else if (opcija == "Brisanje")
                    if (postojeca != null)
                        zivotinje.Remove(postojeca);
                    else
                        throw new ArgumentException("Životinja nije registrovana u bazi!");

                else if (postojeca == null)
                    throw new ArgumentException("Životinja nije registrovana u bazi!");

                else
                    throw new ArgumentException("Životinja je već registrovana u bazi!");

            }

            else
                return;
        }

        // code tuning 1 radio Dautović Hamza
        public void RadSaZivotinjamaTuning1(string opcija, Zivotinja zivotinja, int maxStarost)
        {
            if (zivotinje.Count > 0)
            {
                Zivotinja postojeca = null;
                Zivotinja z2 = null;
                int max = maxStarost * 365;
                foreach (Zivotinja z in zivotinje)
                {
                    if (z.ID1 == zivotinja.ID1)
                        z2 = z;
                    if (z2 != null)
                    {
                        if (max > z2.Starost.Year)
                            postojeca = z2;
                        break;
                    }
                }

                if (opcija == "Dodavanje")
                    if (postojeca == null)
                        zivotinje.Add(zivotinja);
                    else
                        throw new ArgumentException("Životinja je već registrovana u bazi!");

                else if (opcija == "Izmjena")
                    if (postojeca != null)
                    {
                        var index = zivotinje.IndexOf(postojeca);
                        zivotinje.RemoveAt(index);
                        zivotinje.Add(zivotinja);
                    }
                    else
                        throw new ArgumentException("Životinja nije registrovana u bazi!");

                else if (opcija == "Brisanje")
                    if (postojeca != null)
                        zivotinje.Remove(postojeca);
                    else
                        throw new ArgumentException("Životinja nije registrovana u bazi!");

                else if (postojeca == null)
                    throw new ArgumentException("Životinja nije registrovana u bazi!");

                else
                    throw new ArgumentException("Životinja je već registrovana u bazi!");

            }

            else
                return;
        }
        // code tuning 2 radila Selma Hadžijusufović
        public void RadSaZivotinjamaTuning2(string opcija, Zivotinja zivotinja, int maxStarost)
        {
            if (zivotinje.Count > 0)
            {
                Zivotinja postojeca = null;
                Zivotinja z2 = null;
                int max = maxStarost * 365;
                for (int i = 0; i < zivotinje.Count; i += 4)
                {
                    
                        int ID1 = zivotinje[i].ID1;
                        int ID2 = zivotinje[i + 1].ID1;
                        int ID3 = zivotinje[i + 2].ID1;
                        int ID4 = zivotinje[i + 3].ID1;

                        int indeks = -1;

                        if (zivotinja.ID1 == ID1)
                            indeks = i;
                        else if (zivotinja.ID1 == ID2)
                            indeks = i + 1;
                        else if (zivotinja.ID1 == ID3)
                            indeks = i + 2;
                        else if (zivotinja.ID1 == ID4)
                            indeks = i + 3;


                        if (indeks != -1)
                            z2 = zivotinje[indeks];

                        if (z2 != null)
                        {
                            if (max > z2.Starost.Year)
                                postojeca = z2;
                            break;
                        }
                    }
                
                if (opcija == "Dodavanje")
                    if (postojeca == null)
                        zivotinje.Add(zivotinja);
                    else
                        throw new ArgumentException("Životinja je već registrovana u bazi!");

                else if (opcija == "Izmjena")
                    if (postojeca != null)
                    {
                        var index = zivotinje.IndexOf(postojeca);
                        zivotinje.RemoveAt(index);
                        zivotinje.Add(zivotinja);
                    }
                    else
                        throw new ArgumentException("Životinja nije registrovana u bazi!");

                else if (opcija == "Brisanje")
                    if (postojeca != null)
                        zivotinje.Remove(postojeca);
                    else
                        throw new ArgumentException("Životinja nije registrovana u bazi!");

                else if (postojeca == null)
                    throw new ArgumentException("Životinja nije registrovana u bazi!");

                else
                    throw new ArgumentException("Životinja je već registrovana u bazi!");

            }

            else
                return;
        }

        // code tuning 3 radila Jasmina Hasanović
        public void RadSaZivotinjamaTuning3(string opcija, Zivotinja zivotinja, int maxStarost)
        {
            if (zivotinje.Count == 0) return;

            Zivotinja postojeca = null;
            Zivotinja z2 = null;

            int max = 0;
            for (int i = 0; i < 365; i++)
                max += maxStarost;

             for (int i = 0; i < zivotinje.Count; i += 5)
                {
                    int ID1 = zivotinje[i].ID1;
                    int ID2 = zivotinje[i + 1].ID1;
                    int ID3 = zivotinje[i + 2].ID1;
                    int ID4 = zivotinje[i + 3].ID1;
                    int ID5 = zivotinje[i + 4].ID1;

                    int indeks = -1;

                    if (zivotinja.ID1 == ID1)
                        indeks = i;
                    else if (zivotinja.ID1 == ID2)
                        indeks = i + 1;
                    else if (zivotinja.ID1 == ID3)
                        indeks = i + 2;
                    else if (zivotinja.ID1 == ID4)
                        indeks = i + 3;
                    else if (zivotinja.ID1 == ID5)
                        indeks = i + 4;

                    if (indeks != -1)
                        z2 = zivotinje[indeks];

                    if (z2 != null)
                    {
                        if (max > z2.Starost.Year)
                            postojeca = z2;
                        break;
                    }
                }

                //if (indeks != -1)
                // z2 = zivotinje[indeks];

                /*if (z2 != null)
                    {
                        if (max > z2.Starost.Year)
                            postojeca = z2;
                        break;
                    }
                }*/

                if (opcija == "Dodavanje")
                    if (postojeca == null)
                        zivotinje.Add(zivotinja);
                    else
                        throw new ArgumentException("Životinja je već registrovana u bazi!");

                else if (opcija == "Izmjena")
                    if (postojeca != null)
                    {
                        var index = zivotinje.IndexOf(postojeca);
                        zivotinje.RemoveAt(index);
                        zivotinje.Add(zivotinja);
                    }
                    else
                        throw new ArgumentException("Životinja nije registrovana u bazi!");

                else if (opcija == "Brisanje")
                    if (postojeca != null)
                        zivotinje.Remove(postojeca);
                    else
                        throw new ArgumentException("Životinja nije registrovana u bazi!");

                else if (postojeca == null)
                    throw new ArgumentException("Životinja nije registrovana u bazi!");

                else
                    throw new ArgumentException("Životinja je već registrovana u bazi!");
            }

        public void RadSaZivotinjamaRefaktor(IDoAction action, Zivotinja zivotinja, int maxStarost)
        {
            if (zivotinje.Count > 0)
            {
                Zivotinja postojeca = null;
                foreach (Zivotinja z in zivotinje)
                {
                    Zivotinja z2 = null;
                    if (z.ID1 == zivotinja.ID1)
                        z2 = z;
                    if (z2 != null)
                    {
                        if (maxStarost * 365 > z2.Starost.Year)
                            postojeca = z2;
                    }
                }

                action.doAction(zivotinje, zivotinja, postojeca);

            }

            else
                return;
        }

        public void DodavanjeNoveLokacije(Lokacija lokacija)
        {
            if (lokacije.Any(l => l.Grad == lokacija.Grad && l.Adresa == lokacija.Adresa
                        && l.BrojUlice == lokacija.BrojUlice))
                throw new InvalidOperationException("Ista lokacija je već zabilježena!");
            lokacije.Add(lokacija);
        }

        public bool BrisanjeLokacije(Lokacija lokacija)
        {
            return lokacije.Remove(lokacija);
        }

        public bool KupovinaProizvoda(Proizvod p, DateTime rok, int količina)
        {
            bool popust = Praznik(DateTime.Now);
            int id = Kupovina.DajSljedeciBroj();
            Kupovina kupovina = new Kupovina(id.ToString(), DateTime.Now, rok, p, količina, popust);

            if (!kupovina.VerificirajKupovinu())
                return false;
            else
            {
                Kupovina postojecaKupovina = null;
                for (int i = 0; i < kupovine.Count; i++)
                {
                    if (kupovine[i].DatumKupovine == kupovina.DatumKupovine)
                    {
                        if (kupovine[i].IDKupca1 == kupovina.IDKupca1)
                        {
                            if (kupovine[i].KupljeniProizvod == kupovina.KupljeniProizvod)
                                postojecaKupovina = kupovine[i];
                            else
                                continue;
                        }
                    }
                }

                if (postojecaKupovina == null)
                    kupovine.Add(kupovina);
                else
                    return false;

                return true;
            }
        }


        public bool KupovinaProizvodaRefaktor(Proizvod p, DateTime rok, int količina)
        {
            bool popust = Praznik(DateTime.Now);
            int id = Kupovina.DajSljedeciBroj();
            Kupovina kupovina = new Kupovina(id.ToString(), DateTime.Now, rok, p, količina, popust);
            if (!kupovina.VerificirajKupovinu())
                return false;
            return daLiPostojiKupovina(kupovina);

        }

        private bool daLiPostojiKupovina(Kupovina kupovina)
        {

            for (int i = 0; i < kupovine.Count; i++)
            {
                if (provjeriKupovinu(kupovina, i))
                {
                    return false;

                }
            }
            kupovine.Add(kupovina);
            return true;

        }
        private bool provjeriKupovinu(Kupovina kupovina, int i)
        {
            return kupovine[i].DatumKupovine == kupovina.DatumKupovine &&
                   kupovine[i].IDKupca1 == kupovina.IDKupca1 &&
                   kupovine[i].KupljeniProizvod == kupovina.KupljeniProizvod;
        }

        public void BrisanjeKupovine(Kupovina kupovina)
        {
            if (kupovine.Contains(kupovina))
                kupovine.Remove(kupovina);
        }

        public void ObaviSistematskiPregled(List<List<string>> informacije)
        {
            int i = 0;
            foreach (var zivotinja in zivotinje)
            {
                zivotinja.PregledajZivotinju(informacije[i].ElementAt(0), informacije[i].ElementAt(1), informacije[i].ElementAt(2));
                i++;
            }
        }

        public static bool Praznik(DateTime datum)
        {
            List<List<int>> praznici = new List<List<int>>()
            {
                new List<int>() { 01, 01 },
                new List<int>() { 01, 03 },
                new List<int>() { 01, 05 },
                new List<int>() { 25, 11 },
                new List<int>() { 31, 12 }
            };

            List<int> dan = new List<int>()
            { datum.Day, datum.Month };

            return praznici.Find(datum => datum[0] == dan[0] && datum[1] == dan[1]) != null;
        }

        #endregion
    }
    public interface IDoAction
    {
        public void doAction(List<Zivotinja> zivotinje, Zivotinja zivotinja, Zivotinja postojeca);
    }
    class Dodavanje : IDoAction
    {
        public void doAction(List<Zivotinja> zivotinje, Zivotinja zivotinja, Zivotinja postojeca)
        {
            if (postojeca == null)
                zivotinje.Add(zivotinja);
            else
                throw new ArgumentException("Životinja je već registrovana u bazi!");
        }
    }
    class Izmjena : IDoAction
    {
        public void doAction(List<Zivotinja> zivotinje, Zivotinja zivotinja, Zivotinja postojeca)
        {
            if (postojeca != null)
            {
                var index = zivotinje.IndexOf(postojeca);
                zivotinje.RemoveAt(index);
                zivotinje.Add(zivotinja);
            }
            else
                throw new ArgumentException("Životinja nije registrovana u bazi!");
        }
    }
    class Brisanje : IDoAction
    {
        public void doAction(List<Zivotinja> zivotinje, Zivotinja zivotinja, Zivotinja postojeca)
        {
            if (postojeca != null)
                zivotinje.Remove(postojeca);
            else
                throw new ArgumentException("Životinja nije registrovana u bazi!");
        }
    }
    class Greska : IDoAction
    {
        public void doAction(List<Zivotinja> zivotinje, Zivotinja zivotinja, Zivotinja postojeca)
        {
            if (postojeca == null)
                throw new ArgumentException("Životinja nije registrovana u bazi!");
            else
                throw new ArgumentException("Životinja je već registrovana u bazi!");

        }
    }
}
