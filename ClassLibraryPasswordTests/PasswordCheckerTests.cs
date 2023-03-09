using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryPassword;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryPassword.Tests
{
    [TestClass()]
    public class PasswordCheckerTests
    {
        [TestMethod()]
        public void Check_8Symbols_ReturnsTrue()
        {
            // Arrange.
            string password = "ASqw12$$";
            bool expected = true;

            // Act.
            bool actual = PasswordChecker.ValidatePassword(password);

            // Assert.
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Check_4Symbols_ReturnsFalse()
        {
            // Arrange.
            string password = "Aq1$";

            // Act.
            bool actual = PasswordChecker.ValidatePassword(password);

            // Assert.
            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void Check_PasswordWidthLowerSymbols_ReturnsTrue()
        {
            // Arrange.
            string password = "ASDq123$";
            bool expected = true;

            // Act.
            bool actual = PasswordChecker.ValidatePassword(password);

            // Assert.
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Check_PasswordWidthLowerSymbols_ReturnsFalse()
        {
            // Arrange.
            string password = "ASDQWE123$";
            bool expected = false;

            // Act.
            bool actual = PasswordChecker.ValidatePassword(password);

            // Assert.
            Assert.AreEqual(expected, actual);
        }
    }
}