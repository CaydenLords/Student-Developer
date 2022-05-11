using System;
using System.Collections.Generic;


namespace unit02_hilo.Game
{
    /// <summary>
    /// A person who directs the game. 
    ///
    /// The responsibility of a Director is to control the sequence of play.
    /// </summary>
    public class Director
    {
        Card card = new Card();
        int totalScore = 0;
        int lastCard = 0;
        string guess = "h";
        bool isPlaying = true;
        /// <summary>
        /// Constructs a new instance of Director.
        /// </summary>
        public Director()
        {
            
        }

        /// <summary>
        /// Starts the game by running the main game loop.
        /// </summary>
        public void StartGame()
        {
            card.Draw();
            while (isPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }

        /// <summary>
        /// Asks the user if they want to roll.
        /// </summary>
        public void GetInputs()
        {
            Console.Write($"The Card is {lastCard}");
            guess = Console.ReadLine();
            card.Draw();
        }

        /// <summary>
        /// Updates the player's score.
        /// </summary>
        public void DoUpdates()
        {
            if (!isPlaying)
            {
                return;
            }
            if (guess == "h"){
                if (card.value > lastCard){
                    totalScore = totalScore+100;
                }
                else if (card.value < lastCard){
                    totalScore = totalScore-75;
                }
            }
            if (guess == "l"){
                if (card.value > lastCard){
                    totalScore = totalScore-75;
                }
                else if (card.value < lastCard){
                    totalScore = totalScore+100;
                }
            }

            
        }

        /// <summary>
        /// Displays the dice and the score. Also asks the player if they want to roll again. 
        /// </summary>
        public void DoOutputs()
        {
            if (!isPlaying)
            {
                return;
            }
            Console.WriteLine($"The next card was {card.value}.");
            Console.WriteLine($"Your score is {totalScore}.");
            Console.WriteLine("Do you want to play again? y/n ");
            string playAgain = Console.ReadLine();
            isPlaying = (playAgain == "y");
        }
    }
}


