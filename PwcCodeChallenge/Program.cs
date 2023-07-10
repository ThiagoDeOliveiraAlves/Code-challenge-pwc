using System.ComponentModel.DataAnnotations;

namespace PwcCodeChallenge {
    public class Program {
        public static void Main (String[] args) {
            //string phrase = "Hello, World! OpenAI is amazing.";
            string phrase = Console.ReadLine();
            Console.WriteLine(PhraseInverter(phrase)); //challenge 1
            //phrase = "Hello, World!";
            phrase = Console.ReadLine();
            Console.WriteLine(RemoveDuplicatedChars(phrase)); //challenge 2
            //phrase = "babad";
            phrase = Console.ReadLine();
            Console.WriteLine(PalindromeSubStr(phrase)); //challenge 3
            //phrase = "hello. how are you? i'm fine, thank you.";
            phrase = Console.ReadLine();
            Console.WriteLine(Challenge4(phrase)); //challenge 4
            //phrase = "racecar";
            phrase = Console.ReadLine();
            Console.WriteLine(IsPalindrome(phrase)); //challenge 5
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

        public static string Challenge4(string phrase) {
            phrase = phrase.Trim();
            string aux1 = phrase[0].ToString().ToUpper();
            bool test = false;

            for (int i = 1; i < phrase.Length; i++) {
                if (phrase[i] == '.' || phrase[i] == '!' || phrase[i] == '?') {
                    aux1 += phrase[i];
                    test = true;
                    if (phrase.Length - i >= 2) {
                        aux1 += phrase[i + 1];
                        i++;
                    }
                }
                else if (test == true && phrase[i] == ' ') { //in case there is more than one space after '.', '!' or '?';
                    aux1 += phrase[i];
                }
                else if (test == true && phrase[i] != ' ') {
                    aux1 += phrase[i].ToString().ToUpper();
                    test = false;
                }
                else {
                    aux1 += phrase[i];
                    test = false;
                }
            }
            return aux1;
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