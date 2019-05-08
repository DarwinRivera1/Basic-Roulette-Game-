using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTA322Exercise8C
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lets Play Roulette");
            RandomRoll();
        }
        static void RandomRoll()
        {
            int[] red = { 0, 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 };
            int[] black = { 0, 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35 };

            Random random = new Random();

            int bet = random.Next(0, 36);
            int landred;
            int landblack;
            int temp;
            int choice = random.Next(0, 2);
            int final;

            temp = random.Next(0, red.Length);

            Console.WriteLine("The bet placed is:" + bet);

            landred = red[temp];

            temp = random.Next(0, black.Length);

            landblack = black[temp];

            final = (choice == 0) ? landblack : landred;

            if (landblack == 0)
            {
                Console.WriteLine("The Ball landed on 00");
            }
            else if (landred == 0)
            {
                Console.WriteLine("The Ball landed on 0");
            }
            else if (final == landblack)
            {
                Console.WriteLine("The Ball landed on Black " + landblack);
            }
            else if (final == landred)
            {
                Console.WriteLine("The Ball landed on Red " + landred);
            }
            if (bet == final)
            {
                Console.WriteLine("Winner Winner Chicken Dinner.");
            }
            if (final >= 19)
            {
                Console.WriteLine("High Bets Win");
            }
            else if (final <= 18)
            {
                Console.WriteLine("Low bets Win");
            }
            if (CheckArray(red, final) && final != 0)
            {
                Console.WriteLine("Bets on Red Win");
            }
            else if (CheckArray(black, final) && final != 0)
            {
                Console.WriteLine("Bets on Black Win");
            }
            else if (CheckArray(black, bet) == true && final != 0)
            {
                Console.WriteLine("Your bet on Black Won");
            }
            if (CheckOdd(final) == true && final != 0)
            {
                Console.WriteLine("Odd bets win");
            }
            else if (CheckOdd(final) == false && final != 0)
            {
                Console.WriteLine("Even bets win");
            }
            if (final <= 12)
            {
                Console.WriteLine("Dozen # 1 win (1-12)");
            }
            else if (final > 12 && final <= 24)
            {
                Console.WriteLine("Dozen # 2 win (13-24)");
            }
            else if (final > 24 && final <= 36)
            {
                Console.WriteLine("Dozen # 3 win (25-36)");
            }
            else if (final <= 18)
            {
                Console.WriteLine("Low bets Win");
            }
            if (final == 1 || final == 4 || final == 7 || final == 10 || final == 13 || final == 16 || final == 19 || final == 22 || final == 25 || final == 28 || final == 31 || final == 34)
            {
                Console.WriteLine("Column 1 wins");
            }
            if (final == 2 || final == 5 || final == 8 || final == 11 || final == 14 || final == 17 || final == 20 || final == 23 || final == 26 || final == 29 || final == 32 || final == 35)
            {
                Console.WriteLine("Column 2 wins");
            }
            if (final == 3 || final == 6 || final == 9 || final == 12 || final == 15 || final == 18 || final == 21 || final == 24 || final == 27 || final == 30 || final == 33 || final == 36)
            {
                Console.WriteLine("Column 3 wins");
            }
            if (final == 1 || final == 2 || final == 3)
            {
                Console.WriteLine("Street Row 1 wins");
            }
            else if (final == 4 || final == 5 || final == 6)
            {
                Console.WriteLine("Street Row 2 wins");
            }
            else if (final == 7 || final == 8 || final == 9)
            {
                Console.WriteLine("Street Row 3 wins");
            }
            else if (final == 10 || final == 11 || final == 12)
            {
                Console.WriteLine("Street Row 4 wins");
            }
            else if (final == 13 || final == 14 || final == 15)
            {
                Console.WriteLine("Street Row 5 wins");
            }
            else if (final == 16 || final == 17 || final == 18)
            {
                Console.WriteLine("Street Row 6 wins");
            }
            else if (final == 19 || final == 20 || final == 21)
            {
                Console.WriteLine("Street Row 7 wins");
            }
            else if (final == 22 || final == 23 || final == 24)
            {
                Console.WriteLine("Street Row 8 wins");
            }
            else if (final == 25 || final == 26 || final == 27)
            {
                Console.WriteLine("Street Row 9 wins");
            }
            else if (final == 28 || final == 29 || final == 30)
            {
                Console.WriteLine("Street Row 10 wins");
            }
            else if (final == 31 || final == 32 || final == 33)
            {
                Console.WriteLine("Street Row 11 wins");
            }
            else if (final == 34 || final == 35 || final == 66)
            {
                Console.WriteLine("Street Row 12 wins");
            }
            if (final == 1 || final == 2 || final == 3 || final == 4 || final == 5 || final == 6)
            {
                Console.WriteLine("6th Line #1 wins");
            }
            else if (final == 7 || final == 8 || final == 9 || final == 10 || final == 11 || final == 12)
            {
                Console.WriteLine("6th Line #2 wins");
            }
            else if (final == 13 || final == 14 || final == 15 || final == 16 || final == 17 || final == 18)
            {
                Console.WriteLine("6th Line #3 wins");
            }
            else if (final == 19 || final == 20 || final == 21 || final == 22 || final == 23 || final == 24)
            {
                Console.WriteLine("6th Line #4 wins");
            }
            else if (final == 25 || final == 26 || final == 27 || final == 28 || final == 29 || final == 30)
            {
                Console.WriteLine("6th Line #5 wins");
            }
            else if (final == 31 || final == 32 || final == 33 || final == 34 || final == 35 || final == 36)
            {
                Console.WriteLine("6th Line #6 wins");
            }
            if (final == 1 || final == 2 || final == 4 || final == 5)
            {
                Console.WriteLine("Corner 1/2/4/5 Wins");
            }
            if (final == 2 || final == 3 || final == 5 || final == 6)
            {
                Console.WriteLine("Corner 2/3/5/6 Wins");
            }
            if (final == 4 || final == 5 || final == 7 || final == 8)
            {
                Console.WriteLine("Corner 4/5/7/8 Wins");
            }
            if (final == 5 || final == 6 || final == 8 || final == 9)
            {
                Console.WriteLine("Corner 5/6/8/9 Wins");
            }
            if (final == 7 || final == 8 || final == 10 || final == 11)
            {
                Console.WriteLine("Corner 7/8/10/11 Wins");
            }
            if (final == 8 || final == 9 || final == 11 || final == 12)
            {
                Console.WriteLine("Corner 8/9/11/12 Wins");
            }
            if (final == 10 || final == 11 || final == 13 || final == 14)
            {
                Console.WriteLine("Corner 10/11/13/14 Wins");
            }
            if (final == 11 || final == 12 || final == 14 || final == 15)
            {
                Console.WriteLine("Corner 11/12/14/15 Wins");
            }
            if (final == 13 || final == 14 || final == 16 || final == 17)
            {
                Console.WriteLine("Corner 13/14/16/17 Wins");
            }
            if (final == 14 || final == 15 || final == 17 || final == 18)
            {
                Console.WriteLine("Corner 14/15/17/18 Wins");
            }
            if (final == 16 || final == 17 || final == 19 || final == 20)
            {
                Console.WriteLine("Corner 16/17/19/20 Wins");
            }
            if (final == 17 || final == 18 || final == 20 || final == 21)
            {
                Console.WriteLine("Corner 17/18/20/21 Wins");
            }
            if (final == 19 || final == 20 || final == 22 || final == 23)
            {
                Console.WriteLine("Corner 19/20/22/23 Wins");
            }
            if (final == 20 || final == 21 || final == 23 || final == 24)
            {
                Console.WriteLine("Corner 20/21/23/24 Wins");
            }
            if (final == 22 || final == 23 || final == 25 || final == 26)
            {
                Console.WriteLine("Corner 22/23/25/26 Wins");
            }
            if (final == 23 || final == 24 || final == 26 || final == 27)
            {
                Console.WriteLine("Corner 23/24/26/27 Wins");
            }
            if (final == 25 || final == 26 || final == 28 || final == 29)
            {
                Console.WriteLine("Corner 25/26/28/29 Wins");
            }
            if (final == 26 || final == 27 || final == 29 || final == 30)
            {
                Console.WriteLine("Corner 26/27/29/30 Wins");
            }
            if (final == 28 || final == 29 || final == 31 || final == 32)
            {
                Console.WriteLine("Corner 28/29/31/32 Wins");
            }
            if (final == 29 || final == 30 || final == 32 || final == 33)
            {
                Console.WriteLine("Corner 29/30/32/33 Wins");
            }
            if (final == 31 || final == 32 || final == 34 || final == 35)
            {
                Console.WriteLine("Corner 31/32/34/35 Wins");
            }
            if (final == 32 || final == 33 || final == 35 || final == 36)
            {
                Console.WriteLine("Corner 32/33/35/36 Wins");
            }
            if (final == 00)
            {
                Console.WriteLine("00 wins");
            }
        }
        static bool CheckArray(int[] arr, int x)
        {
            if (Array.Exists(arr, element => element == x))
            {
                return true;
            }
            else
                return false;
        }
        static bool CheckOdd(int num)
        {
            if (num % 2 == 0)
                return false;
            else
                return true;
        }
    }
}
