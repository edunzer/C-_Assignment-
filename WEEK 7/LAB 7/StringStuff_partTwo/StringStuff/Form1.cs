using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringStuff
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static class WordTools
        {
            // WORD REVERSE CONVERTER
            public static string ReverseWords(string str)
            {
                char[] chars = str.ToCharArray();
                Array.Reverse(chars);
                return new string(chars);
            }

            // VOWEL DICTONARY
            public static bool IsVowel(char c)
            {
                return (c == 'A' || c == 'E' ||
                        c == 'I' || c == 'O' ||
                        c == 'U' || c == 'a' ||
                        c == 'e' || c == 'i' ||
                        c == 'o' || c == 'u');
            }

            // PIGLATEN CONVERTER
            public static string PigLatinConverter(string s)
            {

                int len = s.Length;
                int index = -1;
                for (int i = 0; i < len; i++)
                {
                    if (IsVowel(s[i]))
                    {
                        index = i;
                        break;
                    }
                }

                if (index == -1)
                    return "-1";

                return s.Substring(index) +
                       s.Substring(0, index)
                                      + "ay";
            }

            // CASE CONVERTER
            public static void ConvertOpposite(StringBuilder str)
            {
                int ln = str.Length;

                for (int i = 0; i < ln; i++)
                {
                    if (str[i] >= 'a' && str[i] <= 'z')

                        str[i] = (char)(str[i] - 32);

                    else if (str[i] >= 'A' && str[i] <= 'Z')

                        str[i] = (char)(str[i] + 32);
                }
            }

            // DOLLAR SIGN INJECTOR
            public static string DollarSignConverter(string str)
            {
                return str = String.Join<char>("$", str) + "$";
                
            }
        }

        
        private string CaseSwitch()
        {
            StringBuilder str = new StringBuilder(txtEnter.Text);
            WordTools.ConvertOpposite(str);

            return txtCaseSwitch.Text = str.ToString();

        }

        private string Reverse()
        {
            string str = txtEnter.Text;
            return txtReverse.Text = WordTools.ReverseWords(str.ToString());
        }

       
        private string PigLatin()
        {
            string str = WordTools.PigLatinConverter(txtEnter.Text);

            if (str == "-1")
                return txtPigLatin.Text = "Error no vowels";
            else
                return txtPigLatin.Text = str.ToString();
        }

        private string DollarSign()
        {
            string str = WordTools.DollarSignConverter(txtEnter.Text);
            return txtDollarSigns.Text = str.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CaseSwitch();
            Reverse();
            PigLatin();
            DollarSign();

        }
    }
}
