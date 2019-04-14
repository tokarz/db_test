using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesPracticeTest.Zadanie
{

    // wykrywacz palindromow
    public class Zadanie1
    {
        public bool IsPalindrome(string text)
        {
            if (string.IsNullOrEmpty(text)) return false;

            for (int x = 0; x < text.Length / 2; x++)
            {
                if (text[x] != text[text.Length - 1 - x])
                    return false;
            }

            return true;
        }

        public bool IsPalindromAnagram(string text)
        {
            Dictionary<string, int> Slownik = new Dictionary<string, int>();
            // abba
            //aaaaaaaaaaaaaaaaaaaaabaaaaaaaaaaaaaaaaaaaaa
            //abbbba 2a, 4b
            //abccccba 
            //aba  2a, 1b

            //ccccbaab , 2b, 2a, 4c

            //aaabbbcc -> aba  cc  aba  3a, 3b, 2c

            //abc  3, 1 1 1
            //abbc
            //abbca 5, 2, 2, 1

            if (string.IsNullOrEmpty(text)) return false;

            for(int i = 0; i< text.Length; i++)
            {
                // jesli litera istnieje w slowniku - zwieksz licznik
                // jesli nie - ustaw na 1
            }

            return false;
        }


    }
}
