
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
            string[] suits = { "♠", "♥", "♦", "♣" };
            string[] values = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            var deck = new List<string>();

            foreach (var suit in suits)
            {
                foreach (var value in values)
                {
                    deck.Add($"{value}{suit}");
                }
            }

            return deck;
        }

        static void ShuffleDeck(List<string> deck)
        {
            var rand = new Random();
            for (int i = deck.Count - 1; i > 0; i--)
            {
                int j = rand.Next(i + 1);
                var temp = deck[i];
                deck[i] = deck[j];
                deck[j] = temp;
            }
        }


        static void DealInitialCards(List<string> deck, string[] playerHand, string[] computerHand)
        {
            playerHand[0] = deck[0];
            playerHand[1] = deck[1];
            computerHand[0] = deck[2];
            computerHand[1] = deck[3];
            deck.RemoveRange(0, 4); // Remove dealt cards from the deck
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

