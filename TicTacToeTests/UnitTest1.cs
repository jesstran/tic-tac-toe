using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TicTacToeTests
{
    [TestClass]
    public class UnitTest1
    {
        const int SIZE = 3;

        //1. Assert the board has 9 active fields
        [TestMethod]
        public void TestCreateBoard()
        {
            TicTacToe.GamePlay gamePlay = new TicTacToe.GamePlay();
            gamePlay.CreateBoard();
            int[,] board = gamePlay.Board;
            int expectedBoard = 9; // the created board has 9 fields
            int expected = 0; // value for initiating board            

            Assert.AreEqual(expectedBoard, board.Length);

            for (int i = 0; i < SIZE; i++)
            {
                for (int j = 0; j < SIZE; j++)
                    Assert.AreEqual(expected, board[i, j]);
            }            
        }
        //2. Assert the current player is X
        [TestMethod]
        public void TestCurrentPlayerX()
        {
            TicTacToe.GamePlay gamePlay = new TicTacToe.GamePlay();
            gamePlay.ChangePlayer("X");
            string player = gamePlay.CurrentPlayer();
            Assert.AreEqual("X", player);
        }
        //3. Assert the current player is O
        [TestMethod]
        public void TestCurrentPlayerO()
        {
            TicTacToe.GamePlay gamePlay = new TicTacToe.GamePlay();
            gamePlay.ChangePlayer("O");
            string player = gamePlay.CurrentPlayer();
            Assert.AreEqual("O", player);
        }
        //4. Assert that the current player places an X in a spot on the board
        [TestMethod]
        public void TestMakeMoveX()
        {
            TicTacToe.GamePlay gamePlay = new TicTacToe.GamePlay();
            gamePlay.CreateBoard();
            gamePlay.ChangePlayer("X");
            gamePlay.MakeMove(0, 0);
            Assert.AreEqual(1, gamePlay.Board[0, 0]);
        }
        //5. Assert that the current player places an O in a spot on the board
        [TestMethod]
        public void TestMakeMoveO()
        {
            TicTacToe.GamePlay gamePlay = new TicTacToe.GamePlay();
            gamePlay.CreateBoard();
            gamePlay.ChangePlayer("O");
            gamePlay.MakeMove(1, 1);
            Assert.AreEqual(2, gamePlay.Board[1, 1]);
        }
        //6. Assert that the placement is in an unoccupied spot*/
        [TestMethod]
        public void TestSpaceInUse()
        {
            TicTacToe.GamePlay gamePlay = new TicTacToe.GamePlay();
            gamePlay.CreateBoard();            
            
            Assert.AreEqual(false, gamePlay.SpaceInUse(0, 1));
            gamePlay.ChangePlayer("X");
            gamePlay.MakeMove(0, 1);
            Assert.AreEqual(true, gamePlay.SpaceInUse(0, 1));
        }
    }
}
