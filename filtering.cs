using System.Collections;
using System;

namespace part_one
{
    public class filtering
    {
        //variable declaration 
        ArrayList replies = new ArrayList();
        ArrayList ignore = new ArrayList();
        private string user_name = string.Empty;
        private string asked = string.Empty;
        private string question = string.Empty;


        //this is a constructor 
        public filtering()
        {
           
            //printing the welcome and asking for the name 
            //also changing the colors for decoration
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine( " _-- **************************************************** --_ " );
            Console.ForegroundColor= ConsoleColor.DarkGray;
            Console.WriteLine( " |     Welcome to the CyberSecurity AI Assistant!     | " );
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("   _--****************************************************--_ ");

            //asking for the user name and assigning it to the variable 
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" ChatBot: --> ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" Please enter your name. ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(" User:-->  ");
            Console.ForegroundColor = ConsoleColor.White;
            //assigning the users input to the variable
            user_name = Console.ReadLine();

            //recreating the interface
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(" ChatBot: --> ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" Hey " + user_name + " , Would you like to exit or do you have a question? ");
            //creating a do-while

            do
            {
               
                //asking the user if they want exit or continue,to stay within the do-while
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("  "+ user_name + " :--> ");
                Console.ForegroundColor = ConsoleColor.White;
                asked = Console.ReadLine();

                
                user_interaction();
                
            } while ( asked != "exit" ); //if the user types "exit" the program will stop running


        }

        private void user_interaction(  ) 
        {

            //create a checking condition
            if (asked != "exit")
            {
                //calling both methods to auto store the values 
                store_ignore();
                store_replies();

                //prompt the user for the question 
                //changing color of the the chatbot
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(" ChatbotAi --> ");
                Console.ForegroundColor= ConsoleColor.White;
                Console.WriteLine(" What is your question? ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write( user_name + " :--> " ) ;
                Console.ForegroundColor = ConsoleColor.White;
                question = Console.ReadLine();
              

                //making use of the split function to store each word within a 1D array 
                string[] store_word = question.Split(' ');
                //creating a temp array 
                ArrayList store_final_words = new ArrayList();

                //for loop to check the words and store 
                for (int count = 0; count< store_word.Length;count++ ) 
                {
                    if (!ignore.Contains(store_word[count] ) ) 
                    { 
                        store_final_words.Add( store_word[count] );
                    }                
                }

                //temp variables
                Boolean found = false;
                string message = String.Empty;

                for ( int counting = 0; counting < store_final_words.Count; counting++ ) 
                {
                    for ( int count = 0; count < replies.Count; count++ )
                    {
                        
                        if ( store_final_words[ counting].ToString().Contains(replies[count].ToString()) ) 
                        {
                            message += replies[count] + "\n";
                            found = true;
                        }
                    }
                }

                //making a for loop for final responses
                /*for (int counting = 0; counting < store_final_words.Count; counting++)
                {
                    //search for the answer from the temporary array list
                    for (int count = 0; count < replies.Count; count++)
                    {
                        
                        //the if statement is checking if found in replies
                        if (store_final_words[counting].ToString().ToLower().Contains(replies[count].ToString().ToLower() )   )
                        {
                            //adding the responses to message variable so they can be printed for the user 
                            message += replies[count] + "\n";
                            found = true;
                        }
                    }
                }*/

                //displaying an error message or answers
                if (found)
                {
                    //if the condition is true then the message will display
                    //then display 
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" ChatBot:--> ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(message);
                }


                else
                {
                    //if the condition is false then an error message will display 
                    Console.ForegroundColor= ConsoleColor.Red;
                    Console.Write( " ChatBot:--> " );
                    Console.ForegroundColor = ConsoleColor.White; 
                    Console.WriteLine(" Please search something related to cybersecurity ");
                }


            }
            else 
            { 
            
                //the else will exit the App entirely depending on the "asked" variable 
                Console.WriteLine( " Thank you for using AI, bye " );
                System.Environment.Exit( 0 );

            }

        }

        //method for storing the replies 
        private void store_replies()
        {
            //store the values of reply 
            replies.Add("password should be strong.");
            replies.Add("attacking phones is based on phishing");
            replies.Add("do ot write your password down, store it safely and securely.");
            replies.Add("long complex password makes things harder for hackers");
            replies.Add("sql injection is an attack where hackers insert malicious sql code into a website's input fields to access or modify databases.");
            replies.Add("sql injection exploits poorly coded queries to steal ,delete or change data.");
            replies.Add("sql injection can delete an entire database");
            replies.Add("a firewall helps prevent sql injection but secure defense is the best defense");
            replies.Add("phishing is A cyber attack where scammers trick you into providing sensitive information through fake emails, messages, or websites.");
            replies.Add("phishing attacks are targeted using personal information.");
            replies.Add("protect yourself from phishing by using filter, conducting security awareness training and implementing MFA.");
            replies.Add("do not click on any phishing links , is it may install malware or steal credentials.");
        }
        //method for storing the ignore values 
        private void store_ignore() {

            //storing the words that have to be ignored 
            ignore.Add("tell");         ignore.Add("risks");      ignore.Add("may");        ignore.Add("risk");
            ignore.Add("me");           ignore.Add("do");         ignore.Add("might");      ignore.Add("threat");
            ignore.Add("about");        ignore.Add("are");        ignore.Add("mean");       ignore.Add("attack");
            ignore.Add("the");          ignore.Add("and");        ignore.Add("define");     ignore.Add("safety");
            ignore.Add("protections");  ignore.Add("must");       ignore.Add("explain");    ignore.Add("data");
            ignore.Add("what");         ignore.Add("that");       ignore.Add("describe");   ignore.Add("comes");
            ignore.Add("is");           ignore.Add("when");       ignore.Add("meaning");    ignore.Add("when");
            ignore.Add("how");          ignore.Add("should");     ignore.Add("secure");     ignore.Add("to");
            ignore.Add("threats");      ignore.Add("could");      ignore.Add("fix");        ignore.Add("prevention");

        }

    }
}