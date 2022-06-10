namespace Unit04.Game.Casting
{
    public class Artifact : Actor
    {
        private string text = "";

        /// <summary>
        /// <para>An item of cultural or historical interest. Notably either a rock or a gem. </para>
        /// <para>
        /// The responsibility of an Artifact is to provide a message about itself.
        /// </para>
        /// </summary>

        
        /// <summary>
        /// Constructs a new instance of Artifact.
        /// </summary>
       public Artifact()
       {

       }

         public string GetMessage(){
            return text;
        }
        /// <summary>
        /// Gets the artifact's message.
        /// </summary>
        /// <returns>The message as a string.</returns>
       
        public void SetMessage(string message){
            text = message;
        }
        /// <summary>
        /// Sets the artifact's message to the given value.
        /// </summary>
        /// <param name="message">The given message.</param>
    }
}