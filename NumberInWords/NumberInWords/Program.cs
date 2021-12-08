using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberInWords
{
    public class Program

       
    {
        static void Main(string[] args)

        {
            InputFormatValidate inputFormatValidate = new InputFormatValidate();



            // работаем с тройками
            string numberInDigit = inputFormatValidate.InputNumber();// numberInDigit в формате 000 000 000
            string[] threeNumMassive = numberInDigit.Split(' ');

            

            for (int i = 0; i < 3; i++)
            {

                numberInDigit = threeNumMassive[i];
                //Console.WriteLine("***"+numberInDigit[1]+numberInDigit[2]+"***");
                


                int hundreds = (numberInDigit[0] - 48) * 100;
                int dozens = (numberInDigit[1] - 48) * 10;
                int units = numberInDigit[2] - 48;

                int indexEnding = numberInDigit[2] - 48;
                //Console.WriteLine(dozens + units);
                //Console.WriteLine($"i= { i}");
                //Console.WriteLine(indexEnding);
                //Console.WriteLine(dozens);

                //ифы для окончаний
                if (4 < dozens+units && dozens+units < 21) { indexEnding = 11+3*i; }
                else if (4 < units && units < 10) { indexEnding = 11+3*i; }
                else if (units==1) { indexEnding = 9+3*i; }
                else if (1 < units && units < 5) { indexEnding = 10+3*i; }

                //
                //Console.WriteLine(indexEnding);


                if (10 <(dozens + units) && (dozens + units) < 21 )//как короче?
                { dozens = dozens + units; units = 0; }

                //Console.WriteLine(indexEnding);
                string numberInWords = new DictionaryOfWords().numberDictionary[hundreds] + " " + new DictionaryOfWords().numberDictionary[dozens] + " " + new DictionaryOfWords().numberDictionary[units]+" "+  new DictionaryOfWords().numberRank[indexEnding];
                if (numberInDigit=="000") { numberInWords = ""; }



                Console.WriteLine(numberInWords);
            }
        }


        






        }
    }

