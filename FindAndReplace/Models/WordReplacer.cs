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
        string[] words = sentence.Split(' ');

        // Loop through each word to find and replace partial matches
        for (int i = 0; i < words.Length; i++)
        {
            // If the current word contains the old word, replace it with the new word
            if (words[i].IndexOf(oldWord, StringComparison.OrdinalIgnoreCase) != -1)
            {
                // Replace the old word with the new word
                words[i] = words[i].Replace(oldWord, newWord, StringComparison.OrdinalIgnoreCase);
            }
        }

        // Join the words back into a sentence
        string modifiedSentence = string.Join(" ", words);
        return modifiedSentence;
    }

}
}