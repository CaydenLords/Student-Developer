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
        int totalScore = 300;
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
        /// Gets the last Card value and saves it, then gets higher or lower from the player, then draws a new card. 
        /// </summary>
        public void GetInputs()
        {
            lastCard = card.value;
            Console.WriteLine($"The card is : {lastCard}.");
            Console.Write("Higher or Lower? [h/l] ");
            guess = Console.ReadLine();
            card.Draw();
        }

        /// <summary>
        /// Determines whether the card value is higher or lower, then awards points as such. 
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
        /// Displays the new card and the score, then asks the player if they want to play again.  
        /// </summary>
        public void DoOutputs()
        {
            if (!isPlaying)
            {
                return;
            }
            Console.WriteLine($"The next card was {card.value}.");
            Console.WriteLine($"Your score is {totalScore}.");
            if (totalScore > 0){
                Console.Write("Do you want to play again? [y/n] ");
                string playAgain = Console.ReadLine();
                isPlaying = (playAgain == "y");
            }
            else{
                Console.WriteLine("Game Over");
                isPlaying = false;
            }
            Console.WriteLine("");
        }
    }
}


