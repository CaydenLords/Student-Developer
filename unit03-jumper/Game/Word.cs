using System;
using System.Collections.Generic;


namespace unit03_jumper 
{
    /// <summary>
    /// <para>The hidden word the player has to guess. </para>
    /// <para>
    /// The responsibility of Word is to keep track of the hidden word and how much of it the player has guessed. 
    /// </para>
    /// </summary>
    public class Word
    {
        public string hiddenWord = "";
        string[] wordList = System.IO.File.ReadAllLines("Game/1-1000.txt");
        public string displayWord = "";

        /// <summary>
        /// Constructs a new instance of Word. 
        /// </summary>
        public Word()
        {
            Random random = new Random();
            hiddenWord = wordList[random.Next(0,999)];
            foreach (char c in hiddenWord){
                displayWord += "_";
            }
        }

        /// <summary>
        /// Displays the word with the letters the player has guessed.
        /// </summary>
        /// <returns>A new hint.</returns>
        public string GetHint()
        {
            return displayWord;
        }

        /// <summary>
        /// Whether or not the whole word has been found.
        /// </summary>
        /// <returns>True if found; false if otherwise.</returns>
        public bool IsFound()
        {
            return hiddenWord == displayWord;
        }

        /// <summary>
        /// Checks to see if any of the letters in the hidden word matches the guess.
        /// </summary>
        /// <param name="joe">The parachuter keeping track of the guess.</param>
        public void WatchGuess(Joe joe)
        {
            char letter = joe.GetGuess();
            int i = 0;
            foreach (char c in hiddenWord){
                if (c == letter){
                    displayWord = displayWord.Remove(i, 1).Insert(i, Convert.ToString(c));
                    joe.guessCorrect = true;
                }
                i++;
            }
        }
    }
}