using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sudoku;

namespace SudokuCheckerTests
{
    [TestClass]
    public class SudokuCheckerTests
    {
        private int[,] validGrid =
        {
            { 4, 1, 7, 3, 6, 9, 8, 2, 5 },
            { 6, 3, 2, 1, 5, 8, 9, 4, 7 },
            { 9, 5, 8, 7, 2, 4, 3, 1, 6 },
            { 8, 2, 5, 4, 3, 7, 1, 6, 9 },
            { 7, 9, 1, 5, 8, 6, 4, 3, 2 },
            { 3, 4, 6, 9, 1, 2, 7, 5, 8 },
            { 2, 8, 9, 6, 4, 3, 5, 7, 1 },
            { 5, 7, 3, 2, 9, 1, 6, 8, 4 },
            { 1, 6, 4, 8, 7, 5, 2, 9, 3 }
        };

        private int[,] gridTooFewColumns =
        {
            { 6, 3, 2, 1, 5, 8, 9, 4 },
            { 4, 1, 7, 3, 6, 9, 8, 2 },
            { 9, 5, 8, 7, 2, 4, 3, 1 },
            { 8, 2, 5, 4, 3, 7, 1, 6 },
            { 7, 9, 1, 5, 8, 6, 4, 3 },
            { 3, 4, 6, 9, 1, 2, 7, 5 },
            { 2, 8, 9, 6, 4, 3, 5, 7 },
            { 5, 7, 3, 2, 9, 1, 6, 8 },
            { 1, 6, 4, 8, 7, 5, 2, 9 }
        };

        private int[,] gridTooFewRows =
{
            { 6, 3, 2, 1, 5, 8, 9, 4 },
            { 4, 1, 7, 3, 6, 9, 8, 2 },
            { 9, 5, 8, 7, 2, 4, 3, 1 },
            { 8, 2, 5, 4, 3, 7, 1, 6 },
            { 7, 9, 1, 5, 8, 6, 4, 3 },
            { 3, 4, 6, 9, 1, 2, 7, 5 },
            { 2, 8, 9, 6, 4, 3, 5, 7 },
            { 5, 7, 3, 2, 9, 1, 6, 8 }
        };

        [TestMethod]
        public void ValidateGroupOfNine_ShouldReturnFalse_IfArrayIsTooShort()
        {
            var tooShort = new int[] { 1, 2 };
            var result = new SudokuChecker().ValidateGroupOfNine(tooShort);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ValidateGroupOfNine_ShouldReturnFalse_IfArrayIsTooLong()
        {
            var tooLong = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var result = new SudokuChecker().ValidateGroupOfNine(tooLong);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ValidateGroupOfNine_ShouldReturnFalse_IfArrayDoesNotContainAllDigits()
        {
            var invalidGroup = new int[] { 1, 2, 3, 3, 5, 6, 7, 8, 9 };
            var result = new SudokuChecker().ValidateGroupOfNine(invalidGroup);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ValidateGroupOfNine_ShouldReturnTrue_IfArrayIsValid()
        {
            var validGroup = new int[] { 3, 2, 1, 4, 5, 6, 7, 8, 9 };
            var result = new SudokuChecker().ValidateGroupOfNine(validGroup);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ValidateGridShape_ShouldReturnFalse_IfTooFewColumns()
        {
            var result = new SudokuChecker().ValidateGridShape(gridTooFewColumns);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ValidateGridShape_ShouldReturnFalse_IfTooFewRows()
        {
            var result = new SudokuChecker().ValidateGridShape(gridTooFewRows);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ValidateGridShape_ShouldReturnTrue_IfGridIsValid()
        {
            var result = new SudokuChecker().ValidateGridShape(validGrid);
            Assert.IsTrue(result);
        }
    }
}
