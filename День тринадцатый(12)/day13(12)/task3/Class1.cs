using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Class1
    {
        public delegate string TextEditing(string text, char letter);

        public static string SearchIndex(string text, char letter)
        {
            int index = text.IndexOf(letter);
            return Convert.ToString(index);
        }

        public static string CaseChangeLower(string text, char letter)
        {
            string newText = text.ToLower();
            return newText;
        }

        public static string CaseChangeUpper(string text, char letter)
        {
            string newText = text.ToUpper();
            return newText;
        }
    }
}
