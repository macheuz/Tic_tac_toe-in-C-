using System;

namespace TicTacToe
{
    class Program
    {
        static string[,] createTable()
        {
            string[,] table = new string[3, 3];
            return table;
        }

        static bool verifyColumns(string[,] table)
        {
            for (int x = 0; x < 3; x++)
            {
                int contX = 0;
                int contO = 0;
                for (int i = 0; i < 3; i++)
                {
                    if (table[x, i] == "X")
                    {
                        contX = contX + 1;
                        if (contX == 3)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Player X Wins");
                            return false;
                        }
                        else if (table[x, i] == "O")
                        {
                            contO = contO + 1;
                            if (contO == 3)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Player O wins");
                                return false;
                            }
                        }
                    }
                }
            }
            return true;
        }



        static bool verifyLines(string[,] table)
        {
            for (int x = 0; x < 3; x++)
            {
                int contX = 0;
                int contO = 0;
                for (int i = 0; i < 3; i++)
                {
                    if (table[i, x] == "X")
                    {
                        contX = contX + 1;
                        if (contX == 3)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Player X Wins");
                            return false;
                        }
                        else if (table[i, x] == "O")
                        {
                            contO = contO + 1;
                            if (contO == 3)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Player O wins");
                                return false;
                            }
                        }
                    }
                }
            }
            return true;
        }


        static bool verifyDiagonal(string[,] table)
        {
            int contX = 0;
            int contO = 0;
            for (int x = 0; x < 3; x++)
            {
                if (table[x, x] == "X")
                {
                    contX = contX + 1;
                }
                if (table[x, x] == "O")
                {
                    contO = contO + 1;
                }
            }
            if (contX == 3)
            {
                Console.WriteLine();
                Console.WriteLine("Player X wins");
                return false;
            }
            if (contO == 3)
            {
                Console.WriteLine();
                Console.WriteLine("Player O wins");
                return false;
            }
            return true;
        }


        static bool verifyDiagonal2 (string[,] table)
        { 
            int contX = 0;
            int j = 2;
            int contO = 0;
            for(int x =0; x<3; x++){
                if( table[x,j] == "X"){
                    contX = contX+1;
                }
                if (table[x,j] == "O"){
                    contO = contO+1;
                }
            j = j -1;
            } 
            if (contX == 3){
                Console.WriteLine();
                Console.WriteLine("Player X wins");
                return false;
            }
            if (contO == 3){
                Console.WriteLine();
                Console.WriteLine("Player O wins");
                return false;
            }
        return true;           
        }


        static void playWithX(string[,] table)
        {
            Console.WriteLine("Put the line you want to fill: ");
            int line = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.WriteLine("Put the column you want to fill: ");
            int column = Convert.ToInt32(Console.ReadLine()) - 1;
            if (table[line, column] != "X" && table[line, column] != "O")
            {
                table[line, column] = "X";
            }
            else
            {
                Console.WriteLine("Invalid Position, input another position!");
                playWithX(table);
            }
        }


        static void playWithO(string[,] table)
        {
            Console.WriteLine("Put the line you want to fill: ");
            int line = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.WriteLine("Put the column you want to fill: ");
            int column = Convert.ToInt32(Console.ReadLine()) - 1;
            if (table[line, column] != "X" && table[line, column] != "O")
            {
                table[line, column] = "O";
            }
            else
            {
                Console.WriteLine("Invalid Position, input another position!");
                playWithO(table);
            }
        }

        static void printTable(string [,]table){
            for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine();
                    for (int k = 0; k < 3; k++)
                    {
                        Console.Write(" [ {0} ] ", table[i, k]);
                    }
                }
        }

        static void Main(string[] args)
        {
            string[,] table = createTable();
            int x = 0;
            while (x < 9 && (verifyColumns(table) == true && verifyDiagonal(table) == true && verifyDiagonal2(table) == true && verifyLines(table) == true))
            {
                Console.WriteLine("Player X");
                Console.WriteLine();
                playWithX(table);
                printTable(table);
                x++;
                if (x == 9 || (verifyColumns(table) == false || verifyDiagonal(table)== false || verifyDiagonal2(table)== false || verifyLines(table)== false)){
                    break;
                }
                Console.WriteLine();
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("Player O");
                Console.WriteLine();
                playWithO(table);
                printTable(table);
                Console.WriteLine();
                x++;
            }
        }
    }
}

