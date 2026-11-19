Specyfikacja Minutnika

1. 
    - Odmierza czas wstecz od ustalonej wartości (minuty i sekundy).
    - Posiada przyciski Start, Pauza oraz Reset.
    - Wyświetla aktualny stan odliczania na ekranie.

2. 
    - Nie obsługuje dźwięków ani alarmów po zakończeniu czasu.
    - Nie pozwala na zapisywanie historii ani własnych predefiniowanych czasów.
    - Nie działa w tle po zamknięciu karty w przeglądarce.

3.
    1. Kiedy klikniesz przycisk Start, to minutnik zaczyna odmierzać czas w dół co sekundę.
    2. Kiedy klikniesz przycisk Pauza, to odliczanie natychmiast się zatrzymuje, zachowując aktualny czas.
    3. Kiedy klikniesz przycisk Reset, to licznik wraca do wartości początkowej.
    4. Kiedy czas dojdzie do zera, to minutnik zatrzymuje się i sygnalizuje koniec odliczania.
    5. Kiedy odświeżysz stronę w trakcie odliczania, to licznik resetuje się do stanu początkowego.

4. Do ustalenia
    - Czy po zakończeniu czasu powinien włączać się dźwięk?
    - Jaki ma być domyślny czas startowy (np. 5 minut czy 25 minut jak w Pomodoro)?

---

Uzupełnienie (Po porównaniu z 7 zasadami)
- **Zasady odtworzone z pamięci:** Z siedmiu kluczowych zasad udało się poprawnie odtworzyć strukturę wymagań funkcjonalnych oraz ograniczeń (co aplikacja robi i czego nie robi).
- **Sytuacja nieobjęta zasadami:** Program zachowuje się specyficznie w sytuacji, gdy kliknie się Reset w trakcie trwania zaplanowanej przerwy (licznik cykli resetuje się całkowicie, o czym żadna z podstawowych zasad tworzenia specyfikacji nie wspomniała bezpośrednio).