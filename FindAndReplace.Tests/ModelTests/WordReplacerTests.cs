using FindAndReplace.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace FindAndReplace.Tests
{
    [TestClass]
    public class WordReplacerTests
    {
        // Test 1: Testing whether An Instance of a WordReplacer object can be created
        [TestMethod]
        public void WordReplacerConstructor_CreatesInstanceOfClass_WordReplace()
        {
            // Arrange
            WordReplacer newReplacer = new WordReplacer("Example sentence", "Dynasty", "Warrior");

            // Assert
            Assert.AreEqual(typeof(WordReplacer), newReplacer.GetType());
        }

        // Test 2: Testing whether I can get the value of my Sentence property in WordReplacer object
        [TestMethod]
        public void GetSentence_ReturnsTheSentence_String()
        {
            // Arrange
            WordReplacer newReplacer = new WordReplacer("Dynasty will be Great", "Dynasty", "Warrior");
            string expectedSentence = "Dynasty will be Great";
            
            // Act
            string returnedSentence = newReplacer.Sentence;

            // Assert
            Assert.AreEqual(expectedSentence, returnedSentence);
        }

        // Test 3: Testing whether I can set the value of my Sentence property
        [TestMethod]
        public void SetSentence_SetsTheValueOfSentence_Void()
        {
            // Arrange
            WordReplacer newReplacer = new WordReplacer("Dynasty will be a Multi Billionnaire", "Dynasty", "Warrior");
            string setSentence = "Dynasty will be a Trillionnaire";

            // Act
            newReplacer.Sentence = setSentence;

            // Assert
            Assert.AreEqual(setSentence, newReplacer.Sentence);
        }

          // Test 4: Testing whether I can get the value of my FindWord property in WordReplacer object
        [TestMethod]
        public void GetFindWord_ReturnsTheFindWord_String()
        {
            // Arrange
            WordReplacer newReplacer = new WordReplacer("Dynasty will be Great", "Dynasty", "Warrior");
            string expectedFindWord = "Dynasty";
            
            // Act
            string returnedFindWord = newReplacer.FindWord;

            // Assert
            Assert.AreEqual(expectedFindWord, returnedFindWord);
        }

         // Test 5: Testing whether I can set the value of my Sentence property
        [TestMethod]
        public void SetFindWord_SetsTheValueOfFindWord_Void()
        {
            // Arrange
            WordReplacer newReplacer = new WordReplacer("Dynasty will be a Multi Billionnaire", "Dynasty", "Warrior");
            string setFindWord = "MJ";

            // Act
            newReplacer.FindWord = setFindWord;

            // Assert
            Assert.AreEqual(setFindWord, newReplacer.FindWord);
        }

         // Test 6: Testing whether I can get the value of my ReplaceWord property in WordReplacer object
        [TestMethod]
        public void GetReplaceWord_ReturnsTheReplaceWord_String()
        {
            // Arrange
            WordReplacer newReplacer = new WordReplacer("Dynasty will be Great", "Dynasty", "Emzzy");
            string expectedReplaceWord = "Emzzy";
            
            // Act
            string returnedReplaceWord = newReplacer.ReplaceWord;

            // Assert
            Assert.AreEqual(expectedReplaceWord, returnedReplaceWord);
        }

        // Test 7: Testing whether I can set the value of my ReplaceWord property n the WordReplacer objetc
        [TestMethod]
        public void SetReplaceWord_SetsTheReplaceWord_Void()
        {
            // Arrange
            WordReplacer newReplacer = new WordReplacer("Dynasty will be Great", "Dynasty", "Emzzy");
            string setReplaceWord = "Mojiboye";

            // Act
            newReplacer.ReplaceWord = setReplaceWord;

            // Assert
            Assert.AreEqual(setReplaceWord, newReplacer.ReplaceWord);
        }

        // Test 8: Testing FindAndReplaceWord() method, a method that takes 3 arguments; first, sentence. Second, a word in that sentence we want to change, third, is the new word we want to add into our sentence.
        [TestMethod]
        public void FindAndReplaceWordMethod_RunsAPartOfMyPowerfulMethod_String()
        {
            // Arrange
            WordReplacer newReplacer = new WordReplacer("Dynasty will be Great", "Dynasty", "Emzzy");
            string expectedValue = "Emzzy will be Great";

            // Act
            string actualValue = newReplacer.FindAndReplaceWord("Dynasty will be Great", "Dynasty", "Emzzy");

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        // Test 9: Testing for Partial Matches in my amazing method
        [TestMethod]
        public void FindAndReplaceWordMethodPartial_RunsAPartOfMyPowerfulMethod_String()
        {
            // Arrange
            WordReplacer newReplacer = new WordReplacer("I am walking my cat to the cathedral", "cat", "dog");
            string expectedValue = "I am walking my dog to the doghedral";

            // Act
            string actualValue = newReplacer.FindAndReplaceWord("I am walking my cat to the cathedral", "cat", "dog");

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

    }
    
}