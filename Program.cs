﻿using System.Data;
using TicTacToe2;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace TicTacToe2
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
             const int COLUMN = 3;
             const int ROW = 3;
          
            UIMethods.DisplayMessage();
            int[,] grid = new int[COLUMN, ROW];
             //grid =Logic.PopulateWithUserChoice(grid, COLUMN, ROW);
            UIMethods.DisplayGrid();

            //make use of a grid and allow users to place a symbol
            //think of a way how a user can actually place a symbol into the play area
            //build an AI that also places their symbol
            //check when the game is over
            //keep a clean separation between ui and logic functions
        }
    }
}
