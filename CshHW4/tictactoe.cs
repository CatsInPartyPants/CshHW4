using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CshHW4
{
    internal class tictactoe
    {
        private string _firstName;
        private string _secondName;
        public string firstPlayerChar = "";
        public string secondPlayerChar = "";
        public string[,] board = new string[3, 3];

        public tictactoe()
        {
            board = new string[3, 3];
            for(int i = 0; i < board.GetLength(0); i++)
            {
                for(int j = 0; j < board.GetLength(1); j++)
                {
                    board[i, j] = "_";
                }
            }
        }
        public void EnterNames()
        {
            Console.WriteLine("Enter the name of the first player:");
            _firstName = Console.ReadLine();
            Console.WriteLine("Enter the name of the second player:");
            _secondName = Console.ReadLine();
        }

        public void ChooseChar()
        {
            Console.WriteLine($"What is the char of {_firstName}? X or Y");
            firstPlayerChar = Console.ReadKey().ToString();
            _ = (firstPlayerChar == "X") ? secondPlayerChar = "O" : secondPlayerChar = "X";
        }

        public void Show()
        {
            Console.WriteLine("1 2 3");
            for (int i = 0; i < board.GetLength(0); i++)
            {
                Console.Write(i + 1);
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    Console.Write($"|{board[i, j]}");
                }
                Console.WriteLine("|");
            }
        }

        public bool win()
        {
            if (board[0,0] == board[0,1] && board[0,1] == board[0,2] && board[0,0] != "_") return false;
            if (board[1][0] == board[1][1] && board[1][1] == board[1][2] && board[1][0] != '_') return false;
            if (board[2][0] == board[2][1] && board[2][1] == board[2][2] && board[2][0] != '_') return false;

            if (board[0][0] == board[1][0] && board[1][0] == board[2][0] && board[0][0] != '_') return false;
            if (board[0][1] == board[1][1] && board[1][1] == board[2][1] && board[0][1] != '_') return false;
            if (board[0][2] == board[1][2] && board[1][2] == board[2][2] && board[0][2] != '_') return false;

            if (board[0][0] == board[1][1] && board[1][1] == board[2][2] && board[0][0] != '_') return false;
            if (board[0][2] == board[1][1] && board[1][1] == board[2][0] && board[0][2] != '_') return false;

            return true;
        }

    }
}
