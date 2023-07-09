using System.ComponentModel.DataAnnotations;

namespace PwcCodeChallenge {
    public class Program {
        public static void Main (String[] args) {
            string phrase = "Hello, World! OpenAI is amazing.";
            //string phrase = Console.ReadLine();
            Console.WriteLine(PhraseInverter(phrase));
            Console.WriteLine(RemoveDuplicatedChars(phrase));
        }

        public static string PhraseInverter(string phrase) {
            string [] phraseSplit = phrase.Split(' ');
            int length = phraseSplit.Length;
            string result = phraseSplit[length - 1];

            for (int i = 2; i <= length; i++) {
                result += " " + phraseSplit[length - i];
            }
            return result;
        }

        public static string RemoveDuplicatedChars(string phrase) {
            char aux1 = phrase[0];
            string result = aux1.ToString();

            for (int i = 0; i < phrase.Length; i++) {
                if (phrase[i] != aux1) {
                    result += phrase[i].ToString();
                }
                phrase = phrase.Replace(phrase[i], aux1);
            }
            return result;
        }
    }
}