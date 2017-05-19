using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


class VS_Player
{
    static char[] game_Board = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    static int player = 0;
    static int choice;

    static int flag = 0;
    
    private static void Board()
    {
        Console.WriteLine("     |     |      ");
        Console.WriteLine("  {0}  |  {1}  |  {2}", game_Board[1], game_Board[2], game_Board[3]);
        Console.WriteLine("_____|_____|_____ ");
        Console.WriteLine("     |     |      ");
        Console.WriteLine("  {0}  |  {1}  |  {2}", game_Board[4], game_Board[5], game_Board[6]);
        Console.WriteLine("_____|_____|_____ ");
        Console.WriteLine("     |     |      ");
        Console.WriteLine("  {0}  |  {1}  |  {2}", game_Board[7], game_Board[8], game_Board[9]);
        Console.WriteLine("     |     |      ");
    }
    
    private static int CheckWin()
    {
        //Winning Condition For First Row   
        if (game_Board[1] == game_Board[2] && game_Board[2] == game_Board[3])
        {
            return 1;
        }
        //Winning Condition For Second Row   
        else if (game_Board[4] == game_Board[5] && game_Board[5] == game_Board[6])
        {
            return 1;
        }
        //Winning Condition For Third Row   
        else if (game_Board[6] == game_Board[7] && game_Board[7] == game_Board[8])
        {
            return 1;
        }

        //Winning Condition For First Column       
        else if (game_Board[1] == game_Board[4] && game_Board[4] == game_Board[7])
        {
            return 1;
        }
        //Winning Condition For Second Column  
        else if (game_Board[2] == game_Board[5] && game_Board[5] == game_Board[8])
        {
            return 1;
        }
        //Winning Condition For Third Column  
        else if (game_Board[3] == game_Board[6] && game_Board[6] == game_Board[9])
        {
            return 1;
        }
 
        else if (game_Board[1] == game_Board[5] && game_Board[5] == game_Board[9])
        {
            return 1;
        }
        else if (game_Board[3] == game_Board[5] && game_Board[5] == game_Board[7])
        {
            return 1;
        }

        // If all the cells or values filled with X or O then any player has won the match  
        else if (game_Board[1] != '1' && game_Board[2] != '2' && game_Board[3] != '3' && game_Board[4] != '4' && game_Board[5] != '5' && game_Board[6] != '6' && game_Board[7] != '7' && game_Board[8] != '8' && game_Board[9] != '9')
        {
            return -1;
        }

        else
        {
            return 0;
        }

    }


    public void vs_player()
    {
        do
        {
            Console.Clear();// whenever loop will be again start then screen will be clear  
            Console.WriteLine("Player1:X and Player2:O");
            Console.WriteLine("\n");
            if (player % 2 == 0)//checking the chance of the player  
            {
                Console.WriteLine("Player 2 Chance");
            }
            else
            {
                Console.WriteLine("Player 1 Chance");
            }
            Console.WriteLine("\n");
            Board();// calling the board Function  
            choice = int.Parse(Console.ReadLine());//Taking users choice   

            // checking that position where user want to run is marked (with X or O) or not  
            if (game_Board[choice] != 'X' && game_Board[choice] != 'O')
            {
                if (player % 2 == 0) //if chance is of player 2 then mark O else mark X  
                {
                    game_Board[choice] = 'O';
                    player++;
                }
                else
                {
                    game_Board[choice] = 'X';
                    player++;
                }
            }
            else //If there is any possition where user want to run and that is already marked then show message and load board again  
            {
                Console.WriteLine("Sorry the row {0} is already marked with {1}", choice, game_Board[choice]);
                Console.WriteLine("\n");
                Console.WriteLine("Please wait 2 second board is loading again.....");
                Thread.Sleep(2000);
            }
            flag = CheckWin();// calling of check win  
        } while (flag != 1 && flag != -1);// This loof will be run until all cell of the grid is not marked with X and O or some player is not win  

        Console.Clear();// clearing the console  
        Board();// getting filled board again  

        if (flag == 1)// if flag value is 1 then some one has win or means who played marked last time which has win  
        {
            Console.WriteLine("Player {0} has won", (player % 2) + 1);
        }
        else// if flag value is -1 the match will be draw and no one is winner  
        {
            Console.WriteLine("Draw");
        }
        Console.ReadLine();
    }
}
