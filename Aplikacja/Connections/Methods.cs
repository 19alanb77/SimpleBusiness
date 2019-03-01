using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Connections
{
    public class Methods
    {
        public static IEnumerable<Pracownicy> getPracownicy()
        {
            return Connections.Connection.Read<Pracownicy>("PobierzPracownikow");
        }

        public static IEnumerable<Zadania> getZadania()
        {
            return Connections.Connection.Read<Zadania>("PobierzZadania");
        }

        public static IEnumerable<Faktury> getFaktury()
        {
            return Connections.Connection.Read<Faktury>("PobierzFaktury");
        }

        public static IEnumerable<Statystyki> getStatystyki()
        {
            return Connections.Connection.Read<Statystyki>("PobierzStatystyki");
        }

        public static IEnumerable<Statystyki> getMiesiac()
        {
            return Connections.Connection.Read<Statystyki>("PobierzMiesiac");
        }

        public static IEnumerable<SzczegolyFaktury> getSzczegolyFaktur()
        {
            return Connections.Connection.Read<SzczegolyFaktury>("PobierzSzczegolyFaktury");
        }

        public static IEnumerable<Produkty> getProdukty()
        {
            return Connections.Connection.Read<Produkty>("PobierzProdukty");
        }

        public static IEnumerable<KategorieProduktow> getKategorieProduktow()
        {
            return Connections.Connection.Read<KategorieProduktow>("PobierzKategorieProduktow");
        }

        public static int dodajPracownika(string imie, string nazwisko, string nazwaStanowiska, string pesel, float zarobkiMiesieczne, string email, string telefon)
        {
            return Connections.Connection.Insert<int>("DodajPracownika", new { Imie = imie, Nazwisko = nazwisko, NazwaStanowiska = nazwaStanowiska, PESEL = pesel, ZarobkiMiesieczne = zarobkiMiesieczne, Email = email, Telefon = telefon });
        }

        public static int dodajZadanie(string nazwaPracownika, string dataWykonania, string tresc)
        {
            return Connections.Connection.Insert<int>("DodajZadanie", new { NazwaPracownika = nazwaPracownika, DataWykonania = dataWykonania, Tresc = tresc });
        }

        public static int dodajProdukt(string nazwaProduktu, float ilosc, float cenaDetaliczna, float cenaHurtowa, string nazwaKategorii, string dataWaznosci)
        {
            return Connections.Connection.Insert<int>("DodajProdukt", new { NazwaProduktu = nazwaProduktu, Ilosc = ilosc, CenaDetaliczna = cenaDetaliczna, CenaHurtowa = cenaHurtowa, NazwaKategorii = nazwaKategorii, DataWaznosci = dataWaznosci });
        }

        public static int dodajDoFaktury(string numerFaktury, string nazwaProduktu, float ilosc, float stawkaVAT)
        {
            return Connections.Connection.Insert<int>("DodajDoFaktury", new { NumerFaktury = numerFaktury, NazwaProduktu = nazwaProduktu, Ilosc = ilosc, StawkaVAT = stawkaVAT });
        }

        public static int dodajFakture(string numerFaktury, string nazwaWystawiajacego, string dataWystawienia, string nazwaNabywcy, string adresNabywcy, string numerNIP)
        {
            return Connections.Connection.Insert<int>("DodajFakture", new { NumerFaktury = numerFaktury, NazwaWystawiajacego = nazwaWystawiajacego, DataWystawienia = dataWystawienia, NazwaNabywcy = nazwaNabywcy, AdresNabywcy = adresNabywcy, NumerNIP = numerNIP });
        }

        public static int usunProdukt(string produkt, float ilosc)
        {
            return Connections.Connection.Remove<int>("UsunProdukt", new { Produkt = produkt, Ilosc = ilosc });
        }

        public static int usunPracownika(string nazwaPracownika)
        {
            return Connections.Connection.Remove<int>("UsunPracownika", new { NazwaPracownika = nazwaPracownika });
        }

        public static int usunZadanie(string trescZadania)
        {
            return Connections.Connection.Remove<int>("UsunZadanie", new { TrescZadania = trescZadania });
        }

        public static int usunFakture(string numerFaktury)
        {
            return Connections.Connection.Remove<int>("UsunFakture", new { NumerFaktury = numerFaktury });
        }

        public static int usunSzczegolyFaktury(string nazwaProduktu, string numerFaktury, float ilosc)
        {
            return Connections.Connection.Remove<int>("UsunSzczegolyFaktury", new { NazwaProduktu = nazwaProduktu, NumerFaktury = numerFaktury, Ilosc = ilosc });
        }

        public static IEnumerable<float> dodajNettoDoFaktury(string produkt, float ilosc)
        {
            return Connections.Connection.Function<float>("select [dbo].[DodajNettoDoFaktury](@Produkt,@Ilosc)", new {Produkt = produkt, Ilosc = ilosc });
        }

        public static IEnumerable<float> dodajZyskDoFaktury(string produkt, float ilosc)
        {
            return Connections.Connection.Function<float>("select [dbo].[DodajZyskDoFaktury](@Produkt,@Ilosc)", new { Produkt = produkt, Ilosc = ilosc });
        }

        public static IEnumerable<int> sprawdzHaslo(string haslo)
        {
            return Connections.Connection.Function<int>("select [dbo].[SprawdzHaslo](@Haslo)", new { Haslo = haslo });
        }

        public static int zmienHaslo(string stareHaslo, string noweHaslo, string powtorzHaslo)
        {
            return Connections.Connection.Update<int>("ZmienHaslo", new { StareHaslo = stareHaslo, NoweHaslo = noweHaslo, PowtorzHaslo = powtorzHaslo });
        }

        public static IEnumerable<Faktury> znajdzDzien(string miesiac)
        {
            return Connections.Connection.ReadById<Faktury>("ZnajdzDzien", new { Miesiac = miesiac });
        }

        public static IEnumerable<Produkty> krotkaWaznosc()
        {
            return Connections.Connection.Read<Produkty>("KrotkaWaznosc");
        }

        public static IEnumerable<Produkty> najwiekszyZarobek()
        {
            return Connections.Connection.Read<Produkty>("NajwiekszyZarobek");
        }

        public static int zwiekszProdukt(string produkt, float ilosc)
        {
            return Connections.Connection.Update<int>("ZwiekszProdukt", new { Produkt = produkt, Ilosc = ilosc });
        }

        public static IEnumerable<float> obliczPrzychod(int miesiac)
        {
            return Connections.Connection.Function<float>("select [dbo].[ObliczPrzychod](@Miesiac)", new { Miesiac = miesiac });
        }

        public static IEnumerable<float> obliczWydatki()
        {
            return Connections.Connection.Function<float>("select [dbo].[ObliczWydatki]()",new { } );
        }

        public static IEnumerable<float> obliczDochodBrutto(float przychod, float wydatki)
        {
            return Connections.Connection.Function<float>("select [dbo].[ObliczDochodBrutto](@Przychod,@Wydatki)", new {Przychod = przychod, Wydatki = wydatki });
        }

        public static IEnumerable<float> obliczDochodNetto(float brutto)
        {
            return Connections.Connection.Function<float>("select [dbo].[ObliczDochodNetto](@Brutto)", new { Brutto = brutto });
        }

        public static int dodajStatystki(string miesiac, float zysk)
        {
            return Connections.Connection.Insert<int>("DodajStatystyki", new { Miesiac = miesiac, Zysk = zysk });
        }

        public static IEnumerable<PracownicyView> GetPracownicyView()
        {
            return Connections.Connection.ReadView<PracownicyView>("select * from PracownicyView");
        }

        public static IEnumerable<ProduktyView> GetProduktyView()
        {
            return Connections.Connection.ReadView<ProduktyView>("select * from ProduktyView");
        }

        public static IEnumerable<StanowiskaView> GetStanowiskaView()
        {
            return Connections.Connection.ReadView<StanowiskaView>("select * from StanowiskaView");
        }

        public static IEnumerable<FakturaView> GetFakturaView()
        {
            return Connections.Connection.ReadView<FakturaView>("select * from FakturaView");
        }
    }
}
