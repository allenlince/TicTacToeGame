using System;

namespace TicTacToeGame {
    class Program {
        static void Main(string[] args) {
            
            //Variables
            int count = 0;
            int x_coord = 0;
            int y_coord = 0;
            string marker = "";
            int win = 0;
            bool gameWin = false;

            //Filling Array
            string[,] checkersBoard = new string[3, 3];

            //For Loop
            for (int row = 0; row < checkersBoard.GetLength(0); row++) {
                for (int column = 0; column < checkersBoard.GetLength(1); column++) {
                    checkersBoard[row, column] = " ";
                }//End Column For
            }//End Row For

          //While Loop
          while (count < 9 && gameWin == false) {
            drawBoard(checkersBoard);
                do {
                    marker = "X";
                    x_coord = PromptInt("Please enter the row number of where you want to place the X");
                     y_coord = PromptInt("Please enter the column number of where you want to place the X");
                    if (checkersBoard[x_coord, y_coord] != " ") Console.WriteLine("The spot has been taken already.");                  
                }while (checkersBoard[x_coord, y_coord] != " ");
                    count++;
                    placeMarker(checkersBoard, marker, x_coord, y_coord);
             
            Console.WriteLine();

            
            drawBoard(checkersBoard);

            win = WinCheck(checkersBoard);
               
                
            //If/Else stating who won if there is a winner
            if (win == 1) {
                Console.WriteLine("Player one wins.");
                gameWin = true;
            } else if (win == 2) {
                Console.WriteLine("Player two wins.");             
                gameWin = true;
            }//End if/else


             //Loop prompting for placement and giving error message if spot is already taken
             if (count < 9 && gameWin == false) {
               do {
                marker = "O";
                x_coord = PromptInt("Please enter the row number of where you want to place the O");
                y_coord = PromptInt("Please enter the column number of where you want to place the O");
                if(checkersBoard[x_coord, y_coord] != " ") Console.WriteLine("The spot has been taken already.");                  
               }while (checkersBoard[x_coord, y_coord] != " ");
                placeMarker(checkersBoard, marker, x_coord, y_coord);
                Console.WriteLine();
                count++;  
             }//End if
              
            win = WinCheck(checkersBoard);
             
              
            //Win conditions and number play who won
            if (gameWin == false) {
              if (win == 1) {
                Console.WriteLine("Player one wins.");
                   gameWin = true;
              } else if (win == 2) {
                    Console.WriteLine("Player two wins.");             
                       gameWin = true;
              }//End if/else
            }//End gamewin if


          }//End while

          //Game condition for tying
          if (win == 0) {
                Console.WriteLine("The game is a tie.");            
          }//End if

        }//End Main

        #region Prompt function
        static int PromptInt(string text) {
            Console.Write(text + " ");
            return int.Parse(Console.ReadLine());
        }//End PromptInt Function
        #endregion
        
        #region drawboard
        static void drawBoard(string[,] board) {
            for (int length = 0; length < board.GetLength(0); length++) {
                Console.WriteLine("   |   |   ");
                Console.Write(" ");
                for (int height = 0; height < board.GetLength(1); height++) {
                    Console.Write(board[length, height]);
                    if (height < 2) {
                        Console.Write(" | ");
                    }//End Height If
                }//End Height For
                Console.WriteLine();
                if (length < 2) {
                    Console.WriteLine("___|___|___");
                }//End If
                if (length == 2) {
                    Console.WriteLine("   |   |  ");
                }//End If
            }//End Length For
            Console.WriteLine();
        }//End drawBoard Function
        #endregion

        #region placeMarker
        static string placeMarker(string[,] board, string marker, int x_coord, int y_coord) {
            return board[x_coord, y_coord] = marker;
        }//End placeMarker
        #endregion

        #region WinCheck
        static int WinCheck(string[,] board) {
            if (board[0, 0] == "X" && board[0, 1] == "X" && board[0, 2] == "X") return 1;

            if (board[1, 0] == "X" && board[1, 1] == "X" && board[1, 2] == "X") return 1;

            if (board[2, 0] == "X" && board[2, 1] == "X" && board[2, 2] == "X") return 1;

            if (board[0, 0] == "X" && board[1, 1] == "X" && board[2, 2] == "X") return 1;

            if (board[0, 2] == "X" && board[1, 1] == "X" && board[2, 0] == "X") return 1;

            if (board[0, 0] == "O" && board[0, 1] == "O" && board[0, 2] == "O") return 2;

            if (board[1, 0] == "O" && board[1, 1] == "O" && board[1, 2] == "O") return 2;

            if (board[2, 0] == "O" && board[2, 1] == "O" && board[2, 2] == "O") return 2;

            if (board[0, 0] == "O" && board[1, 1] == "O" && board[2, 2] == "O") return 2;

            if (board[0, 2] == "O" && board[1, 1] == "O" && board[2, 0] == "O") return 2;

            if (board[0,0] == "X" && board[1,0] == "X" && board[2,0] == "X") return 1;

            if (board[0,1] == "X" && board[1,1] == "X" && board[2,1] == "X") return 1;

            if (board[0,2] == "X" && board[1,2] == "X" && board[2,2] == "X") return 1;

            if (board[0,0] == "O" && board[1,0] == "O" && board[2,0] == "O") return 2;

            if (board[0,1] == "O" && board[1,1] == "O" && board[2,1] == "O") return 2;

            if (board[0,2] == "O" && board[1,2] == "O" && board[2,2] == "O") return 2;

            else return 0;
         }//End WinCheck Function
        #endregion


    }//End Class
}//End Namespace
