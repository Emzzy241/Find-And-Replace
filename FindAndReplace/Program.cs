using System;
using FindAndReplace.Models;

namespace FindAndReplace.Models
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to the FindAndReplace App");
            Console.WriteLine();
            Console.WriteLine("made by Dynasty");

            // Creating new Instance of class
            Console.WriteLine("Enter 3 words; first is a sentence, second is a word you want to in that sentence, 3rd is th enew word you want to change it into");
            Console.WriteLine();
            Console.WriteLine("If word does not exist in sentence, the sentence gets returned and nothing will be done");
            Console.WriteLine();

            Console.WriteLine("Enter the Sentence");
            string userSentence = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Enter the Word you want to find in the sentence");
            string userFindWord = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Enter the replace word i.e the new word you want to replace that previous word into");
            string userReplaceWord = Console.ReadLine();
            WordReplacer newReplacer = new WordReplacer(userSentence, userFindWord, userReplaceWord);

            string modifiedSentence = newReplacer.FindAndReplaceWord(userSentence, userFindWord, userReplaceWord);
            Console.WriteLine();
            Console.WriteLine("The modified sentence is: ");
            Console.WriteLine(modifiedSentence);
            Console.WriteLine();
            Console.WriteLine();
            try
            {
                Console.WriteLine("To go again, Enter 1,  to quit or exit enter 0 ");
                string userContinue = Console.ReadLine();
                int userContinueInt = int.Parse(userContinue);
                 switch (userContinueInt)
                {
                    case 1:
                        Main();
                        break;
                    case 2:
                        Console.WriteLine("Goodbye :(");
                        break;
                    default:
                        Console.WriteLine("Oops! I didn't get that, let's try again");
                        Main();
                        break;
                }
            }
            catch
            {
                Console.WriteLine("Oops! Please ensure you enter an integer(e.g: 1,2,3,4) next time");
                Console.WriteLine();
                Console.WriteLine("Let's give it another try");
                Main();
            }

           
            

            
        }        
    }
}