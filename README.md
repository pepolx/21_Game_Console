# Console Game Project - 21

## Overview

Prosta gra konsolowa „21” (Blackjack) napisana w C#. Projekt zawiera logikę talii, gracza, dilera i interfejsu tekstowego.

## Co działa teraz

- Rozgrywka w pętli aż do wyczerpania talii (z bezpiecznym limitem kart na kolejną rundę).
- Dobieranie kart przez gracza (`g` + Enter).
- Automatyczna logika dilera (dobiera do minimum 17).
- Poprawne liczenie wartości ręki z obsługą Asa jako `11` lub `1` (w zależności od sytuacji).
- Podsumowanie wyniku całej sesji: wygrane gracza, wygrane dilera, remisy.

## Uruchomienie

```bash
dotnet run
```

## Struktura projektu

- `Card.cs` – definicje kart i ich bazowych wartości.
- `Deck.cs` – tworzenie i tasowanie talii.
- `Player.cs` – logika gracza i jego ręki.
- `Dealer.cs` – logika dilera i jego ręki.
- `HandValueCalculator.cs` – wspólne liczenie wartości ręki (w tym Asy).
- `ConsoleInterface.cs` – komunikaty i prezentacja w konsoli.
- `Program.cs` – pętla gry i licznik wyników sesji.

## Możliwe dalsze kroki

- ukryta karta dilera do końca tury gracza,
- obstawianie i saldo gracza,
- testy jednostkowe logiki punktacji,
- tryb symulacji wielu rozdań bez interakcji.
