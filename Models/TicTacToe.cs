using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeWars.Models
{
    public class TicTacToe
    {
        public static int TicTacToeChecker(int[,] board)
        {
            int[,] winningCombinations = new int[,]
            {
                { 0, 1, 2 },
                { 3, 4, 5 },
                { 6, 7, 8 },
                { 0, 3, 6 },
                { 1, 4, 7 },
                { 2, 5, 8 },
                { 0, 4, 8 },
                { 2, 4, 6 },
            };

            for (int i = 0; i < winningCombinations.GetLength(0); i++)
            {
                int a = winningCombinations[i, 0];
                int b = winningCombinations[i, 1];
                int c = winningCombinations[i, 2];

                if (
                    board[a / 3, a % 3] != 0
                    && board[a / 3, a % 3] == board[b / 3, b % 3]
                    && board[a / 3, a % 3] == board[c / 3, c % 3]
                )
                {
                    return board[a / 3, a % 3];
                }
            }

            foreach (int cell in board)
            {
                if (cell == 0)
                {
                    return -1;
                }
            }

            return 0;
        }
    }

    public class Board
    {
        public List<int[]> board = new List<int[]>();
    }
}
