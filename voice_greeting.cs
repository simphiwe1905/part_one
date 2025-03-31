namespace part_one
{
    using System.Media;
    using System;
    using System.IO;

    public class voice_greeting
    {
        public voice_greeting()
        {
            string project_location = AppDomain.CurrentDomain.BaseDirectory;

            //replacing the bin\debug
            string updated_path = project_location.Replace("bin\\Debug\\", "");
            //combine the wav name with the updated path
            string full_path = Path.Combine(updated_path, "voice.wav");

            //pass to the method
            sound_play(full_path);
        }

        //creating a method that is going to play the voice greeting 
        private void sound_play( string full_path )
        {
            //create a try and catch 
            try
            {
                //within try play the voice greeting
                using (SoundPlayer player = new SoundPlayer(full_path))
                {
                    player.PlaySync();
                }
            }
            catch ( Exception error )
            {

                //the catch should display the error message
                Console.WriteLine( error.Message );

            }
        }
    }
}