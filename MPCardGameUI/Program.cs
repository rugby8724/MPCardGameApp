
using MPCardGameUI;

PokerDeck deck = new PokerDeck();

var hand = deck.DealCards();

foreach (var card in hand)
{
    Console.WriteLine($"{card.Value.ToString()} of {card.Suit.ToString()}");
}



Console.ReadLine();
