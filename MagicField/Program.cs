using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicField
{
    class Program
    {
        static string createTemplate(string s)
        {
            string newWord = "";
            for (int i = 0; i < s.Length; i++)
            {
                newWord += "*";
            }
            return newWord;
        }
        /*
        static string checkLetterInWord(char letter, string word, string template)
        {
            string newTemplate = "";
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == letter)
                {
                    newTemplate += letter;
                }
                else
                {
                    newTemplate += template[i];
                }
            }
            return newTemplate;
        }
        */

        static bool isLetterInWord(char letter, string word, ref string template)
        {
            bool isExist = false;
            string newTemplate = "";
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == letter)
                {
                    newTemplate += letter;
                    isExist = true;
                }
                else
                {
                    newTemplate += template[i];
                }
            }
            template = newTemplate;
            return isExist;
        }
        static void Main(string[] args)
        {
            int countError = 0;
            string word = "стул";
            string template = createTemplate(word);
            while (template != word)
            {
                Console.WriteLine(template);
                Console.WriteLine("Введите букву");
                char letter = Console.ReadLine()[0];
                // template = checkLetterInWord(letter, word, template);
                countError += Convert.ToInt32(!isLetterInWord(letter, word, ref template));
            }
            Console.WriteLine("Вы выиграли!");
            Console.WriteLine("Вы допустили " + countError + " ошибок!");
        }
    }
}
