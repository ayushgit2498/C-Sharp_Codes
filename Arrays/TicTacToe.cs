using System;

namespace Arrays
{
    class TicTacToe
    {
        char [,]board;

        public TicTacToe()
        {
            board = new char[3,3];
            Initialize();
        }

        public void Initialize()
        {
            for(int i = 0;i < 3;i++)
                for(int j = 0;j < 3;j++)
                    board[i, j] = '*';
        }

        public void PrintBoard()
        {
                int counter = 1;
                Console.WriteLine("===================================");

                for(int i = 0;i < 3;i++)
                {
                    Console.Write("\t|");
                    for(int j = 0;j < 3;j++)
                    {
                        if(board[i,j] == '*')
                            Console.Write(counter + "|");
                        else
                            Console.Write(board[i, j] + "|");
                        counter++;
                    }
                    Console.WriteLine("\n \t________");
                }
                Console.WriteLine("===================================");
        }

        public string getIndexes(int p)
        {
            switch(p)
            {
                case 1:
                    return "00";
                case 2:
                    return "01";          
                case 3:
                    return "02";
                case 4:
                    return "10";
                case 5:
                    return "11";
                case 6:
                    return "12";
                case 7:
                    return "20";
                case 8:
                    return "21";
                case 9:
                    return "22";
                default:
                    return "wrong";
            }

        }
        public string CheckPosition(int p)
        {
            string c = getIndexes(p);
            if(c.Equals("wrong"))
            {
                return "1";
            }else
            {
                int i = c[0] - '0', j = c[1] - '0';
                if(board[i,j] == '*')
                    return c;
                else
                    return "2";
            }
        }

        public void SetBoard(char c, int i, int j)
        {
            // Console.WriteLine("test" + c + i + j);
            board[i, j] = c;
        }

        public char CheckConditions()
        {
            if(board[0, 0] == board[0, 1] && board[0, 1] == board[0,2])
                return board[0, 0];
            else if(board[1, 0] == board[1, 1] && board[1, 1] == board[1,2])
                return board[1 ,0];
            else if(board[2, 0] == board[2, 1] && board[2, 1] == board[2,2])
                return board[2 ,0];
            else if(board[0, 0] == board[1, 0] && board[1, 0] == board[2,0])
                return board[0 ,0];
            else if(board[0, 1] == board[1, 1] && board[1, 1] == board[2,1])
                return board[0 ,1];
            else if(board[0, 2] == board[1, 2] && board[1, 2] == board[2,2])
                return board[0 ,2];
            else if(board[0, 0] == board[1, 1] && board[1, 1] == board[2,2])
                return board[0 ,0];
            else if(board[0, 2] == board[1, 1] && board[1, 1] == board[2,0])
                return board[0 ,2];
            else
                return 'n';
        }
    }
}
