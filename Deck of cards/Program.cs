using System;
using Deck_of_cards;

namespace MyApplication
{
    class Main_Program
    {

        public static void Main()
        {
            
            Face_Card queen_hearts = new Face_Card(Face_Card.suits.SPADES, Face_Card.colors.BLACK, Face_Card.faces.ACE);
            
            Console.WriteLine((int)queen_hearts.Color);
            Console.WriteLine(queen_hearts.Suit);
            Deck My_Deck = new Deck();


        }
    }
}