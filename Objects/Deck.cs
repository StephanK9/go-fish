using System.Collections.Generic;
using System;

namespace GoFish.Objects
{
    public class Deck
    {
        private string[] _suits = new string[] { "Hearts", "Clubs", "Diamonds", "Spades" };
        private string[] _values = new string[] { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
        private List<string> _cards = new List<string> {};

        public Deck()
        {

            foreach(string suit in _suits)
            {
                foreach(string valu in _values)
                {
                    string cardStuff = valu + " of " + suit;
                    _cards.Add(cardStuff);
                    Console.WriteLine(cardStuff);
                }
            }
        }
    }
}
