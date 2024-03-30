using System;
using System.Text.RegularExpressions;

namespace FindAndReplace.Models
{
    
    public class WordReplacer
    {
        // This Objec takes in 3 things; 1 is the sentence
        // 2 is the word in that sentence we want to replace(finding)
        // 3 is the new word
        
        public string Sentence { get; set; }
        public string FindWord { get; set; }
        public string ReplaceWord { get; set; }

        public WordReplacer(string mySentence , string myFindWord , string myReplaceWord)
        {
            Sentence = mySentence;
            FindWord = myFindWord;
            ReplaceWord = myReplaceWord;
        }

        // Writing the FindAndReplaceWord() method
    //     public string FindAndReplaceWord(string newSentence, string newFindWord, string newReplaceWord)
    //     {
    //         // Splitting the sentence as a whole with respect to spaces
    //         string[] arrayOfWords = newSentence.Split(" ");


    //         // Looping through each word in the arrayto find and replace words
    //         for (var i = 0; i < arrayOfWords.Length; i++)
    //         {

    //             // If the current word(i; each word we loop through) matches the old word(newFindWord), replace it with the new word(newReplaceWord)
    //             if (arrayOfWords[i].Equals(newFindWord, StringComparison.OrdinalIgnoreCase))
    //             {
    //                 // Replacing the word
    //                 arrayOfWords[i] = newReplaceWord;
    //             }
                
    //         }
    //             // Join the words back into a sentence
    //             string modifiedSentence = string.Join(" ", arrayOfWords);
    //             return modifiedSentence;
    //         }
    // }   

    // public string FindAndReplaceWord(string newSentence, string newFindWord, string newReplaceWord)
    // {
    //     // Use regular expression to find the word with word boundaries
    //     string pattern = "\\b" + Regex.Escape(newFindWord) + "\\b";
    //     // Replace using regular expression
    //     string modifiedSentence = Regex.Replace(newSentence, pattern, newReplaceWord, RegexOptions.IgnoreCase);
    //     return modifiedSentence;
    // }


    // For partial matches and for single words
    public string FindAndReplaceWord(string sentence, string oldWord, string newWord)
    {
        // Split the sentence into words
        string[] arrayOfWords = sentence.Split(' ');

        // Loop through each word in the array to find and replace partial matches or normal matches
        for (int i = 0; i < arrayOfWords.Length; i++)
        {
            // If the current word contains the old word, replace it with the new word
            if (arrayOfWords[i].IndexOf(oldWord, StringComparison.OrdinalIgnoreCase) != -1)
            {
                // Replace the old word with the new word
                arrayOfWords[i] = arrayOfWords[i].Replace(oldWord, newWord, StringComparison.OrdinalIgnoreCase);
            }
        }

        // Join the arrayOfWords back into a sentence
        string modifiedSentence = string.Join(" ", arrayOfWords);
        return modifiedSentence;

        // In the ode above:
        /* if statement that checks whether the current word (words[i]) contains the old word (oldWord). This check is performed using the IndexOf method.
        IndexOf returns the zero-based index of the first occurrence of the specified string within the current word. If the word doesn't contain the old word, it returns -1.
        The condition words[i].IndexOf(oldWord, StringComparison.OrdinalIgnoreCase) != -1 checks if the index of the old word in the current word is not -1, indicating that the old word is found within the current word.
        Replace Method:

        If the old word is found within the current word, the Replace method is called to replace all occurrences of the old word with the new word.
        The Replace method takes three parameters: the string to replace (oldWord), the replacement string (newWord), and an optional parameter (StringComparison.OrdinalIgnoreCase) specifying the string comparison rules (in this case, a case-insensitive comparison).
        Joining Words:

        After all modifications are done, the modified array of words (words) is joined back into a single string using the string.Join method. Each word is separated by a space.
        */
    }

}
}