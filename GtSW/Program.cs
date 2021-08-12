using System;

namespace GtSW
{
    class Program
    {
        static void Main(string[] args)
        {
            // The secret word. Change it to whatever you like!
            string secretword = "guessesguessesguessesguessesguessesguessesguessesguessesguessesguesses";
            // A variable for inputting the guess word. You can change it and make it as an easter egg.
            string guessword = "";
            // The starting guess count, used for printing out and keeping track of what guess you're on. You should NOT change it.
            int guesscount = 1;
            // The guess limit that's displayed when booting up the program. Change it to whatever you like.
            int guesslimitdisplay = 3;
            // The real guess limit. Since guesscount = 1, guesslimit must equal to guesslimitdisplay + 1. DO NOT CHANGE.
            int guesslimit = guesslimitdisplay + 1;
            // A boolean that'll be used to check if you ran out of guesses and lost the game. Changing it to true will result in an insta-game over.
            bool gameover = false;

            // Draw title and instructions
            Console.WriteLine("GUESS THE SECRET WORD - GWE's C# Test Program 2");
            Console.WriteLine("Find the secret word (with correct capital and lowercase letters) and type it out! Hints\nare very unfair, so who needs them? Except people who think it's hard. >:)");
            Console.WriteLine("You have " + guesslimitdisplay + " guesses! When you're out of guesses, it's game over!\n");

            // While loop for the game. It breaks out when you lose or win. 
            while(guessword != secretword && !gameover)
            {
                // If statement that checks if you're not out of guesses.
                if (guesscount < guesslimit)
                {
                    // If not out of guesses:

                    // If statement that checks if you're on the last guess.
                    if (guesslimit - 1 == guesscount)
                    {
                        // If on last guess, draw final guess message
                        Console.Write("FINAL GUESS - If you fail this guess, it's game over!\nWhat's the secret word? ");
                        // Waits input from user and stores input into guessword, then increment guesscount.
                        guessword = Console.ReadLine();
                        guesscount++;
                    }
                    else
                    {
                        // If not on last guess, draw guess number
                        Console.Write("Guess #" + guesscount + "\nWhat's the secret word? ");
                        // Waits input from user and stores input into guessword, then increment guesscount.
                        guessword = Console.ReadLine();
                        guesscount++;
                    }

                    // If statement that checks if the guess word is wrong.
                    if (guessword != secretword)
                    {
                        // If guess word is incorrect, print "wrong" message
                        Console.WriteLine("Wrong! \"" + guessword + "\" is not the secret word!\n");
                    }   
                }
                else
                {
                    // If out of guesses, set the game over boolean to true
                    gameover = true;
                }
            }

            // If statement that checks if you lost.
            if (gameover)
            {
                // If you lost, print game over message.
                Console.Write("--------GAME OVER--------\nOh no... Try again another time!");
            }
            else
            {
                // If you didn't lose, print win message.
                Console.Write("\n\n-----CONGRATULATIONS-----\nHurray! You guessed the secret word!");
            }

            // Receive input until Enter is pressed
            Console.ReadLine();
        }
    }
}
