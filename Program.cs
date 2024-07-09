using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Y9_DEC_TO_BIN_SKELETON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //STARTER: Practice using breakpoints and the watch window (F8 to single-step, F11 to start in single step mode)
            int myInt = 0; //just for testing single stepping
            string myString = "12"; //watch me being cast from string to int
            int myStringAsInt = Convert.ToInt32(myString); //watch me cast from string to int

            //MAIN:  NUMBER CONVERSION PROGRAM
            Console.WriteLine(numberConversion(210, 2));
            //CODE GOES HERE
        }

        //static void means the function will not return a value so it does not need a data type 
        //...this function DOES return a value so the method must have a data type
        static string numberConversion(int number, int numberbase)
        {
            //CODE GOES HERE
            int calc = number + numberbase;
            string result = calc.ToString();
            string text = "Return ";
            string newString = text + result;

            return newString; //REMOVE THE RED LINE!
        }
        
        int remainder = 0; 
Console.WriteLine("Please enter a denary number within the range of 1-256: ");
int denaryNum = int.Parse(Console.ReadLine()); //converts the string to an integer
while (denaryNum <= 256 && denaryNum >= 1) //makes sure number is in the range
{
    remainder = denaryNum % 2; //finds module of denaryNum (remainder of its division by 2)
    denaryNum = denaryNum / 2;
    string binaryNum = string.Empty; //declares empty string
    binaryNum = remainder.ToString(); //converts remainder to a string so that it can be outputted
    Console.Write(binaryNum);
}
