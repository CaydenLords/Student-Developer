using System;


namespace unit03_jumper
{

    public class Joe{
    public char guess = '@';
    public bool guessCorrect = false;
    private int lives = 4;
    public string parachute = " ___ " + "\n" + @"/___\" + "\n" + @"\   /" + "\n" + @" \ / "+ "\n" + "  0  " +"\n" +
     @" /|\ " + "\n" + @" / \ " + "\n\n\n^^^^^";
        /// <summary>
        /// <para>The person on the parachute.</para>
        /// <para>
        /// The responsibility of a Joe is to keep track of the current guess and how much parachute he has left.
        /// </para>
        /// </summary>


        public Joe(){

        }
        /// <summary>
        /// Constructs a new instance of Joe.
        /// </summary>
       

        public char GetGuess(){
            return guess;
        }
        /// <summary>
        /// Gets the current guess.
        /// </summary>
        /// <returns>The current guess as an character.</returns>
        
        public void ChangeGuess(string letter){
            guess = Convert.ToChar(letter);
        }
        /// <summary>
        /// Converts the inputted guess to a character and stores it. 
        /// </summary>
        /// <param name="letter">The given guess as a string.</param>
        public bool IsDead(){
            if (guessCorrect == false){
                lives = lives -1;
                parachute = parachute.Remove(0, 6);
            }
            guessCorrect = false;
            if (lives > 0){
                return false;
            }
            else{
                return true;
            }
        }    
        /// <summary>
        /// updates the amount of parachute left and keeps track of whether the player has lost. 
        /// </summary>
    }
}