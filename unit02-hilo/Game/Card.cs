using System;


namespace unit02_hilo.Game
{
        /// <summary>
        /// A small rectangular piece of paper with a rank from 1 to 13. 
        /// The responsibility of Card is to get keep track of its current rank. 
        ///</summary> 
    public class Card{
        public int value = 0;
    

    public Card(){
    }
        /// <summary>
        /// Constructs a new instance of Card.
        /// </summary>
    public void Draw(){
        Random rand = new Random();
        value = rand.Next(1,13);
    }    
        /// <summary>
        /// Gets a random number between 1 and 13
        /// </summary>
    }  
}