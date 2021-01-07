using System;
using System.Collections.Generic;
using System.Linq;

namespace AllCardsOnDeckCS
{
    class Program
    {
        static void Main(string[] args)
        {

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

            Console.WriteLine("This is the deck of cards:");
            Console.WriteLine(" ");

            foreach (var card in deckOfCards)
            {
                Console.WriteLine(card);
            }

            Console.WriteLine(" ");
            Console.WriteLine("Shuffling the deck...");

            for (var i = deckOfCards.Count - 1; i > 0; i--)
            {
                var randomNumber = new Random().Next(i - 1);
                var leftCard = deckOfCards[randomNumber];
                var rightCard = deckOfCards[i];

                deckOfCards[randomNumber] = rightCard;
                deckOfCards[i] = leftCard;
            }

            Console.WriteLine("This is the new shuffled deck:");
            Console.WriteLine(" ");

            foreach (var card in deckOfCards)
            {
                Console.WriteLine(card);
            }

            Console.WriteLine(" ");
            Console.WriteLine($"These are the top two cards: {deckOfCards[0]} and {deckOfCards[1]}.");
        }
    }
}

