using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModulnoeTestirovanie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModulnoeTestirovanie.Tests
{
    [TestClass()]
    public class PasswordCheckerTests
    {
        [TestMethod()]
        public void Check_8Symbols_ReturnsTrue()
        {   
            string password = "ASqw12$$"; //объявляем переменую для установки пароля
            bool expexcted = true;//объявляем ожидаемое значение в результате в тесте
            
            bool actual = PasswordChecker.ValidatePassword(password);//переменая вернет ожидаемы результат при выполнеии метода dfkbltqngfcdjhl
            
            Assert.AreEqual(expexcted, actual);//сравниваем два значения при помощи метода areequal и наших данных
        }

        [TestMethod()]
        public void Check_4Symbols_ReturnsFalse()
        {
            string password = "Aq1$";

            bool actual = PasswordChecker.ValidatePassword(password);

            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void Check_30Symbols_ReturnsFalse()
        {
            string password = "ASDqwe123$ASDqwe123$ASDqwe123$";
            bool expexcted = false;

            bool actual = PasswordChecker.ValidatePassword(password);

            Assert.AreEqual(expexcted, actual);
        }

        [TestMethod()]
        public void Check_PasswordWithDigits_ReturnsTrue()
        {
            string password = "ASDqwe1$";
            bool expexcted = true;

            bool actual = PasswordChecker.ValidatePassword(password);

            Assert.AreEqual(expexcted, actual);
        }

        [TestMethod()]
        public void Check_PasswordWithoutDigits_ReturnsFalse()
        {
            string password = "ASDqweASD$";
            bool expexcted = false;

            bool actual = PasswordChecker.ValidatePassword(password);

            Assert.AreEqual(expexcted, actual);
        }

        [TestMethod()]
        public void Check_PasswordWithSpecSymbols_ReturnsTrue()
        {
            string password = "Aqwe123$";
            bool expexcted = true;

            bool actual = PasswordChecker.ValidatePassword(password);

            Assert.AreEqual(expexcted, actual);
        }

        [TestMethod()]
        public void Check_PasswordWithoutSpecSymbols_ReturnsFalse()
        {
            string password = "ASDqwe123";
            bool expexcted = false;

            bool actual = PasswordChecker.ValidatePassword(password);

            Assert.AreEqual(expexcted, actual);
        }

        [TestMethod()]
        public void Check_PasswordWithCapsSymbols_ReturnsTrue()
        {
            string password = "Aqwe123$";
            bool expexcted = true;

            bool actual = PasswordChecker.ValidatePassword(password);

            Assert.AreEqual(expexcted, actual);
        }

        [TestMethod()]
        public void Check_PasswordWithoutCapsSymbols_ReturnsFalse()
        {
            string password = "asdqwe123$";
            bool expexcted = false;

            bool actual = PasswordChecker.ValidatePassword(password);

            Assert.AreEqual(expexcted, actual);
        }

        [TestMethod()]
        public void Check_PasswordWithLowerSymbols_ReturnsTrue()
        {
            string password = "ASDq123$";
            bool expexcted = true;

            bool actual = PasswordChecker.ValidatePassword(password);

            Assert.AreEqual(expexcted, actual);
        }

        [TestMethod()]
        public void Check_PasswordWithoutLowerSymbols_ReturnsFalse()
        {
            string password = "ASDQWE123$";
            bool expexcted = false;

            bool actual = PasswordChecker.ValidatePassword(password);

            Assert.AreEqual(expexcted, actual);
        }
    }
}