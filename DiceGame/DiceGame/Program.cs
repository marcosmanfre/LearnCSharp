﻿using System;

namespace DiceGame
{ 
    class Program
    {
        static void Main(string[] args) 
        {
            int playerRandomNum;

            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Press any key to roll the dice.");

                playerRandomNum = random.Next(1, 7);

                Console.ReadKey();

                playerRandomNum = random.Next(1, 7);
                Console.WriteLine("You rolled a  " + playerRandomNum);
            }
            Console.ReadLine();

        }
    }
        
 }