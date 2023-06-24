using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickACardUI
{
    internal class CardPicker
    {
        /// <summary>
        /// Random generator
        /// </summary>
        static Random random = new Random();

        /// <summary>
        /// Picks a number of cards and returns them.
        /// </summary>
        /// <param name="numberOfCards">The number of cards to pick.</param>
        /// <returns>An array of strings that contains the card names.</returns>
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
        /// Return random card type.
        /// </summary>
        /// <returns>String with card type.</returns>
        private static string RandomSuit()
        {
            int value = random.Next(1, 5);

            switch (value)
            {
                case 1:
                    return "Spades";
                case 2:
                    return "Hearts";
                case 3:
                    return "Clubs";
                default:
                    return "Diamonds";
            }
        }

        /// <summary>
        /// Return random card value.
        /// </summary>
        /// <returns>String with a card value.</returns>
        private static string RandomValue()
        {
            int value = random.Next(1, 14);

            switch (value)
            {
                case 1:
                    return "Ace";
                case 11:
                    return "Jack";
                case 12:
                    return "Queen";
                case 13:
                    return "King";
                default:
                    return value.ToString();
            }
        }
    }
}
