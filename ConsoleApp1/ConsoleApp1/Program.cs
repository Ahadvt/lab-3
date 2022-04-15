
using ConsoleApp1.Models;
using System;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Class Task 

            Hell hell = new Hell(10, 4);
            Redbull redbull = new Redbull(100,50);

            hell.ShowCostPrice();
            hell.ShowSalePrice();
            hell.ShowEarn();

            redbull.ShowCostPrice();
            redbull.ShowSalePrice();
            redbull.ShowEarn();
            #endregion
            #region Reverse Task
            ReverseSentence("Hello World");
            #endregion
        }


        static void ReverseSentence(string str)
        {
            string[] ArrayStr = str.Split(" ");
            for (int i = 0; i < ArrayStr.Length; i++)
            {
                char[] CharArr = ArrayStr[i].ToCharArray();
             
                string Result = string.Empty;
                for (int j =CharArr.Length-1; j>=0 ; j--)
                {
                    Result += CharArr[j];
                }
                Console.Write(Result+" ");
            }
        }
    }
}
