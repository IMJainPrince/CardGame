﻿using System.Collections.Generic;
using System.Linq;

namespace CardGameConsole
{
    public class Player
    {
        public string Name { get; set; }
        public Queue<Card> Deck { get; set; }       

        public Player(string name)
        {
            Name = name;
        }

        public Queue<Card> Deal(Queue<Card> cards)
        {
            Queue<Card> player1cards = new Queue<Card>();
            Queue<Card> player2cards = new Queue<Card>();

            int counter = 2;
            while (cards.Any())
            {
                if (counter % 2 == 0) //Card etiquette says the player who is NOT the dealer gets first card
                {
                    player2cards.Enqueue(cards.Dequeue());
                }
                else
                {
                    player1cards.Enqueue(cards.Dequeue());
                }
                counter++;
            }

            Deck = player1cards;
            return player2cards;
        }
    }


}
