using System;

struct Przedmiot
{
    public float Waga;
    public int Wartosc;
    public string KlasaRzadkosci;
    public string Typ;
    public string NazwaWlasna;

    public void Wypelnij(float waga, int wartosc, string klasaRzadkosci, string typ, string nazwaWlasna)
    {
        Waga = waga;
        Wartosc = wartosc;
        KlasaRzadkosci = klasaRzadkosci;
        Typ = typ;
        NazwaWlasna = nazwaWlasna;
    }

    public void WyswietlInformacje()
    {
        Console.WriteLine("Przedmiot: {0}", NazwaWlasna);
        Console.WriteLine("Typ: {0}", Typ);
        Console.WriteLine("Waga: {0}", Waga);
        Console.WriteLine("Wartość: {0} sztuk złota", Wartosc);
        Console.WriteLine("Klasa rzadkości: {0}", KlasaRzadkosci);
    }
}

class Program
{
    static Random random = new Random();

    static Przedmiot WylosujPrzedmiot(Przedmiot[] przedmioty)
    {
        int sumaRzadkosci = 0;
        foreach (Przedmiot przedmiot in przedmioty)
        {
            switch (przedmiot.KlasaRzadkosci)
            {
                case "powszechny":
                    sumaRzadkosci += 1;
                    break;
                case "rzadki":
                    sumaRzadkosci += 2;
                    break;
                case "unikalny":
                    sumaRzadkosci += 3;
                    break;
                case "epicki":
                    sumaRzadkosci += 4;
                    break;
            }
        }

        int losowaSuma = random.Next(1, sumaRzadkosci + 1);
        int aktualnaSuma = 0;

        foreach (Przedmiot przedmiot in przedmioty)
        {
            switch (przedmiot.KlasaRzadkosci)
            {
                case "powszechny":
                    aktualnaSuma += 1;
                    break;
                case "rzadki":
                    aktualnaSuma += 2;
                    break;
                case "unikalny":
                    aktualnaSuma += 3;
                    break;
                case "epicki":
                    aktualnaSuma += 4;
                    break;
            }

            if (aktualnaSuma >= losowaSuma)
                return przedmiot;
        }

        return przedmioty[0];
    }

    static void Main()
    {
        Przedmiot[] przedmioty = new Przedmiot[3];

        przedmioty[0].Wypelnij(2.5f, 10, "rzadki", "broń", "Miecz Ognia");
        przedmioty[1].Wypelnij(1.
