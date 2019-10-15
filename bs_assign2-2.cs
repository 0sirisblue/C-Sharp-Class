// Britton Starr  -  9/9/2019  -  SDEV240
//Change Maker App 2.13
//Make an app that takes a numeric input for dollars/cents, and converts the change into the various coins/bills.

using System;
using static System.Console;

namespace ChangeMaker
{
    class ChangeCalculator
    {
        static void Main()
        {
            //Initial setup to keep track of values and number of a particular bill or coin
            string InitMoney = "";
            decimal MoneyRemaining = 0;

            decimal Hundred = 100;
            decimal Twenty = 20;
            decimal Ten = 10;
            decimal Five = 5;
            decimal One = 1;
            decimal Quarter = 0.25M;
            decimal Dime = 0.10M;
            decimal Nickel = 0.05M;
            decimal Penny = 0.01M;

            int NumberOfHundreds = 0;
            int NumberofTwenties = 0;
            int NumberOfTens = 0;
            int NumberOfFives = 0;
            int NumberOfOnes = 0;
            int NumberOfQuarters = 0;
            int NumberOfDimes = 0;
            int NumberOfNickels = 0;
            int NumberOfPennies = 0;

            //Get initial user input, and convert to a decimal data type.

            WriteLine("Welcome to Change Maker!");
            WriteLine("");
            Write("How much change do you need? : $");
            InitMoney = ReadLine();
            decimal InitMoneyAsDecimal = Convert.ToDecimal(InitMoney);

            //Calculate change, and display to the user. Each set of three lines does a bill/coin

            NumberOfHundreds = (int)(InitMoneyAsDecimal / Hundred);
            MoneyRemaining = (InitMoneyAsDecimal - (NumberOfHundreds * Hundred));
            WriteLine("{0} hundreds.", NumberOfHundreds);
            NumberofTwenties = (int)(MoneyRemaining / Twenty);
            MoneyRemaining -= (NumberofTwenties * Twenty);
            WriteLine("{0} twenties.", NumberofTwenties);
            NumberOfTens = (int)(MoneyRemaining / Ten);
            MoneyRemaining -= (NumberOfTens * Ten);
            WriteLine("{0} tens.", NumberOfTens);
            NumberOfFives = (int)(MoneyRemaining / Five);
            MoneyRemaining -= (NumberOfFives * Five);
            WriteLine("{0} fives.", NumberOfFives);
            NumberOfOnes = (int)(MoneyRemaining / One);
            MoneyRemaining -= (NumberOfOnes * One);
            WriteLine("{0} ones.", NumberOfOnes);
            NumberOfQuarters = (int)(MoneyRemaining / Quarter);
            MoneyRemaining -= (NumberOfQuarters * Quarter);
            WriteLine("{0} quarters.", NumberOfQuarters);
            NumberOfDimes = (int)(MoneyRemaining / Dime);
            MoneyRemaining -= (NumberOfDimes * Dime);
            WriteLine("{0} dimes.", NumberOfDimes);
            NumberOfNickels = (int)(MoneyRemaining / Nickel);
            MoneyRemaining -= (NumberOfNickels * Nickel);
            WriteLine("{0} nickels.", NumberOfNickels);
            NumberOfPennies = (int)(MoneyRemaining / Penny);
            MoneyRemaining -= (NumberOfPennies * Penny);
            WriteLine("{0} pennies.", NumberOfPennies);
            WriteLine("");
            WriteLine("You have successfully made ${0} in change.", InitMoney);
            ReadLine();


        }
    }
}
