using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CustomerOrderService.Tests
{
    [TestFixture]
    public class CustomerTest
    {
        [Test]
        public void test1()
        {
            Assert.That(1 == 1);
        }

        [TestCase]
        public void When_Premium_10Percent()
        {
            Customer c = new Customer();
            c.CustID = "php";
            c.CustName = "Ramy";
            c.CustomerType = CustomerType.Premium;

            Order o = new Order();
            o.OrderID = 23;
            o.ProductID = 4;
            o.Quantity = 10;
            o.Amount = 1000;

            CustomerOrder co = new CustomerOrder();
            co.Discount(c, o);

            Assert.AreEqual(o.Amount, 900);
        }
        [TestCase]
        public void When_Gold_20Percent()
        {
            Customer c = new Customer();
            c.CustID = "lkl";
            c.CustName = "Ramy";
            c.CustomerType = CustomerType.Gold;

            Order o = new Order();
            o.OrderID = 23;
            o.ProductID = 4;
            o.Quantity = 10;
            o.Amount = 1000;

            CustomerOrder co = new CustomerOrder();
            co.Discount(c, o);

            Assert.AreEqual(o.Amount, 800);
        }

        [TestCase]
        public void FetchList()
        {
            CustomerOrder customerOrder = new CustomerOrder();
            Customer c1 = new Customer();

            customerOrder.GetCustomerList(c1);
            List<Customer> custList1 = new List<Customer>();
            custList1.Add(new Customer() { CustID = "sk", CustName = "sk" });
            custList1.Add(new Customer() { CustID = "ab", CustName = "ab" });
            Assert.AreEqual(custList1, c1.Customers);
        }

       

    }

    [TestFixture]
    public class UniversityTest
    {
        [TestCase]
        public void CheckFees()
        {
            Student s1 = new Student();
            s1.RollNo = 10;
            s1.StudName = "Ramy";
            s1.CourseName = CourseName.DotNet;

            Enrollments e = new Enrollments();
            e.EnrollNo = 11;
            e.Fees = 1000;
            StudentEnrollment s = new StudentEnrollment();
            bool ans = s.EnrollStudents(s1, e);
            Assert.IsTrue(ans);
        }
    }




    //We have implemented a simple FileChecker operation.The actual FileExtension
    //manager class is not implemented fully and so we have implemented a stub version
    //of the class. We are seeing that the CheckExtension function will always return true,
    //as we defined explicitly.

    [TestFixture]
    public class UnitTest1
    {
        [TestCase]
        public void TestMethod1()
        {
            //Act  
            StubExtensionManager stub = new StubExtensionManager();
            FileChecker checker = new FileChecker(stub);

            //Action  
            bool IsTrueFile = checker.CheckFile("myFile.whatever");

            //Assert  
            Assert.AreEqual(true, IsTrueFile);
        }
    }


    //just implemented a Mock class that will mimic the actual functionality.

    [TestFixture]
    public class UnitTest2
    {
        [TestCase]
        public void TestMethod1()
        {
            //Act  
            MockExtensionService mockobject = new MockExtensionService();
            //Inject mock object now  
            ExtensionAnalyzer analyzer = new ExtensionAnalyzer(mockobject);
            //Action  
            analyzer.ExtensionCheck("somefile.someextension");

            //Assert  
            Assert.AreEqual(mockobject.ErrorMessage, "Wrong Type");
        }
    }

    [TestFixture]
    class Test1
    {
        int s;
        [SetUp]
        public void Add()  /*----compulsory/first in the sequenec
*/      {
            int x = 10;
            int y = 20;
            s= x+y;
            Console.WriteLine(s);
        }

    [Test]
    public void subtract()
    {
        int p = s - 10;
            Console.WriteLine(p);
        Assert.AreEqual(p, 20);
    }
    [Test]
    [TearDown]/*----------------Last in the sequence of execution*/
    public void Multiply()
    {
        int x = 100;
        int y = 20;
        int result = x * y;
            Console.WriteLine(result);
        Assert.AreEqual(result, 2000);
    }

    } 

}
