using System;

enum DniTygodnia
{
    Poniedzialek,
    Wtorek,
    Sroda,
    Czwartek,
    Piatek,
    Sobota,
    Niedziela
}

enum EtapyPrania
{
    PranieWstepne,
    PranieGlowne,
    Plukanie,
    Wirowanie,
    Suszenie
}

enum Posilki
{
    Sniadanie,
    DrugieSniadanie,
    Obiad,
    Podwieczorek,
    Kolacja
}

enum BierkiSzachowe
{
    Hetman,
    Krol,
    Królowa
    Wieza,
    Goniec,
    Skoczek,
    Pion
}

class Program
{
    static void Main()
    {
        DniTygodnia dzien = DniTygodnia.Czwartek;
        EtapyPrania etap = EtapyPrania.PrzanieWstepne;
        Posilki posilek = Posilki.Obiad;
        BierkiSzachowe bierka = BierkiSzachowe.Hetman;

       
    }
}
