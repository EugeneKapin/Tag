﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Tag
{
    class Program
    {
        static void Main(string[] args)
        {
            Game margin = new Game(1, 2, 3, 4, 5, 6, 7, 0, 8);
            Game2 margin1 = new Game2(2, 1, 3, 4, 5, 6, 7, 0, 8);
            Game3 margin2 = new Game3(1, 2, 3, 4, 5, 6, 7, 0, 8);
            ConsoleGameUI obj = new ConsoleGameUI(margin2);
            obj.StartGame();

            //Field.Playingfield(margin.Numbers);
            //margin.Shift(4);
            //Field.Playingfield(margin.Numbers);
            //margin.Shift(5);
            //Field.Playingfield(margin.Numbers);
            //margin.Shift(10);
            //Field.Playingfield(margin.Numbers);
            //Console.WriteLine("После");
            //Field.Playingfield(margin1.Numbers);
            //Console.WriteLine(margin.GetStep(1));
            //Console.WriteLine(margin.GetStep(2));
            //Console.WriteLine(margin.GetStep(3));
            //Console.WriteLine("{0} with coordinate ({1}) replaced to ({2})", value, margin.GetLocation(0), margin.GetLocation(value));
            //Game game = new Game(1, 6, 4, 0, 2, 3, 5, 7, 8, 11, 10, 9, 14, 12, 13, 15);
            //Field.Playingfield(game.Numbers);
            //Console.WriteLine(game.GetLocation(0));
            //game.Shift(4);
            //Console.WriteLine(game.GetLocation(0));
            //Field.Playingfield(game.Numbers);
        }
    }
}
