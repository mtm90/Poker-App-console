# Poker App new version

After creating the the folder directory, here are the basic steps to create a poker app.

## Plan the Poker Game Logic

### Key components

 - [x] Deck Initialization: Function to initialize and shuffle the deck.
 - [x] Hand Dealing: Function to deal hands to the player and the computer.
 - [x] Community Cards: Functions to deal the flop, turn, and river.
 - [x] Blinds Handling: Function to handle the small and big blinds.
 - [ ] Betting Rounds: Function to handle betting rounds (preflop, flop, turn, river).
 - [ ] Hand Evaluation: Function to evaluate hands and determine the winner.
 - [ ] Game Flow:  Main function to control the flow of the game.

The first commit will have the base code implemented, then step by step i will add all the functionalities.

## First Commit

```csharp
// Program.cs

using System;
using System.Collections.Generic;
using System.Linq;

namespace PokerGame
{
    class Program
    {
        static void Main(string[] args)
        {
            StartNewGame();
        }

        static void StartNewGame()
        {
            // Initialize game variables
            var deck = InitializeDeck();
            ShuffleDeck(deck);
            
            var playerHand = new string[2];
            var computerHand = new string[2];
            var communityCards = new string[5];

            int playerStack = 500;
            int computerStack = 500;
            int pot = 0;

            bool isPlayerSmallBlind = true;

            // Game loop
            while (playerStack > 0 && computerStack > 0)
            {
                DealInitialCards(deck, playerHand, computerHand);
                HandleBlinds(ref playerStack, ref computerStack, ref pot, isPlayerSmallBlind);
                
                if (!BettingRound(playerHand, computerHand, communityCards, ref playerStack, ref computerStack, ref pot, isPlayerSmallBlind))
                    break;

                DealCommunityCards(deck, communityCards, 3); // Flop
                if (!BettingRound(playerHand, computerHand, communityCards, ref playerStack, ref computerStack, ref pot, isPlayerSmallBlind))
                    break;

                DealCommunityCards(deck, communityCards, 1); // Turn
                if (!BettingRound(playerHand, computerHand, communityCards, ref playerStack, ref computerStack, ref pot, isPlayerSmallBlind))
                    break;

                DealCommunityCards(deck, communityCards, 1); // River
                if (!BettingRound(playerHand, computerHand, communityCards, ref playerStack, ref computerStack, ref pot, isPlayerSmallBlind))
                    break;

                DetermineWinner(playerHand, computerHand, communityCards, ref playerStack, ref computerStack, ref pot);
                isPlayerSmallBlind = !isPlayerSmallBlind; // Switch blinds
            }

            Console.WriteLine("Game Over");
        }

        static List<string> InitializeDeck()
        {
            // Placeholder: Return a new initialized deck
            return new List<string>();
        }

        static void ShuffleDeck(List<string> deck)
        {
            // Placeholder: Shuffle the deck
        }

        static void DealInitialCards(List<string> deck, string[] playerHand, string[] computerHand)
        {
            // Placeholder: Deal initial cards to player and computer
        }

        static void HandleBlinds(ref int playerStack, ref int computerStack, ref int pot, bool isPlayerSmallBlind)
        {
            // Placeholder: Handle blinds
        }

        static void DealCommunityCards(List<string> deck, string[] communityCards, int stage)
        {
            // Placeholder: Deal community cards based on the stage
        }

        static bool BettingRound(string[] playerHand, string[] computerHand, string[] communityCards, ref int playerStack, ref int computerStack, ref int pot, bool isPlayerSmallBlind)
        {
            // Placeholder: Implement betting logic
            return true;
        }

        static void DetermineWinner(string[] playerHand, string[] computerHand, string[] communityCards, ref int playerStack, ref int computerStack, ref int pot)
        {
            // Placeholder: Evaluate hands and determine the winner
        }
    }
}
```


