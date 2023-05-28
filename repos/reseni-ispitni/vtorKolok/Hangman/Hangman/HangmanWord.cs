using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    public class HangmanWord
    {
        public string Word { get; set; }
        public HashSet<char> LettersInWord { get; set; }
        public HashSet<char> GuessedLetters { get; set; }
        public int WrongCount { get; set; }
        public static readonly int MAX_RETRIES = 5;
        
        public HangmanWord(string Word) 
        {
            this.Word = Word;
            LettersInWord = new HashSet<char>();
            foreach(char c in Word)
            {
                LettersInWord.Add(Char.ToLower(c));
            }
            GuessedLetters = new HashSet<char>();   
            WrongCount = 0;
        }

        public string GetMaskedWord()
        {
            StringBuilder sb = new StringBuilder();
            foreach(char c in Word)
            {
                if (LettersInWord.Contains(Char.ToLower(c)))
                {
                    sb.Append("_");
                }
                else
                {
                    sb.Append(c);
                }
                sb.Append(" ");
            }
            return sb.ToString();
        }

        public string GetMaskedGuessedLetters()
        {
            StringBuilder sb = new StringBuilder();
            for (char c = 'a'; c <= 'z'; c++)
            {
                if (GuessedLetters.Contains(c))
                {
                    sb.Append(Char.ToUpper(c));
                }
                else
                {
                    sb.Append("_");
                }
                sb.Append(" ");
            }
            return sb.ToString();
        }

        public bool GuessLetter(char letter)
        {
            letter = Char.ToLower(letter);
            if (GuessedLetters.Contains(letter))
            {
                return false;
            }
            else
            {
                if (LettersInWord.Contains(letter))
                {
                    LettersInWord.Remove(letter);
                }
                else
                {
                    WrongCount++;
                }
                GuessedLetters.Add(letter);
                return true;
            }
        }

        public bool Win()
        {
            return LettersInWord.Count == 0;
        }

        public bool Lose()
        {
            return WrongCount == MAX_RETRIES;
        }
    }
}
