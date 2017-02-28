using System;
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
            Game game = new Game(1, 2, 0, 4, 6, 3, 7, 5, 8);
            Field.Playingfield(game.Numbers);   
            game.Shift(3);
            Field.Playingfield(game.Numbers);
            game.Shift(6);
            Field.Playingfield(game.Numbers);
            game.Shift(5);
            Field.Playingfield(game.Numbers);
            game.Shift(8);
            Field.Playingfield(game.Numbers);
            Console.WriteLine("Position number 7: {0}", game.GetLocation(7));
            Console.WriteLine("Position zero: {0}", game.GetLocation(0));
            Console.WriteLine();
            Game game2 = Game.FromCSV("File.csv");
            Field.Playingfield(game2.Numbers);
        }
    }
}
