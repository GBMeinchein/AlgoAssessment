using System;
using System.Linq;

namespace TGS.Challenge
{
  /*
        Devise a function that checks if 1 word is an anagram of another, if the words are anagrams of
        one another return true, else return false

        "Anagram": An anagram is a type of word play, the result of rearranging the letters of a word or
        phrase to produce a new word or phrase, using all the original letters exactly once; for example
        orchestra can be rearranged into carthorse.

        areAnagrams("horse", "shore") should return true
        areAnagrams("horse", "short") should return false

        NOTE: Punctuation, including spaces should be ignored, e.g.

        horse!! shore = true
        horse  !! shore = true
          horse? heroes = true

        There are accompanying unit tests for this exercise, ensure all tests pass & make
        sure the unit tests are correct too.
     */
    public class Anagram
    {
        public bool AreAnagrams(string word1, string word2)
        {
            if (string.IsNullOrEmpty(word1) ||
                string.IsNullOrEmpty(word2))
                throw new ArgumentException("Invalid parameters!");

            word1 = new String(word1.ToLower().Where(Char.IsLetter).ToArray());
            word2 = new String(word2.ToLower().Where(Char.IsLetter).ToArray());
            string anagram = string.Empty;

            for (int i = 0; i < word1.Length; i++)
            {
                for (int x = 0; x < word2.Length; x++)
                {
                    if (word1[i] == word2[x])
                    {
                        anagram += word2[x];
                        word2 = word2.Remove(x, 1);
                        break;
                    }
                }
            }

            if (word1 == anagram)
                return true;

            return false;
        }
    }
}
