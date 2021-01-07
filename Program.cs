using System;
using System.Collections.Generic;
using System.Linq;

namespace AllCardsOnDeckCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to 'All Cards On Deck'");

            var deckOfCards = new List<string>();

            var ranks = new List<string>() { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
            var suits = new List<string>() { "Clubs", "Diamonds", "Hearts", "Spades" };

            for (var i = 0; i < ranks.Count; i++)
            {
                for (var j = 0; j < suits.Count; j++)
                {
                    deckOfCards.Add($"{ranks[i]} of {suits[j]}");
                }
            }
            Console.WriteLine("This is the deck of cards");

            foreach (var card in deckOfCards)
            {
                Console.WriteLine(card);
            }
        }
    }
}

