#include <iostream>
#include <cstdlib>
#include <ctime>

int main()
{
    int a, b;
    std::cout << "Podaj poczatek losowanego przedzialu: ";
    std::cin >> a;

    std::cout << "Podaj koniec losowanego przedzialu: ";
    std::cin >> b;

    if (b < a)
    {
        std::cout << "Koniec przedzialu nie moze byc mniejsza liczba od jego poczatku!" << std::endl;
        return 1;
    }

    std::cout << "Teraz wylosowana bedzie liczba z przedzialu od " << a << " do " << b << std::endl;

    std::srand(std::time(nullptr));
    int ilosc_liczb_ktore_mozna_wylosowac = b - a + 1;
    int wylosowana_liczba = (rand() % ilosc_liczb_ktore_mozna_wylosowac) + a;

    std::cout << "Wylosowano liczbe" << std::endl;

    int liczba_uzytkownika;
    int ilosc_prob = 0;

    do
    {
        std::cout << "Zgaduj liczbe: ";
        std::cin >> liczba_uzytkownika;
        ilosc_prob++;

        if (liczba_uzytkownika < wylosowana_liczba)
        {
            std::cout << "Wylosowana liczba jest wieksza" << std::endl;
        }
        else if (liczba_uzytkownika > wylosowana_liczba)
        {
            std::cout << "Wylosowana liczba jest mniejsza" << std::endl;
        }
    } while (liczba_uzytkownika != wylosowana_liczba);

    std::cout << "Zgadles!" << std::endl << "Ilosc prob: " << ilosc_prob << std::endl;

    return 0;
}