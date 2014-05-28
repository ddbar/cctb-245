using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.GameElements
{
    // Extra data types that relate to the Card class
    enum Suit { HEARTS, DIAMONDS, CLUBS, SPADES }
    enum CardFace
    {
        Ace = 1,
        Deuce,
        Three, Four, Five, Six, Seven, Eight, Nine, Ten,
        Jack, Queen, King
    }
    
    class Card
    {

        public Suit Suit { get; private set; }
        public CardFace Face { get; private set; }
        public int FaceValue
{
    get
{
    int value = (int) Face;
    if (value > 10)
    value = 10;
    return value;
}
            //Suit SuitValue, CardFace FaceValue
}
        // prompt 

         public Card()
        {
        }

        public Card(Suit SuitValue, CardFace FaceValue)

        {
            Suit = SuitValue;
            Face = FaceValue;
        }
    } 
    
   // Console.WriteLine("The suit of the card that you have is the: " + SV + "The value of the card you have is: " + FV);
}
