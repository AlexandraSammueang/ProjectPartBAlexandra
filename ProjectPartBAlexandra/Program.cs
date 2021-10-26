using System;

namespace ProjectPartB_B1
{
    class Program
    {
        static void Main(string[] args)
        {
            DeckOfCards myDeck = new DeckOfCards();
            myDeck.CreateFreshDeck();
            Console.WriteLine($"\nA freshly created deck with {myDeck.Count} cards:");
            Console.WriteLine(myDeck);

            Console.WriteLine($"\nA sorted deck with {myDeck.Count} cards:");
            myDeck.Sort();
            Console.WriteLine(myDeck);

            Console.WriteLine($"\nA shuffled deck with {myDeck.Count} cards:");
            myDeck.Shuffle();
            Console.WriteLine(myDeck);


            HandOfCards player1 = new HandOfCards();
            HandOfCards player2 = new HandOfCards();
            player1.Add(myDeck.RemoveTopCard());
            Console.WriteLine(player1);


            Console.WriteLine($"\nLet's play a game of highest and lowest card with two players." +
                              $"\nHow many cards to deal to each player (1-5)?");

            int nrRounds = 0;
            bool PlayGame = TryReadNrOfCards(out int nrCardsToPlayer) &&
                          TryReadNrOfRounds(out nrRounds);


            if (PlayGame)
            {

                Console.WriteLine($"Lets play {nrRounds} rounds");

            }

            int round = 0;
            while (PlayGame && round < nrRounds)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine($"\nPlaying round nr {round + 1}");
                Console.WriteLine($"------------------");

               

                /* PlayGame = TryReadNrOfCards(out nrCardsToPlayer);
                 if (!PlayGame)
                     break;

                 Console.WriteLine($"You entered {nrCardsToPlayer}");*/ //FEEEL HÄÄÄR

                round++;

                Deal(myDeck, nrCardsToPlayer, player1, player2);
                Console.WriteLine($"{player1}");

                DetermineWinner(player1, player2);

                //Your code to play the game comes here

            }
        }

        /// <summary>
        /// Asking a user to give how many cards should be given to players.
        /// User enters an integer value between 1 and 5. 
        /// </summary>
        /// <param name="NrOfCards">Number of cards given by user</param>
        /// <returns>true - if value could be read and converted. Otherwise false</returns>

        private static bool TryReadNrOfCards(out int nrCardsToPlayer)
        {
            nrCardsToPlayer = 0;

            string sInput;
            do
            {

                sInput = Console.ReadLine();
                if (int.TryParse(sInput, out nrCardsToPlayer) && nrCardsToPlayer >= 1 && nrCardsToPlayer <= 5)
                {
                    return true;
                }
                else if (sInput != "Q" && sInput != "q")
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Wrong input, please try again.");
                }
            }
            while ((sInput != "Q" && sInput != "q"));
            return false;
        }

        /// <summary>
        /// Asking a user to give how many round should be played.
        /// User enters an integer value between 1 and 5. 
        /// </summary>
        /// <param name="NrOfRounds">Number of rounds given by user</param>
        /// <returns>true - if value could be read and converted. Otherwise false</returns>
        private static bool TryReadNrOfRounds(out int NrOfRounds)
        {
            NrOfRounds = 0;
            string sInput;
            do
            {

                Console.WriteLine("How many rounds do you like (1-5 or Q to quit)?");
                sInput = Console.ReadLine();
                if (int.TryParse(sInput, out NrOfRounds) && NrOfRounds >= 1 && NrOfRounds <= 5)
                {
                    return true;
                }
                else if (sInput != "Q" && sInput != "q")
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Wrong input, please try again.");
                }
            }
            while ((sInput != "Q" && sInput != "q"));
            return false;
        }


        /// <summary>
        /// Removes from myDeck one card at the time and gives it to player1 and player2. 
        /// Repeated until players have recieved nrCardsToPlayer 
        /// </summary>
        /// <param name="myDeck">Deck to remove cards from</param>
        /// <param name="nrCardsToPlayer">Number of cards each player should recieve</param>
        /// <param name="player1">Player 1</param>
        /// <param name="player2">Player 2</param>
        private static void Deal(DeckOfCards myDeck, int nrCardsToPlayer, HandOfCards player1, HandOfCards player2)
        {

            for (int i = 0; i < nrCardsToPlayer; i++) // Vi går bakåt för att minska kortleken
            {
                player1.Add(myDeck.RemoveTopCard());
                player2.Add(myDeck.RemoveTopCard());
               

               // player1.RemoveTopCard(); // Tar översta kortet
            }
           /* for (int i = myDeck.Count - 1; i <= nrCardsToPlayer; i--)
            {
                player2.RemoveTopCard();

            }*/
            //Console.WriteLine(value:$"{player1} cards {player2} cards");

        }

        /// <summary>
        /// Determines and writes to Console the winner of player1 and player2. 
        /// Player with higest card wins. If both cards have equal value it is a tie.
        /// </summary>
        /// <param name="player1">Player 1</param>
        /// <param name="player2">Player 2</param>
        private static void DetermineWinner(HandOfCards player1, HandOfCards player2)
        {

           /* var p1 = player1.cards;
            var p2 = player2.cards;
            int value = p1.CompareTo(p2);

            if (value == 0)
            {
                Console.WriteLine("It´s a tie");
            }
            else if (value < 0)
            {
                Console.WriteLine("Player1 has de highest cards");
            }
            else
            {
                Console.WriteLine("Player2 has the highest cards");
            }*/
        }

    }
}
