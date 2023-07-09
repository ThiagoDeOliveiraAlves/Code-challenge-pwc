using System.ComponentModel.DataAnnotations;

namespace PwcCodeChallenge {
    public class Program {
        public static void Main (String[] args) {
            string phrase = "Hello, World! OpenAI is amazing.";
            //string phrase = Console.ReadLine();
            Console.WriteLine(PhraseInverter(phrase));
            phrase = "Hello, World!";
            Console.WriteLine(RemoveDuplicatedChars(phrase));
            phrase = "babad";
            Console.WriteLine(PalindromeSubStr(phrase));
            phrase = "racecar";
            Console.WriteLine(IsPalindrome(phrase));
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

        public static string PalindromeSubStr(string word) {
            word = word.Trim();
            string subStr;
            string palindromeSubStr = "";
            string aux1;
            bool test1 = false; //used to test if a substring is palindrome
            bool test2 = false; //true if a polindrome substring exist. Used to define the return

            for (int i = 0; i < word.Length; i++) {
                subStr = word[i].ToString().ToUpper();
                aux1 = word[i].ToString();

                for (int j = i+1; j < word.Length; j++) {
                    subStr += word[j].ToString().ToUpper();
                    aux1 += word[j].ToString();

                    test1 = IsPalindrome(subStr);

                    if (test1 == true && aux1.Length > palindromeSubStr.Length) {
                        palindromeSubStr = aux1;
                        test2 = true;
                    }
                }
            }
            if (test2 == true) {
                return palindromeSubStr;
            }
            else {
                return "A palavra não é palíndroma";
            }
        }

        public static bool IsPalindrome (string word) {
            bool test1 = false;
            for (int i = 0; i < word.Length/2; i++) {
                if (word[i] == word[word.Length - i - 1]) {
                    test1 = true;
                }
                else {
                    test1 = false;
                    break;
                }
            }
            return test1;
        }
    }
}