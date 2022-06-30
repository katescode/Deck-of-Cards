using System;


namespace Deck_of_cards
{

    internal class Face_Card
    {
       
        public enum suits { SPADES, HEARTS, CLUBS, DIAMONDS }
        public enum colors { RED, BLACK }
        public enum faces {  ACE = 1, TWO, THREE, FOUR, FIVE, SIX, SEVEN, EIGHT, NINE, TEN, JACK, QUEEN, KING }

        private colors color = 0;
        public colors Color
            { get { return color; } set { color = value; }}
        
        private faces face = 0;
        public faces Face
            { get { return face; } set { face = value; } }
        private suits suit = 0;
        public suits Suit
            { get { return suit; } set { suit = value; } }
        public Face_Card(suits incoming_suit, colors incoming_color, faces incoming_face)
        {
            incoming_suit = suits.HEARTS;
            incoming_color = colors.RED;
            incoming_face = faces.ACE;
        }


        // public void Set_Color(colors new_color)
        // { 
        //  if (new_color == colors.RED || new_color == colors.BLACK)
        //        color = new_color;
        //}

        // public void Get_Color()
        // { 
        // return color;
        // Console.WriteLine(color);

    }

        // public void Set_Face( string new_face)
        // {
        // if (new_face == "King" || new_face == "Jack" || new_face == "Queen"
        // }

    }

