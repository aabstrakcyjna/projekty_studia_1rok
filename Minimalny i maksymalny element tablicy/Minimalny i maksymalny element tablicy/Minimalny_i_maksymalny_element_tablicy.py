tablica=[42,48,44,14,10,17,16,82,73]
print("Tablica liczb o indeksach nieparzystych")
liczby_nieparzyste=tablica[::2]
liczby_parzyste=tablica[1::2]
print(liczby_nieparzyste)
print("Tablica liczb o indeksach parzystych")
print(liczby_parzyste)
print (f"Max liczby nieparzyste:{max(liczby_nieparzyste)}")
print (f"Max liczby parzyste:{max(liczby_parzyste)}")
print(f"Min liczby nieparzyste:{min(liczby_nieparzyste)}")
print(f"Min liczby nieparzyste: {min(liczby_parzyste)}")

