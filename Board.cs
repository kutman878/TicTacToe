using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Logic
{
    public class Board
    {
        //доска
        public char[,] board = new char[3, 3] { 
            { '#', '#', '#' }, 
            { '#', '#', '#' }, 
            { '#', '#', '#' } };

        //вывод доски
        public void PrintBoard(char[,] board)
        {
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{board[i, 0]} | {board[i, 1]} | {board[i, 2]}");
            }
        }

        //проверка победы
        public bool CheckWin(char player)
        {
            for(int i = 0; i < 3; i++)
            {
                //проверка строк
                if (board[i, 0] == player && board[i,1] == player && board[i, 2] == player)
                {
                    return true;
                }
                //проверка столбцов
                if (board[0, i] == player && board[1, i] == player && board[2, i] == player)
                {
                    return true;
                }
            }
            //проверка диагоналей
            if (board[0, 0] == player && board[1, 1] == player && board[2, 2] == player)
            {
                return true;
            }
            if (board[0, 2] == player && board[1, 1] == player && board[2, 0] == player)
            {
                return true;
            }
            return false;
        }

        //проверка ничьей
        public bool CheckDraw()
        {
            for(int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] == '#')
                    {
                        return false; 
                    }
                }
            }
            return true;
        }
    }
    public enum Player
    {
        X,
        O
    }
}
