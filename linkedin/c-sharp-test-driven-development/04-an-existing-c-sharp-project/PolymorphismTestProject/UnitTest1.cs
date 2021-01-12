using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Polymorphism;

namespace PolymorphismTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalcualteWeeklySalaryForEmployeeTest_70wage55hoursReturns2800Dollars()
        {
            // Arrange
            int weeklyHours = 55;
            int wage = 70;
            int salary = 40 * wage;
            Employee e = new Employee();

            string expected = String.Format("This ANGRY EMPLOYEE worked {0} hrs. " +
                              "Paid for 40 hrs at $ {1}" +
                              "/hr = ${2}", weeklyHours, wage, salary);

            // Act
            string actual = e.CalculateWeeklySalary(weeklyHours, wage);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalcualteWeeklySalaryForContractorTest_70wage55hoursReturns3850Dollars()
        {
            // Arrange
            int weeklyHours = 55;
            int wage = 70;
            int salary = weeklyHours * wage;
            Contractor c = new Contractor();

            string expected = String.Format("This HAPPY CONTRACTOR worked {0} hrs. " +
                              "Paid for {0} hrs at $ {1}" +
                              "/hr = ${2}", weeklyHours, wage, salary);

            // Act
            string actual = c.CalculateWeeklySalary(weeklyHours, wage);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalcualteWeeklySalaryForEmployeeTest_70wage55hoursDoesNotReturnCorrectString()
        {
            // Arrange
            int weeklyHours = 55;
            int wage = 70;
            int salary = 40 * wage;
            Employee e = new Employee();

            string notExpected = String.Format("Problem 1 - This ANGRY EMPLOYEE worked {0} hrs. " +
                              "Paid for 40 hrs at $ {1}" +
                              "/hr = ${2}", weeklyHours, wage, salary);

            // Act
            string actual = e.CalculateWeeklySalary(weeklyHours, wage);

            // Assert
            Assert.AreNotEqual(notExpected, actual);
        }

        [TestMethod]
        public void CalcualteWeeklySalaryForContractorTest_70wage55hoursDoesNotReturnCorrectString()
        {
            // Arrange
            int weeklyHours = 55;
            int wage = 70;
            int salary = weeklyHours * wage;
            Contractor c = new Contractor();

            string notExpected = String.Format("Problem 2 - This HAPPY CONTRACTOR worked {0} hrs. " +
                              "Paid for {0} hrs at $ {1}" +
                              "/hr = ${2}", weeklyHours, wage, salary);

            // Act
            string actual = c.CalculateWeeklySalary(weeklyHours, wage);

            // Assert
            Assert.AreNotEqual(notExpected, actual);
        }
    }
}
