using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickRandomCards
{
    class CardPicker
    {
        /// <summary>
        /// A static field that is a random number generator
        /// </summary>
        static Random _random = new Random(); 

        public static string[] PickSomeCards(int numberOfCards) 
        {
            string[] pickedCards = new string[numberOfCards];
            for (int i = 0; i < numberOfCards; i++)
            {
                pickedCards[i] = RandomValue() + " of " + RandomSuit();
            }
            return pickedCards;
        }

        /// <summary>
        /// A method that returns a random card value between 1 and 13
        /// </summary>
        /// <remarks>
        /// You can add .ToString() to any variable or value to convert it to a string.
        /// </remarks>
        /// <returns></returns>
        private static string RandomValue()
        {
            int value = _random.Next(1, 14);    // get a random number between 1 and 13

            if (value == 1) return "Ace";       // if it's 1, return Ace
            if (value == 11) return "Jack";      // if it's 2, return Jack
            if (value == 12) return "Queen";     // if it's 3, return Queen
            if (value == 13) return "King";      // if it's 4, return King

            return value.ToString();            // convert the random number to a string and return it
        }

        private static string RandomSuit()
        {
            int value = _random.Next(1, 5);     // get a random number between 1 and 4

            if (value == 1) return "Spades";    // if it's 1 return Spades
            if (value == 2) return "Hearts";    // if it's 2 return Hearts
            if (value == 3) return "Clubs";     // if it's 3 return Clubs
            return "Diamonds";                  // if it's not 1, 2, or 3, return Diamonds
        }
    }
}
