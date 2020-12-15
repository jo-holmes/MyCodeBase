﻿///* C# program to solve N Queen 
//Problem using backtracking */
//using System;

//class GfG
//{

//    static int N = 5;
//    static int k = 1;

//    /* A utility function to print solution */
//    static void printSolution(int[,] board)
//    {
//        Console.Write("{0}-\n", k++);
//        for (int i = 0; i < N; i++)
//        {
//            for (int j = 0; j < N; j++)
//                Console.Write(" {0} ", board[i, j]);
//            Console.Write("\n");
//        }
//        Console.Write("\n");
//    }

//    /* A utility function to check if a queen can 
//    be placed on board[row,col]. Note that this 
//    function is called when "col" queens are 
//    already placed in columns from 0 to col -1. 
//    So we need to check only left side for 
//    attacking queens */
//    static bool isSafe(int[,] board, int row, int col)
//    {
//        int i, j;

//        /* Check this row on left side */
//        for (i = 0; i < col; i++)
//            if (board[row, i] == 1)
//                return false;

//        /* Check upper diagonal on left side */
//        for (i = row, j = col; i >= 0 && j >= 0; i--, j--)
//            if (board[i, j] == 1)
//                return false;

//        /* Check lower diagonal on left side */
//        for (i = row, j = col; j >= 0 && i < N; i++, j--)
//            if (board[i, j] == 1)
//                return false;

//        return true;
//    }

//    /* A recursive utility function 
//    to solve N Queen problem */
//    static bool solveNQUtil(int[,] board, int col)
//    {
//        /* base case: If all queens are placed 
//        then return true */
//        if (col == N)
//        {
//            printSolution(board);
//            return true;
//        }

//        /* Consider this column and try placing 
//        this queen in all rows one by one */
//        bool res = false;
//        for (int i = 0; i < N; i++)
//        {
//            /* Check if queen can be placed on 
//            board[i,col] */
//            if (isSafe(board, i, col))
//            {
//                /* Place this queen in board[i,col] */
//                board[i, col] = 1;

//                // Make result true if any placement 
//                // is possible 
//                res = solveNQUtil(board, col + 1) || res;

//                /* If placing queen in board[i,col] 
//                doesn't lead to a solution, then 
//                remove queen from board[i,col] */
//                board[i, col] = 0; // BACKTRACK 
//            }
//        }

//        /* If queen can not be place in any row in 
//            this column col then return false */
//        return res;
//    }

//    /* This function solves the N Queen problem using 
//    Backtracking. It mainly uses solveNQUtil() to 
//    solve the problem. It returns false if queens 
//    cannot be placed, otherwise return true and 
//    prints placement of queens in the form of 1s. 
//    Please note that there may be more than one 
//    solutions, this function prints one of the 
//    feasible solutions.*/
//    static void solveNQ()
//    {
//        int[,] board = new int[N, N];

//        if (solveNQUtil(board, 0) == false)
//        {
//            Console.Write("Solution does not exist");
//            return;
//        }

//        return;
//    }

//    // Driver code 
//    public static void Main()
//    {
//        Console.WriteLine("your Choice \n1.solveNQ\t2.LCM");
//        string choice = Console.ReadLine();
//        switch(choice)
//        {
//            case "solveNQ": solveNQ();
//                break;
//            case "LCM":LCM();
//                break;
//            default:Console.WriteLine("Bad choice");
//                break;
//        }
      

//    }
//    static int gcd(int a, int b)
//    {
//        if (a == 0)
//            return b;
//        return gcd(b % a, a);
//    }

//    // method to return  
//    // LCM of two numbers 
//    static int lcm(int a, int b)
//    {
//        return (a * b) / gcd(a, b);
//    }

//    // Driver method 
//    public static void LCM()
//    {
//        Console.WriteLine("Enter two numbers");
//        int a = Convert.ToInt32(Console.ReadLine()), b = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("LCM of " + a +
//         " and " + b + " is " + lcm(a, b));
//    }
//}

///* This code contributed by PrinciRaj1992 */
