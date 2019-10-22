using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class GamePlay
    {
        int[,] board;
        int player;  // 1 : player makes X, and 2: player makes O
        const int SIZE = 3;   
        public int[,] Board { get => board; }

        //1. CreateBoard()
        public void CreateBoard()
        {
            board = new int[SIZE, SIZE];
            for (int i = 0; i < SIZE; i++)
            {
                for (int j = 0; j < SIZE; j++)
                    board[i, j] = 0; // initiate before playing
            }
        }
        //2. CurrentPlayer()
        public string CurrentPlayer()
        {
            if (player == 1)
                return "X";
            else
                return "O";
        }
        //3. ChangePlayer()
        public void ChangePlayer(string player)
        {
            if (player == "X")
                this.player = 1;
            else
                this.player = 2;
        }
        //4. MakeMove()
        public void MakeMove(int row, int col)
        {
            board[row, col] = this.player;
        }
        //5. SpaceInUse()
        public bool SpaceInUse(int row, int col)
        {
            if (board[row, col] != 0)
                return true;
            return false;
        }
    }
}
