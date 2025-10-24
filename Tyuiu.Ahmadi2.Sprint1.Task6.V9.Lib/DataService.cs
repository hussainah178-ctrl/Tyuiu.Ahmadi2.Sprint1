using System;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.Ahmadi2.Sprint1.Task6.V9
{
    public class DataService : ISprint1Task6V9
    {
        public string MoveLastLetter(string text)
        {
            if (string.IsNullOrEmpty(text))
                return text;

            string[] words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];

                if (word.Length > 1)
                {
                    // Move last letter to beginning
                    char lastLetter = word[word.Length - 1];
                    string modifiedWord = lastLetter + word.Substring(0, word.Length - 1);
                    result.Append(modifiedWord);
                }
                else
                {
                    // If word has only one letter, keep it as is
                    result.Append(word);
                }

                // Add space between words (except after last word)
                if (i < words.Length - 1)
                    result.Append(' ');
            }

            return result.ToString();
        }

        public string MoveLetterToStart(string value)
        {
            throw new NotImplementedException();
        }
    }
}