using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessWhat
{
    internal class WordGame
    {
        private List<string> Words;
        private string Path = "words.txt";
        public WordGame()
        {
            Words = ReadWordsFromFile(Path);
        }

        private List<string> ReadWordsFromFile(string filePath)
        {
            List<string> wordsList = new List<string>();

            using (StreamReader reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();

                    string[] words = line.Split(' ');

                    foreach (string word in words)
                    {
                        wordsList.Add(word.ToLower());
                    }
                }
            }

            return wordsList;
        }

        public string GetRandomWord()
        {
            Random random = new Random();
            return Words[random.Next(0, Words.Count)];
        }

        public bool CheckWordInCollection(string word)
        {
            return Words.Contains(word);
        }
    }
}
