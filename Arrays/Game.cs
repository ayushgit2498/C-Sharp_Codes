using System;

namespace Arrays
{
    class Game
    {
        TicTacToe t1;
        public void Prepare()
        {
            t1 = new TicTacToe();
            t1.PrintBoard();
        }

        public void Start()
        {
            bool turn = true, flag = false;
            int counter = 9;
            int position;
            string check;  
            char c;          

            while(counter != 0)
            {
                if(turn)
                    Console.WriteLine("It is x's turn");
                else
                    Console.WriteLine("It is o's turn");
                Console.WriteLine("Please enter the position number");
                try
                {
                    position = int.Parse(Console.ReadLine());
                }
                catch (System.Exception)
                {
                    Console.WriteLine("======================================================");
                    Console.WriteLine("Please enter an integer number.");
                    Console.WriteLine("======================================================");
                    continue;
                }
                check = t1.CheckPosition(position);
                if(check == "1")
                {
                    Console.WriteLine("======================================================");
                    Console.WriteLine("Wrong input.Please select enter a position p between 1<=p<=9.");
                    Console.WriteLine("======================================================");
                    continue;
                }else if(check == "2")
                {
                    Console.WriteLine("======================================================");
                    Console.WriteLine("place already filled.Please select other position.");
                    Console.WriteLine("======================================================");
                    continue;
                }else
                {
                    int i = check[0] - '0', j = check[1] - '0';
                    if(turn)
                    {
                        t1.SetBoard('x', i, j);
                    }else
                    {
                        t1.SetBoard('o', i, j);
                    }
                    turn = !turn;
                    c = t1.CheckConditions();
                    if(c == 'x')
                    {
                        t1.PrintBoard();
                        Console.WriteLine("Winner is x.");
                        flag = true;
                        break;
                    }else if(c == 'o')
                    {
                        t1.PrintBoard();
                        Console.WriteLine("Winner is o.");
                        flag = true;
                        break;          
                    }
                    t1.PrintBoard();
                }
                counter--;
            }
            if(!flag)
                Console.WriteLine("It's a tie.");
        }
    }
}
