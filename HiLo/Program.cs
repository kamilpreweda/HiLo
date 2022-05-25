using HiLo;

Console.WriteLine("Witaj w HiLo!");
Console.WriteLine($"Odgadnij liczbę od 1 do {HiLoGame.MAXIMUM}.");
// HiLoGame.Hint();
while (HiLoGame.GetPot() > 0)
{
    Console.WriteLine("Wciśńij w (większa), m (mniejsza) lub ? (kupno wskazówki).");
    Console.WriteLine($"Inne klawisze to koniec gry z {HiLoGame.GetPot()} zł.");
    char key = Console.ReadKey(true).KeyChar;
    if (key == 'w') HiLoGame.Guess(true);
    else if (key == 'm') HiLoGame.Guess(false);
    else if (key == '?') HiLoGame.Hint();
    else return;
}
Console.WriteLine("Skończyły Ci się pieniądze. Do zobaczenia!");

