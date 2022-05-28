namespace unit03_jumper
{
    /// <summary>
    /// <para>A person who directs the game.</para>
    /// <para>
    /// The responsibility of a Director is to control the sequence of play.
    /// </para>
    /// </summary>
    public class Director
    {
        private Word word = new Word();
        private bool isPlaying = true;
        private Joe joe = new Joe();
        private TerminalService terminalService = new TerminalService();

        /// <summary>
        /// Constructs a new instance of Director.
        /// </summary>
        public Director()
        {
        }

        /// <summary>
        /// Starts the game by displaying the starting text, then running the main game loop.
        /// </summary>
        public void StartGame()
        {
            terminalService.WriteText("Welcome to Parachute Joe!");
            terminalService.WriteText(word.GetHint());
            while (isPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }

        /// <summary>
        /// Gets and saves the guessed letter. 
        /// </summary
        private void GetInputs()
        {
            terminalService.WriteText("Guess a letter:");
            string letter = terminalService.ReadText("");
            joe.ChangeGuess(letter);
        }

        /// <summary>
        /// Checks to see if the guessed letter is correct.
        /// </summary>
        private void DoUpdates()
        {
            word.WatchGuess(joe);
        }

        /// <summary>
        /// Shows the discovered parts of the word, and tracks victory and defeat conditions. 
        /// </summary>
        private void DoOutputs()
        {
            if (word.IsFound())
            {
                isPlaying = false;
                terminalService.WriteText("\n\nVICTORY!\n");
                terminalService.WriteText(@"\ 0 /");
                terminalService.WriteText(@"  |  ");
                terminalService.WriteText(@" / \ ");
                terminalService.WriteText("Joe went on to live a long and happy life");
            }
            else if (joe.IsDead())
            {
                isPlaying = false;
                terminalService.WriteText("Defeat!");
                terminalService.WriteText(joe.parachute.Replace("0", "X"));
            }
            else{
                terminalService.WriteText(word.GetHint());
                terminalService.WriteText("\n");
                terminalService.WriteText(joe.parachute);
            }
            
        }
    }
}