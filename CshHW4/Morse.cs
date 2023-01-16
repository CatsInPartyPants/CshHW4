using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CshHW4
{
    internal class Morse
    {
        private string _forDecode;
        private string _forEncode;

        private Dictionary<string, string> ABC;
        public Morse() {
            ABC = new Dictionary<string, string>
            {
                ["A"] = ".-",
                ["B"] = "-...",
                ["C"] = "-.-.",
                ["D"] = "-..",
                ["E"] = ".",
                ["F"] = "..-.",
                ["G"] = "--.",
                ["H"] = "....",
                ["I"] = "--",
                ["J"] = ".---",
                ["K"] = "-.-",
                ["L"] = ".-..",
                ["M"] = "--",
                ["N"] = "-.",
                ["O"] = "---",
                ["P"] = ".--.",
                ["Q"] = "--.-",
                ["R"] = ".-.",
                ["S"] = "...",
                ["T"] = "-",
                ["U"] = "..-",
                ["V"] = "...-",
                ["W"] = ".--",
                ["X"] = "-..-",
                ["Y"] = "-.--",
                ["Z"] = "--..",
                ["1"] = ".----",
                ["2"] = "..---",
                ["3"] = "...--",
                ["4"] = "....-",
                ["5"] = ".....",
                ["6"] = "-....",
                ["7"] = "--...",
                ["8"] = "---..",
                ["9"] = "----.",
                ["0"] = "-----",
                [" "] = " "

            };
        }

        public void showABC()
        {
            foreach(KeyValuePair<string, string> p in ABC)
            {
                Console.WriteLine($"{p.Key} : {p.Value}");
            }
        }

        public string Encode(string forEncode)
        {
            _forEncode = forEncode.ToUpper();
            char[] chars = _forEncode.ToCharArray();
            string encoded = "";
            foreach(var ch in chars)
            {
                foreach (KeyValuePair<string, string> p in ABC)
                {
                    if(ch.ToString() == p.Key)
                    {
                        encoded += p.Value;
                        encoded += " ";
                    }
                }
            }
            return encoded;
        }

        public string Decode(string forEncode)
        {
            _forEncode = forEncode;
            string decoded = "";
            string[] encodedLetters = _forEncode.Split(' ');
            foreach(string letter in encodedLetters)
            {
                foreach(KeyValuePair<string, string> p in ABC)
                {
                    if(letter == p.Value)
                    {
                        decoded += p.Key;
                    }
                }
            }

            return decoded;
        }


    }
}
