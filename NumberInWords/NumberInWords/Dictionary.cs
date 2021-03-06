using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberInWords
{
    class DictionaryOfWords

    {
        public Dictionary<int, string> numberDictionary = new Dictionary<int, string>()
        {
            { 0, "" },
            { 1, "один" },
            { 2, "два" },
            { 3, "три" },
            { 4, "четыре" },
            { 5, "пять" },
            { 6, "шесть" },
            { 7, "семь" },
            { 8, "восемь" },
            { 9, "девять" },
            { 10, "десять" },
            { 11, "одинадцать" },
            { 12, "двенадцать" },
            { 13, "тринадцать" },
            { 14, "четырнадцать" },
            { 15, "пятнадцать" },
            { 16, "шестнадцать" },
            { 17, "семнадцать" },
            { 18, "восемнадцать" },
            { 19, "девятнадцать" },
            { 20, "двадцать" },
            { 30, "тридцать" },
            { 40, "сорок" },
            { 50, "пятьдесят" },
            { 60, "шестьдесят" },
            { 70, "семьдесят" },
            { 80, "восемьдесят" },
            { 90, "девяносто" },
            { 100, "сто" },
            { 200, "двести" },
            { 300, "триста" },
            { 400, "четыреста" },
            { 500, "пятьсот" },
            { 600, "шестьсот" },
            { 700, "семьсот" },
            { 800, "восемьсот" },
            { 900, "девятьсот" }
        };

        public Dictionary<int, string> numberRank = new Dictionary<int, string>()
        {
            { 1, "" },
            { 2, "" },
            { 3, "" },
            { 0, "миллионов" },

            { 12, " тысяча " },
            { 13, " тысячи " },
            { 14, " тысяч " },
            
            { 9, " миллион " },
            { 10, " миллиона " },
            { 11, " миллионов " },

            { 15, " " },
            { 16, " " },
            { 17, " " },
            { 18, " " },

    };
    }
}
