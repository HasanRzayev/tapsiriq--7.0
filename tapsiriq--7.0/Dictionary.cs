using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tapsiriq__7._0
{
    class Dict
    {

        public string[,] dictionary = new string[,] { };

        
        public int Findrow(string a)
        {
            for (int i = 0; i <dictionary.GetLength(0) ; i++)
            {
                for (int j = 0; j < dictionary.GetLength(1); j++)
                {
                    if (dictionary[i, j] == a) return i;
                }
            }
            return -1;
        }
        public int Findcolumn(string a)
        {
            for (int i = 0; i < dictionary.GetLength(0); i++)
            {
                for (int j = 0; j < dictionary.GetLength(1); j++)
                {
                    if (dictionary[i, j] == a) return j;
                }
            }
            return -1;
        }
      
        public string this[string i1]
        {
            get { 
                if(Findrow(i1)==-1 || Findcolumn(i1) == -1)
                {
                    return "0000";
                }
                else {
                    return dictionary[Findrow(i1), Findcolumn(i1)] ; 
                } 
            }
            set {

                string[,] dictionary2 = new string[dictionary.GetLength(0) + 1, 2];
                for (int i = 0; i < dictionary.GetLength(0); i++)
                {
                    dictionary2[i, 0] = dictionary[i, 0];
                    dictionary2[i, 1] = dictionary[i, 1];
                }

                dictionary2[dictionary2.GetLength(0) - 1, 0] = i1;
                dictionary2[dictionary2.GetLength(0) - 1, 1] = value;

                dictionary = new string[dictionary2.GetLength(0), 2];
                dictionary = dictionary2;

            }
        }

       
      
        public void Print()
        {
            Console.WriteLine("Luget baslayir");
            for (int i = 0; i < dictionary.GetLength(0); i++)
            {
                Console.WriteLine(dictionary[i, 0] + "   "+ dictionary[i, 1]);

            }
        }

        public string Mean(string c)
        {
            for (int i = 0; i < dictionary.GetLength(0); i++)
            {
                if (dictionary[i, 0] == c) return dictionary[i, 1];
            }
            return "0000";
        }
    }
}
