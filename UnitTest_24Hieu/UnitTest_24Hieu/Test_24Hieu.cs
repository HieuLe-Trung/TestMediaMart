using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest_24Hieu
{
    public static class DateTime24Hieu
    {
        public static bool IsWeekend_24Hieu(DateTime date)
        {
            return date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday;
        }

        public static DateTime GetNextDay_24Hieu(DateTime date)
        {
            return date.AddDays(1);
        }
    }
    public class Math24Hieu
    {
        public static int Factorial_24Hieu(int n)
        {
            if (n < 0)
                throw new ArgumentException("Không thể tính giai thừa của số âm", nameof(n));
            if (n == 0 || n == 1)
                return 1;

            int result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
    }
    [TestClass]
    public class Test_24Hieu
    {
        [TestMethod]
        public void Test_IsWeekend_24Hieu()
        {
            DateTime weekendDate = new DateTime(2024, 5, 4); // a Saturday
            DateTime weekdayDate = new DateTime(2024, 5, 6); // a Monday
            Console.WriteLine(weekendDate.ToString());
            
            bool isWeekend1 = DateTime24Hieu.IsWeekend_24Hieu(weekendDate);
            bool isWeekend2 = DateTime24Hieu.IsWeekend_24Hieu(weekdayDate);

            Assert.IsTrue(isWeekend1);
            Assert.IsFalse(isWeekend2);
        }

        [TestMethod]
        public void Test_GetNextDay_24Hieu()
        {
            DateTime date = new DateTime(2024, 5, 31);
            DateTime nextDay = DateTime24Hieu.GetNextDay_24Hieu(date);
            Assert.AreEqual(new DateTime(2024, 6, 1), nextDay);
        }

        [TestMethod]
        public void Test_Factorial_WithPositiveNumber_24Hieu()
        {
            int n = 5;
            int result = Math24Hieu.Factorial_24Hieu(n);
            Assert.AreEqual(120, result);
        }

        [TestMethod]
        public void Test_Factorial_WithZero_24Hieu()
        {
            int n = 0;
            int result = Math24Hieu.Factorial_24Hieu(n);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Test_Factorial_WithNegativeNumber_24Hieu()
        {
            Assert.ThrowsException<ArgumentException>(() => Math24Hieu.Factorial_24Hieu(-5));
        }
    }
}
