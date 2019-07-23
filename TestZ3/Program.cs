using System;
using Z3_solveur;
using SudokuLib;
using System.Collections.Generic;

namespace TestZ3
{
    class Program
    {
        static void Main(string[] args)
        {
            Z3 solveur = new Z3();
            Sudoku s = new Sudoku();
            List<Sudoku> sudokus = new List<Sudoku>();
            sudokus = s.ParseFile("C:/Users/hengm/Downloads/Easy.txt");
            for (int i = 0; i < sudokus.Count; i++)
            {
                s = solveur.Solve(sudokus[i]);
                Console.WriteLine("Solution : ---------------\n");
                Console.WriteLine(s);
            }
        }
    }
}
