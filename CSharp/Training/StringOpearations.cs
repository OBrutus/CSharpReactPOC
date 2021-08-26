using System;
using System.Collections.Generic;
using System.Text;

namespace Training
{
    class StringOpearations
    {
        public void Run()
        {
            Console.WriteLine();
            Decor.star();
            Console.Write(" String operations ");
            Decor.star();
            Console.WriteLine();
            Decor.star();
            Decor.star();
            Decor.star();
            Console.WriteLine();

            Console.Write(" Enter String 1 ");
            String s1 = Console.ReadLine();
            Console.Write(" Enter String 2 ");
            String s2 = Console.ReadLine();
            UInt16 task = 0;
            Console.WriteLine($"{++task} Comparing strings {s1} and {s2} results\n" +
                $" [compare]:  {String.Compare(s1,s2)} \t [compareTo]: {s1.CompareTo(s2)}");
            Console.WriteLine($"{++task} Reversed Strings are {reverse(s1)} : {reverse(s2)}");
            Console.WriteLine($"{++task} {s1} isPalindrome {isPalindrome(s1)} : " +
                $"{s2} isPalindrome {isPalindrome(s2)}");
            Console.WriteLine($"{++task} For String {s1} ->\t vowel: {countVowel(s1, true)} \t  consonant: {countVowel(s1, false)}");
            Console.WriteLine($"{task} For String {s2} ->\t vowel: {countVowel(s2, true)} \t  consonant: {countVowel(s2, false)}");
            Console.WriteLine($"{++task} Upper case: {s1.ToLower()} \t Lower Case: {s1.ToUpper()}");
            Console.WriteLine($"{task} Upper case: {s2.ToLower()} \t Lower Case: {s2.ToUpper()}");
            Console.WriteLine($"{++task} Space Removed String : {s1.Replace(' ', '\0')}\n"
                +$"{task} Space Removed String : {s2.Replace(' ', '\0')}");
            Decor.star();
        }

        private int countVowel(string s, bool res)
        {
            int cnt = 0;
            s = s.ToLower();
            bool[] vovel = new bool[26];
            vovel[0] = vovel['e' - 'a'] = vovel['i' - 'a'] = vovel['o' - 'a'] = vovel['u' - 'a'] = true;
            foreach(char letter in s)
            {
                int index = letter - 'a';
                if (index < 26 && index >= 0 && vovel[index] == res)
                    cnt++;
            }
            return cnt;
        }

        private bool isPalindrome(string s)
        {
            return s.Equals(reverse(s));
        }

        private string reverse(string s, int index = 0)
        {
            if (s.Length-1 <= index)
                return s[index]+"";
            return reverse(s, index+1) + s[index];
        }

        void task()
        {

        }
    }
}
