
using GenericEg;
using NUnit.Framework;

namespace GenericEgTests
{
    [TestFixture]
    public class EmployeeClientTests
    {
        [Test]
        public void TestCreateEmployee()
        {
            // Arrange
            int eid = 1;
            string name = "John";
            float salary = 50000.0f;

            // Act
            Employee employee = Employee.CreateEmployee(eid, name, salary);

            // Assert
            Assert.AreEqual(eid, employee.Eid);
            Assert.AreEqual(name, employee.Name);
            Assert.AreEqual(salary, employee.Salary);
        }
    }
}
