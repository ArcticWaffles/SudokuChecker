using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sudoku;

namespace SudokuCheckerTests
{
    [TestClass]
    public class SudokuCheckerTests
    {
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
    }
}
