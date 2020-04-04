using System;
using System.Collections.Generic;
using System.Linq;

namespace Sudoku
{
    public class SudokuChecker
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //ReadFile()
            //ValidateGrid()
        }

        public bool ValidateGrid(int[,] grid)
        {
            //ValidateShape
            //GetRows
            //GetColumns
            //GetSubGrids
            //Validate all groups of nine
            return false;
        }
        
        public bool ValidateGridShape(int[,] grid)
        {
            var rows = grid.GetLength(0);
            var columns = grid.GetLength(1);
            return rows == 9 && columns == 9;
        }

        public bool ValidateGroupOfNine(int[] group)
        {
            if (group.Length != 9) return false;

            var list = group.ToList();
            list.Sort();

            var expectedList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            return list.SequenceEqual(expectedList);
        }
    }
}
